using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using vnstat_dashboard_core.Interfaces;
using vnstat_dashboard_core.Models.Vnstat;

namespace vnstat_dashboard_core.Helpers
{
    public class VnStatHelperDev : IVnstatHelper
    {
        private VnstatRoot _vnstatRoot;
        private string _jsonResponse;

        public VnStatHelperDev()
        {
            _jsonResponse = File.ReadAllText("./Data/dev.json");
            _vnstatRoot = JsonConvert.DeserializeObject<VnstatRoot>(_jsonResponse);
        }

        public string GetJson
        {
            get { return _jsonResponse; }
        }

        public List<Interface> GetInterfaces()
        {
            return _vnstatRoot.interfaces;
        }
    }
}
