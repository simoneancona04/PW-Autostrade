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
    public partial class Form3 : Form
    {
        private frmVetture frm;

        public Form3(frmVetture frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
        }

        private void addAuto_Click(object sender, EventArgs e)
        {
            //frm.TableMacchineAdd(marcaBox.Text,modBox.Text,targaBox.Text);
            this.Close();
        }

        private void closePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ShowReadOnly = true,
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                rjButton1.Controls.Remove(rjButton1);
                TextBox nomeFileBox = new TextBox();
                nomeFileBox.BackColor.Equals(targaBox.BackColor);
                tableLayoutPanel1.Controls.Add(nomeFileBox, 1, 3);
                nomeFileBox.Text = openFileDialog1.FileName;
            }
            
                    
        }
    }
}
