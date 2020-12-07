using ForumAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ForumAPI
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        {
        }

        public DbSet<CategoryGroup> CategoryGroups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryGroup>().ToTable("CategoryGroup");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Topic>().ToTable("Topic");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<Role>().ToTable("Role");

            modelBuilder.Entity<Category>().HasOne<CategoryGroup>(c => c.CategoryGroup).WithMany(cg => cg.Categories).HasForeignKey(c => c.GroupCategoryID);
            modelBuilder.Entity<Topic>().HasOne<Category>(t => t.Category).WithMany(c => c.Topics).HasForeignKey(t => t.CategoryID);
            modelBuilder.Entity<Topic>().HasOne<User>(t => t.User).WithMany(u => u.Topics).HasForeignKey(t => t.CreatedBy);
            modelBuilder.Entity<Post>().HasOne<User>(p => p.User).WithMany(u => u.Posts).HasForeignKey(p => p.CreatedBy);
            modelBuilder.Entity<Post>().HasOne<Topic>(p => p.Topic).WithMany(t => t.Posts).HasForeignKey(p => p.TopicID);
            modelBuilder.Entity<UserRole>()
            .HasOne<User>(sc => sc.User)
            .WithMany(s => s.UserRoles)
            .HasForeignKey(sc => sc.UserID);
            modelBuilder.Entity<UserRole>()
            .HasOne<Role>(sc => sc.Role)
            .WithMany(s => s.UserRoles)
            .HasForeignKey(sc => sc.RoleID);
        }
    }
}
