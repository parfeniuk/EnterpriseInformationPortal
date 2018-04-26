using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acc_trans_jrn",
                columns: table => new
                {
                    acc_trans_jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    acc_trans_chema_number = table.Column<int>(nullable: true),
                    account1_number = table.Column<int>(nullable: true),
                    account2_number = table.Column<int>(nullable: true),
                    articl_number = table.Column<int>(nullable: true),
                    bundle_nakl_number = table.Column<int>(nullable: true),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    date_utv = table.Column<DateTime>(type: "datetime", nullable: true),
                    summa = table.Column<double>(nullable: true),
                    user_number = table.Column<int>(nullable: true),
                    utv = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acc_trans_jrn", x => x.acc_trans_jrn_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    account_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    acc_type = table.Column<short>(nullable: true),
                    account_name = table.Column<string>(maxLength: 255, nullable: true),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    rest = table.Column<double>(nullable: true),
                    top_account_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.account_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "account_plan",
                columns: table => new
                {
                    account_plan_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    account_code = table.Column<string>(maxLength: 255, nullable: true),
                    account_name = table.Column<string>(maxLength: 255, nullable: true),
                    account_sphere = table.Column<string>(maxLength: 255, nullable: true),
                    account_type = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_plan", x => x.account_plan_number);
                });

            migrationBuilder.CreateTable(
                name: "articl",
                columns: table => new
                {
                    articl_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    act_pass = table.Column<bool>(nullable: false),
                    articl_name = table.Column<string>(maxLength: 255, nullable: false),
                    closed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articl", x => x.articl_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    car_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    model = table.Column<string>(maxLength: 255, nullable: true),
                    netto = table.Column<double>(nullable: true),
                    reg_number = table.Column<string>(maxLength: 255, nullable: true),
                    tara = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car", x => x.car_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "cash_table",
                columns: table => new
                {
                    cash_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cash_text = table.Column<string>(maxLength: 255, nullable: true),
                    field_name = table.Column<string>(maxLength: 255, nullable: true),
                    form_name = table.Column<string>(maxLength: 255, nullable: true),
                    lng_number = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cash_table", x => x.cash_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "cli_group",
                columns: table => new
                {
                    cli_group_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cli_group_name = table.Column<string>(maxLength: 250, nullable: true),
                    post = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cli_group", x => x.cli_group_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "DocStan",
                columns: table => new
                {
                    DocStanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameStan = table.Column<string>(type: "nchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocStan", x => x.DocStanId);
                });

            migrationBuilder.CreateTable(
                name: "in_out_jrn",
                columns: table => new
                {
                    in_out_jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    articl_number = table.Column<int>(nullable: true),
                    date_utv = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    key_field = table.Column<string>(maxLength: 255, nullable: true),
                    key_number = table.Column<int>(nullable: true),
                    point_number = table.Column<int>(nullable: true),
                    table_name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_in_out_jrn", x => x.in_out_jrn_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "izmer",
                columns: table => new
                {
                    izmer_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    default_izmer = table.Column<bool>(nullable: true),
                    izmer_name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izmer", x => x.izmer_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "kassa",
                columns: table => new
                {
                    kassa_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    kassa_name = table.Column<string>(type: "nchar(50)", nullable: true),
                    shop_id = table.Column<int>(nullable: true),
                    team_viewer = table.Column<string>(type: "nchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kassa", x => x.kassa_id);
                });

            migrationBuilder.CreateTable(
                name: "kat",
                columns: table => new
                {
                    kat_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ext_kat_name = table.Column<string>(maxLength: 4000, nullable: true),
                    kat_image = table.Column<byte[]>(type: "image", nullable: true),
                    kat_name = table.Column<string>(maxLength: 50, nullable: true),
                    MacroGroupId = table.Column<string>(maxLength: 50, nullable: true),
                    PointsGeneratePercent = table.Column<double>(nullable: true),
                    top_kat = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kat", x => x.kat_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "key_list",
                columns: table => new
                {
                    key_list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    answer_key = table.Column<string>(maxLength: 255, nullable: true),
                    init_key = table.Column<string>(maxLength: 255, nullable: true),
                    reg_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_key_list", x => x.key_list_number);
                });

            migrationBuilder.CreateTable(
                name: "location_list",
                columns: table => new
                {
                    location_list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    accuracy = table.Column<double>(nullable: true),
                    agent_number = table.Column<int>(nullable: true),
                    correction_service = table.Column<string>(maxLength: 50, nullable: true),
                    device_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    longitude = table.Column<double>(nullable: true),
                    near_address = table.Column<string>(maxLength: 255, nullable: true),
                    near_address_latitude = table.Column<double>(nullable: true),
                    near_address_longitude = table.Column<double>(nullable: true),
                    provider = table.Column<string>(maxLength: 50, nullable: true),
                    server_time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location_list", x => x.location_list_number);
                });

            migrationBuilder.CreateTable(
                name: "MyConnString",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    catalog = table.Column<string>(type: "nchar(50)", nullable: false),
                    login = table.Column<string>(type: "nchar(50)", nullable: false),
                    pass = table.Column<string>(type: "nchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyConnString", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nakl_import_jrn",
                columns: table => new
                {
                    nakl_import_jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_nakl = table.Column<double>(nullable: false),
                    cena_nakl_dol = table.Column<double>(nullable: false),
                    ext_point1_name = table.Column<string>(nullable: false),
                    ext_point1_number = table.Column<int>(nullable: false),
                    ext_point2_name = table.Column<string>(nullable: false),
                    ext_point2_number = table.Column<int>(nullable: false),
                    ext_tovar_name = table.Column<string>(nullable: false),
                    ext_tovar_number = table.Column<int>(nullable: false),
                    kurs_nakl = table.Column<double>(nullable: false),
                    list_number = table.Column<int>(nullable: false),
                    nakl_number = table.Column<int>(nullable: false),
                    point1_number = table.Column<int>(nullable: false),
                    point2_number = table.Column<int>(nullable: false),
                    record_update_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    tovar_kol_nakl = table.Column<double>(nullable: false),
                    tovar_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nakl_import_jrn", x => x.nakl_import_jrn_number);
                });

            migrationBuilder.CreateTable(
                name: "nakl_prop_template",
                columns: table => new
                {
                    nakl_prop_template_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    default_template = table.Column<bool>(nullable: false),
                    nakl_type = table.Column<int>(nullable: true),
                    template_name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nakl_prop_template", x => x.nakl_prop_template_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "price_import_jrn",
                columns: table => new
                {
                    price_import_jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_price1 = table.Column<double>(nullable: false),
                    cena_price1_dol = table.Column<double>(nullable: false),
                    cena_price2 = table.Column<double>(nullable: false),
                    cena_price2_dol = table.Column<double>(nullable: false),
                    cena_price3 = table.Column<double>(nullable: false),
                    cena_price3_dol = table.Column<double>(nullable: false),
                    cena_price4 = table.Column<double>(nullable: false),
                    cena_price4_dol = table.Column<double>(nullable: false),
                    cena_price5 = table.Column<double>(nullable: false),
                    cena_price5_dol = table.Column<double>(nullable: false),
                    ext_tovar_name = table.Column<string>(nullable: false),
                    ext_tovar_number = table.Column<int>(nullable: false),
                    izmer_number = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    kat_number = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    point_number = table.Column<int>(nullable: false),
                    tovar_append = table.Column<bool>(nullable: false),
                    tovar_descrip = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    tovar_number = table.Column<int>(nullable: false),
                    tovar_present = table.Column<string>(maxLength: 30, nullable: false),
                    tovar_update_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price_import_jrn", x => x.price_import_jrn_number);
                });

            migrationBuilder.CreateTable(
                name: "recipe_list",
                columns: table => new
                {
                    recipe_list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(maxLength: 255, nullable: true),
                    kol = table.Column<double>(nullable: true),
                    recipe_number = table.Column<int>(nullable: true),
                    self_cost_percent = table.Column<double>(nullable: true),
                    tovar_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_list", x => x.recipe_list_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "route",
                columns: table => new
                {
                    route_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    distance = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route", x => x.route_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "sys_jrn",
                columns: table => new
                {
                    sys_jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    a_per_d = table.Column<bool>(nullable: false),
                    a_per_e = table.Column<bool>(nullable: false),
                    a_per_v = table.Column<bool>(nullable: false),
                    a_spis_d = table.Column<bool>(nullable: false),
                    a_spis_e = table.Column<bool>(nullable: false),
                    a_spis_v = table.Column<bool>(nullable: false),
                    admin = table.Column<bool>(nullable: false),
                    akt_number = table.Column<int>(nullable: true),
                    cli_zad = table.Column<bool>(nullable: false),
                    client_number = table.Column<int>(nullable: true),
                    comp_number = table.Column<string>(maxLength: 255, nullable: true),
                    date_doc = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_oper_base = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1))+CONVERT([datetime],CONVERT([varchar],getdate(),(14)),(14)))"),
                    date_oper_client = table.Column<DateTime>(type: "datetime", nullable: true),
                    jrn_number = table.Column<int>(nullable: true),
                    k_d = table.Column<bool>(nullable: false),
                    k_e = table.Column<bool>(nullable: false),
                    k_v = table.Column<bool>(nullable: false),
                    msg_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    nakl_number = table.Column<int>(nullable: true),
                    name_oper = table.Column<string>(maxLength: 255, nullable: true),
                    p_n_d = table.Column<bool>(nullable: false),
                    p_n_e = table.Column<bool>(nullable: false),
                    p_n_v = table.Column<bool>(nullable: false),
                    per_n_d = table.Column<bool>(nullable: false),
                    per_n_e = table.Column<bool>(nullable: false),
                    per_n_v = table.Column<bool>(nullable: false),
                    point_number = table.Column<int>(nullable: true),
                    r_n_d = table.Column<bool>(nullable: false),
                    r_n_e = table.Column<bool>(nullable: false),
                    r_n_v = table.Column<bool>(nullable: false),
                    reestr_number = table.Column<int>(nullable: true),
                    sprav = table.Column<bool>(nullable: false),
                    tovar_number = table.Column<int>(nullable: true),
                    user_name = table.Column<string>(maxLength: 255, nullable: true),
                    user_number = table.Column<int>(nullable: true),
                    user_passwd = table.Column<string>(maxLength: 255, nullable: true),
                    z_cli_d = table.Column<bool>(nullable: false),
                    z_cli_e = table.Column<bool>(nullable: false),
                    z_cli_v = table.Column<bool>(nullable: false),
                    z_firm_d = table.Column<bool>(nullable: false),
                    z_firm_e = table.Column<bool>(nullable: false),
                    z_firm_v = table.Column<bool>(nullable: false),
                    zad_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_jrn", x => x.sys_jrn_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "sys_jrn_ext",
                columns: table => new
                {
                    sys_jrn_number = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    msg_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    msg_text = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_jrn_ext", x => x.sys_jrn_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "tcu_par",
                columns: table => new
                {
                    param_name = table.Column<string>(maxLength: 50, nullable: false),
                    bool_value = table.Column<bool>(nullable: false),
                    double_value = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    long_value = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    param_type = table.Column<short>(nullable: true, defaultValueSql: "((0))"),
                    text_value = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tcu_par", x => x.param_name)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin = table.Column<bool>(nullable: false),
                    allow_purchase_kurs = table.Column<bool>(nullable: true),
                    allow_sales_kurs = table.Column<bool>(nullable: true),
                    articl_sprav = table.Column<bool>(nullable: false),
                    cash_report_access = table.Column<bool>(nullable: false),
                    change_date = table.Column<bool>(nullable: false),
                    cli_sprav = table.Column<bool>(nullable: false),
                    cli_zad = table.Column<bool>(nullable: false),
                    closed = table.Column<bool>(nullable: true),
                    days_backward = table.Column<int>(nullable: true),
                    days_forward = table.Column<int>(nullable: true),
                    max_discount = table.Column<double>(nullable: true),
                    negative_rests = table.Column<bool>(nullable: false),
                    point_sprav = table.Column<bool>(nullable: true),
                    r_l_approve = table.Column<bool>(nullable: false),
                    r_l_delete = table.Column<bool>(nullable: false),
                    r_l_edit = table.Column<bool>(nullable: false),
                    r_l_rollback = table.Column<bool>(nullable: false),
                    r_l_view = table.Column<bool>(nullable: false),
                    report_access = table.Column<bool>(nullable: true),
                    route_sprav = table.Column<bool>(nullable: false),
                    sale_more_purchase = table.Column<bool>(nullable: false),
                    settlements_access = table.Column<bool>(nullable: true),
                    sprav = table.Column<bool>(nullable: false),
                    tovar_sprav = table.Column<bool>(nullable: false),
                    user_fullname = table.Column<string>(maxLength: 255, nullable: true),
                    user_name = table.Column<string>(maxLength: 255, nullable: true),
                    user_passwd = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "user_rights",
                columns: table => new
                {
                    user_rights_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    point_number = table.Column<int>(nullable: true),
                    user_number = table.Column<int>(nullable: true),
                    _00approve = table.Column<bool>(name: "00approve", nullable: false),
                    _00delete = table.Column<bool>(name: "00delete", nullable: false),
                    _00edit = table.Column<bool>(name: "00edit", nullable: false),
                    _00rollback = table.Column<bool>(name: "00rollback", nullable: false),
                    _00view = table.Column<bool>(name: "00view", nullable: false),
                    _01approve = table.Column<bool>(name: "01approve", nullable: false),
                    _01delete = table.Column<bool>(name: "01delete", nullable: false),
                    _01edit = table.Column<bool>(name: "01edit", nullable: false),
                    _01rollback = table.Column<bool>(name: "01rollback", nullable: false),
                    _01view = table.Column<bool>(name: "01view", nullable: false),
                    _02approve = table.Column<bool>(name: "02approve", nullable: false),
                    _02delete = table.Column<bool>(name: "02delete", nullable: false),
                    _02edit = table.Column<bool>(name: "02edit", nullable: false),
                    _02rollback = table.Column<bool>(name: "02rollback", nullable: false),
                    _02view = table.Column<bool>(name: "02view", nullable: false),
                    _03approve = table.Column<bool>(name: "03approve", nullable: true),
                    _03delete = table.Column<bool>(name: "03delete", nullable: true),
                    _03edit = table.Column<bool>(name: "03edit", nullable: true),
                    _03rollback = table.Column<bool>(name: "03rollback", nullable: true),
                    _03view = table.Column<bool>(name: "03view", nullable: true),
                    _04approve = table.Column<bool>(name: "04approve", nullable: false),
                    _04delete = table.Column<bool>(name: "04delete", nullable: false),
                    _04edit = table.Column<bool>(name: "04edit", nullable: false),
                    _04rollback = table.Column<bool>(name: "04rollback", nullable: false),
                    _04view = table.Column<bool>(name: "04view", nullable: false),
                    _05approve = table.Column<bool>(name: "05approve", nullable: false),
                    _05delete = table.Column<bool>(name: "05delete", nullable: false),
                    _05edit = table.Column<bool>(name: "05edit", nullable: false),
                    _05rollback = table.Column<bool>(name: "05rollback", nullable: false),
                    _05view = table.Column<bool>(name: "05view", nullable: false),
                    _07approve = table.Column<bool>(name: "07approve", nullable: false),
                    _07delete = table.Column<bool>(name: "07delete", nullable: false),
                    _07edit = table.Column<bool>(name: "07edit", nullable: false),
                    _07rollback = table.Column<bool>(name: "07rollback", nullable: false),
                    _07view = table.Column<bool>(name: "07view", nullable: false),
                    _08approve = table.Column<bool>(name: "08approve", nullable: false),
                    _08delete = table.Column<bool>(name: "08delete", nullable: false),
                    _08edit = table.Column<bool>(name: "08edit", nullable: false),
                    _08rollback = table.Column<bool>(name: "08rollback", nullable: false),
                    _08view = table.Column<bool>(name: "08view", nullable: false),
                    _09approve = table.Column<bool>(name: "09approve", nullable: false),
                    _09delete = table.Column<bool>(name: "09delete", nullable: false),
                    _09edit = table.Column<bool>(name: "09edit", nullable: false),
                    _09rollback = table.Column<bool>(name: "09rollback", nullable: false),
                    _09view = table.Column<bool>(name: "09view", nullable: false),
                    _14approve = table.Column<bool>(name: "14approve", nullable: false),
                    _14delete = table.Column<bool>(name: "14delete", nullable: false),
                    _14edit = table.Column<bool>(name: "14edit", nullable: false),
                    _14rollback = table.Column<bool>(name: "14rollback", nullable: false),
                    _14view = table.Column<bool>(name: "14view", nullable: false),
                    _15approve = table.Column<bool>(name: "15approve", nullable: true),
                    _15delete = table.Column<bool>(name: "15delete", nullable: true),
                    _15edit = table.Column<bool>(name: "15edit", nullable: true),
                    _15rollback = table.Column<bool>(name: "15rollback", nullable: true),
                    _15view = table.Column<bool>(name: "15view", nullable: true),
                    _17approve = table.Column<bool>(name: "17approve", nullable: false),
                    _17delete = table.Column<bool>(name: "17delete", nullable: false),
                    _17edit = table.Column<bool>(name: "17edit", nullable: false),
                    _17rollback = table.Column<bool>(name: "17rollback", nullable: false),
                    _17view = table.Column<bool>(name: "17view", nullable: false),
                    _18approve = table.Column<bool>(name: "18approve", nullable: false),
                    _18delete = table.Column<bool>(name: "18delete", nullable: false),
                    _18edit = table.Column<bool>(name: "18edit", nullable: false),
                    _18rollback = table.Column<bool>(name: "18rollback", nullable: false),
                    _18view = table.Column<bool>(name: "18view", nullable: false),
                    _19approve = table.Column<bool>(name: "19approve", nullable: true),
                    _19delete = table.Column<bool>(name: "19delete", nullable: true),
                    _19edit = table.Column<bool>(name: "19edit", nullable: true),
                    _19rollback = table.Column<bool>(name: "19rollback", nullable: true),
                    _19view = table.Column<bool>(name: "19view", nullable: true),
                    _20approve = table.Column<bool>(name: "20approve", nullable: true),
                    _20delete = table.Column<bool>(name: "20delete", nullable: true),
                    _20edit = table.Column<bool>(name: "20edit", nullable: true),
                    _20rollback = table.Column<bool>(name: "20rollback", nullable: true),
                    _20view = table.Column<bool>(name: "20view", nullable: true),
                    _21approve = table.Column<bool>(name: "21approve", nullable: true),
                    _21delete = table.Column<bool>(name: "21delete", nullable: true),
                    _21edit = table.Column<bool>(name: "21edit", nullable: true),
                    _21rollback = table.Column<bool>(name: "21rollback", nullable: true),
                    _21view = table.Column<bool>(name: "21view", nullable: true),
                    _22approve = table.Column<bool>(name: "22approve", nullable: true),
                    _22delete = table.Column<bool>(name: "22delete", nullable: true),
                    _22edit = table.Column<bool>(name: "22edit", nullable: true),
                    _22rollback = table.Column<bool>(name: "22rollback", nullable: true),
                    _22view = table.Column<bool>(name: "22view", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_rights", x => x.user_rights_number)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "acc_trans_chema",
                columns: table => new
                {
                    acc_trans_chema_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    account1_number = table.Column<int>(nullable: true),
                    account2_number = table.Column<int>(nullable: true),
                    articl_number = table.Column<int>(nullable: true),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    percent = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acc_trans_chema", x => x.acc_trans_chema_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "acc_trans_chema_FK00",
                        column: x => x.articl_number,
                        principalTable: "articl",
                        principalColumn: "articl_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "point",
                columns: table => new
                {
                    point_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(maxLength: 255, nullable: true),
                    address_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    agent_cash_allow = table.Column<bool>(nullable: true),
                    agent_max_discount = table.Column<double>(nullable: true),
                    agent_only_selected_categories = table.Column<bool>(nullable: true),
                    agent_order_allow = table.Column<bool>(nullable: true),
                    agent_si_allow = table.Column<bool>(nullable: true),
                    agent_use_routes = table.Column<bool>(nullable: true),
                    arenda = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    bank_account = table.Column<string>(maxLength: 50, nullable: true),
                    BankClearingNumber = table.Column<string>(maxLength: 255, nullable: true),
                    bank_from_param = table.Column<bool>(nullable: false),
                    bank_name = table.Column<string>(maxLength: 255, nullable: true),
                    card_activated = table.Column<bool>(nullable: true),
                    card_number = table.Column<string>(maxLength: 20, nullable: true),
                    cash_point_number = table.Column<int>(nullable: true),
                    cli_group_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    CliGroupNumber1 = table.Column<int>(nullable: true),
                    client_kurs = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    closed = table.Column<bool>(nullable: false),
                    co_articl_number = table.Column<int>(nullable: true),
                    comm_agent = table.Column<bool>(nullable: true),
                    contact_person = table.Column<string>(maxLength: 255, nullable: true),
                    contract_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    contract_number = table.Column<string>(maxLength: 20, nullable: true),
                    contract_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    corr_account = table.Column<string>(maxLength: 32, nullable: true),
                    date_cli_zad = table.Column<double>(nullable: true),
                    DayZad = table.Column<int>(nullable: true),
                    DayZadOn = table.Column<bool>(nullable: false),
                    discount_card_percent = table.Column<double>(nullable: true),
                    discount_type = table.Column<int>(nullable: true),
                    driver = table.Column<bool>(nullable: false),
                    email = table.Column<string>(maxLength: 255, nullable: true),
                    ExportDocumentToFranchiseService = table.Column<bool>(nullable: true),
                    fax = table.Column<string>(maxLength: 255, nullable: true),
                    iban = table.Column<string>(maxLength: 255, nullable: true),
                    ind_num = table.Column<string>(maxLength: 50, nullable: true),
                    kpp = table.Column<string>(maxLength: 10, nullable: true),
                    kredit = table.Column<double>(nullable: true),
                    kredit_dol = table.Column<double>(nullable: true),
                    kredit_on = table.Column<bool>(nullable: false),
                    last_edit_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    licence_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    licence_number = table.Column<string>(maxLength: 255, nullable: true),
                    ma_otv_person = table.Column<string>(maxLength: 255, nullable: true),
                    ma_otv_person_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    mfo = table.Column<string>(maxLength: 50, nullable: true),
                    name_1_person = table.Column<string>(maxLength: 255, nullable: true),
                    name_1_person_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    name_1_person_fiscal_tax_id = table.Column<string>(maxLength: 50, nullable: true),
                    name_2_person = table.Column<string>(maxLength: 255, nullable: true),
                    name_2_person_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    name_2_person_fiscal_tax_id = table.Column<string>(maxLength: 50, nullable: true),
                    name_ceo_person = table.Column<string>(maxLength: 255, nullable: true),
                    name_firm = table.Column<string>(maxLength: 255, nullable: true),
                    name_firm_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    name_firm_from_param = table.Column<bool>(nullable: false),
                    name_firm_from_param_fiscal = table.Column<bool>(nullable: false),
                    name_point = table.Column<string>(maxLength: 255, nullable: false),
                    nds = table.Column<double>(nullable: true),
                    nds_payer = table.Column<bool>(nullable: true),
                    okpo = table.Column<string>(maxLength: 50, nullable: true),
                    path_to_mobile_synchro = table.Column<string>(maxLength: 255, nullable: true),
                    pis_articl_number = table.Column<int>(nullable: true),
                    point_comment = table.Column<string>(maxLength: 255, nullable: true),
                    point_type = table.Column<int>(nullable: true),
                    post = table.Column<bool>(nullable: false),
                    Postconto = table.Column<string>(maxLength: 255, nullable: true),
                    price_column_number = table.Column<int>(nullable: true),
                    prof_1_person = table.Column<string>(maxLength: 255, nullable: true),
                    prof_1_person_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    prof_2_person = table.Column<string>(maxLength: 255, nullable: true),
                    prof_2_person_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    realis = table.Column<bool>(nullable: false),
                    routes_by_dates = table.Column<bool>(nullable: true),
                    saldo = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    saldo_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    si_articl_number = table.Column<int>(nullable: true),
                    svid_num = table.Column<string>(maxLength: 50, nullable: true),
                    Swiftcode = table.Column<string>(maxLength: 255, nullable: true),
                    telefon = table.Column<string>(maxLength: 255, nullable: true),
                    telefon_fiscal = table.Column<string>(maxLength: 255, nullable: true),
                    transport_pr = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    waiter = table.Column<bool>(nullable: true),
                    zad_activate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_point", x => x.point_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_point_cli_group_cli_group_number",
                        column: x => x.cli_group_number,
                        principalTable: "cli_group",
                        principalColumn: "cli_group_number",
                        onDelete: ReferentialAction.Restrict);
                    //table.ForeignKey(
                    //    name: "FK_point_cli_group_CliGroupNumber1",
                    //    column: x => x.CliGroupNumber1,
                    //    principalTable: "cli_group",
                    //    principalColumn: "cli_group_number",
                    //    onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "kat_agent",
                columns: table => new
                {
                    kat_agent_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    kat_number = table.Column<int>(nullable: true),
                    point_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kat_agent", x => x.kat_agent_number);
                    table.ForeignKey(
                        name: "FK__kat_agent__kat_n__5E54FF49",
                        column: x => x.kat_number,
                        principalTable: "kat",
                        principalColumn: "kat_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tovar",
                columns: table => new
                {
                    tovar_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    all_kol = table.Column<bool>(nullable: false),
                    AnalyticCode = table.Column<string>(maxLength: 32, nullable: true),
                    articul = table.Column<string>(maxLength: 255, nullable: true),
                    balls = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn2 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn2_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn3 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn3_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn4 = table.Column<double>(nullable: true),
                    cena_rozn4_dol = table.Column<double>(nullable: true),
                    cena_rozn5 = table.Column<double>(nullable: true),
                    cena_rozn5_dol = table.Column<double>(nullable: true),
                    cena_rozn_sprav = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn_sprav_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cert_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    certificate = table.Column<string>(maxLength: 20, nullable: true),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    discount_calc_on1 = table.Column<bool>(nullable: true),
                    discount_calc_on2 = table.Column<bool>(nullable: true),
                    discount_calc_on3 = table.Column<bool>(nullable: true),
                    discount_calc_on4 = table.Column<bool>(nullable: true),
                    discount_calc_on5 = table.Column<bool>(nullable: true),
                    discount_limitation = table.Column<double>(nullable: true),
                    discount_markup = table.Column<bool>(nullable: true),
                    discount_percent1 = table.Column<double>(nullable: true),
                    discount_percent2 = table.Column<double>(nullable: true),
                    discount_percent3 = table.Column<double>(nullable: true),
                    discount_percent4 = table.Column<double>(nullable: true),
                    discount_percent5 = table.Column<double>(nullable: true),
                    fiscal_group_number = table.Column<int>(nullable: true),
                    franch_top_id = table.Column<int>(nullable: true),
                    image1 = table.Column<byte[]>(type: "image", nullable: true),
                    image1_cash = table.Column<byte[]>(type: "image", nullable: true),
                    izmer_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    kat_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    kol_default = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_in_pak = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_linked1 = table.Column<double>(nullable: true),
                    kol_linked2 = table.Column<double>(nullable: true),
                    kol_min1 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_min2 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_osn1 = table.Column<double>(nullable: true),
                    kol_osn2 = table.Column<double>(nullable: true),
                    last_cena_opt = table.Column<double>(nullable: true),
                    last_cena_opt_dol = table.Column<double>(nullable: true),
                    last_edit_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    objem = table.Column<double>(nullable: true),
                    perc_skid1 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    perc_skid2 = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    produced_by = table.Column<string>(maxLength: 255, nullable: true),
                    product = table.Column<bool>(nullable: false),
                    purchase_period = table.Column<int>(nullable: true),
                    round_to1 = table.Column<int>(nullable: true),
                    round_to2 = table.Column<int>(nullable: true),
                    round_to3 = table.Column<int>(nullable: true),
                    round_to4 = table.Column<int>(nullable: true),
                    round_to5 = table.Column<int>(nullable: true),
                    serial_number_check = table.Column<bool>(nullable: false),
                    spare_factor = table.Column<double>(nullable: true),
                    st_dost = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    st_dost_alg = table.Column<bool>(nullable: false),
                    st_dost_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    tara = table.Column<bool>(nullable: false),
                    tara1_number = table.Column<int>(nullable: true),
                    tara1_round = table.Column<bool>(nullable: true),
                    tara2_number = table.Column<int>(nullable: true),
                    tara2_round = table.Column<bool>(nullable: true),
                    tare1_check = table.Column<bool>(nullable: false),
                    tare2_check = table.Column<bool>(nullable: false),
                    tov_closed = table.Column<bool>(nullable: false),
                    tov_description = table.Column<string>(maxLength: 4000, nullable: true),
                    tov_picture = table.Column<string>(maxLength: 255, nullable: true),
                    tovar_backcolor = table.Column<int>(nullable: true),
                    tovar_font_bold = table.Column<bool>(nullable: false),
                    tovar_font_italic = table.Column<bool>(nullable: false),
                    tovar_font_name = table.Column<string>(maxLength: 127, nullable: true),
                    tovar_font_size = table.Column<int>(nullable: true),
                    tovar_forecolor = table.Column<int>(nullable: true),
                    tovar_kod = table.Column<string>(maxLength: 50, nullable: true),
                    tovar_name = table.Column<string>(maxLength: 250, nullable: false),
                    tovar_type = table.Column<int>(nullable: true),
                    UKTZED_code = table.Column<string>(maxLength: 255, nullable: true),
                    uni_number = table.Column<string>(maxLength: 50, nullable: true),
                    use_cert = table.Column<bool>(nullable: true),
                    ves = table.Column<double>(nullable: true),
                    video_hyperlink = table.Column<string>(maxLength: 4000, nullable: true),
                    warranty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tovar", x => x.tovar_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "tovar_FK01",
                        column: x => x.izmer_number,
                        principalTable: "izmer",
                        principalColumn: "izmer_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "tovar_FK00",
                        column: x => x.kat_number,
                        principalTable: "kat",
                        principalColumn: "kat_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "route_agent",
                columns: table => new
                {
                    route_agent_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date_of_route = table.Column<DateTime>(type: "datetime", nullable: true),
                    day_of_route = table.Column<int>(nullable: true),
                    point_number = table.Column<int>(nullable: true),
                    route_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route_agent", x => x.route_agent_number);
                    table.ForeignKey(
                        name: "FK__route_age__route__4C364F0E",
                        column: x => x.route_number,
                        principalTable: "route",
                        principalColumn: "route_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "delive_point",
                columns: table => new
                {
                    delive_point_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    delive_address = table.Column<string>(maxLength: 255, nullable: true),
                    delive_point_name = table.Column<string>(maxLength: 255, nullable: true),
                    district = table.Column<string>(maxLength: 255, nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    longitude = table.Column<double>(nullable: true),
                    point_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delive_point", x => x.delive_point_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "delive_point_FK00",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "discount_rules",
                columns: table => new
                {
                    discount_rules_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    discount_percent = table.Column<double>(nullable: true),
                    fact_sale_sum = table.Column<double>(nullable: true),
                    fact_sale_sum_dol = table.Column<double>(nullable: true),
                    point_number = table.Column<int>(nullable: true),
                    sales_period = table.Column<int>(nullable: true),
                    sales_sum = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discount_rules", x => x.discount_rules_number);
                    table.ForeignKey(
                        name: "FK__discount___point__6319B466",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ext_point",
                columns: table => new
                {
                    ext_point_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ext_point_name = table.Column<string>(nullable: false),
                    point_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ext_point", x => x.ext_point_number);
                    table.ForeignKey(
                        name: "FK__ext_point__point__59904A2C",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ext_shablon",
                columns: table => new
                {
                    ext_shablon_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_price1_dol_position = table.Column<int>(nullable: false),
                    cena_price1_position = table.Column<int>(nullable: false),
                    cena_price2_dol_position = table.Column<int>(nullable: false),
                    cena_price2_position = table.Column<int>(nullable: false),
                    cena_price3_dol_position = table.Column<int>(nullable: false),
                    cena_price3_position = table.Column<int>(nullable: false),
                    cena_price4_dol_position = table.Column<int>(nullable: false),
                    cena_price4_position = table.Column<int>(nullable: false),
                    cena_price5_dol_position = table.Column<int>(nullable: false),
                    cena_price5_position = table.Column<int>(nullable: false),
                    is_split = table.Column<int>(nullable: false),
                    point_number = table.Column<int>(nullable: false),
                    shablon_name = table.Column<string>(maxLength: 50, nullable: true),
                    split_step = table.Column<int>(nullable: false),
                    tovar_descrip_position = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    tovar_name_position = table.Column<int>(nullable: false),
                    tovar_present_position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ext_shablon", x => x.ext_shablon_number);
                    table.ForeignKey(
                        name: "FK__ext_shabl__point__54CB950F",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "manager",
                columns: table => new
                {
                    manager_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    manager_name = table.Column<string>(type: "nchar(50)", nullable: false),
                    manager_telephone = table.Column<string>(type: "nchar(20)", nullable: true),
                    point_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manager", x => x.manager_number);
                    table.ForeignKey(
                        name: "FK_manager_point",
                        column: x => x.point_id,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nakl",
                columns: table => new
                {
                    nakl_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    agent_number = table.Column<int>(nullable: true),
                    articl_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    auto_payment = table.Column<bool>(nullable: true),
                    BonusPaid = table.Column<double>(nullable: true),
                    bundle_nakl_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn_select = table.Column<int>(nullable: true),
                    check_point = table.Column<short>(nullable: true),
                    client_discount = table.Column<double>(nullable: true),
                    date_franch_upload = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_nakl = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_utv = table.Column<DateTime>(type: "datetime", nullable: true),
                    delive_point_number = table.Column<int>(nullable: true),
                    delivery_condition = table.Column<string>(maxLength: 255, nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    doc_number = table.Column<string>(maxLength: 50, nullable: true),
                    DocStanId = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    DocumentGuid = table.Column<Guid>(nullable: true),
                    dov_number = table.Column<string>(maxLength: 32, nullable: true),
                    fiscal_document = table.Column<bool>(nullable: false),
                    fiscal_number = table.Column<string>(maxLength: 255, nullable: true),
                    flag = table.Column<short>(nullable: true, defaultValueSql: "((0))"),
                    kurs = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    MaterialReq = table.Column<string>(maxLength: 50, nullable: true),
                    ModeOfShipment = table.Column<string>(maxLength: 50, nullable: true),
                    nakl_prop_template_number = table.Column<int>(nullable: true),
                    nakl_rash = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    nakl_rash_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    nakl_rash_me = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    nakl_rash_me_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    nakl_type = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    order_rezerved = table.Column<bool>(nullable: true),
                    osn = table.Column<string>(maxLength: 255, nullable: true),
                    perc_skid = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    point1_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    point2_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    post_number = table.Column<string>(maxLength: 50, nullable: true),
                    prim = table.Column<string>(maxLength: 255, nullable: true),
                    print_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    r_dol = table.Column<bool>(nullable: false),
                    rash_prih = table.Column<bool>(nullable: false),
                    recipe_number = table.Column<int>(nullable: true),
                    @return = table.Column<bool>(name: "return", nullable: false),
                    RFQ = table.Column<string>(maxLength: 50, nullable: true),
                    route_list_number = table.Column<int>(nullable: true),
                    route_number = table.Column<int>(nullable: true),
                    SoAndProject = table.Column<string>(maxLength: 50, nullable: true),
                    source_number = table.Column<int>(nullable: true),
                    sum_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_opl = table.Column<double>(nullable: true),
                    sum_opl_dol = table.Column<double>(nullable: true),
                    sum_opt = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_opt_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_rozn = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_tara = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_tara_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_volume = table.Column<double>(nullable: true),
                    sum_vzr = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_vzr_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_weight = table.Column<double>(nullable: true),
                    SupplierRef = table.Column<string>(maxLength: 50, nullable: true),
                    sys_kurs = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    TopDocumentGuid = table.Column<Guid>(nullable: true),
                    user_number = table.Column<int>(nullable: true),
                    utv = table.Column<bool>(nullable: false),
                    vid_plat = table.Column<string>(maxLength: 80, nullable: true),
                    view_add_prop = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nakl", x => x.nakl_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_nakl_DocStan",
                        column: x => x.DocStanId,
                        principalTable: "DocStan",
                        principalColumn: "DocStanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nakl_point",
                        column: x => x.point1_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nakl_point1",
                        column: x => x.point2_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "point_agent",
                columns: table => new
                {
                    point_agent_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    agent_number = table.Column<int>(nullable: true),
                    point_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_point_agent", x => x.point_agent_number);
                    table.ForeignKey(
                        name: "FK__point_age__agent__55BFB948",
                        column: x => x.agent_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "route_list",
                columns: table => new
                {
                    route_list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    car_number = table.Column<int>(nullable: true),
                    date_utv = table.Column<DateTime>(type: "datetime", nullable: true),
                    distance = table.Column<double>(nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    expeditor_number = table.Column<int>(nullable: true),
                    osn = table.Column<string>(maxLength: 255, nullable: true),
                    route_number = table.Column<int>(nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    sum_dol = table.Column<double>(nullable: true),
                    sum_rozn = table.Column<double>(nullable: true),
                    utv = table.Column<bool>(nullable: false),
                    volume = table.Column<double>(nullable: true),
                    weight = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route_list", x => x.route_list_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "route_list_FK00",
                        column: x => x.car_number,
                        principalTable: "car",
                        principalColumn: "car_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "route_list_FK01",
                        column: x => x.expeditor_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "route_list_FK02",
                        column: x => x.route_number,
                        principalTable: "route",
                        principalColumn: "route_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "service",
                columns: table => new
                {
                    service_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comment = table.Column<string>(type: "nchar(50)", nullable: true),
                    kassa_id = table.Column<int>(nullable: false),
                    point_id = table.Column<int>(nullable: true),
                    service_date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service", x => x.service_id);
                    table.ForeignKey(
                        name: "FK_service_kassa",
                        column: x => x.kassa_id,
                        principalTable: "kassa",
                        principalColumn: "kassa_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_service_point",
                        column: x => x.point_id,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ext_tovar",
                columns: table => new
                {
                    ext_tovar_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ext_kat_number = table.Column<int>(nullable: false),
                    ext_tovar_name = table.Column<string>(nullable: false),
                    point_number = table.Column<int>(nullable: false),
                    price_or_nakl = table.Column<bool>(nullable: false),
                    tovar_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ext_tovar", x => x.ext_tovar_number);
                    table.ForeignKey(
                        name: "FK__ext_tovar__point__51EF2864",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ext_tovar__tovar__52E34C9D",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "kassa_tovar",
                columns: table => new
                {
                    kassa_id = table.Column<int>(nullable: false),
                    tovar_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kassa_tovar", x => new { x.kassa_id, x.tovar_id });
                    table.ForeignKey(
                        name: "FK_kassa_tovar_kassa",
                        column: x => x.kassa_id,
                        principalTable: "kassa",
                        principalColumn: "kassa_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kassa_tovar_tovar",
                        column: x => x.tovar_id,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdersRedirection",
                columns: table => new
                {
                    OrdersRedirection_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    point_number = table.Column<int>(nullable: true),
                    restaurant_number = table.Column<int>(nullable: true),
                    tovar_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersRedirection", x => x.OrdersRedirection_number);
                    table.ForeignKey(
                        name: "FK__OrdersRed__point__6BAEFA67",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OrdersRed__resta__6ABAD62E",
                        column: x => x.restaurant_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OrdersRed__tovar__6CA31EA0",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    recipe_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<bool>(nullable: false),
                    closed = table.Column<bool>(nullable: false),
                    description = table.Column<string>(maxLength: 255, nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    exit_prod = table.Column<double>(nullable: true),
                    self_cost = table.Column<double>(nullable: true),
                    self_cost_dol = table.Column<double>(nullable: true),
                    size = table.Column<double>(nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    tovar_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.recipe_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "recipe_FK00",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reestr",
                columns: table => new
                {
                    reestr_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    kol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_min = table.Column<double>(nullable: true),
                    kol_rezerv = table.Column<double>(nullable: true),
                    last_edit_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    point_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    post_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    rezerv1 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv2 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv3 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv4 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv5 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv6 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv7 = table.Column<string>(maxLength: 128, nullable: true),
                    rezerv8 = table.Column<string>(maxLength: 128, nullable: true),
                    tovar_number = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reestr", x => x.reestr_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "reestr_FK00",
                        column: x => x.point_number,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "reestr_FK01",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tovar_code",
                columns: table => new
                {
                    tovar_code_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    chk_disable = table.Column<bool>(nullable: false),
                    closed = table.Column<bool>(nullable: false),
                    tovar_bar_code = table.Column<string>(maxLength: 255, nullable: true),
                    tovar_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tovar_code", x => x.tovar_code_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "tovar_code_FK00",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "route_point",
                columns: table => new
                {
                    route_point_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    delive_point_number = table.Column<int>(nullable: true),
                    return_distance = table.Column<double>(nullable: true),
                    route_number = table.Column<int>(nullable: true),
                    sort_number = table.Column<int>(nullable: true),
                    up_point_distance = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route_point", x => x.route_point_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "route_point_FK00",
                        column: x => x.delive_point_number,
                        principalTable: "delive_point",
                        principalColumn: "delive_point_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "route_point_FK01",
                        column: x => x.route_number,
                        principalTable: "route",
                        principalColumn: "route_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shop",
                columns: table => new
                {
                    shop_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    adress = table.Column<string>(type: "nchar(50)", nullable: true),
                    manager_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "nchar(50)", nullable: true),
                    point_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop", x => x.shop_number);
                    table.ForeignKey(
                        name: "FK_shop_manager",
                        column: x => x.manager_id,
                        principalTable: "manager",
                        principalColumn: "manager_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shop_point",
                        column: x => x.point_id,
                        principalTable: "point",
                        principalColumn: "point_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jrn_opl",
                columns: table => new
                {
                    jrn_opl_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date_opl = table.Column<DateTime>(type: "datetime", nullable: true),
                    nakl1_number = table.Column<int>(nullable: true),
                    nakl2_number = table.Column<int>(nullable: true),
                    nakl_type = table.Column<int>(nullable: true),
                    sum_opl = table.Column<double>(nullable: true),
                    sum_opl_dol = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jrn_opl", x => x.jrn_opl_number);
                    table.ForeignKey(
                        name: "FK__jrn_opl__nakl1_n__43A1090D",
                        column: x => x.nakl1_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__jrn_opl__nakl2_n__44952D46",
                        column: x => x.nakl2_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "list",
                columns: table => new
                {
                    list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_dol_after = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt_after = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt_dol_after = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn_after = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_zak = table.Column<double>(nullable: true),
                    cena_zak_dol = table.Column<double>(nullable: true),
                    comment = table.Column<string>(maxLength: 255, nullable: true),
                    cust_decl_number = table.Column<string>(maxLength: 100, nullable: true),
                    kol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_add = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_after = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_current = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_in_pak = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kol_pak = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    list_prih_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    list_zakaz_number = table.Column<int>(nullable: true),
                    nakl_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    new_rest = table.Column<double>(nullable: true),
                    perc_skid = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    product = table.Column<bool>(nullable: true),
                    recipe_number = table.Column<int>(nullable: true),
                    reestr2_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    reestr_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    rez_list1 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list2 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list3 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list4 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list5 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list6 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list7 = table.Column<string>(maxLength: 128, nullable: true),
                    rez_list8 = table.Column<string>(maxLength: 128, nullable: true),
                    serial_number = table.Column<string>(maxLength: 255, nullable: true),
                    sum_skid = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    sum_skid_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    tara = table.Column<bool>(nullable: false),
                    tovar_code_number = table.Column<int>(nullable: true),
                    tovar_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    volume = table.Column<double>(nullable: true),
                    weight = table.Column<double>(nullable: true),
                    zakazlist_number = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_list", x => x.list_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_list_nakl",
                        column: x => x.nakl_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_list_tovar",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarketingActionRecords",
                columns: table => new
                {
                    MarketingActionRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MarketingActionId = table.Column<int>(nullable: true),
                    MarketingToolId = table.Column<int>(nullable: true),
                    nakl_number = table.Column<int>(nullable: true),
                    PresentedPoints = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingActionRecords", x => x.MarketingActionRecordId);
                    table.ForeignKey(
                        name: "FK__Marketing__nakl___725BF7F6",
                        column: x => x.nakl_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nakl_prop",
                columns: table => new
                {
                    nakl_prop_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nakl_number = table.Column<int>(nullable: true),
                    property_name = table.Column<string>(maxLength: 255, nullable: true),
                    property_value = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nakl_prop", x => x.nakl_prop_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "nakl_prop_FK00",
                        column: x => x.nakl_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "order_ext",
                columns: table => new
                {
                    order_ext_number = table.Column<int>(nullable: false),
                    calc_alg = table.Column<int>(nullable: true),
                    end_date_purchase = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_date_sales = table.Column<DateTime>(type: "datetime", nullable: true),
                    goods_transfer_include = table.Column<bool>(nullable: true),
                    only_this_supplier = table.Column<bool>(nullable: true),
                    round_combo = table.Column<int>(nullable: true),
                    sale_analasys = table.Column<int>(nullable: true),
                    spare_factor = table.Column<double>(nullable: true),
                    start_date_purchase = table.Column<DateTime>(type: "datetime", nullable: true),
                    start_date_sales = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_ext", x => x.order_ext_number);
                    table.ForeignKey(
                        name: "FK__order_ext__order__67DE6983",
                        column: x => x.order_ext_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PriceShields",
                columns: table => new
                {
                    PriceShieldsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_dol = table.Column<double>(nullable: true),
                    cena_rozn = table.Column<double>(nullable: true),
                    nakl_number = table.Column<int>(nullable: true),
                    tovar_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceShields", x => x.PriceShieldsId);
                    table.ForeignKey(
                        name: "FK__PriceShie__nakl___567ED357",
                        column: x => x.nakl_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PriceShie__tovar__558AAF1E",
                        column: x => x.tovar_number,
                        principalTable: "tovar",
                        principalColumn: "tovar_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "route_nakl_list",
                columns: table => new
                {
                    route_nakl_list_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nakl_number = table.Column<int>(nullable: true),
                    route_list_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route_nakl_list", x => x.route_nakl_list_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "route_nakl_list_FK01",
                        column: x => x.nakl_number,
                        principalTable: "nakl",
                        principalColumn: "nakl_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "route_nakl_list_FK00",
                        column: x => x.route_list_number,
                        principalTable: "route_list",
                        principalColumn: "route_list_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jrn",
                columns: table => new
                {
                    jrn_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cena_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_opt_dol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    cena_rozn = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    date_move = table.Column<DateTime>(type: "datetime", nullable: true),
                    fiscal_document = table.Column<bool>(nullable: false),
                    kol = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    kurs = table.Column<double>(nullable: true, defaultValueSql: "((0))"),
                    list_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    list_prih_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    nakl_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    nakl_prih_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    nakl_type = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    rash_prih = table.Column<bool>(nullable: false),
                    reestr2_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    reestr_number = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    serial_number = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jrn", x => x.jrn_number)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_jrn_list",
                        column: x => x.list_number,
                        principalTable: "list",
                        principalColumn: "list_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jrn_reestr",
                        column: x => x.reestr_number,
                        principalTable: "reestr",
                        principalColumn: "reestr_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jrn_rezerv",
                columns: table => new
                {
                    jrn_rezerv_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    kol_rezerv = table.Column<double>(nullable: true),
                    list_number = table.Column<int>(nullable: true),
                    list_rezerv_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jrn_rezerv", x => x.jrn_rezerv_number);
                    table.ForeignKey(
                        name: "FK__jrn_rezer__list___5A846E65",
                        column: x => x.list_number,
                        principalTable: "list",
                        principalColumn: "list_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__jrn_rezer__list___5B78929E",
                        column: x => x.list_rezerv_number,
                        principalTable: "list",
                        principalColumn: "list_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "articl_trans_rel",
                table: "acc_trans_chema",
                column: "articl_number");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cash_text",
                table: "cash_table",
                column: "cash_text");

            migrationBuilder.CreateIndex(
                name: "field_name",
                table: "cash_table",
                column: "field_name");

            migrationBuilder.CreateIndex(
                name: "form_name",
                table: "cash_table",
                column: "form_name");

            migrationBuilder.CreateIndex(
                name: "lng_number",
                table: "cash_table",
                column: "lng_number");

            migrationBuilder.CreateIndex(
                name: "delive_point_rel",
                table: "delive_point",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_discount_rules_point_number",
                table: "discount_rules",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_ext_point_point_number",
                table: "ext_point",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_ext_shablon_point_number",
                table: "ext_shablon",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_ext_tovar_point_number",
                table: "ext_tovar",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_ext_tovar_tovar_number",
                table: "ext_tovar",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "date_move",
                table: "jrn",
                column: "date_move");

            migrationBuilder.CreateIndex(
                name: "jrnlist_number",
                table: "jrn",
                column: "list_number");

            migrationBuilder.CreateIndex(
                name: "list_prih_number",
                table: "jrn",
                column: "list_prih_number");

            migrationBuilder.CreateIndex(
                name: "nakl_number",
                table: "jrn",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "nakl_type",
                table: "jrn",
                column: "nakl_type");

            migrationBuilder.CreateIndex(
                name: "rash_prih",
                table: "jrn",
                column: "rash_prih");

            migrationBuilder.CreateIndex(
                name: "reestr2_number",
                table: "jrn",
                column: "reestr2_number");

            migrationBuilder.CreateIndex(
                name: "reestrjrn",
                table: "jrn",
                column: "reestr_number");

            migrationBuilder.CreateIndex(
                name: "IX_jrn_opl_nakl1_number",
                table: "jrn_opl",
                column: "nakl1_number");

            migrationBuilder.CreateIndex(
                name: "IX_jrn_opl_nakl2_number_date_opl",
                table: "jrn_opl",
                columns: new[] { "nakl2_number", "date_opl" });

            migrationBuilder.CreateIndex(
                name: "IX_jrn_rezerv_list_number",
                table: "jrn_rezerv",
                column: "list_number");

            migrationBuilder.CreateIndex(
                name: "IX_jrn_rezerv_list_rezerv_number",
                table: "jrn_rezerv",
                column: "list_rezerv_number");

            migrationBuilder.CreateIndex(
                name: "IX_kassa_tovar_tovar_id",
                table: "kassa_tovar",
                column: "tovar_id");

            migrationBuilder.CreateIndex(
                name: "kat_name",
                table: "kat",
                columns: new[] { "kat_name", "top_kat" },
                unique: true,
                filter: "[kat_name] IS NOT NULL AND [top_kat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_kat_agent_kat_number",
                table: "kat_agent",
                column: "kat_number");

            migrationBuilder.CreateIndex(
                name: "list_prih_number",
                table: "list",
                column: "list_prih_number");

            migrationBuilder.CreateIndex(
                name: "nakllist",
                table: "list",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "listreestr_number",
                table: "list",
                column: "reestr_number");

            migrationBuilder.CreateIndex(
                name: "rez_list1",
                table: "list",
                column: "rez_list1");

            migrationBuilder.CreateIndex(
                name: "rez_list2",
                table: "list",
                column: "rez_list2");

            migrationBuilder.CreateIndex(
                name: "rez_list3",
                table: "list",
                column: "rez_list3");

            migrationBuilder.CreateIndex(
                name: "rez_list4",
                table: "list",
                column: "rez_list4");

            migrationBuilder.CreateIndex(
                name: "rez_list5",
                table: "list",
                column: "rez_list5");

            migrationBuilder.CreateIndex(
                name: "rez_list6",
                table: "list",
                column: "rez_list6");

            migrationBuilder.CreateIndex(
                name: "rez_list7",
                table: "list",
                column: "rez_list7");

            migrationBuilder.CreateIndex(
                name: "rez_list8",
                table: "list",
                column: "rez_list8");

            migrationBuilder.CreateIndex(
                name: "tovarlist",
                table: "list",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "zakazlist_number",
                table: "list",
                column: "zakazlist_number");

            migrationBuilder.CreateIndex(
                name: "IX_list_kol_reestr",
                table: "list",
                columns: new[] { "kol_current", "reestr_number", "reestr2_number" });

            migrationBuilder.CreateIndex(
                name: "IX_manager_point_id",
                table: "manager",
                column: "point_id");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingActionRecords_nakl_number",
                table: "MarketingActionRecords",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "articl_number",
                table: "nakl",
                column: "articl_number");

            migrationBuilder.CreateIndex(
                name: "bundle_nakl_number",
                table: "nakl",
                column: "bundle_nakl_number");

            migrationBuilder.CreateIndex(
                name: "date_utv",
                table: "nakl",
                column: "date_utv");

            migrationBuilder.CreateIndex(
                name: "doc_number",
                table: "nakl",
                column: "doc_number");

            migrationBuilder.CreateIndex(
                name: "IX_nakl_DocStanId",
                table: "nakl",
                column: "DocStanId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentGuid",
                table: "nakl",
                column: "DocumentGuid");

            migrationBuilder.CreateIndex(
                name: "nakl_type",
                table: "nakl",
                column: "nakl_type");

            migrationBuilder.CreateIndex(
                name: "pointnakl",
                table: "nakl",
                column: "point1_number");

            migrationBuilder.CreateIndex(
                name: "pointnakl1",
                table: "nakl",
                column: "point2_number");

            migrationBuilder.CreateIndex(
                name: "IX_nakl_nakl_type_utv_nakl_number",
                table: "nakl",
                columns: new[] { "nakl_number", "nakl_type", "utv" });

            migrationBuilder.CreateIndex(
                name: "check_point_index",
                table: "nakl",
                columns: new[] { "nakl_number", "date_utv", "point1_number", "check_point" });

            migrationBuilder.CreateIndex(
                name: "IX_nakl_sum_vzr",
                table: "nakl",
                columns: new[] { "rash_prih", "sum_vzr", "point2_number", "date_utv", "utv" });

            migrationBuilder.CreateIndex(
                name: "IX_nakl_sum_vzr_dol",
                table: "nakl",
                columns: new[] { "rash_prih", "sum_vzr_dol", "point2_number", "date_utv", "utv" });

            migrationBuilder.CreateIndex(
                name: "nakl_prop_rel",
                table: "nakl_prop",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersRedirection_point_number",
                table: "OrdersRedirection",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersRedirection_restaurant_number",
                table: "OrdersRedirection",
                column: "restaurant_number");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersRedirection_tovar_number",
                table: "OrdersRedirection",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "cli_group_number",
                table: "point",
                column: "cli_group_number");

            migrationBuilder.CreateIndex(
                name: "IX_point_CliGroupNumber1",
                table: "point",
                column: "CliGroupNumber1");

            migrationBuilder.CreateIndex(
                name: "name_point1",
                table: "point",
                column: "name_point");

            migrationBuilder.CreateIndex(
                name: "IX_point_agent_agent_number",
                table: "point_agent",
                column: "agent_number");

            migrationBuilder.CreateIndex(
                name: "IX_PriceShields_nakl_number",
                table: "PriceShields",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "IX_PriceShields_tovar_number",
                table: "PriceShields",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "recipe_rel",
                table: "recipe",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "recipe_list_rel",
                table: "recipe_list",
                column: "recipe_number");

            migrationBuilder.CreateIndex(
                name: "recipe_list_tovar_rel",
                table: "recipe_list",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "cena_dol",
                table: "reestr",
                column: "cena_dol");

            migrationBuilder.CreateIndex(
                name: "cena_rozn",
                table: "reestr",
                column: "cena_rozn");

            migrationBuilder.CreateIndex(
                name: "kol",
                table: "reestr",
                column: "kol");

            migrationBuilder.CreateIndex(
                name: "pointreestr",
                table: "reestr",
                column: "point_number");

            migrationBuilder.CreateIndex(
                name: "post_number",
                table: "reestr",
                column: "post_number");

            migrationBuilder.CreateIndex(
                name: "rezerv1",
                table: "reestr",
                column: "rezerv1");

            migrationBuilder.CreateIndex(
                name: "rezerv2",
                table: "reestr",
                column: "rezerv2");

            migrationBuilder.CreateIndex(
                name: "rezerv3",
                table: "reestr",
                column: "rezerv3");

            migrationBuilder.CreateIndex(
                name: "rezerv4",
                table: "reestr",
                column: "rezerv4");

            migrationBuilder.CreateIndex(
                name: "rezerv5",
                table: "reestr",
                column: "rezerv5");

            migrationBuilder.CreateIndex(
                name: "rezerv6",
                table: "reestr",
                column: "rezerv6");

            migrationBuilder.CreateIndex(
                name: "rezerv7",
                table: "reestr",
                column: "rezerv7");

            migrationBuilder.CreateIndex(
                name: "rezerv8",
                table: "reestr",
                column: "rezerv8");

            migrationBuilder.CreateIndex(
                name: "tovarreestr",
                table: "reestr",
                column: "tovar_number");

            migrationBuilder.CreateIndex(
                name: "IX_route_agent_route_number",
                table: "route_agent",
                column: "route_number");

            migrationBuilder.CreateIndex(
                name: "car_rel",
                table: "route_list",
                column: "car_number");

            migrationBuilder.CreateIndex(
                name: "expeditor_rel",
                table: "route_list",
                column: "expeditor_number");

            migrationBuilder.CreateIndex(
                name: "route_list_rel",
                table: "route_list",
                column: "route_number");

            migrationBuilder.CreateIndex(
                name: "route_nakl_rel",
                table: "route_nakl_list",
                column: "nakl_number");

            migrationBuilder.CreateIndex(
                name: "route_nakl_list_rel",
                table: "route_nakl_list",
                column: "route_list_number");

            migrationBuilder.CreateIndex(
                name: "route_point_rel",
                table: "route_point",
                column: "delive_point_number");

            migrationBuilder.CreateIndex(
                name: "route_rel",
                table: "route_point",
                column: "route_number");

            migrationBuilder.CreateIndex(
                name: "IX_service_kassa_id",
                table: "service",
                column: "kassa_id");

            migrationBuilder.CreateIndex(
                name: "IX_service_point_id",
                table: "service",
                column: "point_id");

            migrationBuilder.CreateIndex(
                name: "IX_shop_manager_id",
                table: "shop",
                column: "manager_id");

            migrationBuilder.CreateIndex(
                name: "IX_shop_point_id",
                table: "shop",
                column: "point_id");

            migrationBuilder.CreateIndex(
                name: "msg_number",
                table: "sys_jrn",
                column: "msg_number");

            migrationBuilder.CreateIndex(
                name: "balls",
                table: "tovar",
                column: "balls");

            migrationBuilder.CreateIndex(
                name: "izmer_number",
                table: "tovar",
                column: "izmer_number");

            migrationBuilder.CreateIndex(
                name: "kat_number",
                table: "tovar",
                column: "kat_number");

            migrationBuilder.CreateIndex(
                name: "tovar_name",
                table: "tovar",
                column: "tovar_name");

            migrationBuilder.CreateIndex(
                name: "tovar_and_kat",
                table: "tovar",
                columns: new[] { "tovar_name", "kat_number" },
                unique: true,
                filter: "[kat_number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "tovartovar_code",
                table: "tovar_code",
                column: "tovar_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acc_trans_chema");

            migrationBuilder.DropTable(
                name: "acc_trans_jrn");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "account_plan");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "cash_table");

            migrationBuilder.DropTable(
                name: "discount_rules");

            migrationBuilder.DropTable(
                name: "ext_point");

            migrationBuilder.DropTable(
                name: "ext_shablon");

            migrationBuilder.DropTable(
                name: "ext_tovar");

            migrationBuilder.DropTable(
                name: "in_out_jrn");

            migrationBuilder.DropTable(
                name: "jrn");

            migrationBuilder.DropTable(
                name: "jrn_opl");

            migrationBuilder.DropTable(
                name: "jrn_rezerv");

            migrationBuilder.DropTable(
                name: "kassa_tovar");

            migrationBuilder.DropTable(
                name: "kat_agent");

            migrationBuilder.DropTable(
                name: "key_list");

            migrationBuilder.DropTable(
                name: "location_list");

            migrationBuilder.DropTable(
                name: "MarketingActionRecords");

            migrationBuilder.DropTable(
                name: "MyConnString");

            migrationBuilder.DropTable(
                name: "nakl_import_jrn");

            migrationBuilder.DropTable(
                name: "nakl_prop");

            migrationBuilder.DropTable(
                name: "nakl_prop_template");

            migrationBuilder.DropTable(
                name: "order_ext");

            migrationBuilder.DropTable(
                name: "OrdersRedirection");

            migrationBuilder.DropTable(
                name: "point_agent");

            migrationBuilder.DropTable(
                name: "price_import_jrn");

            migrationBuilder.DropTable(
                name: "PriceShields");

            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "recipe_list");

            migrationBuilder.DropTable(
                name: "route_agent");

            migrationBuilder.DropTable(
                name: "route_nakl_list");

            migrationBuilder.DropTable(
                name: "route_point");

            migrationBuilder.DropTable(
                name: "service");

            migrationBuilder.DropTable(
                name: "shop");

            migrationBuilder.DropTable(
                name: "sys_jrn");

            migrationBuilder.DropTable(
                name: "sys_jrn_ext");

            migrationBuilder.DropTable(
                name: "tcu_par");

            migrationBuilder.DropTable(
                name: "tovar_code");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "user_rights");

            migrationBuilder.DropTable(
                name: "articl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "reestr");

            migrationBuilder.DropTable(
                name: "list");

            migrationBuilder.DropTable(
                name: "route_list");

            migrationBuilder.DropTable(
                name: "delive_point");

            migrationBuilder.DropTable(
                name: "kassa");

            migrationBuilder.DropTable(
                name: "manager");

            migrationBuilder.DropTable(
                name: "nakl");

            migrationBuilder.DropTable(
                name: "tovar");

            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "route");

            migrationBuilder.DropTable(
                name: "DocStan");

            migrationBuilder.DropTable(
                name: "point");

            migrationBuilder.DropTable(
                name: "izmer");

            migrationBuilder.DropTable(
                name: "kat");

            migrationBuilder.DropTable(
                name: "cli_group");
        }
    }
}
