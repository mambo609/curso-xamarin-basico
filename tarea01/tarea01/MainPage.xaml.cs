using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tarea01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
           Adivine.Clicked += Adivine_Clicked;
        }

        private void Adivine_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("adivine el numero ");

           var adivinanza  = 500;
           

            if (entrada.Text == 500. ToString()) {


                Console.WriteLine("correcto ");
                DisplayAlert("correcto", "usted Digito 500", "OK");

            }

            else {

                Console.WriteLine(" no es 500 ");
                DisplayAlert("Incorrecto", "usted no digito 500", "NO");

            }


            }

            
        }
    }
