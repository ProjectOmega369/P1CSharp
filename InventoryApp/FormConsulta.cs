using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classinventory;

namespace InventoryApp
{
    public partial class FormConsulta : Form
    {
        public int? idConsultado { get; private set; }

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                idConsultado = id;
                this.DialogResult = DialogResult.OK; // fecha o form e devolve OK
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um ID válido!");
            }
        }
    }
}
