using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GuiaGuanajuato.Models
{
    public partial class Fotografias
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("lugarId")]
        public int LugarId { get; set; }

        [JsonProperty("lugar")]
        public string Lugar { get; set; }
    }
    public partial class Fotografias
    {
        public static List<Fotografias> FromJson(string json) => JsonConvert.DeserializeObject<List<Fotografias>>(json, GuiaGuanajuato.Models.Converter.Settings);
    }

    public static class Serialize1
    {
        public static string ToJson(List<Fotografias> self) => JsonConvert.SerializeObject(self, GuiaGuanajuato.Models.Converter.Settings);
    }

    internal static class Converter1
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
