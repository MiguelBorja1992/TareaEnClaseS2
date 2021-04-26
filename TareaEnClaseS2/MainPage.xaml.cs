using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaEnClaseS2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }

        private void btnTotal_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(TxtDato1.Text);
                double dato2 = Convert.ToDouble(TxtDato2.Text);
                double dato3 = Convert.ToDouble(TxtDato3.Text);
                double dato4 = Convert.ToDouble(TxtDato4.Text);

                double total = ((dato1 * 0.3) + (dato2 * 0.2)) + ((dato3 * 0.3) + (dato4 * 0.2));

                TxtTotal.Text = total.ToString();
                if(total >= 7)
                {
                    DisplayAlert("Alerta", "Aprobado", "Gracias");
                }
                else
                {
                    DisplayAlert("Alerta", "Reprobado", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}
