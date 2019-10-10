using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using location_service.Models;
using Microsoft.Extensions.Logging;

namespace location_service.Services
{
    public class LocationService : ILocationService
    {
        readonly ILogger<LocationService> logger;
        private List<LocationBucket> locationBuckets;

        public LocationService(ILogger<LocationService> logger)
        {
            this.logger = logger;
            LoadLocationBucketData();
        }

        private void LoadLocationBucketData()
        {
            using var streamReader = File.OpenText(@"resources/locations_alphabetical_buckets.json");
            using var document = JsonDocument.Parse(streamReader.ReadToEnd());
            locationBuckets = JsonSerializer.Deserialize<List<LocationBucket>>(document.RootElement.GetRawText(), null);
        }

        public List<LocationData> getLocationsInBucket(char bucketletter)
        {
            return this.locationBuckets.Where(lb => lb.Id == bucketletter)
                .First().Locations;
        }
    }
}