using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Collaboo.App.WebAPI.Entities
{
    public class User : IdentityUser
    {
        public string GitHubUsername { get; set; }
    }
}
