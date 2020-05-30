using Newtonsoft.Json;
using System;
using GuiaGuanajuato.Models;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace GuiaGuanajuato.Models
{
    public partial class Lugar
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("ubicacion")]
        public string Ubicacion { get; set; }

        [JsonProperty("domicilio")]
        public string Domicilio { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("fotografiaUrl")]
        public string FotografiaURL { get; set; }

        [JsonProperty("fotografias")]
        public List<object> Fotografias { get; set; }
    }
        public partial class Lugar
        {
            public static List<Lugar> FromJson(string json) => JsonConvert.DeserializeObject<List<Lugar>>(json, GuiaGuanajuato.Models.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(List<Lugar> self) => JsonConvert.SerializeObject(self, GuiaGuanajuato.Models.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter{ DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        } 
    }
