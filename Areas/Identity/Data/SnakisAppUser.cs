using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace SnakisApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SnakisAppUser class
    public class SnakisAppUser : IdentityUser
    {
        public string ProfilePictureURL { get; set; }

        public DateTime TimeOfAccountCreation { get; set; }



    }
}
