using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoleEF
{
    public class MyDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=127.0.0.1;database=test;uid=root;pwd=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            

            var typeUser = modelBuilder.Entity<User>();
            typeUser.ToTable<User>("user");

            var typeRole = modelBuilder.Entity<Role>();
            typeRole.ToTable<Role>("role");

            var typeUserRole = modelBuilder.Entity<UserRole>();
            typeUserRole.ToTable<UserRole>("user_role");
            typeUserRole.HasOne(x => x.User).WithMany(u => u.UserRole).HasForeignKey(x => x.UserId).IsRequired();
            typeUserRole.HasOne(x => x.Role).WithMany(r => r.UserRole).HasForeignKey(x => x.RoleId).IsRequired();
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}
