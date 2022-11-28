//TODO: Update this using statement to include your project name
using fa22team31finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace fa22team31finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);

            builder.Entity<StockPortfolio>()
                .Property<String>("AppUserForeignKey");


            //this code configures the 1:1 relationship between AppUser and StockPortfolio
            builder.Entity<AppUser>()
                .HasOne(sp => sp.StockPortfolio)
                .WithOne(u => u.AppUser)
                .HasForeignKey<StockPortfolio>("AppUserForeignKey");
        }
        //TODO: Add Dbsets here.  
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Dispute> Disputes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockPortfolio> StockPortfolios { get; set; }
        public DbSet<StockTransaction> StockTransactions { get; set; }
        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }

}
