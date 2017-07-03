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
            lbldate.Text = System.DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            
            ShipmentDetails shipmentdetails = new ShipmentDetails(values());
            shipmentdetails.Show();
            this.Hide();
        }

        private void cmbairsea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbairsea.SelectedItem.ToString().Equals("Sea")) {
                rdbfcl.Enabled = true;
                rdblcl.Enabled = true;
            } else {
                rdbfcl.Enabled = false;
                rdblcl.Enabled = false;
            }
            enable_next();
        }

        private void rdbimport_CheckedChanged(object sender, EventArgs e)
        {
            
                cmbtype.Enabled = true;
               
                var types = new[] { "Ex-works","FOB","CIF","DDU","DDP"};
                cmbtype.DataSource = types;
                enable_next();

        }

        private void rdbexport_CheckedChanged(object sender, EventArgs e)
        {
                cmbtype.Enabled = true;
                
                var types = new[] { "Ex-works", "FOB", "CIF", "Door to Door" };
                cmbtype.DataSource = types;
                enable_next();

        }

        private List<string> values() {
            string im_ex;
            string fcl_lcl_air="";
            if (rdbimport.Checked) {
                im_ex = "Import";
            } else {
                im_ex = "Export";
            }
            
            if (cmbairsea.Text!="") {
                if (cmbairsea.Text == "Air") {
                    fcl_lcl_air = "Air";


                }
                else if (rdbfcl.Checked)
                {
                    fcl_lcl_air = "FCL";
                }
                else {
                    fcl_lcl_air = "LCL";
                }
           }
            List<string> valueList = new List<string> { tbJobID.Text, im_ex, fcl_lcl_air, cmbtype.Text , lbldate.Text, tbSFName.Text, tbSLName.Text, tbCFName.Text, tbCLName.Text,};
            return valueList;
        }

        private void enable_next() {
            
            if (string.IsNullOrWhiteSpace(tbSFName.Text) || string.IsNullOrWhiteSpace(tbSLName.Text) || string.IsNullOrWhiteSpace(tbCFName.Text) || string.IsNullOrWhiteSpace(tbCLName.Text)||(!rdbimport.Checked && !rdbexport.Checked)|| cmbairsea.SelectedItem==null || (cmbairsea.SelectedItem=="Sea" && !rdbfcl.Checked && !rdblcl.Checked) ) {
                
                btnnext.Enabled = true;
            }
            



        }

        private void tbJobID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSFName_TextChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void tbSLName_TextChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void tbCFName_TextChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void tbCLName_TextChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void rdbfcl_CheckedChanged(object sender, EventArgs e)
        {
            enable_next();
        }

        private void rdblcl_CheckedChanged(object sender, EventArgs e)
        {
            enable_next();
        }
    }
}
