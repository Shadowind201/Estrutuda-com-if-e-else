using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutuda_com_if_e_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum.Text, out double number))
            {
                if ( number < 0 )
                {
                    number = Math.Abs(number);
                }

                lblResultado.Text = $"Resultado: {number}";
            }
            else
            {
                MessageBox.Show("Por favor, digite um numero valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
