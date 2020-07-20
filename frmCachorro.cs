using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdadeCanina
{
    public partial class frmCachorro : Form
    {
        public frmCachorro()
        {
            InitializeComponent();
        }


        Double Resultado;
        int Idade;

        public void btnCalcular_Click(object sender, EventArgs e)
        {

            Idade = Convert.ToInt32(txbIdade.Text);
            Resultado = Idade * 7;

            txbResultado.Text = "Seu cachorro tem " + Resultado + " anos caninos";
            pcbFundo.Visible = true;
            pcbFrente.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txbIdade.Clear();
            this.txbResultado.Clear();
            pcbFundo.Visible = false;
            pcbFrente.Visible = true;
            

        }
    }
}
