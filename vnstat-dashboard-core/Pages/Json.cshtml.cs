using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using vnstat_dashboard_core.Interfaces;

namespace vnstat_dashboard_core.Pages
{
    public class JsonModel : PageModel
    {
        private IVnstatHelper _vnstatHelper;

        public JsonModel(IVnstatHelper vnstatHelper)
        {
            _vnstatHelper = vnstatHelper;
        }

        public IActionResult OnGet()
        {
            return Content(_vnstatHelper.GetJson);
        }
    }
}
