using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ImportExportManagement
{
    public partial class ShipmentDetails : Form
    {
        public ShipmentDetails()
        {
            InitializeComponent();
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
                                        command.ExecuteNonQuery();

                }

                catch (Exception j)
                {
                    Console.WriteLine(j.Message);
                }
                finally { connection.Close(); }



            }
        }
    }
}
