using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaGuanajuato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuAPI : ContentPage
    {
        public MenuAPI()
        {
            InitializeComponent();
        }

        private async void CargarLugares()
        {
            HttpClient client = new HttpClient();

            string URL = "https://guiaguanajuatoapi.azurewebsites.net/api/Lugares";

            var resultado = await client.GetAsync(URL);

            var json = resultado.Content.ReadAsStringAsync().Result;
        }
    }
}