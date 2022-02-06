using System;

namespace vnstat_dashboard_core.Helpers
{
    public static class ValueHelper
    {
        private static readonly string[] SizeSuffixes =
       { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        private static int GetScale(Int64 i)
        {
            var m = Math.Log(1024);

            var scale = Math.Floor(Math.Round(Math.Log(i) / m, 3));

            if (scale < 0) { scale = 0; }
            if (scale > 8) { scale = 8; }

            return (int)scale;
        }

        public static string GetSuffix(this Int64 val)
        {
            return SizeSuffixes[GetScale(val)];   
        }

        public static double GetValue(this Int64 val, int decimals = 3)
        {
            return Math.Round(val / Math.Pow(1024, GetScale(val)), decimals);
        }

        public static double GetBytes(this Int64 val, int decimals = 3)
        {
            return Math.Round(val / Math.Pow(1024, 2), decimals);
        }
        public static string GetValueAndSuffix(this Int64 val, int decimals = 3)
        {
            return String.Format("{0} {1}", GetValue(val, decimals), GetSuffix(val));
        }
    }
}
