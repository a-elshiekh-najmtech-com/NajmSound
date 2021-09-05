using Microsoft.AspNetCore.Identity;

namespace NajmSound.Models
{
    public class ApplicationUser :  IdentityUser
    {
        public string Name { get; set; }
    }
}
