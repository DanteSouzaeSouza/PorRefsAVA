using System;
using System.Windows.Forms;

namespace PorRefsAVA
{
    public partial class FrmRefs : Form
    {
        public FrmRefs()
        {
            InitializeComponent();
        }

        private static void PorValor(double varA, double varB)
        {
            //altera o valor das variáveis locais que são passadas por valor
            //não altera os valores das variáveis originais (declaradas no botão Por Valor
            //essas alterações são válidas somente dentro deste escopo
            varA = varA * 2;
            varB = varB * 5;
        }

        private static void PorReferencia(ref double varA, ref double varB)
        {
            //altera o valor das variáveis que são passadas por referência
            //altera os valores das variáveis originais (declaradas no botão Por Referencia
            varA = varA * 2;
            varB = varB * 5;
        }

        private void LimparControles()
        {
            //limpa os textos dos controles
            txtResA.Clear();
            txtResB.Clear();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            //declaração das variáveis original

            //entrada de dados
            var varA = Convert.ToDouble(txtVarA.Text);
            var varB = Convert.ToDouble(txtVarB.Text);

            //chama o procedimento porValor passando os parâmetros por por valor,
            //ou seja, é passada uma cópia das variáveis
            PorValor(varA, varB);

            //chama o procedimento para Limpar os controles
            LimparControles();

            //saída de dados para verificar que não houve alteração no valor da variável original
            // os valores das variáveis não foram alterados no procedimento
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            //declaração das variáveis originais

            //entrada de dados
            var varA = Convert.ToDouble(txtVarA.Text);
            var varB = Convert.ToDouble(txtVarB.Text);

            //chama o procedimento porReferencia passando os parâmetros por referência
            PorReferencia(ref varA, ref varB);

            //chama o procedimento para Limpar os controles
            LimparControles();

            //saída de dados para verificar a alteração no valor da variável original
            // os valores das variáveis foram alterados no procedimento
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }
    }
}