using GuiaGuanajuato.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaGuanajuato
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            var tabMarket = new TapGestureRecognizer();
            tabMarket.Tapped += TabMarket_Tapped;
            imgMarket.GestureRecognizers.Add(tabMarket);
        }

        async void TabMarket_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info());
        }
    }
}