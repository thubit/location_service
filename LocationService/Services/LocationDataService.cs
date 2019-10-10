using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using LocationService.Models;
using Microsoft.Extensions.Logging;

namespace LocationService.Services
{
    public class LocationDataService : ILocationService
    {
        readonly ILogger<LocationDataService> logger;
        private List<LocationBucket> locationBuckets;

        public LocationDataService(ILogger<LocationDataService> logger)
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