using System.Collections.Generic;
using System.Linq;
using vnstat_dashboard_core.Helpers;

namespace vnstat_dashboard_core.Models.Vnstat{ 

    public class Traffic
    {
        public Total total { get; set; }
        public List<Fiveminute> fiveminute { get; set; }
        public List<Data> hour { get; set; }
        public List<Data> day { get; set; }
        public List<Data> month { get; set; }
        public List<Data> year { get; set; }
        public List<Data> top { get; set; }

        public string GetHighestHourlySuffix()
        {
            var s = this.hour.Max(m => m.GetTotal()).GetSuffix();

            return s;
        }

    }

}