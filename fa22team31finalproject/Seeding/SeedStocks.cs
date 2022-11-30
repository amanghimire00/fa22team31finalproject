
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


    public static class SeedStocks
    {
        public static void SeedAllStocks(AppDbContext db)
        {
            List<Stock> AllStocks = new List<Stock>();

            AllStocks.Add(new Stock
            {
                TickerSymbol = "GOOG",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Alphabet Inc.",
                StockPrice = 87.07m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "AAPL",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Apple Inc.",
                StockPrice = 145.03m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "AMZN",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Amazon.com Inc.",
                StockPrice = 92.12m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "LUV",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Southwest Airlines",
                StockPrice = 36.50m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "TXN",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Texas Instruments",
                StockPrice = 158.49m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "HSY",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "The Hershey Company",
                StockPrice = 235.11m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "V",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Visa Inc.",
                StockPrice = 200.95m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "NKE",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Nike",
                StockPrice = 90.30m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "VWO",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "ETF"),
                StockName = "Vanguard Emerging Markets ETF",
                StockPrice = 35.77m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "CORN",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Futures"),
                StockName = "Corn",
                StockPrice = 27.35m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "FXAIX",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Mutual Fund"),
                StockName = "Fidelity 500 Index Fund",
                StockPrice = 133.88m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "F",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Ford Motor Company",
                StockPrice = 13.06m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "BAC",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Bank of America Corporation",
                StockPrice = 36.09m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "VNQ",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "ETF"),
                StockName = "Vanguard REIT ETF",
                StockPrice = 80.67m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "NSDQ",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Index Fund"),
                StockName = "Nasdaq Index Fund",
                StockPrice = 10524.80m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "KMX",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "CarMax, Inc.",
                StockPrice = 62.36m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "DIA",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Index Fund"),
                StockName = "Dow Jones Industrial Average Index Fund",
                StockPrice = 321.36m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "SPY",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Index Fund"),
                StockName = "S&P 500 Index Fund",
                StockPrice = 374.87m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "BEN",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Ordinary"),
                StockName = "Franklin Resources, Inc.",
                StockPrice = 22.56m,

            });


            AllStocks.Add(new Stock
            {
                TickerSymbol = "FLCEX",
                StockType = db.StockTypes.FirstOrDefault(st => st.StockTypeName == "Mutual Fund"),
                StockName = "Fidelity Large Cap Core Enhanced Index Fund",
                StockPrice = 18.10m,

            });

            //create a counter and flag to help with debugging
            int intStockID = 0;
            String strStockName = "Start";
            String strTickerSymbol = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Stock seedStock in AllStocks)
                {
                    //updates the counters to get info on where the problem is
                    intStockID = seedStock.StockID;
                    strStockName = seedStock.StockName;
                    strTickerSymbol = seedStock.TickerSymbol;

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Stock dbStock = db.Stocks.FirstOrDefault(c => (c.TickerSymbol == seedStock.TickerSymbol) &&
                                                                                       (c.StockName == seedStock.StockName)
                                                                                  );

                    //if the artistRating isn't in the database, dbStock will be null
                    if (dbStock == null)
                    {
                        //add the Stock to the database
                        db.Stocks.Add(seedStock);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStock.StockName = seedStock.StockName;
                        dbStock.TickerSymbol = seedStock.TickerSymbol;



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
                msg.Append(strStockName);
                msg.Append(strTickerSymbol);
                msg.Append(" strStockName and strTickerSymbol (StockID = ");
                msg.Append(intStockID);
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
