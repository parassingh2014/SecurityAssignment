using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAIS3110_ASPLab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DateTime Message { get; set; }
        public string Name { get; set; }
        List<String> abc = new List<string>()
        {
            "Raman",
            "Raman"
        };

        [BindProperty]
        public string InputTextBox { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            for (var i = 0; i<=5; i++)
            {
                Name = "Raman";
            }
        }

        public void OnPost()
        {
            Message = DateTime.Now;
        }
    }
}
