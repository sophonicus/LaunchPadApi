using LaunchPadApi.Models;
using LaunchPadApi.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadApi.Test
{
    public class SpaceXApiCallerFake : ISpaceXApiCaller
    {
        private readonly List<LaunchPad> _launchPads;

        public SpaceXApiCallerFake()
        {
            _launchPads = new List<LaunchPad>
            {
                new LaunchPad()
                {
                    padid = 1,
                    id = "kwajalein_atoll",
                    full_name = "Kwajalein Atoll Omelek Island",
                    status = "retired",
                    location = new Location(){
                        name = "Omelek Island",
                        region = "Marshall Islands",
                        latitude = 9.0477206,
                        longitude = 167.7431292
                    },
                    vehicles_launched = new List<string>(){ "Falcon 1" },
                    details = "SpaceX original launch site, where all of the Falcon 1 launches occured. Abandoned as SpaceX decided against upgrading the pad to support Falcon 9."

                },
                new LaunchPad()
                {
                    padid = 2,
                    id = "ccafs_slc_40",
                    full_name = "Cape Canaveral Air Force Station Space Launch Complex 40",
                    status = "active",
                    location = new Location(){
                      name = "Cape Canaveral",
                      region = "Florida",
                      latitude = 28.5618571,
                      longitude = -80.577366
                    },
                    vehicles_launched = new List<string>() {
                      "Falcon 9"
                    },
                    details = "SpaceX primary Falcon 9 launch pad, where all east coast Falcon 9s launched prior to the AMOS-6 anomaly. Initially used to launch Titan rockets for Lockheed Martin. Back online since CRS-13 on 2017-12-15."
                },
                new LaunchPad()
                {
                    padid = 3,
                    id = "ccafs_lc_13",
                    full_name = "Cape Canaveral Air Force Station Space Launch Complex 13",
                    status = "active",
                    location = new Location() {
                      name = "Cape Canaveral",
                      region = "Florida",
                      latitude = 28.4857244,
                      longitude = -80.5449222
                    },
                    vehicles_launched = new List<string>() {
                      "Falcon 9"
                    },
                    details = "SpaceX east coast landing pad, where the historic first landing occurred. Originally used for early Atlas missiles and rockets from Lockheed Martin. Currently being expanded to add two smaller pads for Falcon Heavy RTLS missions."
                }
            };
        }

        public async Task<List<LaunchPad>> GetLaunchPadInfoAsync()
        {
            return await Task.FromResult(_launchPads);        
        }
    }
}
