using System.Collections.Generic; 
namespace vnstat_dashboard_core.Models.Vnstat{ 

    public class VnstatRoot
    {
        public string vnstatversion { get; set; }
        public string jsonversion { get; set; }
        public List<Interface> interfaces { get; set; }
    }

}