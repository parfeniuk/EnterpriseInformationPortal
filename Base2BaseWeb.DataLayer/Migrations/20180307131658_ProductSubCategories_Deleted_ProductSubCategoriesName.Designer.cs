﻿// <auto-generated />
using Base2BaseWeb.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Base2BaseWeb.DataLayer.Migrations
{
    [DbContext(typeof(Base2BaseWebContext))]
    [Migration("20180307131658_ProductSubCategories_Deleted_ProductSubCategoriesName")]
    partial class ProductSubCategories_Deleted_ProductSubCategoriesName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Base2BaseFeature", b =>
                {
                    b.Property<Guid>("Base2BaseFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Base2BaseFeatureCategoryId");

                    b.Property<string>("FontIconName");

                    b.Property<string>("FontType");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.HasKey("Base2BaseFeatureId");

                    b.HasIndex("Base2BaseFeatureCategoryId");

                    b.ToTable("Base2BaseFeatures");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Base2BaseFeatureCategory", b =>
                {
                    b.Property<Guid>("Base2BaseFeatureCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Base2BaseFeatureCategoryName");

                    b.HasKey("Base2BaseFeatureCategoryId");

                    b.ToTable("Base2BaseFeatureCategories");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Client", b =>
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("HttpUrl");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientImage", b =>
                {
                    b.Property<Guid>("ClientImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientId");

                    b.Property<bool>("IsPoster");

                    b.Property<string>("Path");

                    b.HasKey("ClientImageId");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientImages");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientSegment", b =>
                {
                    b.Property<Guid>("ClientSegmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("ClientSegmentId");

                    b.ToTable("ClientSigments");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientSegmentFeature", b =>
                {
                    b.Property<Guid>("ClientSegmentFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientSegmentId");

                    b.Property<string>("FontIconName");

                    b.Property<string>("FontType");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.HasKey("ClientSegmentFeatureId");

                    b.HasIndex("ClientSegmentId");

                    b.ToTable("ClientSigmentFeatures");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientSegmentImage", b =>
                {
                    b.Property<Guid>("ClientSegmentImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientSegmentId");

                    b.Property<string>("Path");

                    b.HasKey("ClientSegmentImageId");

                    b.HasIndex("ClientSegmentId");

                    b.ToTable("ClientSigmentImages");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.CompanyImage", b =>
                {
                    b.Property<Guid>("CompanyImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CompanyId");

                    b.Property<bool>("IsPoster");

                    b.Property<string>("Path");

                    b.HasKey("CompanyImageId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyImages");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProdAttribute", b =>
                {
                    b.Property<Guid>("ProdAttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attribute");

                    b.Property<string>("Value");

                    b.HasKey("ProdAttributeId");

                    b.ToTable("ProdAttributes");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductSubCategoryId");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductSubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("ProductCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductCategoryName");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductFeature", b =>
                {
                    b.Property<Guid>("ProductFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FontIconName");

                    b.Property<string>("FontType");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductId");

                    b.HasKey("ProductFeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductImage", b =>
                {
                    b.Property<Guid>("ProductImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPoster");

                    b.Property<string>("Path");

                    b.Property<Guid>("ProductId");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductProdAttribute", b =>
                {
                    b.Property<Guid>("ProdAttributeId");

                    b.Property<Guid>("ProductId");

                    b.HasKey("ProdAttributeId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductProdAttributes");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategory", b =>
                {
                    b.Property<Guid>("ProductSubCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductCategoryId");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title");

                    b.HasKey("ProductSubCategoryId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("ProductSubCategories");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategoryFeature", b =>
                {
                    b.Property<Guid>("ProductSubCategoryFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FontIconName");

                    b.Property<string>("FontType");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductSubCategoryId");

                    b.HasKey("ProductSubCategoryFeatureId");

                    b.HasIndex("ProductSubCategoryId");

                    b.ToTable("ProductSubCategoryFeature");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategoryImage", b =>
                {
                    b.Property<Guid>("ProductSubCategoryImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPoster");

                    b.Property<string>("Path");

                    b.Property<Guid>("ProductSubCategoryId");

                    b.HasKey("ProductSubCategoryImageId");

                    b.HasIndex("ProductSubCategoryId");

                    b.ToTable("ProductSubCategoryImage");
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Base2BaseFeature", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Base2BaseFeatureCategory", "Base2BaseFeatureCategory")
                        .WithMany("Base2BaseFeatures")
                        .HasForeignKey("Base2BaseFeatureCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientImage", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Client", "Client")
                        .WithMany("ClientImages")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientSegmentFeature", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ClientSegment", "ClientSegment")
                        .WithMany("ClientSegmentFeatures")
                        .HasForeignKey("ClientSegmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ClientSegmentImage", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ClientSegment", "ClientSegment")
                        .WithMany("ClientSegmentImages")
                        .HasForeignKey("ClientSegmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.CompanyImage", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Company", "Company")
                        .WithMany("CompanyImages")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.Product", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ProductSubCategory", "ProductSubCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductFeature", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Product")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductImage", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductProdAttribute", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ProdAttribute", "ProdAttribute")
                        .WithMany("ProductProdAttributes")
                        .HasForeignKey("ProdAttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Base2BaseWeb.DataLayer.Entities.Product", "Product")
                        .WithMany("ProductProdAttributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategory", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ProductCategory")
                        .WithMany("ProductSubCategories")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategoryFeature", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ProductSubCategory")
                        .WithMany("ProductSubCategoryFeatures")
                        .HasForeignKey("ProductSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Base2BaseWeb.DataLayer.Entities.ProductSubCategoryImage", b =>
                {
                    b.HasOne("Base2BaseWeb.DataLayer.Entities.ProductSubCategory", "ProductSubCategory")
                        .WithMany("ProductSubCategoryImages")
                        .HasForeignKey("ProductSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}