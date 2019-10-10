using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using LocationService;
using Xunit;
using FluentAssertions;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;
using LocationService.Models;

namespace LocationServiceTests.Integration
{
    public class IntegrationTestBase
    {
        protected readonly HttpClient _client;

        public IntegrationTestBase()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }

        [Fact]
        public async Task GetLocationData_From_A_Bucket()
        {
            var response = await _client.GetAsync("/api/location/a");
            List<LocationData> locationData = await response.Content?.ReadAsAsync<List<LocationData>>();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            locationData.Count.Should().Be(17);
        }

    }

}