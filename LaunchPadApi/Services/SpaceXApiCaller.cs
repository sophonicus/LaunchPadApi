using LaunchPadApi.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LaunchPadApi.Services
{
    public class SpaceXApiCaller : ISpaceXApiCaller
    {
        private ILogger _logger;

        public SpaceXApiCaller(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<List<LaunchPad>> GetLaunchPadInfoAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.spacexdata.com/");
                    var response = await client.GetAsync($"/v2/launchpads");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var LounchPadInfo = JsonConvert.DeserializeObject<List<LaunchPad>>(stringResult);

                    return LounchPadInfo;

                }
                catch (HttpRequestException httpRequestException)
                {
                    _logger.LogError($"Failed to complete http request to https://api.spacexdata.com/ : {httpRequestException} ");
                    //TODO: logging
                    return null;
                }

            }
        }
    }
}
