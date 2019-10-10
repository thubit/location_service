using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace location_service.Models
{
    public class LocationBucket
    {
        [JsonPropertyName("Id")]
        public char Id { get; set; }

        [JsonPropertyName("Locations")]
        public List<LocationData> Locations { get; set; }
    }
}