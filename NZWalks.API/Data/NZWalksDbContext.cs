using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : IdentityDbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    var readerRoleId = "a71a55d6-99d7-4123-b4e0-1218ecb90e3e";
        //    var writerRoleId = "c309fa92-2123-47be-b397-a1c77adb502c";

        //    var roles = new List<IdentityRole>
        //    {
        //        new IdentityRole
        //        {
        //            Id = readerRoleId,
        //            ConcurrencyStamp = readerRoleId,
        //            Name = "Reader",
        //            NormalizedName = "Reader".ToUpper()
        //        },
        //        new IdentityRole
        //        {
        //            Id = writerRoleId,
        //            ConcurrencyStamp = writerRoleId,
        //            Name = "Writer",
        //            NormalizedName = "Writer".ToUpper()
        //        }
        //    };

        //    builder.Entity<IdentityRole>().HasData(roles);
        //}
    }
}
