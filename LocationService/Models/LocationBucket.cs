using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LocationService.Models
{
    public class LocationBucket
    {
        [JsonPropertyName("Id")]
        public char Id { get; set; }

        [JsonPropertyName("Locations")]
        public List<LocationData> Locations { get; set; }
    }
}