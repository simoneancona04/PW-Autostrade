using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSmtdb;

namespace Autostrade
{
    public partial class Form2 : Form
    {
        MTDBHandler carDatabase;
        MTDBHandler userDatabase;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(MTDBHandler carDatabase, MTDBHandler userDatabase)
        {
            this.carDatabase = carDatabase;
            this.userDatabase = userDatabase;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.PnlFormLoader.Controls.Clear();
            frmVetture frmVetture_vrb = new frmVetture() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmVetture_vrb.Size = new System.Drawing.Size(PnlFormLoader.Size.Width, PnlFormLoader.Size.Height);
            frmVetture_vrb.FormBorderStyle=FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmVetture_vrb);
            frmVetture_vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            FormPatenti formP = new FormPatenti() { Dock = DockStyle.Fill, TopLevel=false, TopMost = true };
            formP.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formP);
            formP.Show();
        }
    }
}
