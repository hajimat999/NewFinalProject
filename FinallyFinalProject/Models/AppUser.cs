using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FinallyFinalProject.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
