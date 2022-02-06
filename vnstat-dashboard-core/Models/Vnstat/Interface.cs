namespace vnstat_dashboard_core.Models.Vnstat{ 

    public class Interface
    {
        public string name { get; set; }
        public string alias { get; set; }
        public Created created { get; set; }
        public Updated updated { get; set; }
        public Traffic traffic { get; set; }
    }

}