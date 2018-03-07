using Base2BaseWeb.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.DataLayer.Repository
{
    public class RepositoryContext:RepositoryContextBase
    {
        private IRepositoryBase<Base2BaseFeature> base2baseFeatures;
        private IRepositoryBase<Base2BaseFeatureCategory> base2baseFeatureCategories;
        private IRepositoryBase<Client> clients;
        private IRepositoryBase<ClientImage> clientImages;
        private IRepositoryBase<ClientSegment> clientSegments;
        private IRepositoryBase<ClientSegmentFeature> clientSegmentFeatures;
        private IRepositoryBase<ClientSegmentImage> clientSegmentImages;
        private IRepositoryBase<Company> company;
        private IRepositoryBase<CompanyImage> companyImage;
        private IRepositoryBase<ProdAttribute> prodAttributes;
        private IRepositoryBase<Product> products;
        private IRepositoryBase<ProductCategory> productCategories;
        private IRepositoryBase<ProductFeature> productFeatures;
        private IRepositoryBase<ProductImage> productImages;
        private IRepositoryBase<ProductSubCategory> productSubCategories;

        public RepositoryContext(DbContext context) : base(context) { }

        public IRepositoryBase<Base2BaseFeature> Base2BaseFeature {
            get
            {
                return base2baseFeatures != null ? base2baseFeatures : base2baseFeatures = Set<Base2BaseFeature>();
            }
        }
        public IRepositoryBase<Base2BaseFeatureCategory> Base2baseFeatureCategories
        {
            get
            {
                return base2baseFeatureCategories != null ? base2baseFeatureCategories 
                    : base2baseFeatureCategories = Set<Base2BaseFeatureCategory>();
            }
        }
        public IRepositoryBase<Client> Clients {
            get
            {
                return clients != null ? clients
                    : clients = Set<Client>();
            }
        }
        public IRepositoryBase<ClientImage> ClientImages
        {
            get
            {
                return clientImages != null ? clientImages
                    : clientImages = Set<ClientImage>();
            }
        }
        public IRepositoryBase<ClientSegment> ClientSegment
        {
            get
            {
                return clientSegments != null ? clientSegments
                    : clientSegments = Set<ClientSegment>();
            }
        }
        public IRepositoryBase<ClientSegmentFeature> ClientSegmentFeatures
        {
            get
            {
                return clientSegmentFeatures != null ? clientSegmentFeatures
                    : clientSegmentFeatures = Set<ClientSegmentFeature>();
            }
        }
        public IRepositoryBase<ClientSegmentImage> ClientSegmentImages
        {
            get
            {
                return clientSegmentImages != null ? clientSegmentImages
                    : clientSegmentImages = Set<ClientSegmentImage>();
            }
        }
        public IRepositoryBase<Company> Company
        {
            get
            {
                return company != null ? company
                    : company = Set<Company>();
            }
        }
        public IRepositoryBase<CompanyImage> CompanyImage
        {
            get
            {
                return companyImage != null ? companyImage
                    : companyImage = Set<CompanyImage>();
            }
        }
        public IRepositoryBase<ProdAttribute> ProdAttributes
        {
            get
            {
                return prodAttributes != null ? prodAttributes
                    : prodAttributes = Set<ProdAttribute>();
            }
        }
        public IRepositoryBase<Product> Products
        {
            get
            {
                return products != null ? products
                    : products = Set<Product>();
            }
        }
        public IRepositoryBase<ProductCategory> ProductCategories
        {
            get
            {
                return productCategories != null ? productCategories
                    : productCategories = Set<ProductCategory>();
            }
        }
        public IRepositoryBase<ProductFeature> ProductFeatures
        {
            get
            {
                return productFeatures != null ? productFeatures
                    : productFeatures = Set<ProductFeature>();
            }
        }
        public IRepositoryBase<ProductImage> ProductImages
        {
            get
            {
                return productImages != null ? productImages
                    : productImages = Set<ProductImage>();
            }
        }
        public IRepositoryBase<ProductSubCategory> ProductSubCategories
        {
            get
            {
                return productSubCategories != null ? productSubCategories
                    : productSubCategories = Set<ProductSubCategory>();
            }
        }

    }
}
