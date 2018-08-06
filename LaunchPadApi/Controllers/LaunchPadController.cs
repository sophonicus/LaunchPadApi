using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LaunchPadApi.Services;
using LaunchPadApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaunchPadApi.Controllers
{
    [Route("api/LaunchPads")]
    public class LaunchPadController : Controller
    {
        private ILogger<LaunchPadController> _logger;
        private ISpaceXApiCaller _apiCaller;

        public LaunchPadController(/*IWorldRepository repo,*/ ILogger<LaunchPadController> logger, ISpaceXApiCaller apiCaller)
        {
            //_repo = repo;
            _logger = logger;
            _apiCaller = apiCaller;
        }

        // GET: api/LaunchPad
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _apiCaller.GetLaunchPadInfoAsync().Result;

                return Ok(Mapper.Map<IEnumerable<LaunchPadViewModel>>(results.AsEnumerable()));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Launch Pad Info : {ex}");
                return BadRequest("Failed to get Launch Pad Info.");
            }
        }

        
    }
}
