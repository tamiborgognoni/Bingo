using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bingo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            banner.Source = ImageSource.FromResource("Bingo.Img.banner.gif");
        }

        private void sorteio_Clicked(object sender, EventArgs e)
        {
            try
            {


                Random gerar = new Random();

                int inicio = Convert.ToInt32(txt_inicial.Text);
                int fim = Convert.ToInt32(txt_final.Text);
                int qtd = 1;

                int Resultado = 0;

                for (int i = 0; i <= qtd - 1; i++)
                {
                    Resultado = Resultado + gerar.Next(inicio, fim);

                    lbl_resultado.Text = Resultado.ToString();
                }
            }
            catch (Exception)
            {
                lbl_resultado.Text = "Ops! Ocorreu um erro.";
                lbl_resultado.TextColor = Color.Red;
            }
        }
    }
}
