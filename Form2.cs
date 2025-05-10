using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrica
{
    public partial class Form2 : Form
    {
        String nominativo = "";
        String telefono = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nominativo = textBox1.Text;
            telefono = textBox2.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        public String GetNominativo()
        {
            return nominativo;
        }

        public String GetTelefono()
        {
            return telefono;
        }

        public void SetNominativo(String value)
        {
            nominativo = value;
            textBox1.Text = value;
        }

        public void SetTelefono(String value)
        {
            telefono = value;
            textBox2.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }        
    }
}
