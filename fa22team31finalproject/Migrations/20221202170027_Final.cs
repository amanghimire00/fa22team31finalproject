using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("SqlServer:EditionOptions", "EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic'");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fired = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockTypes",
                columns: table => new
                {
                    StockTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTypes", x => x.StockTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    BankAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumofDeposits = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumofWithdrawals = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.BankAccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockPortfolios",
                columns: table => new
                {
                    StockPortfolioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppUserForeignKey = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPortfolios", x => x.StockPortfolioID);
                    table.ForeignKey(
                        name: "FK_StockPortfolios_AspNetUsers_AppUserForeignKey",
                        column: x => x.AppUserForeignKey,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TickerSymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    StockPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SharesQuantity = table.Column<int>(type: "int", nullable: false),
                    StockTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stocks_StockTypes_StockTypeId",
                        column: x => x.StockTypeId,
                        principalTable: "StockTypes",
                        principalColumn: "StockTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionNumber = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionApproved = table.Column<int>(type: "int", nullable: false),
                    TransactionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAccountID = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToAccount = table.Column<long>(type: "bigint", nullable: true),
                    FromAccount = table.Column<long>(type: "bigint", nullable: true),
                    StockPortfolioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "Accounts",
                        principalColumn: "BankAccountID");
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_StockPortfolios_StockPortfolioID",
                        column: x => x.StockPortfolioID,
                        principalTable: "StockPortfolios",
                        principalColumn: "StockPortfolioID");
                });

            migrationBuilder.CreateTable(
                name: "StockTransactions",
                columns: table => new
                {
                    StockTransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharesQuantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockTransactionType = table.Column<int>(type: "int", nullable: false),
                    StockPurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BankAccountID = table.Column<int>(type: "int", nullable: true),
                    StockID = table.Column<int>(type: "int", nullable: true),
                    StockPortfolioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransactions", x => x.StockTransactionID);
                    table.ForeignKey(
                        name: "FK_StockTransactions_Accounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "Accounts",
                        principalColumn: "BankAccountID");
                    table.ForeignKey(
                        name: "FK_StockTransactions_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockTransactions_StockPortfolios_StockPortfolioID",
                        column: x => x.StockPortfolioID,
                        principalTable: "StockPortfolios",
                        principalColumn: "StockPortfolioID");
                    table.ForeignKey(
                        name: "FK_StockTransactions_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID");
                });

            migrationBuilder.CreateTable(
                name: "Disputes",
                columns: table => new
                {
                    DisputeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisputeStatus = table.Column<int>(type: "int", nullable: false),
                    CorrectAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisputeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransactionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputes", x => x.DisputeID);
                    table.ForeignKey(
                        name: "FK_Disputes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Disputes_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID");
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetail",
                columns: table => new
                {
                    TransactionDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionAmount = table.Column<int>(type: "int", nullable: false),
                    TransactionID = table.Column<int>(type: "int", nullable: true),
                    BankAccountID = table.Column<int>(type: "int", nullable: true),
                    DisputeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetail", x => x.TransactionDetailID);
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Accounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "Accounts",
                        principalColumn: "BankAccountID");
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Disputes_DisputeID",
                        column: x => x.DisputeID,
                        principalTable: "Disputes",
                        principalColumn: "DisputeID");
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AppUserId",
                table: "Accounts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_AppUserId",
                table: "Disputes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_TransactionID",
                table: "Disputes",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_StockPortfolios_AppUserForeignKey",
                table: "StockPortfolios",
                column: "AppUserForeignKey",
                unique: true,
                filter: "[AppUserForeignKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockTypeId",
                table: "Stocks",
                column: "StockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactions_AppUserId",
                table: "StockTransactions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactions_BankAccountID",
                table: "StockTransactions",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactions_StockID",
                table: "StockTransactions",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactions_StockPortfolioID",
                table: "StockTransactions",
                column: "StockPortfolioID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_BankAccountID",
                table: "TransactionDetail",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_DisputeID",
                table: "TransactionDetail",
                column: "DisputeID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_TransactionID",
                table: "TransactionDetail",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AppUserId",
                table: "Transactions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BankAccountID",
                table: "Transactions",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_StockPortfolioID",
                table: "Transactions",
                column: "StockPortfolioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "StockTransactions");

            migrationBuilder.DropTable(
                name: "TransactionDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Disputes");

            migrationBuilder.DropTable(
                name: "StockTypes");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "StockPortfolios");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
