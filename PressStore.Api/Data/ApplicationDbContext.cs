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
        public  DbSet<Press> Presses { get; set; }
        public  DbSet<PressCompany> PressCompanies  {get; set;}
        public  DbSet<PressCompanyRedactor> PressCompanyRedactors { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<Operation> Operations { get; set; }
        public  DbSet<Favoris> Favoris { get; set; }
        public  DbSet<Abonnement> Abonnements { get; set; }


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
            //builder.Entity<Press>().ToTable("Press");
            //builder.Entity<Favoris>().ToTable("Favoris");
            //builder.Entity<PressCompany>().ToTable("PressCompany");
            //builder.Entity<Order>().ToTable("order");
            //builder.Entity<PressCompanyRedactor>().ToTable("PressCompanyRedactor");
            //builder.Entity<Abonnement>().ToTable("Abonnement");
            //builder.Entity<Operation>().ToTable("Operation");
        }
        
    }
}
