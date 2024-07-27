
using DoctorApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography;
using System.Text;

namespace DoctorApp.Data.Seeds
{
    public class UserSeeds : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            using var hmac = new HMACSHA512();
            builder.HasData(

                new Users() { Id = 1, Username = "Jose", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = hmac.Key },
                new Users() { Id = 2, Username = "Celina", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = hmac.Key },
                new Users() { Id = 3, Username = "Gloria", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = hmac.Key });
        }
    }
}
