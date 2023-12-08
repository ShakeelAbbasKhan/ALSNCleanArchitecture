using Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    
        public DbSet<UserTypes> UserTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<RolesModule> RolesModule { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Translator> Translators { get; set; }

        public DbSet<TranslationOfficeTranslators> TranslationOfficeTranslators { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderRepitition> OrderRepititions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure identity-related settings (if needed)
            builder.Entity<RolesModule>()
                  .HasOne(rm => rm.Role)
                  .WithMany()
                  .HasForeignKey(rm => rm.RoleId)
                  .IsRequired();

            builder.Entity<ApplicationUser>()
                .HasOne(u => u.UserTypes)
                .WithMany()
                .HasForeignKey(u => u.UserTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasOne(u => u.Country)
                .WithMany()
                .HasForeignKey(u => u.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Translator>()
                .HasOne(t => t.SourceLanguage)
                .WithMany(l => l.SourceTranslators)
                .HasForeignKey(t => t.SourceLanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Translator>()
                .HasOne(t => t.TargetLanguage)
                .WithMany(l => l.TargetTranslators)
                .HasForeignKey(t => t.TargetLanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TranslationOfficeTranslators>()
               .HasOne(tt => tt.Translator)
               .WithMany(t => t.TranslationOfficeTranslators)
               .HasForeignKey(tt => tt.TranslatorID)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction); 

            builder.Entity<TranslationOfficeTranslators>()
                .HasOne(tt => tt.User)
                .WithMany(u => u.TranslationOfficeTranslators)
                .HasForeignKey(tt => tt.TranslationOfficeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

           


            builder.Entity<Order>()
                    .HasOne(tt => tt.GuestUser)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(tt => tt.GuestID)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Order>()
                .HasOne(tt => tt.TranslationOfficeUser)
                .WithMany(u => u.OrdersTranslator)
                .HasForeignKey(tt => tt.TranslationOfficeID)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<OrderDetail>()
               .HasOne(od => od.SourceLanguage)
               .WithMany(l => l.SourceOrderDetails)
               .HasForeignKey(od => od.SourceLanguageId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
                .HasOne(od => od.TargetLanguage)
                .WithMany(l => l.TargetOrderDetails)
                .HasForeignKey(od => od.TargetLanguageId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
                .HasOne(od => od.Orders)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
               .HasOne(od => od.OrderRepitition)
               .WithMany(o => o.OrderDetails)
               .HasForeignKey(od => od.OrderRepitionID)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderAssignment>()
              .HasOne(od => od.Order)
              .WithMany(o => o.OrderAssignments)
              .HasForeignKey(od => od.OrderID)
              .IsRequired()
              .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderAssignment>()
              .HasOne(od => od.User)
              .WithMany(o => o.OrderAssignments)
              .HasForeignKey(od => od.TranslatorId)
              .IsRequired()
              .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
