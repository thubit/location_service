using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace location_service.Models
{
    public class LocationData
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Plaatsnaam")]
        public string Plaatsnaam { get; set; }

        [JsonPropertyName("Alias")]
        public string Alias { get; set; }

        [JsonPropertyName("Gemeentenaam")]
        public string Gemeentenaam { get; set; }

        [JsonPropertyName("Provincienaam")]
        public string Provincienaam { get; set; }
    }
}