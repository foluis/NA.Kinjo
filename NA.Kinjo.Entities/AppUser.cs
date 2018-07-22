using System.Collections.Generic;

namespace NA.Kinjo.Entities
{
    public class AppUser
    {
        public int Id { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public List<Company> Companies { get; set; }

    }
}
