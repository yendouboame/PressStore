using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using PressStore.Api.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressStore.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Press> presses { get; set; }
        public  virtual DbSet<PressCompany> pressCompanies  {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(u =>
            {
                // UserRole
                u.HasMany(e => e.UserRoles)
                .WithOne()
                .HasForeignKey(o => o.UserId)
                .IsRequired();

                // Login
                u.HasMany(e => e.UserLogins)
                .WithOne()
                .HasForeignKey(o => o.UserId)
                .IsRequired();
                
                // Claim
                u.HasMany(e => e.UserClaims)
                .WithOne()
                .HasForeignKey(o => o.UserId)
                .IsRequired();
                
                // Login
                u.HasMany(e => e.UserTokens)
                .WithOne()
                .HasForeignKey(o => o.UserId)
                .IsRequired();

            });

            builder.Entity<Role>(r =>
            {
                r.HasMany(e => e.UserRoles)
                .WithOne()
                .HasForeignKey(o => o.RoleId)
                .IsRequired();
            });

            builder.Entity<UserRole>(ur =>
           {
               //user
               ur.HasOne(e => e.User)
               .WithMany()
               .HasForeignKey(o => o.UserId);
               //role
               ur.HasOne(e => e.Role)
               .WithMany()
               .HasForeignKey(o => o.RoleId);
           });
        }
    }
}
