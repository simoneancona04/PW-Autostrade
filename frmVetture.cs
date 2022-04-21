using Autostrade.BTNCONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autostrade
{
    public partial class frmVetture : Form
    {
        public frmVetture()
        {
           
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 addVettura = new Form3(this);
            addVettura.Size=new Size(form2.Size.Width-100, form2.Size.Height-50);
            

            addVettura.ShowDialog();
            
        }

        private void labelMacchina_Click(object sender, EventArgs e)
        {
            
        }

        public void TableMacchineAdd(string modello, string targa, string annoImm)
        {
            RJButton button = new RJButton();
            button.Width = 250;
            button.Height = 40;
            button.BackColor = Color.MidnightBlue;
            button.ForeColor = Color.White;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Text = modello.ToUpper() + "\t"  + targa.ToUpper() + "\t" + annoImm.ToUpper();
            button.Name = modello + "Button";
            AddVettura frm = new AddVettura(this);
            //button.DoubleClick += new EventHandler(callFunc);
            button.BorderRadius = 15;
            int rowCount = TableMacchine.RowStyles.Count;
            if (rowCount != 1)
            {
                TableMacchine.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            }
           
            TableMacchine.Controls.Add(button,rowCount+1, 0);
           
        }

       /* private void callFunc(object? sender, EventArgs e)
        {
            AddVettura frm = new AddVettura(this);
            frm.vistaMacchina();
            frm.ShowDialog();
            
            deve chiamare la funzione vistaMacchina nel form add vettura 
        }*/

        private void TableMacchine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
