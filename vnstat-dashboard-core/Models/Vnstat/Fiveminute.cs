namespace vnstat_dashboard_core.Models.Vnstat{ 

    public class Fiveminute
    {
        public int id { get; set; }
        public Date date { get; set; }
        public Time time { get; set; }
        public int rx { get; set; }
        public int tx { get; set; }
    }

}