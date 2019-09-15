using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void TextNumeroUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOperar_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(textNumeroUno.Text);
            Numero numeroDos = new Numero(textNumeroDos.Text);

            this.labelResultado.Text = Calculadora.Operar(numeroUno, numeroDos, comboBoxOperadores.Text).ToString();
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            this.labelResultado.Text = "0";
            this.comboBoxOperadores.Text = "";
            this.textNumeroDos.Text = "";
            this.textNumeroUno.Text = "";

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBinario_Click(object sender, EventArgs e)
        {   
            //no anda
            Numero numeroUno = new Numero(labelResultado.Text);
            labelResultado.Text = numeroUno.DecimalBinario(labelResultado.Text);
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(labelResultado.Text);
            labelResultado.Text =numeroUno.BinarioDecimal(labelResultado.Text);
        }
    }
}
