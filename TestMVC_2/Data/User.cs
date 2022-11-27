using Microsoft.AspNetCore.Identity;

namespace TestMVC_2.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
