using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class b2b_testContext : DbContext
    {
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountPlan> AccountPlan { get; set; }
        public virtual DbSet<AccTransChema> AccTransChema { get; set; }
        public virtual DbSet<AccTransJrn> AccTransJrn { get; set; }
        public virtual DbSet<Articl> Articl { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CashTable> CashTable { get; set; }
        public virtual DbSet<CliGroup> CliGroup { get; set; }
        public virtual DbSet<DelivePoint> DelivePoint { get; set; }
        public virtual DbSet<DiscountRules> DiscountRules { get; set; }
        public virtual DbSet<DocStan> DocStan { get; set; }
        public virtual DbSet<ExtPoint> ExtPoint { get; set; }
        public virtual DbSet<ExtShablon> ExtShablon { get; set; }
        public virtual DbSet<ExtTovar> ExtTovar { get; set; }
        public virtual DbSet<InOutJrn> InOutJrn { get; set; }
        public virtual DbSet<Izmer> Izmer { get; set; }
        public virtual DbSet<Jrn> Jrn { get; set; }
        public virtual DbSet<JrnOpl> JrnOpl { get; set; }
        public virtual DbSet<JrnRezerv> JrnRezerv { get; set; }
        public virtual DbSet<Kassa> Kassa { get; set; }
        public virtual DbSet<KassaTovar> KassaTovar { get; set; }
        public virtual DbSet<Kat> Kat { get; set; }
        public virtual DbSet<KatAgent> KatAgent { get; set; }
        public virtual DbSet<KeyList> KeyList { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<LocationList> LocationList { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<MarketingActionRecords> MarketingActionRecords { get; set; }
        public virtual DbSet<MyConnString> MyConnString { get; set; }
        public virtual DbSet<Nakl> Nakl { get; set; }
        public virtual DbSet<NaklImportJrn> NaklImportJrn { get; set; }
        public virtual DbSet<NaklProp> NaklProp { get; set; }
        public virtual DbSet<NaklPropTemplate> NaklPropTemplate { get; set; }
        public virtual DbSet<OrderExt> OrderExt { get; set; }
        public virtual DbSet<OrdersRedirection> OrdersRedirection { get; set; }
        public virtual DbSet<Point> Point { get; set; }
        public virtual DbSet<PointAgent> PointAgent { get; set; }
        public virtual DbSet<PriceImportJrn> PriceImportJrn { get; set; }
        public virtual DbSet<PriceShields> PriceShields { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeList> RecipeList { get; set; }
        public virtual DbSet<Reestr> Reestr { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<RouteAgent> RouteAgent { get; set; }
        public virtual DbSet<RouteList> RouteList { get; set; }
        public virtual DbSet<RouteNaklList> RouteNaklList { get; set; }
        public virtual DbSet<RoutePoint> RoutePoint { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<SysJrn> SysJrn { get; set; }
        public virtual DbSet<SysJrnExt> SysJrnExt { get; set; }
        public virtual DbSet<TcuPar> TcuPar { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
        public virtual DbSet<TovarCode> TovarCode { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRights> UserRights { get; set; }

        // Unable to generate entity type for table 'dbo.__EFMigrationsHistoryArchive'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nakl_prop_template_list'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MarketingToolRecordDescriptions'. Please see the warning messages.

        public b2b_testContext(DbContextOptions<b2b_testContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("account");

                entity.Property(e => e.AccountNumber).HasColumnName("account_number");

                entity.Property(e => e.AccType).HasColumnName("acc_type");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Rest).HasColumnName("rest");

                entity.Property(e => e.TopAccountNumber).HasColumnName("top_account_number");
            });

            modelBuilder.Entity<AccountPlan>(entity =>
            {
                entity.HasKey(e => e.AccountPlanNumber);

                entity.ToTable("account_plan");

                entity.Property(e => e.AccountPlanNumber).HasColumnName("account_plan_number");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountSphere)
                    .HasColumnName("account_sphere")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountType).HasColumnName("account_type");
            });

            modelBuilder.Entity<AccTransChema>(entity =>
            {
                entity.HasKey(e => e.AccTransChemaNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("acc_trans_chema");

                entity.HasIndex(e => e.ArticlNumber)
                    .HasName("articl_trans_rel");

                entity.Property(e => e.AccTransChemaNumber).HasColumnName("acc_trans_chema_number");

                entity.Property(e => e.Account1Number).HasColumnName("account1_number");

                entity.Property(e => e.Account2Number).HasColumnName("account2_number");

                entity.Property(e => e.ArticlNumber).HasColumnName("articl_number");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.HasOne(d => d.ArticlNumberNavigation)
                    .WithMany(p => p.AccTransChema)
                    .HasForeignKey(d => d.ArticlNumber)
                    .HasConstraintName("acc_trans_chema_FK00");
            });

            modelBuilder.Entity<AccTransJrn>(entity =>
            {
                entity.HasKey(e => e.AccTransJrnNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("acc_trans_jrn");

                entity.Property(e => e.AccTransJrnNumber).HasColumnName("acc_trans_jrn_number");

                entity.Property(e => e.AccTransChemaNumber).HasColumnName("acc_trans_chema_number");

                entity.Property(e => e.Account1Number).HasColumnName("account1_number");

                entity.Property(e => e.Account2Number).HasColumnName("account2_number");

                entity.Property(e => e.ArticlNumber).HasColumnName("articl_number");

                entity.Property(e => e.BundleNaklNumber).HasColumnName("bundle_nakl_number");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.DateUtv)
                    .HasColumnName("date_utv")
                    .HasColumnType("datetime");

                entity.Property(e => e.Summa).HasColumnName("summa");

                entity.Property(e => e.UserNumber).HasColumnName("user_number");

                entity.Property(e => e.Utv).HasColumnName("utv");
            });

            modelBuilder.Entity<Articl>(entity =>
            {
                entity.HasKey(e => e.ArticlNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("articl");

                entity.Property(e => e.ArticlNumber).HasColumnName("articl_number");

                entity.Property(e => e.ActPass).HasColumnName("act_pass");

                entity.Property(e => e.ArticlName)
                    .IsRequired()
                    .HasColumnName("articl_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Closed).HasColumnName("closed");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId });

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.CarNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("car");

                entity.Property(e => e.CarNumber).HasColumnName("car_number");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255);

                entity.Property(e => e.Netto).HasColumnName("netto");

                entity.Property(e => e.RegNumber)
                    .HasColumnName("reg_number")
                    .HasMaxLength(255);

                entity.Property(e => e.Tara).HasColumnName("tara");
            });

            modelBuilder.Entity<CashTable>(entity =>
            {
                entity.HasKey(e => e.CashNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("cash_table");

                entity.HasIndex(e => e.CashText)
                    .HasName("cash_text");

                entity.HasIndex(e => e.FieldName)
                    .HasName("field_name");

                entity.HasIndex(e => e.FormName)
                    .HasName("form_name");

                entity.HasIndex(e => e.LngNumber)
                    .HasName("lng_number");

                entity.Property(e => e.CashNumber).HasColumnName("cash_number");

                entity.Property(e => e.CashText)
                    .HasColumnName("cash_text")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FormName)
                    .HasColumnName("form_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LngNumber)
                    .HasColumnName("lng_number")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CliGroup>(entity =>
            {
                entity.HasKey(e => e.CliGroupNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("cli_group");

                entity.Property(e => e.CliGroupNumber).HasColumnName("cli_group_number");

                entity.Property(e => e.CliGroupName)
                    .HasColumnName("cli_group_name")
                    .HasMaxLength(250);

                entity.Property(e => e.Post).HasColumnName("post");
            });

            modelBuilder.Entity<DelivePoint>(entity =>
            {
                entity.HasKey(e => e.DelivePointNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("delive_point");

                entity.HasIndex(e => e.PointNumber)
                    .HasName("delive_point_rel");

                entity.Property(e => e.DelivePointNumber).HasColumnName("delive_point_number");

                entity.Property(e => e.DeliveAddress)
                    .HasColumnName("delive_address")
                    .HasMaxLength(255);

                entity.Property(e => e.DelivePointName)
                    .HasColumnName("delive_point_name")
                    .HasMaxLength(255);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(255);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.DelivePoint)
                    .HasForeignKey(d => d.PointNumber)
                    .HasConstraintName("delive_point_FK00");
            });

            modelBuilder.Entity<DiscountRules>(entity =>
            {
                entity.HasKey(e => e.DiscountRulesNumber);

                entity.ToTable("discount_rules");

                entity.Property(e => e.DiscountRulesNumber).HasColumnName("discount_rules_number");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.FactSaleSum).HasColumnName("fact_sale_sum");

                entity.Property(e => e.FactSaleSumDol).HasColumnName("fact_sale_sum_dol");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.SalesPeriod).HasColumnName("sales_period");

                entity.Property(e => e.SalesSum).HasColumnName("sales_sum");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.DiscountRules)
                    .HasForeignKey(d => d.PointNumber)
                    .HasConstraintName("FK__discount___point__6319B466");
            });

            modelBuilder.Entity<DocStan>(entity =>
            {
                entity.Property(e => e.NameStan).HasColumnType("nchar(50)");
            });

            modelBuilder.Entity<ExtPoint>(entity =>
            {
                entity.HasKey(e => e.ExtPointNumber);

                entity.ToTable("ext_point");

                entity.Property(e => e.ExtPointNumber).HasColumnName("ext_point_number");

                entity.Property(e => e.ExtPointName)
                    .IsRequired()
                    .HasColumnName("ext_point_name");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.ExtPoint)
                    .HasForeignKey(d => d.PointNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ext_point__point__59904A2C");
            });

            modelBuilder.Entity<ExtShablon>(entity =>
            {
                entity.HasKey(e => e.ExtShablonNumber);

                entity.ToTable("ext_shablon");

                entity.Property(e => e.ExtShablonNumber).HasColumnName("ext_shablon_number");

                entity.Property(e => e.CenaPrice1DolPosition).HasColumnName("cena_price1_dol_position");

                entity.Property(e => e.CenaPrice1Position).HasColumnName("cena_price1_position");

                entity.Property(e => e.CenaPrice2DolPosition).HasColumnName("cena_price2_dol_position");

                entity.Property(e => e.CenaPrice2Position).HasColumnName("cena_price2_position");

                entity.Property(e => e.CenaPrice3DolPosition).HasColumnName("cena_price3_dol_position");

                entity.Property(e => e.CenaPrice3Position).HasColumnName("cena_price3_position");

                entity.Property(e => e.CenaPrice4DolPosition).HasColumnName("cena_price4_dol_position");

                entity.Property(e => e.CenaPrice4Position).HasColumnName("cena_price4_position");

                entity.Property(e => e.CenaPrice5DolPosition).HasColumnName("cena_price5_dol_position");

                entity.Property(e => e.CenaPrice5Position).HasColumnName("cena_price5_position");

                entity.Property(e => e.IsSplit).HasColumnName("is_split");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.ShablonName)
                    .HasColumnName("shablon_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SplitStep).HasColumnName("split_step");

                entity.Property(e => e.TovarDescripPosition)
                    .HasColumnName("tovar_descrip_position")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TovarNamePosition).HasColumnName("tovar_name_position");

                entity.Property(e => e.TovarPresentPosition).HasColumnName("tovar_present_position");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.ExtShablon)
                    .HasForeignKey(d => d.PointNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ext_shabl__point__54CB950F");
            });

            modelBuilder.Entity<ExtTovar>(entity =>
            {
                entity.HasKey(e => e.ExtTovarNumber);

                entity.ToTable("ext_tovar");

                entity.Property(e => e.ExtTovarNumber).HasColumnName("ext_tovar_number");

                entity.Property(e => e.ExtKatNumber).HasColumnName("ext_kat_number");

                entity.Property(e => e.ExtTovarName)
                    .IsRequired()
                    .HasColumnName("ext_tovar_name");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.PriceOrNakl).HasColumnName("price_or_nakl");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.ExtTovar)
                    .HasForeignKey(d => d.PointNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ext_tovar__point__51EF2864");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.ExtTovar)
                    .HasForeignKey(d => d.TovarNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ext_tovar__tovar__52E34C9D");
            });

            modelBuilder.Entity<InOutJrn>(entity =>
            {
                entity.HasKey(e => e.InOutJrnNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("in_out_jrn");

                entity.Property(e => e.InOutJrnNumber).HasColumnName("in_out_jrn_number");

                entity.Property(e => e.ArticlNumber).HasColumnName("articl_number");

                entity.Property(e => e.DateUtv)
                    .HasColumnName("date_utv")
                    .HasColumnType("datetime");

                entity.Property(e => e.IoDate)
                    .HasColumnName("io_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.KeyField)
                    .HasColumnName("key_field")
                    .HasMaxLength(255);

                entity.Property(e => e.KeyNumber).HasColumnName("key_number");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Izmer>(entity =>
            {
                entity.HasKey(e => e.IzmerNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("izmer");

                entity.Property(e => e.IzmerNumber).HasColumnName("izmer_number");

                entity.Property(e => e.DefaultIzmer).HasColumnName("default_izmer");

                entity.Property(e => e.IzmerName)
                    .HasColumnName("izmer_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Jrn>(entity =>
            {
                entity.HasKey(e => e.JrnNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("jrn");

                entity.HasIndex(e => e.DateMove)
                    .HasName("date_move");

                entity.HasIndex(e => e.ListNumber)
                    .HasName("jrnlist_number");

                entity.HasIndex(e => e.ListPrihNumber)
                    .HasName("list_prih_number");

                entity.HasIndex(e => e.NaklNumber)
                    .HasName("nakl_number");

                entity.HasIndex(e => e.NaklType)
                    .HasName("nakl_type");

                entity.HasIndex(e => e.RashPrih)
                    .HasName("rash_prih");

                entity.HasIndex(e => e.Reestr2Number)
                    .HasName("reestr2_number");

                entity.HasIndex(e => e.ReestrNumber)
                    .HasName("reestrjrn");

                entity.Property(e => e.JrnNumber).HasColumnName("jrn_number");

                entity.Property(e => e.CenaDol)
                    .HasColumnName("cena_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOpt)
                    .HasColumnName("cena_opt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOptDol)
                    .HasColumnName("cena_opt_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn)
                    .HasColumnName("cena_rozn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateMove)
                    .HasColumnName("date_move")
                    .HasColumnType("datetime");

                entity.Property(e => e.FiscalDocument).HasColumnName("fiscal_document");

                entity.Property(e => e.Kol)
                    .HasColumnName("kol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kurs)
                    .HasColumnName("kurs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListNumber)
                    .HasColumnName("list_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListPrihNumber)
                    .HasColumnName("list_prih_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklNumber)
                    .HasColumnName("nakl_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklPrihNumber)
                    .HasColumnName("nakl_prih_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklType)
                    .HasColumnName("nakl_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RashPrih).HasColumnName("rash_prih");

                entity.Property(e => e.Reestr2Number)
                    .HasColumnName("reestr2_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReestrNumber)
                    .HasColumnName("reestr_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ListNumberNavigation)
                    .WithMany(p => p.Jrn)
                    .HasForeignKey(d => d.ListNumber)
                    .HasConstraintName("FK_jrn_list");

                entity.HasOne(d => d.ReestrNumberNavigation)
                    .WithMany(p => p.Jrn)
                    .HasForeignKey(d => d.ReestrNumber)
                    .HasConstraintName("FK_jrn_reestr");
            });

            modelBuilder.Entity<JrnOpl>(entity =>
            {
                entity.HasKey(e => e.JrnOplNumber);

                entity.ToTable("jrn_opl");

                entity.HasIndex(e => new { e.Nakl2Number, e.DateOpl });

                entity.Property(e => e.JrnOplNumber).HasColumnName("jrn_opl_number");

                entity.Property(e => e.DateOpl)
                    .HasColumnName("date_opl")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nakl1Number).HasColumnName("nakl1_number");

                entity.Property(e => e.Nakl2Number).HasColumnName("nakl2_number");

                entity.Property(e => e.NaklType).HasColumnName("nakl_type");

                entity.Property(e => e.SumOpl).HasColumnName("sum_opl");

                entity.Property(e => e.SumOplDol).HasColumnName("sum_opl_dol");

                entity.HasOne(d => d.Nakl1NumberNavigation)
                    .WithMany(p => p.JrnOplNakl1NumberNavigation)
                    .HasForeignKey(d => d.Nakl1Number)
                    .HasConstraintName("FK__jrn_opl__nakl1_n__43A1090D");

                entity.HasOne(d => d.Nakl2NumberNavigation)
                    .WithMany(p => p.JrnOplNakl2NumberNavigation)
                    .HasForeignKey(d => d.Nakl2Number)
                    .HasConstraintName("FK__jrn_opl__nakl2_n__44952D46");
            });

            modelBuilder.Entity<JrnRezerv>(entity =>
            {
                entity.HasKey(e => e.JrnRezervNumber);

                entity.ToTable("jrn_rezerv");

                entity.Property(e => e.JrnRezervNumber).HasColumnName("jrn_rezerv_number");

                entity.Property(e => e.KolRezerv).HasColumnName("kol_rezerv");

                entity.Property(e => e.ListNumber).HasColumnName("list_number");

                entity.Property(e => e.ListRezervNumber).HasColumnName("list_rezerv_number");

                entity.HasOne(d => d.ListNumberNavigation)
                    .WithMany(p => p.JrnRezervListNumberNavigation)
                    .HasForeignKey(d => d.ListNumber)
                    .HasConstraintName("FK__jrn_rezer__list___5A846E65");

                entity.HasOne(d => d.ListRezervNumberNavigation)
                    .WithMany(p => p.JrnRezervListRezervNumberNavigation)
                    .HasForeignKey(d => d.ListRezervNumber)
                    .HasConstraintName("FK__jrn_rezer__list___5B78929E");
            });

            modelBuilder.Entity<Kassa>(entity =>
            {
                entity.ToTable("kassa");

                entity.Property(e => e.KassaId).HasColumnName("kassa_id");

                entity.Property(e => e.KassaName)
                    .HasColumnName("kassa_name")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.TeamViewer)
                    .HasColumnName("team_viewer")
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<KassaTovar>(entity =>
            {
                entity.HasKey(e => new { e.KassaId, e.TovarId });

                entity.ToTable("kassa_tovar");

                entity.Property(e => e.KassaId).HasColumnName("kassa_id");

                entity.Property(e => e.TovarId).HasColumnName("tovar_id");

                entity.HasOne(d => d.Kassa)
                    .WithMany(p => p.KassaTovar)
                    .HasForeignKey(d => d.KassaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kassa_tovar_kassa");

                entity.HasOne(d => d.Tovar)
                    .WithMany(p => p.KassaTovar)
                    .HasForeignKey(d => d.TovarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kassa_tovar_tovar");
            });

            modelBuilder.Entity<Kat>(entity =>
            {
                entity.HasKey(e => e.KatNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("kat");

                entity.HasIndex(e => new { e.KatName, e.TopKat })
                    .HasName("kat_name")
                    .IsUnique();

                entity.Property(e => e.KatNumber).HasColumnName("kat_number");

                entity.Property(e => e.ExtKatName)
                    .HasColumnName("ext_kat_name")
                    .HasMaxLength(4000);

                entity.Property(e => e.KatImage)
                    .HasColumnName("kat_image")
                    .HasColumnType("image");

                entity.Property(e => e.KatName)
                    .HasColumnName("kat_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MacroGroupId).HasMaxLength(50);

                entity.Property(e => e.TopKat)
                    .HasColumnName("top_kat")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KatAgent>(entity =>
            {
                entity.HasKey(e => e.KatAgentNumber);

                entity.ToTable("kat_agent");

                entity.Property(e => e.KatAgentNumber).HasColumnName("kat_agent_number");

                entity.Property(e => e.KatNumber).HasColumnName("kat_number");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.HasOne(d => d.KatNumberNavigation)
                    .WithMany(p => p.KatAgent)
                    .HasForeignKey(d => d.KatNumber)
                    .HasConstraintName("FK__kat_agent__kat_n__5E54FF49");
            });

            modelBuilder.Entity<KeyList>(entity =>
            {
                entity.HasKey(e => e.KeyListNumber);

                entity.ToTable("key_list");

                entity.Property(e => e.KeyListNumber).HasColumnName("key_list_number");

                entity.Property(e => e.AnswerKey)
                    .HasColumnName("answer_key")
                    .HasMaxLength(255);

                entity.Property(e => e.InitKey)
                    .HasColumnName("init_key")
                    .HasMaxLength(255);

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => e.ListNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("list");

                entity.HasIndex(e => e.ListPrihNumber)
                    .HasName("list_prih_number");

                entity.HasIndex(e => e.NaklNumber)
                    .HasName("nakllist");

                entity.HasIndex(e => e.ReestrNumber)
                    .HasName("listreestr_number");

                entity.HasIndex(e => e.RezList1)
                    .HasName("rez_list1");

                entity.HasIndex(e => e.RezList2)
                    .HasName("rez_list2");

                entity.HasIndex(e => e.RezList3)
                    .HasName("rez_list3");

                entity.HasIndex(e => e.RezList4)
                    .HasName("rez_list4");

                entity.HasIndex(e => e.RezList5)
                    .HasName("rez_list5");

                entity.HasIndex(e => e.RezList6)
                    .HasName("rez_list6");

                entity.HasIndex(e => e.RezList7)
                    .HasName("rez_list7");

                entity.HasIndex(e => e.RezList8)
                    .HasName("rez_list8");

                entity.HasIndex(e => e.TovarNumber)
                    .HasName("tovarlist");

                entity.HasIndex(e => e.ZakazlistNumber)
                    .HasName("zakazlist_number");

                entity.HasIndex(e => new { e.KolCurrent, e.ReestrNumber, e.Reestr2Number })
                    .HasName("IX_list_kol_reestr");

                entity.Property(e => e.ListNumber).HasColumnName("list_number");

                entity.Property(e => e.CenaDol)
                    .HasColumnName("cena_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaDolAfter)
                    .HasColumnName("cena_dol_after")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOpt)
                    .HasColumnName("cena_opt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOptAfter)
                    .HasColumnName("cena_opt_after")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOptDol)
                    .HasColumnName("cena_opt_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaOptDolAfter)
                    .HasColumnName("cena_opt_dol_after")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn)
                    .HasColumnName("cena_rozn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRoznAfter)
                    .HasColumnName("cena_rozn_after")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaZak).HasColumnName("cena_zak");

                entity.Property(e => e.CenaZakDol).HasColumnName("cena_zak_dol");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.CustDeclNumber)
                    .HasColumnName("cust_decl_number")
                    .HasMaxLength(100);

                entity.Property(e => e.Kol)
                    .HasColumnName("kol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolAdd)
                    .HasColumnName("kol_add")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolAfter)
                    .HasColumnName("kol_after")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolCurrent)
                    .HasColumnName("kol_current")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolInPak)
                    .HasColumnName("kol_in_pak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolPak)
                    .HasColumnName("kol_pak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListPrihNumber)
                    .HasColumnName("list_prih_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListZakazNumber).HasColumnName("list_zakaz_number");

                entity.Property(e => e.NaklNumber)
                    .HasColumnName("nakl_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewRest).HasColumnName("new_rest");

                entity.Property(e => e.PercSkid)
                    .HasColumnName("perc_skid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Product).HasColumnName("product");

                entity.Property(e => e.RecipeNumber).HasColumnName("recipe_number");

                entity.Property(e => e.Reestr2Number)
                    .HasColumnName("reestr2_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReestrNumber)
                    .HasColumnName("reestr_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RezList1)
                    .HasColumnName("rez_list1")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList2)
                    .HasColumnName("rez_list2")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList3)
                    .HasColumnName("rez_list3")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList4)
                    .HasColumnName("rez_list4")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList5)
                    .HasColumnName("rez_list5")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList6)
                    .HasColumnName("rez_list6")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList7)
                    .HasColumnName("rez_list7")
                    .HasMaxLength(128);

                entity.Property(e => e.RezList8)
                    .HasColumnName("rez_list8")
                    .HasMaxLength(128);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255);

                entity.Property(e => e.SumSkid)
                    .HasColumnName("sum_skid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumSkidDol)
                    .HasColumnName("sum_skid_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.TovarCodeNumber).HasColumnName("tovar_code_number");

                entity.Property(e => e.TovarNumber)
                    .HasColumnName("tovar_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.ZakazlistNumber)
                    .HasColumnName("zakazlist_number")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.NaklNumberNavigation)
                    .WithMany(p => p.List)
                    .HasForeignKey(d => d.NaklNumber)
                    .HasConstraintName("FK_list_nakl");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.List)
                    .HasForeignKey(d => d.TovarNumber)
                    .HasConstraintName("FK_list_tovar");
            });

            modelBuilder.Entity<LocationList>(entity =>
            {
                entity.HasKey(e => e.LocationListNumber);

                entity.ToTable("location_list");

                entity.Property(e => e.LocationListNumber).HasColumnName("location_list_number");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.AgentNumber).HasColumnName("agent_number");

                entity.Property(e => e.CorrectionService)
                    .HasColumnName("correction_service")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceTime)
                    .HasColumnName("device_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.NearAddress)
                    .HasColumnName("near_address")
                    .HasMaxLength(255);

                entity.Property(e => e.NearAddressLatitude).HasColumnName("near_address_latitude");

                entity.Property(e => e.NearAddressLongitude).HasColumnName("near_address_longitude");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50);

                entity.Property(e => e.ServerTime)
                    .HasColumnName("server_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => e.ManagerNumber);

                entity.ToTable("manager");

                entity.Property(e => e.ManagerNumber).HasColumnName("manager_number");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasColumnName("manager_name")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.ManagerTelephone)
                    .HasColumnName("manager_telephone")
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_manager_point");
            });

            modelBuilder.Entity<MarketingActionRecords>(entity =>
            {
                entity.HasKey(e => e.MarketingActionRecordId);

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.HasOne(d => d.NaklNumberNavigation)
                    .WithMany(p => p.MarketingActionRecords)
                    .HasForeignKey(d => d.NaklNumber)
                    .HasConstraintName("FK__Marketing__nakl___725BF7F6");
            });

            modelBuilder.Entity<MyConnString>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catalog)
                    .IsRequired()
                    .HasColumnName("catalog")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasColumnType("nchar(50)");
            });

            modelBuilder.Entity<Nakl>(entity =>
            {
                entity.HasKey(e => e.NaklNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("nakl");

                entity.HasIndex(e => e.ArticlNumber)
                    .HasName("articl_number");

                entity.HasIndex(e => e.BundleNaklNumber)
                    .HasName("bundle_nakl_number");

                entity.HasIndex(e => e.DateUtv)
                    .HasName("date_utv");

                entity.HasIndex(e => e.DocNumber)
                    .HasName("doc_number");

                entity.HasIndex(e => e.DocumentGuid)
                    .HasName("IX_DocumentGuid");

                entity.HasIndex(e => e.NaklType)
                    .HasName("nakl_type");

                entity.HasIndex(e => e.Point1Number)
                    .HasName("pointnakl");

                entity.HasIndex(e => e.Point2Number)
                    .HasName("pointnakl1");

                entity.HasIndex(e => new { e.NaklNumber, e.NaklType, e.Utv })
                    .HasName("IX_nakl_nakl_type_utv_nakl_number");

                entity.HasIndex(e => new { e.NaklNumber, e.DateUtv, e.Point1Number, e.CheckPoint })
                    .HasName("check_point_index");

                entity.HasIndex(e => new { e.RashPrih, e.SumVzr, e.Point2Number, e.DateUtv, e.Utv })
                    .HasName("IX_nakl_sum_vzr");

                entity.HasIndex(e => new { e.RashPrih, e.SumVzrDol, e.Point2Number, e.DateUtv, e.Utv })
                    .HasName("IX_nakl_sum_vzr_dol");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.AgentNumber).HasColumnName("agent_number");

                entity.Property(e => e.ArticlNumber)
                    .HasColumnName("articl_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoPayment).HasColumnName("auto_payment");

                entity.Property(e => e.BundleNaklNumber)
                    .HasColumnName("bundle_nakl_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRoznSelect).HasColumnName("cena_rozn_select");

                entity.Property(e => e.CheckPoint).HasColumnName("check_point");

                entity.Property(e => e.ClientDiscount).HasColumnName("client_discount");

                entity.Property(e => e.DateFranchUpload)
                    .HasColumnName("date_franch_upload")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateNakl)
                    .HasColumnName("date_nakl")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUtv)
                    .HasColumnName("date_utv")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelivePointNumber).HasColumnName("delive_point_number");

                entity.Property(e => e.DeliveryCondition)
                    .HasColumnName("delivery_condition")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DocNumber)
                    .HasColumnName("doc_number")
                    .HasMaxLength(50);

                entity.Property(e => e.DocStanId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DovNumber)
                    .HasColumnName("dov_number")
                    .HasMaxLength(32);

                entity.Property(e => e.FiscalDocument).HasColumnName("fiscal_document");

                entity.Property(e => e.FiscalNumber)
                    .HasColumnName("fiscal_number")
                    .HasMaxLength(255);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kurs)
                    .HasColumnName("kurs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialReq).HasMaxLength(50);

                entity.Property(e => e.ModeOfShipment).HasMaxLength(50);

                entity.Property(e => e.NaklPropTemplateNumber).HasColumnName("nakl_prop_template_number");

                entity.Property(e => e.NaklRash)
                    .HasColumnName("nakl_rash")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklRashDol)
                    .HasColumnName("nakl_rash_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklRashMe)
                    .HasColumnName("nakl_rash_me")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklRashMeDol)
                    .HasColumnName("nakl_rash_me_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklType)
                    .HasColumnName("nakl_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderRezerved).HasColumnName("order_rezerved");

                entity.Property(e => e.Osn)
                    .HasColumnName("osn")
                    .HasMaxLength(255);

                entity.Property(e => e.PercSkid)
                    .HasColumnName("perc_skid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Point1Number)
                    .HasColumnName("point1_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Point2Number)
                    .HasColumnName("point2_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostNumber)
                    .HasColumnName("post_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Prim)
                    .HasColumnName("prim")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintDate)
                    .HasColumnName("print_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RDol).HasColumnName("r_dol");

                entity.Property(e => e.RashPrih).HasColumnName("rash_prih");

                entity.Property(e => e.RecipeNumber).HasColumnName("recipe_number");

                entity.Property(e => e.Return).HasColumnName("return");

                entity.Property(e => e.Rfq)
                    .HasColumnName("RFQ")
                    .HasMaxLength(50);

                entity.Property(e => e.RouteListNumber).HasColumnName("route_list_number");

                entity.Property(e => e.RouteNumber).HasColumnName("route_number");

                entity.Property(e => e.SoAndProject).HasMaxLength(50);

                entity.Property(e => e.SourceNumber).HasColumnName("source_number");

                entity.Property(e => e.SumDol)
                    .HasColumnName("sum_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumOpl).HasColumnName("sum_opl");

                entity.Property(e => e.SumOplDol).HasColumnName("sum_opl_dol");

                entity.Property(e => e.SumOpt)
                    .HasColumnName("sum_opt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumOptDol)
                    .HasColumnName("sum_opt_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumRozn)
                    .HasColumnName("sum_rozn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumTara)
                    .HasColumnName("sum_tara")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumTaraDol)
                    .HasColumnName("sum_tara_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumVolume).HasColumnName("sum_volume");

                entity.Property(e => e.SumVzr)
                    .HasColumnName("sum_vzr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumVzrDol)
                    .HasColumnName("sum_vzr_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SumWeight).HasColumnName("sum_weight");

                entity.Property(e => e.SupplierRef).HasMaxLength(50);

                entity.Property(e => e.SysKurs)
                    .HasColumnName("sys_kurs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserNumber).HasColumnName("user_number");

                entity.Property(e => e.Utv).HasColumnName("utv");

                entity.Property(e => e.VidPlat)
                    .HasColumnName("vid_plat")
                    .HasMaxLength(80);

                entity.Property(e => e.ViewAddProp).HasColumnName("view_add_prop");

                entity.HasOne(d => d.DocStan)
                    .WithMany(p => p.Nakl)
                    .HasForeignKey(d => d.DocStanId)
                    .HasConstraintName("FK_nakl_DocStan");

                entity.HasOne(d => d.Point1NumberNavigation)
                    .WithMany(p => p.NaklPoint1NumberNavigation)
                    .HasForeignKey(d => d.Point1Number)
                    .HasConstraintName("FK_nakl_point");

                entity.HasOne(d => d.Point2NumberNavigation)
                    .WithMany(p => p.NaklPoint2NumberNavigation)
                    .HasForeignKey(d => d.Point2Number)
                    .HasConstraintName("FK_nakl_point1");
            });

            modelBuilder.Entity<NaklImportJrn>(entity =>
            {
                entity.HasKey(e => e.NaklImportJrnNumber);

                entity.ToTable("nakl_import_jrn");

                entity.Property(e => e.NaklImportJrnNumber).HasColumnName("nakl_import_jrn_number");

                entity.Property(e => e.CenaNakl).HasColumnName("cena_nakl");

                entity.Property(e => e.CenaNaklDol).HasColumnName("cena_nakl_dol");

                entity.Property(e => e.ExtPoint1Name)
                    .IsRequired()
                    .HasColumnName("ext_point1_name");

                entity.Property(e => e.ExtPoint1Number).HasColumnName("ext_point1_number");

                entity.Property(e => e.ExtPoint2Name)
                    .IsRequired()
                    .HasColumnName("ext_point2_name");

                entity.Property(e => e.ExtPoint2Number).HasColumnName("ext_point2_number");

                entity.Property(e => e.ExtTovarName)
                    .IsRequired()
                    .HasColumnName("ext_tovar_name");

                entity.Property(e => e.ExtTovarNumber).HasColumnName("ext_tovar_number");

                entity.Property(e => e.KursNakl).HasColumnName("kurs_nakl");

                entity.Property(e => e.ListNumber).HasColumnName("list_number");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.Point1Number).HasColumnName("point1_number");

                entity.Property(e => e.Point2Number).HasColumnName("point2_number");

                entity.Property(e => e.RecordUpdateDate)
                    .HasColumnName("record_update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TovarKolNakl).HasColumnName("tovar_kol_nakl");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");
            });

            modelBuilder.Entity<NaklProp>(entity =>
            {
                entity.HasKey(e => e.NaklPropNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("nakl_prop");

                entity.HasIndex(e => e.NaklNumber)
                    .HasName("nakl_prop_rel");

                entity.Property(e => e.NaklPropNumber).HasColumnName("nakl_prop_number");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.PropertyName)
                    .HasColumnName("property_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyValue)
                    .HasColumnName("property_value")
                    .HasMaxLength(255);

                entity.HasOne(d => d.NaklNumberNavigation)
                    .WithMany(p => p.NaklProp)
                    .HasForeignKey(d => d.NaklNumber)
                    .HasConstraintName("nakl_prop_FK00");
            });

            modelBuilder.Entity<NaklPropTemplate>(entity =>
            {
                entity.HasKey(e => e.NaklPropTemplateNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("nakl_prop_template");

                entity.Property(e => e.NaklPropTemplateNumber).HasColumnName("nakl_prop_template_number");

                entity.Property(e => e.DefaultTemplate).HasColumnName("default_template");

                entity.Property(e => e.NaklType).HasColumnName("nakl_type");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OrderExt>(entity =>
            {
                entity.HasKey(e => e.OrderExtNumber);

                entity.ToTable("order_ext");

                entity.Property(e => e.OrderExtNumber)
                    .HasColumnName("order_ext_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalcAlg).HasColumnName("calc_alg");

                entity.Property(e => e.EndDatePurchase)
                    .HasColumnName("end_date_purchase")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDateSales)
                    .HasColumnName("end_date_sales")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoodsTransferInclude).HasColumnName("goods_transfer_include");

                entity.Property(e => e.OnlyThisSupplier).HasColumnName("only_this_supplier");

                entity.Property(e => e.RoundCombo).HasColumnName("round_combo");

                entity.Property(e => e.SaleAnalasys).HasColumnName("sale_analasys");

                entity.Property(e => e.SpareFactor).HasColumnName("spare_factor");

                entity.Property(e => e.StartDatePurchase)
                    .HasColumnName("start_date_purchase")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDateSales)
                    .HasColumnName("start_date_sales")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.OrderExtNumberNavigation)
                    .WithOne(p => p.OrderExt)
                    .HasForeignKey<OrderExt>(d => d.OrderExtNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__order_ext__order__67DE6983");
            });

            modelBuilder.Entity<OrdersRedirection>(entity =>
            {
                entity.HasKey(e => e.OrdersRedirectionNumber);

                entity.Property(e => e.OrdersRedirectionNumber).HasColumnName("OrdersRedirection_number");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.RestaurantNumber).HasColumnName("restaurant_number");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.OrdersRedirectionPointNumberNavigation)
                    .HasForeignKey(d => d.PointNumber)
                    .HasConstraintName("FK__OrdersRed__point__6BAEFA67");

                entity.HasOne(d => d.RestaurantNumberNavigation)
                    .WithMany(p => p.OrdersRedirectionRestaurantNumberNavigation)
                    .HasForeignKey(d => d.RestaurantNumber)
                    .HasConstraintName("FK__OrdersRed__resta__6ABAD62E");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.OrdersRedirection)
                    .HasForeignKey(d => d.TovarNumber)
                    .HasConstraintName("FK__OrdersRed__tovar__6CA31EA0");
            });

            modelBuilder.Entity<Point>(entity =>
            {
                entity.HasKey(e => e.PointNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("point");

                entity.HasIndex(e => e.CliGroupNumber)
                    .HasName("cli_group_number");

                entity.HasIndex(e => e.NamePoint)
                    .HasName("name_point1");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressFiscal)
                    .HasColumnName("address_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentCashAllow).HasColumnName("agent_cash_allow");

                entity.Property(e => e.AgentMaxDiscount).HasColumnName("agent_max_discount");

                entity.Property(e => e.AgentOnlySelectedCategories).HasColumnName("agent_only_selected_categories");

                entity.Property(e => e.AgentOrderAllow).HasColumnName("agent_order_allow");

                entity.Property(e => e.AgentSiAllow).HasColumnName("agent_si_allow");

                entity.Property(e => e.AgentUseRoutes).HasColumnName("agent_use_routes");

                entity.Property(e => e.Arenda)
                    .HasColumnName("arenda")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAccount)
                    .HasColumnName("bank_account")
                    .HasMaxLength(50);

                entity.Property(e => e.BankClearingNumber).HasMaxLength(255);

                entity.Property(e => e.BankFromParam).HasColumnName("bank_from_param");

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CardActivated).HasColumnName("card_activated");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(20);

                entity.Property(e => e.CashPointNumber).HasColumnName("cash_point_number");

                entity.Property(e => e.CliGroupNumber)
                    .HasColumnName("cli_group_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientKurs)
                    .HasColumnName("client_kurs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.CoArticlNumber).HasColumnName("co_articl_number");

                entity.Property(e => e.CommAgent).HasColumnName("comm_agent");

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("contact_person")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractEndDate)
                    .HasColumnName("contract_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contract_number")
                    .HasMaxLength(20);

                entity.Property(e => e.ContractStartDate)
                    .HasColumnName("contract_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CorrAccount)
                    .HasColumnName("corr_account")
                    .HasMaxLength(32);

                entity.Property(e => e.DateCliZad).HasColumnName("date_cli_zad");

                entity.Property(e => e.DiscountCardPercent).HasColumnName("discount_card_percent");

                entity.Property(e => e.DiscountType).HasColumnName("discount_type");

                entity.Property(e => e.Driver).HasColumnName("driver");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.Iban)
                    .HasColumnName("iban")
                    .HasMaxLength(255);

                entity.Property(e => e.IndNum)
                    .HasColumnName("ind_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Kpp)
                    .HasColumnName("kpp")
                    .HasMaxLength(10);

                entity.Property(e => e.Kredit).HasColumnName("kredit");

                entity.Property(e => e.KreditDol).HasColumnName("kredit_dol");

                entity.Property(e => e.KreditOn).HasColumnName("kredit_on");

                entity.Property(e => e.LastEditDate)
                    .HasColumnName("last_edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenceEndDate)
                    .HasColumnName("licence_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenceNumber)
                    .HasColumnName("licence_number")
                    .HasMaxLength(255);

                entity.Property(e => e.MaOtvPerson)
                    .HasColumnName("ma_otv_person")
                    .HasMaxLength(255);

                entity.Property(e => e.MaOtvPersonFiscal)
                    .HasColumnName("ma_otv_person_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.Mfo)
                    .HasColumnName("mfo")
                    .HasMaxLength(50);

                entity.Property(e => e.Name1Person)
                    .HasColumnName("name_1_person")
                    .HasMaxLength(255);

                entity.Property(e => e.Name1PersonFiscal)
                    .HasColumnName("name_1_person_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.Name1PersonFiscalTaxId)
                    .HasColumnName("name_1_person_fiscal_tax_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Name2Person)
                    .HasColumnName("name_2_person")
                    .HasMaxLength(255);

                entity.Property(e => e.Name2PersonFiscal)
                    .HasColumnName("name_2_person_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.Name2PersonFiscalTaxId)
                    .HasColumnName("name_2_person_fiscal_tax_id")
                    .HasMaxLength(50);

                entity.Property(e => e.NameCeoPerson)
                    .HasColumnName("name_ceo_person")
                    .HasMaxLength(255);

                entity.Property(e => e.NameFirm)
                    .HasColumnName("name_firm")
                    .HasMaxLength(255);

                entity.Property(e => e.NameFirmFiscal)
                    .HasColumnName("name_firm_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.NameFirmFromParam).HasColumnName("name_firm_from_param");

                entity.Property(e => e.NameFirmFromParamFiscal).HasColumnName("name_firm_from_param_fiscal");

                entity.Property(e => e.NamePoint)
                    .IsRequired()
                    .HasColumnName("name_point")
                    .HasMaxLength(255);

                entity.Property(e => e.Nds).HasColumnName("nds");

                entity.Property(e => e.NdsPayer).HasColumnName("nds_payer");

                entity.Property(e => e.Okpo)
                    .HasColumnName("okpo")
                    .HasMaxLength(50);

                entity.Property(e => e.PathToMobileSynchro)
                    .HasColumnName("path_to_mobile_synchro")
                    .HasMaxLength(255);

                entity.Property(e => e.PisArticlNumber).HasColumnName("pis_articl_number");

                entity.Property(e => e.PointComment)
                    .HasColumnName("point_comment")
                    .HasMaxLength(255);

                entity.Property(e => e.PointType).HasColumnName("point_type");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.Postconto).HasMaxLength(255);

                entity.Property(e => e.PriceColumnNumber).HasColumnName("price_column_number");

                entity.Property(e => e.Prof1Person)
                    .HasColumnName("prof_1_person")
                    .HasMaxLength(255);

                entity.Property(e => e.Prof1PersonFiscal)
                    .HasColumnName("prof_1_person_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.Prof2Person)
                    .HasColumnName("prof_2_person")
                    .HasMaxLength(255);

                entity.Property(e => e.Prof2PersonFiscal)
                    .HasColumnName("prof_2_person_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.Realis).HasColumnName("realis");

                entity.Property(e => e.RoutesByDates).HasColumnName("routes_by_dates");

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoDol)
                    .HasColumnName("saldo_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiArticlNumber).HasColumnName("si_articl_number");

                entity.Property(e => e.SvidNum)
                    .HasColumnName("svid_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Swiftcode).HasMaxLength(255);

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasMaxLength(255);

                entity.Property(e => e.TelefonFiscal)
                    .HasColumnName("telefon_fiscal")
                    .HasMaxLength(255);

                entity.Property(e => e.TransportPr)
                    .HasColumnName("transport_pr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Waiter).HasColumnName("waiter");

                entity.Property(e => e.ZadActivate).HasColumnName("zad_activate");

                //entity.HasOne(d => d.CliGroup)
                //    .WithMany(p => p.Point)
                //    .HasForeignKey(d => d.CliGroupNumber);
            });

            modelBuilder.Entity<PointAgent>(entity =>
            {
                entity.HasKey(e => e.PointAgentNumber);

                entity.ToTable("point_agent");

                entity.Property(e => e.PointAgentNumber).HasColumnName("point_agent_number");

                entity.Property(e => e.AgentNumber).HasColumnName("agent_number");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.HasOne(d => d.AgentNumberNavigation)
                    .WithMany(p => p.PointAgent)
                    .HasForeignKey(d => d.AgentNumber)
                    .HasConstraintName("FK__point_age__agent__55BFB948");
            });

            modelBuilder.Entity<PriceImportJrn>(entity =>
            {
                entity.HasKey(e => e.PriceImportJrnNumber);

                entity.ToTable("price_import_jrn");

                entity.Property(e => e.PriceImportJrnNumber).HasColumnName("price_import_jrn_number");

                entity.Property(e => e.CenaPrice1).HasColumnName("cena_price1");

                entity.Property(e => e.CenaPrice1Dol).HasColumnName("cena_price1_dol");

                entity.Property(e => e.CenaPrice2).HasColumnName("cena_price2");

                entity.Property(e => e.CenaPrice2Dol).HasColumnName("cena_price2_dol");

                entity.Property(e => e.CenaPrice3).HasColumnName("cena_price3");

                entity.Property(e => e.CenaPrice3Dol).HasColumnName("cena_price3_dol");

                entity.Property(e => e.CenaPrice4).HasColumnName("cena_price4");

                entity.Property(e => e.CenaPrice4Dol).HasColumnName("cena_price4_dol");

                entity.Property(e => e.CenaPrice5).HasColumnName("cena_price5");

                entity.Property(e => e.CenaPrice5Dol).HasColumnName("cena_price5_dol");

                entity.Property(e => e.ExtTovarName)
                    .IsRequired()
                    .HasColumnName("ext_tovar_name");

                entity.Property(e => e.ExtTovarNumber).HasColumnName("ext_tovar_number");

                entity.Property(e => e.IzmerNumber)
                    .HasColumnName("izmer_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KatNumber)
                    .HasColumnName("kat_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.TovarAppend).HasColumnName("tovar_append");

                entity.Property(e => e.TovarDescrip)
                    .IsRequired()
                    .HasColumnName("tovar_descrip")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.Property(e => e.TovarPresent)
                    .IsRequired()
                    .HasColumnName("tovar_present")
                    .HasMaxLength(30);

                entity.Property(e => e.TovarUpdateDate)
                    .HasColumnName("tovar_update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PriceShields>(entity =>
            {
                entity.Property(e => e.CenaDol).HasColumnName("cena_dol");

                entity.Property(e => e.CenaRozn).HasColumnName("cena_rozn");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.HasOne(d => d.NaklNumberNavigation)
                    .WithMany(p => p.PriceShields)
                    .HasForeignKey(d => d.NaklNumber)
                    .HasConstraintName("FK__PriceShie__nakl___567ED357");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.PriceShields)
                    .HasForeignKey(d => d.TovarNumber)
                    .HasConstraintName("FK__PriceShie__tovar__558AAF1E");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.RecipeNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("recipe");

                entity.HasIndex(e => e.TovarNumber)
                    .HasName("recipe_rel");

                entity.Property(e => e.RecipeNumber).HasColumnName("recipe_number");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitProd).HasColumnName("exit_prod");

                entity.Property(e => e.SelfCost).HasColumnName("self_cost");

                entity.Property(e => e.SelfCostDol).HasColumnName("self_cost_dol");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.TovarNumber)
                    .HasConstraintName("recipe_FK00");
            });

            modelBuilder.Entity<RecipeList>(entity =>
            {
                entity.HasKey(e => e.RecipeListNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("recipe_list");

                entity.HasIndex(e => e.RecipeNumber)
                    .HasName("recipe_list_rel");

                entity.HasIndex(e => e.TovarNumber)
                    .HasName("recipe_list_tovar_rel");

                entity.Property(e => e.RecipeListNumber).HasColumnName("recipe_list_number");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Kol).HasColumnName("kol");

                entity.Property(e => e.RecipeNumber).HasColumnName("recipe_number");

                entity.Property(e => e.SelfCostPercent).HasColumnName("self_cost_percent");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");
            });

            modelBuilder.Entity<Reestr>(entity =>
            {
                entity.HasKey(e => e.ReestrNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("reestr");

                entity.HasIndex(e => e.CenaDol)
                    .HasName("cena_dol");

                entity.HasIndex(e => e.CenaRozn)
                    .HasName("cena_rozn");

                entity.HasIndex(e => e.Kol)
                    .HasName("kol");

                entity.HasIndex(e => e.PointNumber)
                    .HasName("pointreestr");

                entity.HasIndex(e => e.PostNumber)
                    .HasName("post_number");

                entity.HasIndex(e => e.Rezerv1)
                    .HasName("rezerv1");

                entity.HasIndex(e => e.Rezerv2)
                    .HasName("rezerv2");

                entity.HasIndex(e => e.Rezerv3)
                    .HasName("rezerv3");

                entity.HasIndex(e => e.Rezerv4)
                    .HasName("rezerv4");

                entity.HasIndex(e => e.Rezerv5)
                    .HasName("rezerv5");

                entity.HasIndex(e => e.Rezerv6)
                    .HasName("rezerv6");

                entity.HasIndex(e => e.Rezerv7)
                    .HasName("rezerv7");

                entity.HasIndex(e => e.Rezerv8)
                    .HasName("rezerv8");

                entity.HasIndex(e => e.TovarNumber)
                    .HasName("tovarreestr");

                entity.Property(e => e.ReestrNumber).HasColumnName("reestr_number");

                entity.Property(e => e.CenaDol)
                    .HasColumnName("cena_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn)
                    .HasColumnName("cena_rozn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Kol)
                    .HasColumnName("kol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolMin).HasColumnName("kol_min");

                entity.Property(e => e.KolRezerv).HasColumnName("kol_rezerv");

                entity.Property(e => e.LastEditDate)
                    .HasColumnName("last_edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PointNumber)
                    .HasColumnName("point_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostNumber)
                    .HasColumnName("post_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rezerv1)
                    .HasColumnName("rezerv1")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv2)
                    .HasColumnName("rezerv2")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv3)
                    .HasColumnName("rezerv3")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv4)
                    .HasColumnName("rezerv4")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv5)
                    .HasColumnName("rezerv5")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv6)
                    .HasColumnName("rezerv6")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv7)
                    .HasColumnName("rezerv7")
                    .HasMaxLength(128);

                entity.Property(e => e.Rezerv8)
                    .HasColumnName("rezerv8")
                    .HasMaxLength(128);

                entity.Property(e => e.TovarNumber)
                    .HasColumnName("tovar_number")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PointNumberNavigation)
                    .WithMany(p => p.Reestr)
                    .HasForeignKey(d => d.PointNumber)
                    .HasConstraintName("reestr_FK00");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.Reestr)
                    .HasForeignKey(d => d.TovarNumber)
                    .HasConstraintName("reestr_FK01");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.HasKey(e => e.RouteNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("route");

                entity.Property(e => e.RouteNumber).HasColumnName("route_number");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Distance).HasColumnName("distance");
            });

            modelBuilder.Entity<RouteAgent>(entity =>
            {
                entity.HasKey(e => e.RouteAgentNumber);

                entity.ToTable("route_agent");

                entity.Property(e => e.RouteAgentNumber).HasColumnName("route_agent_number");

                entity.Property(e => e.DateOfRoute)
                    .HasColumnName("date_of_route")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayOfRoute).HasColumnName("day_of_route");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.RouteNumber).HasColumnName("route_number");

                entity.HasOne(d => d.RouteNumberNavigation)
                    .WithMany(p => p.RouteAgent)
                    .HasForeignKey(d => d.RouteNumber)
                    .HasConstraintName("FK__route_age__route__4C364F0E");
            });

            modelBuilder.Entity<RouteList>(entity =>
            {
                entity.HasKey(e => e.RouteListNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("route_list");

                entity.HasIndex(e => e.CarNumber)
                    .HasName("car_rel");

                entity.HasIndex(e => e.ExpeditorNumber)
                    .HasName("expeditor_rel");

                entity.HasIndex(e => e.RouteNumber)
                    .HasName("route_list_rel");

                entity.Property(e => e.RouteListNumber).HasColumnName("route_list_number");

                entity.Property(e => e.CarNumber).HasColumnName("car_number");

                entity.Property(e => e.DateUtv)
                    .HasColumnName("date_utv")
                    .HasColumnType("datetime");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpeditorNumber).HasColumnName("expeditor_number");

                entity.Property(e => e.Osn)
                    .HasColumnName("osn")
                    .HasMaxLength(255);

                entity.Property(e => e.RouteNumber).HasColumnName("route_number");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SumDol).HasColumnName("sum_dol");

                entity.Property(e => e.SumRozn).HasColumnName("sum_rozn");

                entity.Property(e => e.Utv).HasColumnName("utv");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.CarNumberNavigation)
                    .WithMany(p => p.RouteList)
                    .HasForeignKey(d => d.CarNumber)
                    .HasConstraintName("route_list_FK00");

                entity.HasOne(d => d.ExpeditorNumberNavigation)
                    .WithMany(p => p.RouteList)
                    .HasForeignKey(d => d.ExpeditorNumber)
                    .HasConstraintName("route_list_FK01");

                entity.HasOne(d => d.RouteNumberNavigation)
                    .WithMany(p => p.RouteList)
                    .HasForeignKey(d => d.RouteNumber)
                    .HasConstraintName("route_list_FK02");
            });

            modelBuilder.Entity<RouteNaklList>(entity =>
            {
                entity.HasKey(e => e.RouteNaklListNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("route_nakl_list");

                entity.HasIndex(e => e.NaklNumber)
                    .HasName("route_nakl_rel");

                entity.HasIndex(e => e.RouteListNumber)
                    .HasName("route_nakl_list_rel");

                entity.Property(e => e.RouteNaklListNumber).HasColumnName("route_nakl_list_number");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.RouteListNumber).HasColumnName("route_list_number");

                entity.HasOne(d => d.NaklNumberNavigation)
                    .WithMany(p => p.RouteNaklList)
                    .HasForeignKey(d => d.NaklNumber)
                    .HasConstraintName("route_nakl_list_FK01");

                entity.HasOne(d => d.RouteListNumberNavigation)
                    .WithMany(p => p.RouteNaklList)
                    .HasForeignKey(d => d.RouteListNumber)
                    .HasConstraintName("route_nakl_list_FK00");
            });

            modelBuilder.Entity<RoutePoint>(entity =>
            {
                entity.HasKey(e => e.RoutePointNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("route_point");

                entity.HasIndex(e => e.DelivePointNumber)
                    .HasName("route_point_rel");

                entity.HasIndex(e => e.RouteNumber)
                    .HasName("route_rel");

                entity.Property(e => e.RoutePointNumber).HasColumnName("route_point_number");

                entity.Property(e => e.DelivePointNumber).HasColumnName("delive_point_number");

                entity.Property(e => e.ReturnDistance).HasColumnName("return_distance");

                entity.Property(e => e.RouteNumber).HasColumnName("route_number");

                entity.Property(e => e.SortNumber).HasColumnName("sort_number");

                entity.Property(e => e.UpPointDistance).HasColumnName("up_point_distance");

                entity.HasOne(d => d.DelivePointNumberNavigation)
                    .WithMany(p => p.RoutePoint)
                    .HasForeignKey(d => d.DelivePointNumber)
                    .HasConstraintName("route_point_FK00");

                entity.HasOne(d => d.RouteNumberNavigation)
                    .WithMany(p => p.RoutePoint)
                    .HasForeignKey(d => d.RouteNumber)
                    .HasConstraintName("route_point_FK01");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("service");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.KassaId).HasColumnName("kassa_id");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.ServiceDate)
                    .HasColumnName("service_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Kassa)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.KassaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_kassa");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_service_point");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasKey(e => e.ShopNumber);

                entity.ToTable("shop");

                entity.Property(e => e.ShopNumber).HasColumnName("shop_number");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_shop_manager");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.PointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_shop_point");
            });

            modelBuilder.Entity<SysJrn>(entity =>
            {
                entity.HasKey(e => e.SysJrnNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("sys_jrn");

                entity.HasIndex(e => e.MsgNumber)
                    .HasName("msg_number");

                entity.Property(e => e.SysJrnNumber).HasColumnName("sys_jrn_number");

                entity.Property(e => e.APerD).HasColumnName("a_per_d");

                entity.Property(e => e.APerE).HasColumnName("a_per_e");

                entity.Property(e => e.APerV).HasColumnName("a_per_v");

                entity.Property(e => e.ASpisD).HasColumnName("a_spis_d");

                entity.Property(e => e.ASpisE).HasColumnName("a_spis_e");

                entity.Property(e => e.ASpisV).HasColumnName("a_spis_v");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.AktNumber).HasColumnName("akt_number");

                entity.Property(e => e.CliZad).HasColumnName("cli_zad");

                entity.Property(e => e.ClientNumber).HasColumnName("client_number");

                entity.Property(e => e.CompNumber)
                    .HasColumnName("comp_number")
                    .HasMaxLength(255);

                entity.Property(e => e.DateDoc)
                    .HasColumnName("date_doc")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOperBase)
                    .HasColumnName("date_oper_base")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1))+CONVERT([datetime],CONVERT([varchar],getdate(),(14)),(14)))");

                entity.Property(e => e.DateOperClient)
                    .HasColumnName("date_oper_client")
                    .HasColumnType("datetime");

                entity.Property(e => e.JrnNumber).HasColumnName("jrn_number");

                entity.Property(e => e.KD).HasColumnName("k_d");

                entity.Property(e => e.KE).HasColumnName("k_e");

                entity.Property(e => e.KV).HasColumnName("k_v");

                entity.Property(e => e.MsgNumber)
                    .HasColumnName("msg_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaklNumber).HasColumnName("nakl_number");

                entity.Property(e => e.NameOper)
                    .HasColumnName("name_oper")
                    .HasMaxLength(255);

                entity.Property(e => e.PND).HasColumnName("p_n_d");

                entity.Property(e => e.PNE).HasColumnName("p_n_e");

                entity.Property(e => e.PNV).HasColumnName("p_n_v");

                entity.Property(e => e.PerND).HasColumnName("per_n_d");

                entity.Property(e => e.PerNE).HasColumnName("per_n_e");

                entity.Property(e => e.PerNV).HasColumnName("per_n_v");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.RND).HasColumnName("r_n_d");

                entity.Property(e => e.RNE).HasColumnName("r_n_e");

                entity.Property(e => e.RNV).HasColumnName("r_n_v");

                entity.Property(e => e.ReestrNumber).HasColumnName("reestr_number");

                entity.Property(e => e.Sprav).HasColumnName("sprav");

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserNumber).HasColumnName("user_number");

                entity.Property(e => e.UserPasswd)
                    .HasColumnName("user_passwd")
                    .HasMaxLength(255);

                entity.Property(e => e.ZCliD).HasColumnName("z_cli_d");

                entity.Property(e => e.ZCliE).HasColumnName("z_cli_e");

                entity.Property(e => e.ZCliV).HasColumnName("z_cli_v");

                entity.Property(e => e.ZFirmD).HasColumnName("z_firm_d");

                entity.Property(e => e.ZFirmE).HasColumnName("z_firm_e");

                entity.Property(e => e.ZFirmV).HasColumnName("z_firm_v");

                entity.Property(e => e.ZadNumber).HasColumnName("zad_number");
            });

            modelBuilder.Entity<SysJrnExt>(entity =>
            {
                entity.HasKey(e => e.SysJrnNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("sys_jrn_ext");

                entity.Property(e => e.SysJrnNumber)
                    .HasColumnName("sys_jrn_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MsgNumber)
                    .HasColumnName("msg_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MsgText)
                    .HasColumnName("msg_text")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TcuPar>(entity =>
            {
                entity.HasKey(e => e.ParamName)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tcu_par");

                entity.Property(e => e.ParamName)
                    .HasColumnName("param_name")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BoolValue).HasColumnName("bool_value");

                entity.Property(e => e.DoubleValue)
                    .HasColumnName("double_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LongValue)
                    .HasColumnName("long_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParamType)
                    .HasColumnName("param_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TextValue)
                    .HasColumnName("text_value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tovar>(entity =>
            {
                entity.HasKey(e => e.TovarNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tovar");

                entity.HasIndex(e => e.Balls)
                    .HasName("balls");

                entity.HasIndex(e => e.IzmerNumber)
                    .HasName("izmer_number");

                entity.HasIndex(e => e.KatNumber)
                    .HasName("kat_number");

                entity.HasIndex(e => e.TovarName)
                    .HasName("tovar_name");

                entity.HasIndex(e => new { e.TovarName, e.KatNumber })
                    .HasName("tovar_and_kat")
                    .IsUnique();

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.Property(e => e.AllKol).HasColumnName("all_kol");

                entity.Property(e => e.AnalyticCode).HasMaxLength(32);

                entity.Property(e => e.Articul)
                    .HasColumnName("articul")
                    .HasMaxLength(255);

                entity.Property(e => e.Balls)
                    .HasColumnName("balls")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn2)
                    .HasColumnName("cena_rozn2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn2Dol)
                    .HasColumnName("cena_rozn2_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn3)
                    .HasColumnName("cena_rozn3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn3Dol)
                    .HasColumnName("cena_rozn3_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRozn4).HasColumnName("cena_rozn4");

                entity.Property(e => e.CenaRozn4Dol).HasColumnName("cena_rozn4_dol");

                entity.Property(e => e.CenaRozn5).HasColumnName("cena_rozn5");

                entity.Property(e => e.CenaRozn5Dol).HasColumnName("cena_rozn5_dol");

                entity.Property(e => e.CenaRoznSprav)
                    .HasColumnName("cena_rozn_sprav")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CenaRoznSpravDol)
                    .HasColumnName("cena_rozn_sprav_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertEndDate)
                    .HasColumnName("cert_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Certificate)
                    .HasColumnName("certificate")
                    .HasMaxLength(20);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.DiscountCalcOn1).HasColumnName("discount_calc_on1");

                entity.Property(e => e.DiscountCalcOn2).HasColumnName("discount_calc_on2");

                entity.Property(e => e.DiscountCalcOn3).HasColumnName("discount_calc_on3");

                entity.Property(e => e.DiscountCalcOn4).HasColumnName("discount_calc_on4");

                entity.Property(e => e.DiscountCalcOn5).HasColumnName("discount_calc_on5");

                entity.Property(e => e.DiscountLimitation).HasColumnName("discount_limitation");

                entity.Property(e => e.DiscountMarkup).HasColumnName("discount_markup");

                entity.Property(e => e.DiscountPercent1).HasColumnName("discount_percent1");

                entity.Property(e => e.DiscountPercent2).HasColumnName("discount_percent2");

                entity.Property(e => e.DiscountPercent3).HasColumnName("discount_percent3");

                entity.Property(e => e.DiscountPercent4).HasColumnName("discount_percent4");

                entity.Property(e => e.DiscountPercent5).HasColumnName("discount_percent5");

                entity.Property(e => e.FiscalGroupNumber).HasColumnName("fiscal_group_number");

                entity.Property(e => e.FranchTopId).HasColumnName("franch_top_id");

                entity.Property(e => e.Image1)
                    .HasColumnName("image1")
                    .HasColumnType("image");

                entity.Property(e => e.Image1Cash)
                    .HasColumnName("image1_cash")
                    .HasColumnType("image");

                entity.Property(e => e.IzmerNumber)
                    .HasColumnName("izmer_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KatNumber)
                    .HasColumnName("kat_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolDefault)
                    .HasColumnName("kol_default")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolInPak)
                    .HasColumnName("kol_in_pak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolLinked1).HasColumnName("kol_linked1");

                entity.Property(e => e.KolLinked2).HasColumnName("kol_linked2");

                entity.Property(e => e.KolMin1)
                    .HasColumnName("kol_min1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolMin2)
                    .HasColumnName("kol_min2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KolOsn1).HasColumnName("kol_osn1");

                entity.Property(e => e.KolOsn2).HasColumnName("kol_osn2");

                entity.Property(e => e.LastCenaOpt).HasColumnName("last_cena_opt");

                entity.Property(e => e.LastCenaOptDol).HasColumnName("last_cena_opt_dol");

                entity.Property(e => e.LastEditDate)
                    .HasColumnName("last_edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Objem).HasColumnName("objem");

                entity.Property(e => e.PercSkid1)
                    .HasColumnName("perc_skid1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PercSkid2)
                    .HasColumnName("perc_skid2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProducedBy)
                    .HasColumnName("produced_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Product).HasColumnName("product");

                entity.Property(e => e.PurchasePeriod).HasColumnName("purchase_period");

                entity.Property(e => e.RoundTo1).HasColumnName("round_to1");

                entity.Property(e => e.RoundTo2).HasColumnName("round_to2");

                entity.Property(e => e.RoundTo3).HasColumnName("round_to3");

                entity.Property(e => e.RoundTo4).HasColumnName("round_to4");

                entity.Property(e => e.RoundTo5).HasColumnName("round_to5");

                entity.Property(e => e.SerialNumberCheck).HasColumnName("serial_number_check");

                entity.Property(e => e.SpareFactor).HasColumnName("spare_factor");

                entity.Property(e => e.StDost)
                    .HasColumnName("st_dost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StDostAlg).HasColumnName("st_dost_alg");

                entity.Property(e => e.StDostDol)
                    .HasColumnName("st_dost_dol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.Tara1Number).HasColumnName("tara1_number");

                entity.Property(e => e.Tara1Round).HasColumnName("tara1_round");

                entity.Property(e => e.Tara2Number).HasColumnName("tara2_number");

                entity.Property(e => e.Tara2Round).HasColumnName("tara2_round");

                entity.Property(e => e.Tare1Check).HasColumnName("tare1_check");

                entity.Property(e => e.Tare2Check).HasColumnName("tare2_check");

                entity.Property(e => e.TovClosed).HasColumnName("tov_closed");

                entity.Property(e => e.TovDescription)
                    .HasColumnName("tov_description")
                    .HasMaxLength(4000);

                entity.Property(e => e.TovPicture)
                    .HasColumnName("tov_picture")
                    .HasMaxLength(255);

                entity.Property(e => e.TovarBackcolor).HasColumnName("tovar_backcolor");

                entity.Property(e => e.TovarFontBold).HasColumnName("tovar_font_bold");

                entity.Property(e => e.TovarFontItalic).HasColumnName("tovar_font_italic");

                entity.Property(e => e.TovarFontName)
                    .HasColumnName("tovar_font_name")
                    .HasMaxLength(127);

                entity.Property(e => e.TovarFontSize).HasColumnName("tovar_font_size");

                entity.Property(e => e.TovarForecolor).HasColumnName("tovar_forecolor");

                entity.Property(e => e.TovarKod)
                    .HasColumnName("tovar_kod")
                    .HasMaxLength(50);

                entity.Property(e => e.TovarName)
                    .IsRequired()
                    .HasColumnName("tovar_name")
                    .HasMaxLength(250);

                entity.Property(e => e.TovarType).HasColumnName("tovar_type");

                entity.Property(e => e.UktzedCode)
                    .HasColumnName("UKTZED_code")
                    .HasMaxLength(255);

                entity.Property(e => e.UniNumber)
                    .HasColumnName("uni_number")
                    .HasMaxLength(50);

                entity.Property(e => e.UseCert).HasColumnName("use_cert");

                entity.Property(e => e.Ves).HasColumnName("ves");

                entity.Property(e => e.VideoHyperlink)
                    .HasColumnName("video_hyperlink")
                    .HasMaxLength(4000);

                entity.Property(e => e.Warranty).HasColumnName("warranty");

                entity.HasOne(d => d.IzmerNumberNavigation)
                    .WithMany(p => p.Tovar)
                    .HasForeignKey(d => d.IzmerNumber)
                    .HasConstraintName("tovar_FK01");

                entity.HasOne(d => d.KatNumberNavigation)
                    .WithMany(p => p.Tovar)
                    .HasForeignKey(d => d.KatNumber)
                    .HasConstraintName("tovar_FK00");
            });

            modelBuilder.Entity<TovarCode>(entity =>
            {
                entity.HasKey(e => e.TovarCodeNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tovar_code");

                entity.HasIndex(e => e.TovarNumber)
                    .HasName("tovartovar_code");

                entity.Property(e => e.TovarCodeNumber).HasColumnName("tovar_code_number");

                entity.Property(e => e.ChkDisable).HasColumnName("chk_disable");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.TovarBarCode)
                    .HasColumnName("tovar_bar_code")
                    .HasMaxLength(255);

                entity.Property(e => e.TovarNumber).HasColumnName("tovar_number");

                entity.HasOne(d => d.TovarNumberNavigation)
                    .WithMany(p => p.TovarCode)
                    .HasForeignKey(d => d.TovarNumber)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tovar_code_FK00");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("user");

                entity.Property(e => e.UserNumber).HasColumnName("user_number");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.AllowPurchaseKurs).HasColumnName("allow_purchase_kurs");

                entity.Property(e => e.AllowSalesKurs).HasColumnName("allow_sales_kurs");

                entity.Property(e => e.ArticlSprav).HasColumnName("articl_sprav");

                entity.Property(e => e.CashReportAccess).HasColumnName("cash_report_access");

                entity.Property(e => e.ChangeDate).HasColumnName("change_date");

                entity.Property(e => e.CliSprav).HasColumnName("cli_sprav");

                entity.Property(e => e.CliZad).HasColumnName("cli_zad");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.DaysBackward).HasColumnName("days_backward");

                entity.Property(e => e.DaysForward).HasColumnName("days_forward");

                entity.Property(e => e.MaxDiscount).HasColumnName("max_discount");

                entity.Property(e => e.NegativeRests).HasColumnName("negative_rests");

                entity.Property(e => e.PointSprav).HasColumnName("point_sprav");

                entity.Property(e => e.RLApprove).HasColumnName("r_l_approve");

                entity.Property(e => e.RLDelete).HasColumnName("r_l_delete");

                entity.Property(e => e.RLEdit).HasColumnName("r_l_edit");

                entity.Property(e => e.RLRollback).HasColumnName("r_l_rollback");

                entity.Property(e => e.RLView).HasColumnName("r_l_view");

                entity.Property(e => e.ReportAccess).HasColumnName("report_access");

                entity.Property(e => e.RouteSprav).HasColumnName("route_sprav");

                entity.Property(e => e.SaleMorePurchase).HasColumnName("sale_more_purchase");

                entity.Property(e => e.SettlementsAccess).HasColumnName("settlements_access");

                entity.Property(e => e.Sprav).HasColumnName("sprav");

                entity.Property(e => e.TovarSprav).HasColumnName("tovar_sprav");

                entity.Property(e => e.UserFullname)
                    .HasColumnName("user_fullname")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPasswd)
                    .HasColumnName("user_passwd")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UserRights>(entity =>
            {
                entity.HasKey(e => e.UserRightsNumber)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("user_rights");

                entity.Property(e => e.UserRightsNumber).HasColumnName("user_rights_number");

                entity.Property(e => e.PointNumber).HasColumnName("point_number");

                entity.Property(e => e.UserNumber).HasColumnName("user_number");

                entity.Property(e => e._00approve).HasColumnName("00approve");

                entity.Property(e => e._00delete).HasColumnName("00delete");

                entity.Property(e => e._00edit).HasColumnName("00edit");

                entity.Property(e => e._00rollback).HasColumnName("00rollback");

                entity.Property(e => e._00view).HasColumnName("00view");

                entity.Property(e => e._01approve).HasColumnName("01approve");

                entity.Property(e => e._01delete).HasColumnName("01delete");

                entity.Property(e => e._01edit).HasColumnName("01edit");

                entity.Property(e => e._01rollback).HasColumnName("01rollback");

                entity.Property(e => e._01view).HasColumnName("01view");

                entity.Property(e => e._02approve).HasColumnName("02approve");

                entity.Property(e => e._02delete).HasColumnName("02delete");

                entity.Property(e => e._02edit).HasColumnName("02edit");

                entity.Property(e => e._02rollback).HasColumnName("02rollback");

                entity.Property(e => e._02view).HasColumnName("02view");

                entity.Property(e => e._03approve).HasColumnName("03approve");

                entity.Property(e => e._03delete).HasColumnName("03delete");

                entity.Property(e => e._03edit).HasColumnName("03edit");

                entity.Property(e => e._03rollback).HasColumnName("03rollback");

                entity.Property(e => e._03view).HasColumnName("03view");

                entity.Property(e => e._04approve).HasColumnName("04approve");

                entity.Property(e => e._04delete).HasColumnName("04delete");

                entity.Property(e => e._04edit).HasColumnName("04edit");

                entity.Property(e => e._04rollback).HasColumnName("04rollback");

                entity.Property(e => e._04view).HasColumnName("04view");

                entity.Property(e => e._05approve).HasColumnName("05approve");

                entity.Property(e => e._05delete).HasColumnName("05delete");

                entity.Property(e => e._05edit).HasColumnName("05edit");

                entity.Property(e => e._05rollback).HasColumnName("05rollback");

                entity.Property(e => e._05view).HasColumnName("05view");

                entity.Property(e => e._07approve).HasColumnName("07approve");

                entity.Property(e => e._07delete).HasColumnName("07delete");

                entity.Property(e => e._07edit).HasColumnName("07edit");

                entity.Property(e => e._07rollback).HasColumnName("07rollback");

                entity.Property(e => e._07view).HasColumnName("07view");

                entity.Property(e => e._08approve).HasColumnName("08approve");

                entity.Property(e => e._08delete).HasColumnName("08delete");

                entity.Property(e => e._08edit).HasColumnName("08edit");

                entity.Property(e => e._08rollback).HasColumnName("08rollback");

                entity.Property(e => e._08view).HasColumnName("08view");

                entity.Property(e => e._09approve).HasColumnName("09approve");

                entity.Property(e => e._09delete).HasColumnName("09delete");

                entity.Property(e => e._09edit).HasColumnName("09edit");

                entity.Property(e => e._09rollback).HasColumnName("09rollback");

                entity.Property(e => e._09view).HasColumnName("09view");

                entity.Property(e => e._14approve).HasColumnName("14approve");

                entity.Property(e => e._14delete).HasColumnName("14delete");

                entity.Property(e => e._14edit).HasColumnName("14edit");

                entity.Property(e => e._14rollback).HasColumnName("14rollback");

                entity.Property(e => e._14view).HasColumnName("14view");

                entity.Property(e => e._15approve).HasColumnName("15approve");

                entity.Property(e => e._15delete).HasColumnName("15delete");

                entity.Property(e => e._15edit).HasColumnName("15edit");

                entity.Property(e => e._15rollback).HasColumnName("15rollback");

                entity.Property(e => e._15view).HasColumnName("15view");

                entity.Property(e => e._17approve).HasColumnName("17approve");

                entity.Property(e => e._17delete).HasColumnName("17delete");

                entity.Property(e => e._17edit).HasColumnName("17edit");

                entity.Property(e => e._17rollback).HasColumnName("17rollback");

                entity.Property(e => e._17view).HasColumnName("17view");

                entity.Property(e => e._18approve).HasColumnName("18approve");

                entity.Property(e => e._18delete).HasColumnName("18delete");

                entity.Property(e => e._18edit).HasColumnName("18edit");

                entity.Property(e => e._18rollback).HasColumnName("18rollback");

                entity.Property(e => e._18view).HasColumnName("18view");

                entity.Property(e => e._19approve).HasColumnName("19approve");

                entity.Property(e => e._19delete).HasColumnName("19delete");

                entity.Property(e => e._19edit).HasColumnName("19edit");

                entity.Property(e => e._19rollback).HasColumnName("19rollback");

                entity.Property(e => e._19view).HasColumnName("19view");

                entity.Property(e => e._20approve).HasColumnName("20approve");

                entity.Property(e => e._20delete).HasColumnName("20delete");

                entity.Property(e => e._20edit).HasColumnName("20edit");

                entity.Property(e => e._20rollback).HasColumnName("20rollback");

                entity.Property(e => e._20view).HasColumnName("20view");

                entity.Property(e => e._21approve).HasColumnName("21approve");

                entity.Property(e => e._21delete).HasColumnName("21delete");

                entity.Property(e => e._21edit).HasColumnName("21edit");

                entity.Property(e => e._21rollback).HasColumnName("21rollback");

                entity.Property(e => e._21view).HasColumnName("21view");

                entity.Property(e => e._22approve).HasColumnName("22approve");

                entity.Property(e => e._22delete).HasColumnName("22delete");

                entity.Property(e => e._22edit).HasColumnName("22edit");

                entity.Property(e => e._22rollback).HasColumnName("22rollback");

                entity.Property(e => e._22view).HasColumnName("22view");
            });

            InitializeEntitiesExtention(modelBuilder);
        }
    }
}
