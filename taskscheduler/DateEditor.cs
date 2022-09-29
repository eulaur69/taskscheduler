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
    public partial class DateEditor : Form {

        private List<ListItem> listItems = new List<ListItem>();
        private main parent;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";

        public DateEditor(main main) {
            InitializeComponent();
            parent = main;
            populate();
        }

        private void populate() {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string query = "select * from dates";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader dr = sc.ExecuteReader();
            dateComboBox.Items.Clear();
            while (dr.Read()) {
                ListItem item = new ListItem();
                if (dr["id"].ToString() != "1") {
                    item.setId(int.Parse(dr["id"].ToString()));
                    item.setText(dr["date"].ToString());
                    listItems.Add(item);
                    dateComboBox.Items.Add(item.getText());
                }

            }

            dr.Close();
            connection.Close();
            dateComboBox.SelectedIndex = dateComboBox.Items.Count - 1;
        }

        private void dayComboBox_SelectedValueChanged(object sender, EventArgs e) {
            String date = dateComboBox.Text;
            String[] dateData = date.Split('/');
            int day = int.Parse(dateData[0]);
            int month = int.Parse(dateData[1]);
            int year = int.Parse(dateData[2]);
            dNumeric.Value = day;
            mNumeric.Value = month;
            yNumeric.Value = year;
        }

        private void editDateButton_Click(object sender, EventArgs e) {
            int day = (int)dNumeric.Value;
            int month = (int)mNumeric.Value;
            int year = (int)yNumeric.Value;
            String date = "";
            if (day < 10) {
                date = date + "0";
            }
            date = date + day + "/";
            if (month < 10) {
                date = date + "0";
            }
            date = date + month + "/";
            date = date + year;
            int selectedIndex = dateComboBox.SelectedIndex;
            int id = listItems[dateComboBox.SelectedIndex].getId();
            SqlConnection connection = new SqlConnection(connectString);

            string query = "update dates set date = @date where id = @id; ";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@date", date);
            sc.Parameters.AddWithValue("@id", id);
            try {
                connection.Open();
                sc.ExecuteNonQuery();
                MessageBox.Show("Date Edited Successfully");
                parent.refreshData();
                //parent.changeDateIndex(date);
                populate();
                dateComboBox.SelectedIndex = selectedIndex;
                //this.Close();
            } catch (SqlException err) {
                Console.WriteLine("Error Generated. Details: " + err.ToString());
            } finally {
                connection.Close();
            }
        }

        private void deleteDateButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            int index = dateComboBox.SelectedIndex;
            int actionId = listItems[index].getId();

            string query = "delete from dates where id = @id";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@id", actionId);
            sc.ExecuteNonQuery();
            connection.Close();
            populate();
            dateComboBox.Refresh();
            parent.refreshData();
            populate();
        }
    }
}
