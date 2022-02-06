using System;

namespace vnstat_dashboard_core.Models.Vnstat
{
    public class Data
    {
        public int id { get; set; }
        public Date date { get; set; }
        public Time time { get; set; }
        public int rx { get; set; }
        public int tx { get; set; }


        public DateTime GetDate()
        {
            DateTime getDate;

            if (time != null)
                getDate = new DateTime(date.year, date.month, date.day, time.hour, time.minute, 0);
            else
                getDate = new DateTime(date.year, date.month, (date.day == 0) ? 1: date.day);

            return getDate;
        }

        public int GetTotal()
        {
            var total = rx + tx;

            return total;
        }


    }
}
