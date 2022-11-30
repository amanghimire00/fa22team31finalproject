
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


    public static class SeedStockPortfolios
    {
        public static void SeedAllStockPortfolios(AppDbContext db)
        {
            List<StockPortfolio> AllStockPortfolios = new List<StockPortfolio>();



            AllStockPortfolios.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "Dixon@aool.com"),
                AccountNumber = 2290000001,
                AccountName = "Shan's Stock",
                CashBalance = 0.00m,

            });


            AllStockPortfolios.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "mb@aool.com"),
                AccountNumber = 2290000009,
                AccountName = "Michelle's Stock",
                CashBalance = 8888.88m,

            });


            AllStockPortfolios.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "nelson.Kelly@aool.com"),
                AccountNumber = 2290000011,
                AccountName = "Kelly's Stock",
                CashBalance = 420.00m,

            });


            AllStockPortfolios.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "johnsmith187@aool.com"),
                AccountNumber = 2290000018,
                AccountName = "John's Stock",
                CashBalance = 0.00m,

            });


            AllStockPortfolios.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                AccountNumber = 2290000024,
                AccountName = "CBaker's Stock",
                CashBalance = 6900.00m,

            });

            //create a counter and flag to help with debugging
            int intStockPortfolioID = 0;
            String strAccountName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (StockPortfolio seedStockPortfolio in AllStockPortfolios)
                {
                    //updates the counters to get info on where the problem is
                    intStockPortfolioID = seedStockPortfolio.StockPortfolioID;
                    strAccountName = seedStockPortfolio.AccountName;

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    StockPortfolio dbStockPortfolio = db.StockPortfolios.FirstOrDefault(c => c.AccountName == seedStockPortfolio.AccountName);

                    //if the artistRating isn't in the database, dbStockPortfolio will be null
                    if (dbStockPortfolio == null)
                    {
                        //add the StockPortfolio to the database
                        db.StockPortfolios.Add(seedStockPortfolio);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStockPortfolio.AppUser = seedStockPortfolio.AppUser;
                        dbStockPortfolio.AccountNumber = seedStockPortfolio.AccountNumber;
                        dbStockPortfolio.AccountName = seedStockPortfolio.AccountName;
                        dbStockPortfolio.CashBalance = seedStockPortfolio.CashBalance;


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
                msg.Append(strAccountName);
                msg.Append(intStockPortfolioID);

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}
