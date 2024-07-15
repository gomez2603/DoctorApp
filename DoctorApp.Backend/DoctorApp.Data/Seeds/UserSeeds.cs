
using DoctorApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorApp.Data.Seeds
{
    public class UserSeeds : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(

                new Users() { Id = 1, Username = "Jose" },
                new Users() { Id = 2, Username = "Celina" },
                new Users() { Id = 3, Username = "Gloria" });
        }
    }
}
