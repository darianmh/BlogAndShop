using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BlogAndShop.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            var assembly = Assembly.GetExecutingAssembly();
            var typesToRegister = assembly.GetTypes()
                 .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BaseEntity))).ToList();

            foreach (var type in typesToRegister)
            {
                var method = modelBuilder.GetType().GetMethod("Entity", new Type[] { });
                method = method.MakeGenericMethod(new Type[] { type });
                method.Invoke(modelBuilder, null);
            }
            //post group
            modelBuilder.Entity<Post_PostGroup>(entity =>
            {
                entity.HasKey(x => new { x.GroupId, x.PostId });
                entity.HasOne(x => x.PostGroup)
                    .WithMany(x => x.Post_PostGroups)
                    .HasForeignKey(x => x.GroupId);
                entity.HasOne(x => x.Post)
                    .WithMany(x => x.Post_PostGroups)
                    .HasForeignKey(x => x.PostId);
            });
            //post tag
            modelBuilder.Entity<Post_Tags>(entity =>
            {
                entity.HasKey(x => new { x.TagId, x.PostId });
                entity.HasOne(x => x.Post)
                    .WithMany(x => x.Post_Tags)
                    .HasForeignKey(x => x.PostId);
                entity.HasOne(x => x.Tag)
                    .WithMany(x => x.Post_Tags)
                    .HasForeignKey(x => x.TagId);
            });
            //product media
            modelBuilder.Entity<ProductMedia>(entity =>
            {
                entity.HasKey(x => new { x.ProductId, x.MediaId });
                entity.HasOne(x => x.Media)
                    .WithMany(x => x.ProductMedias)
                    .HasForeignKey(x => x.MediaId);
                entity.HasOne(x => x.Product)
                    .WithMany(x => x.ProductMedias)
                    .HasForeignKey(x => x.ProductId);
            });
            //product tag
            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.HasKey(x => new { x.ProductId, x.TagId });
                entity.HasOne(x => x.Tag)
                    .WithMany(x => x.ProductTags)
                    .HasForeignKey(x => x.TagId);
                entity.HasOne(x => x.Product)
                    .WithMany(x => x.ProductTags)
                    .HasForeignKey(x => x.ProductId);
            });

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

        public virtual DbSet<Post_PostGroup> Post_PostGroup { get; set; }
        public virtual DbSet<Post_Tags> Post_Tags { get; set; }
        public virtual DbSet<ProductMedia> ProductMedia { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
    }
}
