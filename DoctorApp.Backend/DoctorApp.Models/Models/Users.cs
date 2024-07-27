
using System.ComponentModel.DataAnnotations;

namespace DoctorApp.Models.Models
{
    public class Users
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
