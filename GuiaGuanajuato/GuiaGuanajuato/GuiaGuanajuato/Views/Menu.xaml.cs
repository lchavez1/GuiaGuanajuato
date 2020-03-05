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
        Data datos;

        public Menu()
        {
            InitializeComponent();
            var tabMarket = new TapGestureRecognizer();
            var tabJuarez = new TapGestureRecognizer();
            var tabMomias = new TapGestureRecognizer();
            var tabCera = new TapGestureRecognizer();
            var tabPrincipal = new TapGestureRecognizer();
            var tabDiego = new TapGestureRecognizer();
            var tabPipila = new TapGestureRecognizer();
            var tabUG = new TapGestureRecognizer();
            var tabCompania = new TapGestureRecognizer();
            var tabCervantes = new TapGestureRecognizer();
            var tabAlhondiga = new TapGestureRecognizer();
            var tabPPaz = new TapGestureRecognizer();
            tabMarket.Tapped += TabMarket_Tapped;
            imgMarket.GestureRecognizers.Add(tabMarket);
            tabJuarez.Tapped += TabJuarez_Tapped;
            imgJuarez.GestureRecognizers.Add(tabJuarez);
            tabMomias.Tapped += TabMomias_Tapped;
            imgMomias.GestureRecognizers.Add(tabMomias);
            tabCera.Tapped += TabCera_Tapped;
            imgCera.GestureRecognizers.Add(tabCera);
            tabPrincipal.Tapped += TabPrincipal_Tapped;
            imgPrincipal.GestureRecognizers.Add(tabPrincipal);
            tabDiego.Tapped += TabDiego_Tapped;
            imgDiego.GestureRecognizers.Add(tabDiego);
            tabPipila.Tapped += TabPipila_Tapped;
            imgPipila.GestureRecognizers.Add(tabPipila);
            tabUG.Tapped += TabUG_Tapped;
            imgUG.GestureRecognizers.Add(tabUG);
            tabCompania.Tapped += TabCompania_Tapped;
            imgCompania.GestureRecognizers.Add(tabCompania);
            tabCervantes.Tapped += TabCervantes_Tapped;
            imgCervantes.GestureRecognizers.Add(tabCervantes);
            tabAlhondiga.Tapped += TabAlhondiga_Tapped;
            imgAlhondiga.GestureRecognizers.Add(tabAlhondiga);
            tabPPaz.Tapped += TabPPaz_Tapped;
            imgPPaz.GestureRecognizers.Add(tabPPaz);
        }

        async void TabPPaz_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://www.travelbymexico.com/guanatr/guan5433NXX.jpg", "Plaza de la paz");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabAlhondiga_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://upload.wikimedia.org/wikipedia/commons/c/c2/Alhondiga-Granaditas-Mexico.JPG", "Alhondiga de Granaditas");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabCervantes_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://www.mexicoescultura.com/galerias/espacios/principal/05_teatrocervantes.jpg", "Teatro Cervantez");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabCompania_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://periodicocorreo.com.mx/wp-content/uploads/2015/11/ocio-color-compa-3.jpg", "Templo la Compañia");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabUG_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://periodicocorreo.com.mx/wp-content/uploads/2017/01/UG.jpg", "Universidad de Guanajuato");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabPipila_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://upload.wikimedia.org/wikipedia/commons/3/30/El_P%C3%ADpila.jpg", "Pipila");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabDiego_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://boletines.guanajuato.gob.mx/wp-content/uploads/2016/03/COLECCION-MARTE-R-GOMEZ.jpg", "Museo Casa Diego Rivera");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabPrincipal_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://media-cdn.tripadvisor.com/media/photo-s/15/bc/d3/b7/out-front.jpg", "Teatro Principal");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabCera_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://www.travelbymexico.com/guanatr/guan3611OCH.jpg", "Cera");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabMomias_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://www.ancient-origins.es/sites/default/files/field/image/Portada-momias-Guanajuato.jpg", "Momias");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabJuarez_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Teatro_Juarez.jpg/1200px-Teatro_Juarez.jpg", "Teatro Juarez");
            await Navigation.PushAsync(new Info(datos));
        }

        async void TabMarket_Tapped(object sender, EventArgs e)
        {
            datos = new Data("https://media-cdn.tripadvisor.com/media/photo-s/0f/88/70/2a/interior.jpg", "Mercado");
            await Navigation.PushAsync(new Info(datos));
        }
    }
}