using LaunchPadApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaunchPadApi.Services
{
    public static class SpaceXApiExtension
    {
        public static async Task<List<LaunchPad>> GetAllLounchPadInfo(this ISpaceXApiCaller _apiCaller)
        {
            return await _apiCaller.GetLaunchPadInfoAsync();
        }
    }
}
