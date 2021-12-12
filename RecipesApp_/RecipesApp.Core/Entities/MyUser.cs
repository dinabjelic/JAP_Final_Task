using Microsoft.AspNetCore.Identity;

namespace RecipesApp.Database.Entities
{
    public class MyUser : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IdentityUser<int> I_User { get; set; }
        public int I_UserId { get; set; }

    }
}
