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
    public partial class TimeAdder : Form {

        main parent;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";

        public TimeAdder(main main) {
            InitializeComponent();
            parent = main;
        }


        private void buttonAddTime_Click(object sender, EventArgs e) {
            int h = (int)hNumeric.Value;
            int m = (int)mNumeric.Value;
            if(h > 23 || m > 59) {
                MessageBox.Show("Incorrect time values.");
                return;
            }
            String timeValue = "";
            if(h < 10) {
                timeValue = timeValue + "0";
            }
            timeValue = timeValue + h + ":";
            if(m < 10) {
                timeValue = timeValue + "0";
            }
            timeValue = timeValue + m;
            MessageBox.Show(timeValue);
            
            SqlConnection connection = new SqlConnection(connectString);

            string query = "insert into timestamps(time) values(@time); ";
            SqlCommand sc = new SqlCommand(query, connection);
            sc.Parameters.AddWithValue("@time", timeValue);
            try {
                connection.Open();
                sc.ExecuteNonQuery();
                MessageBox.Show("Time Inserted Successfully");
                parent.refreshData();
                //parent.changeTimeIndex(parent.rowIndexToBeChanged, timeValue);
                this.Close();
            } catch (SqlException err) {
                Console.WriteLine("Error Generated. Details: " + err.ToString());
            } finally {
                connection.Close();
            }
            
        }
    }
}
