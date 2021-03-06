using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BlogAndShop.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var assembly = Assembly.GetExecutingAssembly();
            var typesToRegister = assembly.GetTypes()
                 .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BaseEntity))).ToList();

            foreach (var type in typesToRegister)
            {
                //var method = modelBuilder.GetType().GetMethod("Entity", new Type[] { });
                //method = method.MakeGenericMethod(new Type[] { type });
                //method.Invoke(modelBuilder, null);
                modelBuilder.Entity(type);
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
            //ProductForumGroup
            modelBuilder.Entity<Product_ForumInfo>(entity =>
            {
                entity.HasKey(x => new { x.ProductId, x.ForumTitleId });

                entity.HasOne(x => x.Product)
                    .WithMany(x => x.ProductForumGroups)
                    .HasForeignKey(x => x.ProductId);

                entity.HasOne(x => x.ForumTitle)
                    .WithMany(x => x.ProductForumGroups)
                    .HasForeignKey(x => x.ForumTitleId);
            });
            //DownloadItem
            modelBuilder.Entity<DownloadItem>(entity =>
            {
                entity.HasOne(x => x.BannerImage)
                    .WithMany(x => x.DownloadItems)
                    .HasForeignKey(x => x.BannerImageId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(x => x.DownloadPath)
                    .WithMany(x => x.DownloadItems1)
                    .HasForeignKey(x => x.DownloadPathId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
            //LearningSiteConfig
            modelBuilder.Entity<LearningSiteConfig>(entity =>
            {
                entity.HasOne(x => x.Icon)
                    .WithMany(x => x.LearningSiteConfigs)
                    .HasForeignKey(x => x.IconId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //var entities = modelBuilder.Model.GetEntityTypes();
            //var cascadeFKs = entities.SelectMany(t => t.GetForeignKeys())
            //  .Where(fk => !fk.IsOwnership && fk.DeleteBehavior != DeleteBehavior.Cascade);

            //foreach (var fk in cascadeFKs)
            //    fk.DeleteBehavior = DeleteBehavior.Cascade;

            // for the other conventions, we do a metadata model loop
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                entityType.SetTableName(entityType.DisplayName());

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    //.Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Cascade);
            }

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Post_PostGroup> Post_PostGroup { get; set; }
        public virtual DbSet<Post_Tags> Post_Tags { get; set; }
        public virtual DbSet<ProductMedia> ProductMedia { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<Product_ForumInfo> ProductForumInfos { get; set; }
    }
}
