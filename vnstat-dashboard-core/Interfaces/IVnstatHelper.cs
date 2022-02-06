using System.Collections.Generic;
using vnstat_dashboard_core.Models.Vnstat;

namespace vnstat_dashboard_core.Interfaces
{
    public interface IVnstatHelper
    {
        string GetJson { get; }
        List<Interface> GetInterfaces();
    }
}
