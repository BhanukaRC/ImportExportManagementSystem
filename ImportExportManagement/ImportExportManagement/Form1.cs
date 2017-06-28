using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExportManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = DatabaseAccess.getConnection())
            {

                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT into JobInfo (JobID, Weight,Import/Export) VALUES (5, 12.0,import)";
             
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                try
                {
                    connection.Open();
                    Console.WriteLine("ffffffffff");
                    command.ExecuteNonQuery();

                }

                catch (Exception j)
                {
                    Console.WriteLine(j.Message);
                }
                finally { connection.Close(); }
                
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
