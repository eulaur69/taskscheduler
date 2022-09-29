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
    public partial class TaskAdder : Form {

        main parent;
        int rowIndex;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EuLaur\source\repos\taskscheduler1\taskscheduler.mdf;Integrated Security=True;Connect Timeout=30";


        public TaskAdder(main main) {
            InitializeComponent();
            this.parent = main;
        }

        private void buttonAddTask_Click(object sender, EventArgs e) {
            if(taskNameTextBox.Text.Length != 0) {
                SqlConnection connection = new SqlConnection(connectString);

                string query = "insert into actions(action) values(@action); ";
                SqlCommand sc = new SqlCommand(query, connection);
                sc.Parameters.AddWithValue("@action", taskNameTextBox.Text);
                try {
                    connection.Open();
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Task Inserted Successfully");
                    parent.refreshData();
                    //parent.changeTaskIndex(parent.rowIndexToBeChanged, taskNameTextBox.Text);
                    this.Close();
                } catch (SqlException err) {
                    Console.WriteLine("Error Generated. Details: " + err.ToString());
                } finally {
                    connection.Close();
                }
            } else {
                MessageBox.Show("Please Insert a Task Name");
            }
            


        }

        private void TaskAdder_FormClosing(object sender, FormClosingEventArgs e) {
            parent.checkAndRestoreTaskValue(parent.rowIndexToBeChanged);
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
