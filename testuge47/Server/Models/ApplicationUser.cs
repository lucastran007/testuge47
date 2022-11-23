using Microsoft.AspNetCore.Identity;
using testuge47.Shared;

namespace testuge47.Server.Models
{
    public class ApplicationUser : IdentityUser
    {

        public List<SuperHero>SuperHeroes { get; set; } = new List<SuperHero>();
    }
}