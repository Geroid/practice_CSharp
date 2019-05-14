using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DetectiveAgency
{
    class Account
    {
        [Key]
        public int id { get; set; }
        [StringLength(50,ErrorMessage ="Имя должно быть длиной не более 50 символов")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Имя должно быть длиной не более 50 символов")]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public RoleEnum Role { get; set; }
    }
    public enum RoleEnum
    {
        user,
        admin
    }
}
