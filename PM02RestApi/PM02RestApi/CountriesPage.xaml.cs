using PM02RestApi.Controllers;
using PM02RestApi.Models;
using PM02RestApi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02RestApi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountriesPage : ContentPage
    {
        public CountriesPage()
        {
            InitializeComponent();


        }

        private async void btnget_Clicked(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                List<Countries.Example> listapersonas = new List<Countries.Example>();
                listapersonas = await CountriesControllers.getpaises();
                lstPersonas.ItemsSource = listapersonas;
            }
            else
            {
                await DisplayAlert("Conexion", "No se encuentra conectado a internet", "Ok");
            }
        }

    }
}