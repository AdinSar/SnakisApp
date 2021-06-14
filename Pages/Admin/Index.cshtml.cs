using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SnakisApp.Areas.Identity.Data;

namespace SnakisApp.Pages.Admin
{
    public class IndexModel : PageModel
    {

        public SnakisAppUser CurrentUser { get; set; }
        public bool isUser { get; set; }
        public bool isAdmin { get; set; }

        public IQueryable<SnakisAppUser> Users { get; set; }

        public UserManager<SnakisAppUser> _userManager;

        public IndexModel(UserManager<SnakisAppUser> userManager)
        {
            
            _userManager = userManager;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            Users = _userManager.Users;


            CurrentUser = await _userManager.GetUserAsync(User);
            isUser = await _userManager.IsInRoleAsync(CurrentUser, "User");
            isAdmin = await _userManager.IsInRoleAsync(CurrentUser, "Admin");

            return Page();
        }
    }
}
