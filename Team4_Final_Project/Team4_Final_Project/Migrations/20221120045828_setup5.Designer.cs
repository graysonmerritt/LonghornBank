// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team4_Final_Project.DAL;

#nullable disable

namespace Team4_Final_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221120045828_setup5")]
    partial class setup5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);
            SqlServerModelBuilderExtensions.HasServiceTierSql(modelBuilder, "'Basic'");
            SqlServerModelBuilderExtensions.HasPerformanceLevelSql(modelBuilder, "'Basic'");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HiddenAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("AccountID");

                    b.HasIndex("AppUserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleInitial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Dispute", b =>
                {
                    b.Property<int>("DisputeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisputeID"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TransactionID")
                        .HasColumnType("int");

                    b.HasKey("DisputeID");

                    b.HasIndex("TransactionID");

                    b.ToTable("Disputes");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"), 1L, 1);

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StockPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StockTicker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StockTypeID")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.HasIndex("StockTypeID");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockPortfolio", b =>
                {
                    b.Property<int>("StockPortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockPortfolioID"), 1L, 1);

                    b.Property<string>("AppUserForeignKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AvailableCash")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Balanced")
                        .HasColumnType("bit");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Gain")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StockPortfolioID");

                    b.HasIndex("AppUserForeignKey")
                        .IsUnique()
                        .HasFilter("[AppUserForeignKey] IS NOT NULL");

                    b.ToTable("StockPortfolios");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockTransaction", b =>
                {
                    b.Property<int>("StockTransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTransactionID"), 1L, 1);

                    b.Property<decimal>("ExtendedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumberOfShares")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<int?>("StockPortfolioID")
                        .HasColumnType("int");

                    b.HasKey("StockTransactionID");

                    b.HasIndex("StockId");

                    b.HasIndex("StockPortfolioID");

                    b.ToTable("StockTransactions");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockType", b =>
                {
                    b.Property<int>("StockTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTypeID"), 1L, 1);

                    b.Property<string>("StockTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockTypeID");

                    b.ToTable("StockTypes");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistributionStatus")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("AccountID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team4_Final_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Account", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.AppUser", "AppUser")
                        .WithMany("Accounts")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Dispute", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.Transaction", "Transaction")
                        .WithMany("Disputes")
                        .HasForeignKey("TransactionID");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Stock", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.StockType", "StockType")
                        .WithMany("Stocks")
                        .HasForeignKey("StockTypeID");

                    b.Navigation("StockType");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockPortfolio", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.AppUser", "AppUser")
                        .WithOne("StockPortfolio")
                        .HasForeignKey("Team4_Final_Project.Models.StockPortfolio", "AppUserForeignKey");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockTransaction", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockId");

                    b.HasOne("Team4_Final_Project.Models.StockPortfolio", "StockPortfolio")
                        .WithMany("StockTransactions")
                        .HasForeignKey("StockPortfolioID");

                    b.Navigation("Stock");

                    b.Navigation("StockPortfolio");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Transaction", b =>
                {
                    b.HasOne("Team4_Final_Project.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountID");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.AppUser", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("StockPortfolio");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockPortfolio", b =>
                {
                    b.Navigation("StockTransactions");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.StockType", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("Team4_Final_Project.Models.Transaction", b =>
                {
                    b.Navigation("Disputes");
                });
#pragma warning restore 612, 618
        }
    }
}
