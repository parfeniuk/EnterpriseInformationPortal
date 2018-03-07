using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.DataLayer.Migrations
{
    public partial class Base2BaseWebInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Base2BaseFeatureCategories",
                columns: table => new
                {
                    Base2BaseFeatureCategoryId = table.Column<Guid>(nullable: false),
                    Base2BaseFeatureCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base2BaseFeatureCategories", x => x.Base2BaseFeatureCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    HttpUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientSigments",
                columns: table => new
                {
                    ClientSegmentId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSigments", x => x.ClientSegmentId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "ProdAttributes",
                columns: table => new
                {
                    ProdAttributeId = table.Column<Guid>(nullable: false),
                    Attribute = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdAttributes", x => x.ProdAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<Guid>(nullable: false),
                    ProductCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Base2BaseFeatures",
                columns: table => new
                {
                    Base2BaseFeatureId = table.Column<Guid>(nullable: false),
                    Base2BaseFeatureCategoryId = table.Column<Guid>(nullable: false),
                    FontIconName = table.Column<string>(nullable: true),
                    FontType = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base2BaseFeatures", x => x.Base2BaseFeatureId);
                    table.ForeignKey(
                        name: "FK_Base2BaseFeatures_Base2BaseFeatureCategories_Base2BaseFeatureCategoryId",
                        column: x => x.Base2BaseFeatureCategoryId,
                        principalTable: "Base2BaseFeatureCategories",
                        principalColumn: "Base2BaseFeatureCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientImages",
                columns: table => new
                {
                    ClientImageId = table.Column<Guid>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: false),
                    IsPoster = table.Column<bool>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientImages", x => x.ClientImageId);
                    table.ForeignKey(
                        name: "FK_ClientImages_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientSigmentFeatures",
                columns: table => new
                {
                    ClientSegmentFeatureId = table.Column<Guid>(nullable: false),
                    ClientSegmentId = table.Column<Guid>(nullable: false),
                    FontIconName = table.Column<string>(nullable: true),
                    FontType = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSigmentFeatures", x => x.ClientSegmentFeatureId);
                    table.ForeignKey(
                        name: "FK_ClientSigmentFeatures_ClientSigments_ClientSegmentId",
                        column: x => x.ClientSegmentId,
                        principalTable: "ClientSigments",
                        principalColumn: "ClientSegmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientSigmentImages",
                columns: table => new
                {
                    ClientSegmentImageId = table.Column<Guid>(nullable: false),
                    ClientSegmentId = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSigmentImages", x => x.ClientSegmentImageId);
                    table.ForeignKey(
                        name: "FK_ClientSigmentImages_ClientSigments_ClientSegmentId",
                        column: x => x.ClientSegmentId,
                        principalTable: "ClientSigments",
                        principalColumn: "ClientSegmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyImages",
                columns: table => new
                {
                    CompanyImageId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    IsPoster = table.Column<bool>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyImages", x => x.CompanyImageId);
                    table.ForeignKey(
                        name: "FK_CompanyImages_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    ProductSubCategoryId = table.Column<Guid>(nullable: false),
                    ProductCategoryId = table.Column<Guid>(nullable: false),
                    ProductSubCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.ProductSubCategoryId);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductSubCategoryId = table.Column<Guid>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductSubCategories_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "ProductSubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ProductFeatureId = table.Column<Guid>(nullable: false),
                    FontIconName = table.Column<string>(nullable: true),
                    FontType = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.ProductFeatureId);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<Guid>(nullable: false),
                    IsPoster = table.Column<bool>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProdAttributes",
                columns: table => new
                {
                    ProdAttributeId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProdAttributes", x => new { x.ProdAttributeId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductProdAttributes_ProdAttributes_ProdAttributeId",
                        column: x => x.ProdAttributeId,
                        principalTable: "ProdAttributes",
                        principalColumn: "ProdAttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProdAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Base2BaseFeatures_Base2BaseFeatureCategoryId",
                table: "Base2BaseFeatures",
                column: "Base2BaseFeatureCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientImages_ClientId",
                table: "ClientImages",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSigmentFeatures_ClientSegmentId",
                table: "ClientSigmentFeatures",
                column: "ClientSegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSigmentImages_ClientSegmentId",
                table: "ClientSigmentImages",
                column: "ClientSegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_CompanyId",
                table: "CompanyImages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProdAttributes_ProductId",
                table: "ProductProdAttributes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_ProductCategoryId",
                table: "ProductSubCategories",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base2BaseFeatures");

            migrationBuilder.DropTable(
                name: "ClientImages");

            migrationBuilder.DropTable(
                name: "ClientSigmentFeatures");

            migrationBuilder.DropTable(
                name: "ClientSigmentImages");

            migrationBuilder.DropTable(
                name: "CompanyImages");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductProdAttributes");

            migrationBuilder.DropTable(
                name: "Base2BaseFeatureCategories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ClientSigments");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ProdAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
