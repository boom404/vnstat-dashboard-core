using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using vnstat_dashboard_core.Interfaces;
using vnstat_dashboard_core.Models;
using vnstat_dashboard_core.Models.Vnstat;

namespace vnstat_dashboard_core.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IVnstatHelper _vnstatHelper;

        public Interface CurrentInterface { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IVnstatHelper vnstatHelper)
        {

            _logger = logger;
            _vnstatHelper = vnstatHelper;

            CurrentInterface = _vnstatHelper.GetInterfaces().FirstOrDefault();
        }

        public void OnGet()
        {

        }
    }
}
