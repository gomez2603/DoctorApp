

using DoctorApp.Data.Seeds;
using DoctorApp.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorApp.Data.Context
{
    public class DoctorContext :DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext> options) : base(options)
        {
                
        }


        public DbSet<Users> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserSeeds());
        }


    }
}
