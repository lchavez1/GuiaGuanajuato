using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaGuanajuato.Views
{
    public class Data
    {
        public String image { get; set; }
        public String text { get; set; }
        

        public Data(String image, String text)
        {
            this.image = image;
            this.text = text;
        }

        // private String coordenadas;
    }
}
