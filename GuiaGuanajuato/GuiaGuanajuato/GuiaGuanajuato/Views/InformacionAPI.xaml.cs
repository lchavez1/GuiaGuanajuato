using GuiaGuanajuato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace GuiaGuanajuato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformacionAPI : ContentPage
    {
        public InformacionAPI(long index)
        {
            InitializeComponent();
            Informacion(index);
        }

        private async void Informacion(long index)
        {
            HttpClient client = new HttpClient();
            string URL = "https://guiaguanajuatoapi.azurewebsites.net/api/Lugares/" + index;
            var resultado = await client.GetAsync(URL);
            var json = resultado.Content.ReadAsStringAsync().Result;
            Lugar lugar = JsonConvert.DeserializeObject<Lugar>(json);

            var URLgallery = "https://guiaguanajuatoapi.azurewebsites.net/api/Fotografias/" + index;
            var gallery = await client.GetAsync(URLgallery);
            var jsonGallery = gallery.Content.ReadAsStringAsync().Result;

            List<Fotografias> fotografias = Fotografias.FromJson(jsonGallery);

            if (fotografias.Count() > 0)
            {
                gdFotografias.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                gdFotografias.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
             
              
                int j = 0;
                foreach (var item in fotografias)
                {

                    var img = new Image { Source = item.Url, WidthRequest = 100, HeightRequest = 100, Aspect = Aspect.AspectFill };
                    gdFotografias.Children.Add(img,j,0);
                    //gdFotografias.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                    layoutgallery.Children.Add(gdFotografias);
                    gdFotografias.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    //this.Content = layoutgallery;
                    j++;
                }
            }
            else
            {
                var label = new Label { Text = "No se encontraron datos.", TextColor = Color.FromHex("#77d065"), FontSize = 20 };
                layoutgallery.Children.Add(label);
                this.Content = layoutgallery;
            }

            aiCargar.IsRunning = false;
            aiCargar.IsVisible = false;
           
            this.BindingContext = lugar;
            var values = lugar.Ubicacion.Split(',').Take(lugar.Ubicacion.Length).ToList();
            Position position = new Position(double.Parse(values[0]), double.Parse(values[1]));
            map.MoveToRegion(new MapSpan(position, 0.01, 0.01));
            Pin pin = new Pin
            {
                Label = lugar.Nombre,
                Address = lugar.Domicilio,
                Type = PinType.Place,
                Position = position
            };
            map.Pins.Add(pin);
        }
    }
}