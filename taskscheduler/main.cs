using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace taskscheduler1 {
    public partial class main : Form {

        public int rowIndexToBeChanged;
        private int numberOfRows;
        private int numberOfRowsAdded;
        private string dayId;
        List<ListItem> tasks = new List<ListItem>();
        List<ListItem2> actionsAndTime = new List<ListItem2>();
        List<ListItem2> taskData = new List<ListItem2>();
        List<ListItem2> timeData = new List<ListItem2>();
        private bool dataAdded = false;
        private Boolean firstTimeRun = true;
        int timeIndex;
        int hAction;
        int mAction;
        Boolean edited = false;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";

        private void populate() {
            
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string query = "select * from dates";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) {
                String day = dr["date"].ToString();
                dateComboBox.Items.Add(day);
            }
            dr.Close();
            connection.Close();
            if(dateComboBox.Items.Count > 0) {
                tasksDataGridView.Enabled = true;
                dateComboBox.SelectedIndex = 0;
                if (isDateSetToToday()) {
                    populateActionsAndTime();
                    timeIndex = 0;
                    resetTimerValues();
                }
            } else {
                tasksDataGridView.Enabled = false;
                edited = false;
            }
            
        }

        private void populateActionsAndTime() {
            actionsAndTime.Clear();
            DateTime now = DateTime.Now;
            String comboBoxDate = dateComboBox.Text;
            if (comboBoxDate.Contains('/')) {
                String[] date = comboBoxDate.Split('/');
                int day = int.Parse(date[0]);
                int month = int.Parse(date[1]);
                int year = int.Parse(date[2]);
                if (!(now.Day == day && now.Month == month && now.Year == year)) {
                    return;
                }
            }
            int h = now.Hour;
            int m = now.Minute;
            String timeNow = "";
            if (h < 10) {
                timeNow = timeNow + "0";
            }
            timeNow = timeNow + h + ":";
            if (m < 10) {
                timeNow = timeNow + "0";
            }
            timeNow = timeNow + m;
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string query = "select tasks.id, actions.action , timestamps.time from tasks " +
                "join timestamps on tasks.time = timestamps.id " +
                "join actions on tasks.action = actions.id " +
                "where tasks.date = @day " +
                "and timestamps.time > @time " +
                "order by timestamps.time";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@day", dayId);
            sc.Parameters.AddWithValue("@time", timeNow);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) {
                String id = dr["id"].ToString();
                String action = dr["action"].ToString();
                String time = dr["time"].ToString();
                ListItem2 item = new ListItem2();
                item.setId(int.Parse(id));
                item.setText1(action);
                item.setText2(time);
                actionsAndTime.Add(item);
            }
            dr.Close();
            connection.Close();
        }

        

        private bool isDateSetToToday() {
            String boxDate = dateComboBox.Text;
            DateTime now = DateTime.Now;
            String[] dateData = boxDate.Split('/');
            if (now.Day == int.Parse(dateData[0]) &&
                now.Month == int.Parse(dateData[1]) &&
                now.Year == int.Parse(dateData[2])){
                return true;
            } else return false;
        }

        private void populateBasedOnDay(int day) {
            numberOfRows = 0;
            numberOfRowsAdded = 0; 
            tasksDataGridView.Rows.Clear();
            tasksDataGridView.Refresh();
            edited = false;
            tasks.Clear();
          
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            String query = "select * from tasks where date = " + day;
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) {
                string id = dr["id"].ToString();
                string actionId = dr["action"].ToString();
                string timeId = dr["time"].ToString();
                string dateId = dr["date"].ToString();
                string note = dr["note"].ToString();
                string done = dr["done"].ToString();
                string action = "";
                string time = "";
                string date = "";
                ListItem item = new ListItem();
                item.setId(int.Parse(id));
                
                string disposableQuery = "select action from actions where id = " + actionId;
                SqlCommand dsc = new SqlCommand(disposableQuery, connection);
                SqlDataReader ddr = dsc.ExecuteReader();
                if (ddr.Read()) {
                    action = ddr["action"].ToString();
                }
                item.setText(action);
                tasks.Add(item);
                ddr.Close();

                disposableQuery = "select time from timestamps where id = " + timeId;
                dsc = new SqlCommand(disposableQuery, connection);
                ddr = dsc.ExecuteReader();
                if (ddr.Read()) {
                    time = ddr["time"].ToString();
                }
                ddr.Close();
                

                disposableQuery = "select date from dates where id = " + dateId;
                dsc = new SqlCommand(disposableQuery, connection);
                ddr = dsc.ExecuteReader();
                if (ddr.Read()) {
                    date = ddr["date"].ToString();
                }
                ddr.Close();
                DataGridViewRow row = (DataGridViewRow)tasksDataGridView.Rows[0].Clone();
                row.Cells[0].Value = action;
                row.Cells[1].Value = time;
                row.Cells[2].Value = note;
                if (done == "1") {
                    row.Cells[3].Value = true;
                } else {
                    row.Cells[3].Value = false;
                }
                tasksDataGridView.Rows.Add(row); 
                numberOfRows++;
            }
            dr.Close();
            connection.Close();
            numberOfRowsAdded = 0;
            if (isDateSetToToday()) {
                populateActionsAndTime();
                timeIndex = 0;
                resetTimerValues();
            }
            
        }

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            
    
            tasksDataGridView.Rows.Clear();
            tasksDataGridView.Refresh();
            string day = dateComboBox.GetItemText(this.dateComboBox.SelectedItem);
           
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            String query = "select id from dates where date = '" + day + "'";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            dayId = "";
            if(dr.Read()) {
                dayId = dr["id"].ToString();
            }
            dr.Close();
            connection.Close();
            populateBasedOnDay(int.Parse(dayId));

            

        }

        private void refreshColumnBoxes() {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            taskData.Clear();
            timeData.Clear();

            int selectedDate = dateComboBox.SelectedIndex;

            //dates dropdown populate
            ComboBox cb = new ComboBox();
            dateComboBox.Items.Clear();
            string query = "select * from dates";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) {
                dateComboBox.Items.Add(dr["date"].ToString());

            }
            dr.Close();
            dateComboBox.SelectedIndex = dateComboBox.Items.Count - 1;

            //tasks dropdown populate
            query = "select * from actions";
            sc = new SqlCommand(query, connection);
            dr = sc.ExecuteReader();
            cb = new ComboBox();
            while (dr.Read()) {
                cb.Items.Add(dr["action"].ToString());
                ListItem2 item = new ListItem2();
                item.setText1(dr["id"].ToString());
                item.setText2(dr["action"].ToString());
                taskData.Add(item);
            }
            dr.Close();
            ((DataGridViewComboBoxColumn)tasksDataGridView.Columns["Task"]).DataSource = cb.Items;

            //time dropdown populate
            query = "select * from timestamps";
            sc = new SqlCommand(query, connection);
            dr = sc.ExecuteReader();
            cb = new ComboBox();
            while (dr.Read()) {
                cb.Items.Add(dr["time"].ToString());
                ListItem2 item = new ListItem2();
                item.setText1(dr["id"].ToString());
                item.setText2(dr["time"].ToString());
                timeData.Add(item);
            }
            dr.Close();
            ((DataGridViewComboBoxColumn)tasksDataGridView.Columns["Time"]).DataSource = cb.Items;
            if(selectedDate <= dateComboBox.Items.Count - 1) {
                dateComboBox.SelectedIndex = selectedDate;
            }
            
        }

        public void refreshData() {
            refreshColumnBoxes();
            if(dateComboBox.Items.Count > 0) {
                populateBasedOnDay(int.Parse(dayId));
            }
            
           
        }

        public void checkAndRestoreTaskValue(int row) {
            if (!dataAdded) {
                MessageBox.Show("DATA NOT ADDED");
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)tasksDataGridView.Rows[row].Cells[0];
            }
        }

        private void resetTimerValues() {
            if(actionsAndTime.Count > 0) {
                timer1.Enabled = true;
                ListItem2 currentAction = actionsAndTime[timeIndex];
                String timeString = currentAction.getText2();
                String[] time = timeString.Split(':');
                hAction = int.Parse(time[0]);
                mAction = int.Parse(time[1]);
            }
        }

        public main() {
            InitializeComponent();
            numberOfRows = 0;
            populate();
            refreshColumnBoxes();
        }
  
        private void tasksDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            edited = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e) {
            if(dateComboBox.Items.Count == 0) {
                MessageBox.Show("Please add a date.");
                return;
            }
            int rowNo = 0;
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            String query = "select id from tasks where date = " + dayId;
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read()) {
                int id = int.Parse(dr["id"].ToString());
                
                int rowIndex = rowNo;
                DataGridViewRow currentRow = tasksDataGridView.Rows[rowIndex];
                String action = currentRow.Cells[0].Value.ToString();
                String actionId = ListItem2.findText1InListitem2(taskData, action);
                String time = currentRow.Cells[1].Value.ToString();
                String timeId = ListItem2.findText1InListitem2(timeData, time);
                String note = currentRow.Cells[2].Value.ToString();
                bool done = (bool)currentRow.Cells[3].Value;

               
                String queryUpdate = "update tasks set action = @action, time = @time, note = @note, done = @done where id = @id";
                SqlCommand scUpdate = new SqlCommand(queryUpdate, connection);
                scUpdate.Parameters.AddWithValue("@action", actionId);
                scUpdate.Parameters.AddWithValue("@time", timeId);
                scUpdate.Parameters.AddWithValue("@note", note);
                
                if (done == true) {
                    scUpdate.Parameters.AddWithValue("@done", "1");
                } else {
                    scUpdate.Parameters.AddWithValue("@done", "0");
                }
                scUpdate.Parameters.AddWithValue("@id", id);
                scUpdate.ExecuteNonQuery();
                

          
                rowNo++;
            }
            dr.Close();
            rowNo = numberOfRows;
            while(rowNo < numberOfRowsAdded + numberOfRows) {
                int rowIndex = rowNo;
                DataGridViewRow currentRow = tasksDataGridView.Rows[rowIndex];
                String action = currentRow.Cells[0].Value.ToString();
                String actionId = ListItem2.findText1InListitem2(taskData, action);
                String time = currentRow.Cells[1].Value.ToString();
                String timeId = ListItem2.findText1InListitem2(timeData, time);
                String note;
                if (currentRow.Cells[2].Value == null) {
                     note = "";
                } else {
                     note = currentRow.Cells[2].Value.ToString();
                }
                bool done;
                
                if (currentRow.Cells[3].Value == null) {
                    done = false;
                } else {
                    done = (bool)currentRow.Cells[3].Value;
                }
                
                String queryInsert = "insert into tasks(action,time,note,done,date) values(@action,@time,@note,@done,@date)";
                SqlCommand scInsert = new SqlCommand(queryInsert, connection);
                scInsert.Parameters.AddWithValue("@action", actionId);
                scInsert.Parameters.AddWithValue("@time", timeId);
                scInsert.Parameters.AddWithValue("@note", note);
               
                scInsert.Parameters.AddWithValue("@done", done);
                scInsert.Parameters.AddWithValue("@date", dayId);
                scInsert.ExecuteNonQuery();
                rowNo++;
            }
            connection.Close();
            populateBasedOnDay(int.Parse(dayId));
        }

        private void tasksDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            numberOfRowsAdded++;
        }

        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            int rowCount = tasksDataGridView.Rows.Count;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex < rowCount - 1) {
                if(e.RowIndex > tasks.Count - 1) {
                    MessageBox.Show("Please save your changes before deleting.");
                    return;
                }

                

                int id = tasks[e.RowIndex].getId();
                SqlConnection connection = new SqlConnection(connectString);
                connection.Open();
                String queryDelete = "delete from tasks where id = " + id;
                SqlCommand scDelete = new SqlCommand(queryDelete, connection);
                scDelete.ExecuteNonQuery();
                populateBasedOnDay(int.Parse(dayId));
            }
        }

        private void editTasksToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(taskData.Count == 0) {
                MessageBox.Show("Please add a task before editing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaskEditor taskEditor = new TaskEditor(this);
            taskEditor.Show();
        }

        private void editTimestampsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(timeData.Count == 0) {
                MessageBox.Show("Please add a timestamp before editing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeEditor timeEditor = new TimeEditor(this);
            timeEditor.Show();
        }

        private void editDatesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dateComboBox.Items.Count == 0) {
                MessageBox.Show("Please add a date before editing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateEditor dateEditor = new DateEditor(this);
            dateEditor.Show();
        }

        private void main_Resize(object sender, EventArgs e) {
            if (FormWindowState.Minimized == this.WindowState) {
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Task Scheduler";
                notifyIcon.BalloonTipText = "Task Scheduler is now minimized.";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(1500);
                this.Hide();
            } else if (FormWindowState.Normal == this.WindowState) {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (timeIndex > actionsAndTime.Count - 1) {
                timer1.Enabled = false;
                return;
            }
            DateTime date = DateTime.Now;
            int h = date.Hour;
            int m = date.Minute;
            int s = date.Second;
            this.Text = h + " " + m + " " + s + "|||||||" + hAction + " " + mAction;
            if(h == hAction && m == mAction && s == 0) {
                notifyIcon.BalloonTipTitle = actionsAndTime[timeIndex].getText1();
                notifyIcon.BalloonTipText = actionsAndTime[timeIndex].getText1() + " has started.";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(3000);
                timeIndex++;
                if(timeIndex < actionsAndTime.Count) {
                    resetTimerValues();
                }
                
            }

        }

        private void addNewTaskToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaskAdder taskAdder = new TaskAdder(this);
            taskAdder.Show();
        }

        private void addNewTimestampToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeAdder timeAdder = new TimeAdder(this);
            timeAdder.Show();
        }

        private void addNewDateToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                MessageBox.Show("Please save or revert the changes first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateAdder dateAdder = new DateAdder(this);
            dateAdder.Show();
        }

        private void tasksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void revertButton_Click(object sender, EventArgs e) {
            if (dateComboBox.Items.Count == 0) {
                MessageBox.Show("Please add a date.");
                return;
            }
            populateBasedOnDay(int.Parse(dayId));
        }
    }
}
