using Core.Entities;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto //Login olmak isteyen bir kişi
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
