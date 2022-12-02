using fa22team31finalproject.DAL;
using fa22team31finalproject.Models;
using fa22team31finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa22team31finalproject.Seeding
{
    public static class SeedStockTransactions
    {
        public static void SeedAllStockTransactions(AppDbContext db)
        {
            List<StockTransaction> AllStockTransactions = new List<StockTransaction>();



            AllStockTransactions.Add(new StockTransaction
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                StockTransactionType = StockTransactionType.Purchase,
                StockPortfolio = db.StockPortfolios.FirstOrDefault(u => u.AccountNumber == 2290000024),
                PurchasePrice = 145.03m,
                SharesQuantity = 10,
                Stock = db.Stocks.FirstOrDefault(u => u.TickerSymbol == "AAPL"),
                StockPurchaseDate = new DateTime(2022, 4, 1),

            });


            AllStockTransactions.Add(new StockTransaction
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                StockTransactionType = StockTransactionType.Purchase,
                StockPortfolio = db.StockPortfolios.FirstOrDefault(u => u.AccountNumber == 2290000024),
                PurchasePrice = 321.36m,
                SharesQuantity = 5,
                Stock = db.Stocks.FirstOrDefault(u => u.TickerSymbol == "DIA"),
                StockPurchaseDate = new DateTime(2022, 4, 3),

            });


            AllStockTransactions.Add(new StockTransaction
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                StockTransactionType = StockTransactionType.Purchase,
                StockPortfolio = db.StockPortfolios.FirstOrDefault(u => u.AccountNumber == 2290000024),
                PurchasePrice = 18.10m,
                SharesQuantity = 2,
                Stock = db.Stocks.FirstOrDefault(u => u.TickerSymbol == "FLCEX"),
                StockPurchaseDate = new DateTime(2022, 4, 28),

            });

            //create a counter and flag to help with debugging
            int intStockTransactionID = 0;
            String strBankAccountName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (StockTransaction seedStockTransaction in AllStockTransactions)
                {
                    //updates the counters to get info on where the problem is
                    intStockTransactionID = seedStockTransaction.StockTransactionID;

                    //try to find the artist in the database
                    StockTransaction dbStockTransaction = db.StockTransactions.FirstOrDefault(c => c.Stock.TickerSymbol == seedStockTransaction.Stock.TickerSymbol);
                    //Change db.Accounts to db.StockTransactions post migration

                    //if the artist isn't in the database, dbStockTransaction will be null
                    if (dbStockTransaction == null)
                    {
                        //add the StockTransaction to the database
                        db.StockTransactions.Add(seedStockTransaction);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStockTransaction.StockTransactionType = seedStockTransaction.StockTransactionType;
                        dbStockTransaction.BankAccount = seedStockTransaction.BankAccount;
                        dbStockTransaction.PurchasePrice = seedStockTransaction.PurchasePrice;
                        dbStockTransaction.AppUser = seedStockTransaction.AppUser;
                        dbStockTransaction.SharesQuantity = seedStockTransaction.SharesQuantity;
                        dbStockTransaction.Stock = seedStockTransaction.Stock;
                        dbStockTransaction.StockPurchaseDate = seedStockTransaction.StockPurchaseDate;
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append("(StockTransactionID = ");
                msg.Append(intStockTransactionID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}