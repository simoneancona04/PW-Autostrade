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
    public partial class Form1 : Form
    {
        List<Vettura> listVettura = new List<Vettura>();
        MTDBHandler carDatabase;
        MTDBHandler userDatabase;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(MTDBHandler carDatabase,MTDBHandler userDatabase)
        {
            this.carDatabase = carDatabase;     
            this.userDatabase = userDatabase;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = checkUtente();
            if (index == -1)
            {
                MessageBox.Show("Nome utente o password errati", "Errore");
            }
            else
            {
                DataBaseObject utente = userDatabase.Get(index);
                if (utente.GetString("password") != txtPassword.Text)
                {
                    MessageBox.Show("Nome utente o password errati", "Errore");
                }
                else
                {
                    this.Hide();
                    Form2 form = new Form2();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private int checkUtente()
        {
            int index=1;
            foreach (String nome in userDatabase.GetColumn("nome", DBtype.STRING128))
            {
                if (nome.Equals(txtUsername.Text)) return index;
                index++;
            }
            return -1;
        }
    }
}
