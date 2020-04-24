using GuiaGuanajuato.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuiaGuanajuato
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnRegister.Clicked += BtnRegister_Clicked;
        }

        async void BtnRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuAPI());
        }
    }
}
