using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Entities
{
    public class Base2BaseWebContext:DbContext
    {
        public Base2BaseWebContext(DbContextOptions<Base2BaseWebContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define composite key for joining entity ProductProdAttribute
            modelBuilder.Entity<ProductProdAttribute>().HasKey(entity => new { entity.ProdAttributeId, entity.ProductId });
        }

        DbSet<Base2BaseFeature> Base2BaseFeatures { get; set; }
        DbSet<Base2BaseFeatureCategory> Base2BaseFeatureCategories { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<ClientImage> ClientImages { get; set; }
        DbSet<ClientSegment> ClientSigments { get; set; }
        DbSet<ClientSegmentFeature> ClientSigmentFeatures { get; set; }
        DbSet<ClientSegmentImage> ClientSigmentImages { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<CompanyImage> CompanyImages { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<ProductFeature> ProductFeatures { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<ProductProdAttribute> ProductProdAttributes { get; set; }
        DbSet<ProdAttribute> ProdAttributes { get; set; }
    }
}
