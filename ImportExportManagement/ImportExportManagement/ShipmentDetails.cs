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

        private List<string> valueList;
        public ShipmentDetails(List<string> values)
        {
            InitializeComponent();
            valueList = values;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection = DatabaseAccess.getConnection())
            {

                MySqlCommand command = new MySqlCommand();

                command.CommandText = make_command_string();

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
        private string make_command_string() {
            string[] queries = new string[3];
            string[] tablenames = { "shipperdetails","consigneedetails", "jobinfo" };
            string[] columnNames= new string[3];
            string[] valueNames = new string[3];

            

            columnNames[2] = "JobID, Import_Export, FCL_LCL_Air, Type, OpenDate, Weight";

            for (int i=0; i<3;i++) {

                string command = string.Format(@"INSERT INTO {0} ({1}) VALUES ({2})", tablenames[i], columnNames[i], valueNames[i]);
                queries[i] = command;
            }
            string command1 = "INSERT into ShipperDetails (ShipperID,FName,LName,Address,City,Country,PostalCode) VALUES (1,'Gunasekara','Nimal', '47,ghj,kl','Gampaha','SriLanka',1233)";
            string command2 = " INSERT into ConsigneeDetails (ConsigneeID,FName,LName,Address,City,Country,PostalCode) VALUES (1,'Gunasekara','Nimal', '47,ghj,kl','Gampaha','SriLanka',1233)";
            string command3 = "INSERT into JobInfo(JobID, Import_Export, FCL_LCL_Air, Type, OpenDate, Weight, ShipperDetails_ShipperID, ConsigneeDetails_ConsigneeID) VALUES(5,'Import','Air','Ex-Work','2017-05-30',12.0,1,1)";

            
            return string.Join(";",queries);
        }
    }
}
