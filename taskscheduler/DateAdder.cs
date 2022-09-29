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
    public partial class DateAdder : Form {

        private main parent;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";


        public DateAdder(main main) {
            InitializeComponent();
            parent = main;
            DateTime today = DateTime.Today;
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            dNumeric.Value = day;
            mNumeric.Value = month;
            yNumeric.Value = year;
        }

        private void addDateButton_Click(object sender, EventArgs e) {
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

            SqlConnection connection = new SqlConnection(connectString);

            string query = "insert into dates(date) values(@date); ";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@date", date);
            try {
                connection.Open();
                sc.ExecuteNonQuery();
                MessageBox.Show("Date Inserted Successfully");
                parent.refreshData();
                //parent.changeDateIndex(date);
                this.Close();
            } catch (SqlException err) {
                Console.WriteLine("Error Generated. Details: " + err.ToString());
            } finally {
                connection.Close();
            }
        }

        private void yLabel_Click(object sender, EventArgs e) {

        }

        private void mLabel_Click(object sender, EventArgs e) {

        }

        private void dLabel_Click(object sender, EventArgs e) {

        }

        private void mNumeric_ValueChanged(object sender, EventArgs e) {

        }

        private void yNumeric_ValueChanged(object sender, EventArgs e) {

        }

        private void dNumeric_ValueChanged(object sender, EventArgs e) {

        }
    }
}
