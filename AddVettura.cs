using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Autostrade
{
    public partial class AddVettura : Form
    {
        private frmVetture frm;

       

        public AddVettura(frmVetture frm)
        {
            this.frm = frm;
            InitializeComponent();
            
        }

       
        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
                     
        }

        private void txtMacchina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

       /* public void vistaMacchina()
        {
           serve per modificare l'utente
        }*/

        public static implicit operator AddVettura(frmVetture v)
        {
            throw new NotImplementedException();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            frm.TableMacchineAdd(modBox.Text, targaBox.Text, immBox.Text);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
