using System.Security.Principal;

namespace Models
{
    public class AppUser : IIdentity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }        
    }
}
