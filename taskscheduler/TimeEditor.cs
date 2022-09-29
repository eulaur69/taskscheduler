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
    public partial class TimeEditor : Form {


        private List<ListItem> listItems = new List<ListItem>();
        private main parent;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";

        public TimeEditor(main main) {
            InitializeComponent();
            parent = main;
            populate();
            editButton.Visible = false;
            deleteButton.Visible = false;
            hLabel.Visible = false;
            mLabel.Visible = false;
            hNumeric.Visible = false;
            mNumeric.Visible = false;
            this.Height = 77;
        }

        private void populate() {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string query = "select * from timestamps";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            timeComboBox.Items.Clear();
            while (dr.Read()) {
                ListItem item = new ListItem();
                if (dr["id"].ToString() != "1") {
                    item.setId(int.Parse(dr["id"].ToString()));
                    item.setText(dr["time"].ToString());
                    listItems.Add(item);
                    timeComboBox.Items.Add(item.getText());
                }

            }

            dr.Close();
            connection.Close();
        }

        private void editButton_Click(object sender, EventArgs e) {
            if(timeComboBox.Text.Length == 0) {
                MessageBox.Show("Please choose a timestamp.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            int h = (int)hNumeric.Value;
            int m = (int)mNumeric.Value;
            if (h > 23 || m > 59) {
                MessageBox.Show("Incorrect time values.");
                return;
            }
            String timeValue = "";
            if (h < 10) {
                timeValue = timeValue + "0";
            }
            timeValue = timeValue + h + ":";
            if (m < 10) {
                timeValue = timeValue + "0";
            }
            timeValue = timeValue + m;
            int selectedIndex = timeComboBox.SelectedIndex;
            int timeId = listItems[timeComboBox.SelectedIndex].getId();

            string query = "update timestamps set time = @time where id = @id";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@time", timeValue);
            sc.Parameters.AddWithValue("@id", timeId);
            sc.ExecuteNonQuery();

            populate();
            timeComboBox.Refresh();
            timeComboBox.SelectedIndex = selectedIndex;
            //timeComboBox.SelectedItem = action;
            connection.Close();
            parent.refreshData();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (timeComboBox.Text.Length == 0) {
                MessageBox.Show("Please choose a timestamp.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            int index = timeComboBox.SelectedIndex;
            int actionId = listItems[index].getId();

            string query = "delete from timestamps where id = @id";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@id", actionId);
            sc.ExecuteNonQuery();

            populate();
            timeComboBox.Refresh();
            connection.Close();
            parent.refreshData();
        }

        private void timeComboBox_SelectedValueChanged(object sender, EventArgs e) {
            editButton.Visible = true;
            deleteButton.Visible = true;
            hLabel.Visible = true;
            mLabel.Visible = true;
            hNumeric.Visible = true;
            mNumeric.Visible = true;
            this.Height = 135;
            String value = timeComboBox.Text;
            String[] data = value.Split(':');
            hNumeric.Value = int.Parse(data[0]);
            mNumeric.Value = int.Parse(data[1]);
        }
    }
}
