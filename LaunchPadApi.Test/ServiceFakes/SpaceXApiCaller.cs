using LaunchPadApi.Models;
using LaunchPadApi.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadApi.Test
{
    public class SpaceXApiCaller : ISpaceXApiCaller
    {
        public Task<List<LaunchPad>> GetLaunchPadInfoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
