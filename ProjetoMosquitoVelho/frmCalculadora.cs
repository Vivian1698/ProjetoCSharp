﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        //Limparcampos

        public void limparcampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResposta.Text = "";
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtValor1.Focus();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2,         resp = 0;

            try
            {

            

                num1 = Convert.ToDouble(txtValor1.Text);
                num2 = Convert.ToDouble(txtValor2.Text);

                //instanciar o objeto/ classe
                Operacoes op = new Operacoes();
                if (rdbSomar.Checked)
                {
                    resp = op.somar(num1, num2);
                }
                if (rdbSubtrair.Checked)
                {
                    resp = op.subtrair(num1, num2);
                }
                if (rdbMultiplicar.Checked)
                {
                    resp = op.multiplicar(num1, num2);
                }
                if (rdbDividir.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível divisão por 0", "SistemaABC", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        //executa o método limpar campos
                        limparcampos();
                    }
                    else
                    {
                        resp = op.dividir(num1, num2);

                    }
                    lblResposta.Text = resp.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Insira somente números!");
                limparcampos();
            }


        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando o método limpar campos
            limparcampos();
        }
    }
}



