using GuiaGuanajuato.Models;
using GuiaGuanajuato.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text
            };
            Registrar(usuario);
            await Navigation.PushAsync(new MenuAPI());
        }

        private async void Registrar(Usuario user)
        {
            var userJson = await Task.Run(() => JsonConvert.SerializeObject(user));
            var httpContent = new StringContent(userJson, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var httpResponse = await client.PostAsync("https://guiaguanajuatoapi.azurewebsites.net/api/Usuarios", httpContent);

            if (httpResponse.IsSuccessStatusCode == true)
            {
                await SecureStorage.SetAsync("registrado", "si");

            }
        }
    }
}
