using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace taskscheduler1 {

    

    public partial class TaskEditor : Form {


        private List<ListItem> listItems = new List<ListItem>();
        private main parent;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";


        public TaskEditor(main main) {
            InitializeComponent();
            this.parent = main;
            populate();
            nameLabel.Visible = false;
            taskNameTextBox.Visible = false;
            editButton.Visible = false;
            editButton.Visible = false;
            this.Height = 69;
            
        }

        

        private void populate() {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string query = "select * from actions";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            taskComboBox.Items.Clear();
            listItems.Clear();
            while (dr.Read()) {
                ListItem item = new ListItem();
                if (dr["id"].ToString() != "1") {
                    item.setId(int.Parse(dr["id"].ToString()));
                    item.setText(dr["action"].ToString());
                    listItems.Add(item);
                    taskComboBox.Items.Add(item.getText());
                }

            }

            dr.Close();
            connection.Close();
        }

        private void editButton_Click(object sender, EventArgs e) {
            if(taskNameTextBox.Text.Length == 0) {
                MessageBox.Show("Please choose a task.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            String action = taskNameTextBox.Text;
            int actionId = listItems[taskComboBox.SelectedIndex].getId();
            int index = taskComboBox.SelectedIndex;
            
            string query = "update actions set action = @action where id = @id";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@action", action);
            sc.Parameters.AddWithValue("@id", actionId);
            sc.ExecuteNonQuery();

            populate();
            taskComboBox.SelectedIndex = index;
            taskComboBox.Refresh();
            connection.Close();
            try {
                parent.refreshData();
            } catch (System.ArgumentException err) {
                MessageBox.Show("ERR AICI");
            }

            
            
        }

        private void taskComboBox_SelectedValueChanged(object sender, EventArgs e) {
            taskNameTextBox.Text = taskComboBox.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (taskNameTextBox.Text.Length == 0) {
                MessageBox.Show("Please choose a task.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            int index = taskComboBox.SelectedIndex;
            int actionId = listItems[index].getId();

            string query = "delete from actions where id = @id";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@id", actionId);
            sc.ExecuteNonQuery();

            populate();
            taskComboBox.Refresh();
            connection.Close();
            parent.refreshData();
            
        }

        private void taskComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            nameLabel.Visible = true;
            taskNameTextBox.Visible = true;
            editButton.Visible = true;
            editButton.Visible = true;
            this.Height = 123;
        }
    }
}
