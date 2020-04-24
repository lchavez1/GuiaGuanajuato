using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaGuanajuato.Models
{
    class Lugar
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("ubicacion")]
        public string Ubicacion { get; set; }

        [JsonProperty("domicilio")]
        public string Domicilio { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

    }
}
