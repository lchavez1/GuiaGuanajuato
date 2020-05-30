using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaGuanajuato.Models
{
    class Usuario
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
