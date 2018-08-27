using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            int cont=0;int cont2=0;
            int Long = txtPalabra.TextLength;

            char[] palabra = txtPalabra.Text.ToArray();
            char[] palabraReves= new char[Long] ;

            //dar vuelta palabra
            for (int i = Long-1; i >= 0; i--)
            {              
                palabraReves[cont] = palabra[i];
                cont = cont + 1;
            }

            cont = 0;

            for (int i = 0; i < Long-1; i++)
            {
                if (palabraReves[cont2] != palabra[i])
                {
                    cont = cont + 1;
                }
                cont2 = cont2 + 1;
            }
          

            //Evaluar palindromo
            if (cont == 0)
            {
                lblResultado.Text = "Es palindromo";
            }
            else
            {
                if (cont > 1)
                {
                    lblResultado.Text = "No es palindromo";
                }
                else
                {
                    lblResultado.Text =  "Es casi palindromo";
                }
            }

           
        }
    }
}
