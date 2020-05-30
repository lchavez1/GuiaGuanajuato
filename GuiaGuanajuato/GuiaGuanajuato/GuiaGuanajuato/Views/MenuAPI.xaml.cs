using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GuiaGuanajuato.Models;

namespace GuiaGuanajuato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuAPI : ContentPage
    {
       
        public MenuAPI()
        {
            InitializeComponent();
            CargarLugares();
        }

        List<Lugar> lugares = new List<Lugar>();

        private async void CargarLugares()
        {
            try
            {
                HttpClient client = new HttpClient();

                string URL = "https://guiaguanajuatoapi.azurewebsites.net/api/Lugares";

                var resultado = await client.GetAsync(URL);

                var json = resultado.Content.ReadAsStringAsync().Result;             

                lugares = Lugar.FromJson(json);
                          
                var layout = new StackLayout { Padding = new Thickness(5, 10) };
            
                if (lugares.Count() > 0)
                {
                    gdLugares.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    gdLugares.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    gdLugares.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    int i = 0;
                    int j = 0;
                    foreach (var item in lugares)
                    {

                        var img = new Image { Source = item.FotografiaURL, WidthRequest = 200, Aspect = Aspect.AspectFill };
                        gdLugares.Children.Add(img, j, i);
                        if (j > 0)
                        {
                            j = 0;
                            i++;
                            gdLugares.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        }
                        else
                        {
                            j++;
                        }


                        layout.Children.Add(gdLugares);
                        gdLugares.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                        this.Content = layout;

                        var tapLugar = new TapGestureRecognizer();
                        tapLugar.Tapped += TapLugar_Tapped;
                        img.GestureRecognizers.Add(tapLugar);
                    }
                }
                else
                {
                    var label = new Label { Text = "No se encontraron datos.", TextColor = Color.FromHex("#77d065"), FontSize = 20 };
                    layout.Children.Add(label);
                    this.Content = layout;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
                   
        }

        async void TapLugar_Tapped(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            var lugar = lugares.Where(l => "Uri: " + l.FotografiaURL == image.Source.ToString()).FirstOrDefault();
            long index = lugar.Id;
            await Navigation.PushAsync(new InformacionAPI(index));
        }
    }
}