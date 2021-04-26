using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaEnClaseS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = TxtUsuario.Text;
                string pass = TxtPass.Text;
                if(usuario== "estudiante2021")
                {
                    if(pass== "uisrael2021")
                    {
                        await Navigation.PushAsync(new MainPage(usuario));
                    }
                }
                else
                {
                    DisplayAlert("Alerta", "Error de contraseña", "Gracias");
                }
                
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}