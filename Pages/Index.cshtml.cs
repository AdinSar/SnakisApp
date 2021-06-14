using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SnakisApp.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakisApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<SnakisAppUser> _userManager;

        public SnakisAppUser MyUser { get; set; } 
        public IndexModel(ILogger<IndexModel> logger, UserManager<SnakisAppUser> userManager) 
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync() 
        {

            MyUser = await _userManager.GetUserAsync(User);



            return Page();
        }
    }
}
