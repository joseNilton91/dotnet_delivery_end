using System.ComponentModel.DataAnnotations;

namespace LibraryDigital.webapi.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string FirstNameUser { get; set; }
        public string LastNameUser { get; set; }
        public string EmailUser { get; set; }
        public string Password { get; set; }
    }
}
