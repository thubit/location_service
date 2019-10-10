using System.Collections.Generic;
using System.Threading.Tasks;
using location_service.Models;
using location_service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace location_service.Controllers
{
    [ApiController]
    [Route("api/location")]
    public class LocationController : ControllerBase
    {
        readonly ILogger<LocationController> logger;
        readonly ILocationService locationService;
        public LocationController(ILogger<LocationController> logger, ILocationService locationService)
        {
            this.logger = logger;
            this.locationService = locationService;
        }

        [HttpGet("{letter}")]
        public ActionResult<List<LocationData>> GetLocationList(char letter)
        {
            return locationService.getLocationsInBucket(letter);
        }
    }
}