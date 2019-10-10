using System.Collections.Generic;
using location_service.Models;

namespace location_service.Services
{
    public interface ILocationService
    {
        public List<LocationData> getLocationsInBucket(char bucketletter);
    }
}