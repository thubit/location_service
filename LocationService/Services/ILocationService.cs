using System.Collections.Generic;
using LocationService.Models;

namespace LocationService.Services
{
    public interface ILocationService
    {
        public List<LocationData> getLocationsInBucket(char bucketletter);
    }
}