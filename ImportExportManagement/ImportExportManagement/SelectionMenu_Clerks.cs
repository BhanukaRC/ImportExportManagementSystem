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
    public partial class SelectionMenu_Clerks : Form
    {
        public SelectionMenu_Clerks()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form1 new_jobcard = new Form1();
            new_jobcard.Show();
            this.Hide();
        }
    }
}
