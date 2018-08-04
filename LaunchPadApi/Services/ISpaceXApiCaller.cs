using System.Collections.Generic;
using System.Threading.Tasks;
using LaunchPadApi.Models;

namespace LaunchPadApi.Services
{
    public interface ISpaceXApiCaller
    {
        Task<List<LaunchPad>> GetLaunchPadInfoAsync();
    }
}