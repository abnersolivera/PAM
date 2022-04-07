using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AvaliacaoIntermediariaCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero + outroNumero;

            DisplayAlert("Calcular", $"{numero} + {outroNumero} = {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void btnSubtrair_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero - outroNumero;

            DisplayAlert("Calcular", $"{numero} - {outroNumero} = {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero;

            DisplayAlert("Calcular", $"{numero} X {outroNumero} = {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void btnDivisao_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero / outroNumero;

            DisplayAlert("Calcular", $"{numero} / {outroNumero} = {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void BtnAreaRetangulo_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero;

            DisplayAlert("Calcular", $"Base {numero} Altura {outroNumero} = Area {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void btnAreaTriangulo_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero * outroNumero / 2;

            DisplayAlert("Calcular", $"Base {numero} Altura {outroNumero} = Area {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }

        private void btnParImpar_Clicked(object sender, EventArgs e)
        {
            int c1, c2;
            try
            {
                c1 = int.Parse(txtNumero.Text) % 2;
                c2 = int.Parse(txtOutroNumero.Text) % 2;


                if (c1 == 0)
                {

                    if (c2 == 0)
                    {
                        DisplayAlert("Resultado", $"O numero digitado {txtNumero.Text}  e  {txtOutroNumero.Text} é PAR.", "OK");
                    }

                    else
                    {
                        DisplayAlert("Resultado", $"O numero digitado {txtNumero.Text} é PAR.\nO numero digitado {txtOutroNumero.Text} é ÍMPAR.", "OK");

                    }
                }

                else if (c2 == 0)
                {
                    if (c1 == 0)
                    {
                        DisplayAlert("Resultado", $"O numero digitado{txtNumero.Text}  e  {txtOutroNumero.Text} é PAR.", "OK");
                    }

                    else
                    {
                        DisplayAlert("Resultado", $"O numero digitado{txtOutroNumero.Text} é PAR.\nO numero digitado {txtNumero.Text} é ÍMPAR.", "OK");
                    }
                }

                else
                {
                    DisplayAlert("Resultado", $"O numero digitado{txtOutroNumero.Text} e {txtNumero.Text} é ÍMPAR.", "OK");
                }

            }
            catch (FormatException)
            {

                DisplayAlert("Erro!", "Favor informar apenas números", "OK");
            }
        }

        private void btnComparar_Clicked(object sender, EventArgs e)
        {
            int num1, num2;



            try
            {
                num1 = int.Parse(txtNumero.Text);
                num2 = int.Parse(txtOutroNumero.Text);

                if (num1 > num2)
                {
                    if (num2 < num1)
                    {
                        DisplayAlert("Resultado", $"numero digitado: {txtNumero.Text} é maior que o numero {txtOutroNumero.Text}\nnumero digitado: {txtOutroNumero.Text} é menor que o numero {txtNumero.Text}", "OK");
                    }
                }

                else if (num2 > num1)
                {
                    if (num1 < num2)
                    {
                        DisplayAlert("Resultado", $"numero digitado: {txtOutroNumero.Text} é maior que o numero {txtNumero.Text}\nnumero digitado: {txtNumero.Text} é menor que o numero {txtOutroNumero.Text}", "OK");
                    }
                }

                else
                {
                    DisplayAlert("Resultado", "Os numeros digitados são iguais", "OK");
                }

            }
            catch (FormatException)
            {

                DisplayAlert("Erro!", "Favor informar apenas números", "OK");
            }
        }

        private void btnPotenciacao_Clicked(object sender, EventArgs e)
        {
            double n1, n2, resultado;

            n1 = double.Parse(txtNumero.Text);
            n2 = double.Parse(txtOutroNumero.Text);

            resultado = Math.Pow(n1, n2);

            try
            {

                DisplayAlert("Calcular", $"{resultado}", "OK");
            }
            catch (FormatException)
            {

                DisplayAlert("Erro!", "Favor informar apenas números", "OK");
            }
        }

        private void BtnPorcentagem_Clicked(object sender, EventArgs e)
        {
            float n1, n2, resultado;
            n1 = float.Parse(txtNumero.Text);
            n2 = float.Parse(txtOutroNumero.Text);
            resultado = n1 * n2 / 100;


            try
            {

                DisplayAlert("Calcular", $"{resultado}", "OK");
            }
            catch (FormatException)
            {

                DisplayAlert("Erro!", "Favor informar apenas números", "OK");
            }
        }
    }
}
