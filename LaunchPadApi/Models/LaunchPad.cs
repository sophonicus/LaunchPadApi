using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchPadApi.Models
{
    public class LaunchPad
    {

        public int padid { get; set; }
        public string id { get; set; }
        public string full_name { get; set; }
        public string status { get; set; }
        public Location location { get; set; }
        public List<string> vehicles_launched { get; set; }
        public string details { get; set; }
    }
}
