using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaGuanajuato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Info : ContentPage
    {
        public Info(Data datos)
        {
            InitializeComponent();
            imgImage.Source = datos.image;
            lblDescription.Text = datos.text;
        }
    }
}