// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fa22team31finalproject.DAL;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221202170027_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);
            SqlServerModelBuilderExtensions.HasServiceTierSql(modelBuilder, "'Basic'");
            SqlServerModelBuilderExtensions.HasPerformanceLevelSql(modelBuilder, "'Basic'");

            modelBuilder.Entity("fa22team31finalproject.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Fired")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MI")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("fa22team31finalproject.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankAccountID"), 1L, 1);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SumofDeposits")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SumofWithdrawals")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BankAccountID");

                    b.HasIndex("AppUserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Dispute", b =>
                {
                    b.Property<int>("DisputeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisputeID"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("CorrectAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DisputeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisputeStatus")
                        .HasColumnType("int");

                    b.Property<int?>("TransactionID")
                        .HasColumnType("int");

                    b.HasKey("DisputeID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("TransactionID");

                    b.ToTable("Disputes");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"), 1L, 1);

                    b.Property<int>("SharesQuantity")
                        .HasColumnType("int");

                    b.Property<string>("StockName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StockPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("StockID");

                    b.HasIndex("StockTypeId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockPortfolio", b =>
                {
                    b.Property<int>("StockPortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockPortfolioID"), 1L, 1);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("AppUserForeignKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("CashBalance")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StockPortfolioID");

                    b.HasIndex("AppUserForeignKey")
                        .IsUnique()
                        .HasFilter("[AppUserForeignKey] IS NOT NULL");

                    b.ToTable("StockPortfolios");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockTransaction", b =>
                {
                    b.Property<int>("StockTransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTransactionID"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BankAccountID")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SharesQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("StockID")
                        .HasColumnType("int");

                    b.Property<int?>("StockPortfolioID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StockPurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockTransactionType")
                        .HasColumnType("int");

                    b.HasKey("StockTransactionID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BankAccountID");

                    b.HasIndex("StockID");

                    b.HasIndex("StockPortfolioID");

                    b.ToTable("StockTransactions");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockType", b =>
                {
                    b.Property<int>("StockTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTypeId"), 1L, 1);

                    b.Property<string>("StockTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockTypeId");

                    b.ToTable("StockTypes");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BankAccountID")
                        .HasColumnType("int");

                    b.Property<long?>("FromAccount")
                        .HasColumnType("bigint");

                    b.Property<int?>("StockPortfolioID")
                        .HasColumnType("int");

                    b.Property<long?>("ToAccount")
                        .HasColumnType("bigint");

                    b.Property<decimal>("TransactionAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TransactionApproved")
                        .HasColumnType("int");

                    b.Property<string>("TransactionComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionNumber")
                        .HasColumnType("int");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BankAccountID");

                    b.HasIndex("StockPortfolioID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.TransactionDetail", b =>
                {
                    b.Property<int>("TransactionDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionDetailID"), 1L, 1);

                    b.Property<int?>("BankAccountID")
                        .HasColumnType("int");

                    b.Property<int?>("DisputeID")
                        .HasColumnType("int");

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("int");

                    b.Property<int?>("TransactionID")
                        .HasColumnType("int");

                    b.HasKey("TransactionDetailID");

                    b.HasIndex("BankAccountID");

                    b.HasIndex("DisputeID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionDetail");
                });

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

            modelBuilder.Entity("fa22team31finalproject.Models.BankAccount", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", "AppUser")
                        .WithMany("BankAccount")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Dispute", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", "AppUser")
                        .WithMany("Disputes")
                        .HasForeignKey("AppUserId");

                    b.HasOne("fa22team31finalproject.Models.Transaction", "Transaction")
                        .WithMany("Dispute")
                        .HasForeignKey("TransactionID");

                    b.Navigation("AppUser");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Stock", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.StockType", "StockType")
                        .WithMany("Stocks")
                        .HasForeignKey("StockTypeId");

                    b.Navigation("StockType");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockPortfolio", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", "AppUser")
                        .WithOne("StockPortfolio")
                        .HasForeignKey("fa22team31finalproject.Models.StockPortfolio", "AppUserForeignKey");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockTransaction", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("fa22team31finalproject.Models.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountID");

                    b.HasOne("fa22team31finalproject.Models.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockID");

                    b.HasOne("fa22team31finalproject.Models.StockPortfolio", "StockPortfolio")
                        .WithMany("StockTransaction")
                        .HasForeignKey("StockPortfolioID");

                    b.Navigation("AppUser");

                    b.Navigation("BankAccount");

                    b.Navigation("Stock");

                    b.Navigation("StockPortfolio");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Transaction", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("fa22team31finalproject.Models.BankAccount", "BankAccount")
                        .WithMany("Transaction")
                        .HasForeignKey("BankAccountID");

                    b.HasOne("fa22team31finalproject.Models.StockPortfolio", null)
                        .WithMany("Transaction")
                        .HasForeignKey("StockPortfolioID");

                    b.Navigation("AppUser");

                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.TransactionDetail", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountID");

                    b.HasOne("fa22team31finalproject.Models.Dispute", "Dispute")
                        .WithMany()
                        .HasForeignKey("DisputeID");

                    b.HasOne("fa22team31finalproject.Models.Transaction", "Transaction")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionID");

                    b.Navigation("BankAccount");

                    b.Navigation("Dispute");

                    b.Navigation("Transaction");
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
                    b.HasOne("fa22team31finalproject.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", null)
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

                    b.HasOne("fa22team31finalproject.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("fa22team31finalproject.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fa22team31finalproject.Models.AppUser", b =>
                {
                    b.Navigation("BankAccount");

                    b.Navigation("Disputes");

                    b.Navigation("StockPortfolio");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.BankAccount", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockPortfolio", b =>
                {
                    b.Navigation("StockTransaction");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.StockType", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("fa22team31finalproject.Models.Transaction", b =>
                {
                    b.Navigation("Dispute");

                    b.Navigation("TransactionDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
