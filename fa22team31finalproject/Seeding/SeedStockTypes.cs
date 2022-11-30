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


    public static class SeedStockTypes
    {
        public static void SeedAllStockTypes(AppDbContext db)
        {
            List<StockType> AllStockTypes = new List<StockType>();

            AllStockTypes.Add(new StockType
            {
                StockTypeName = "Ordinary",

            });

            AllStockTypes.Add(new StockType
            {
                StockTypeName = "ETF",

            });

            AllStockTypes.Add(new StockType
            {
                StockTypeName = "Mutual Fund",

            });

            AllStockTypes.Add(new StockType
            {
                StockTypeName = "Index Fund",

            });

            AllStockTypes.Add(new StockType
            {
                StockTypeName = "Futures",

            });

            //create a counter and flag to help with debugging
            int intStockTypeId = 0;
            String strStockTypeName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (StockType seedStockType in AllStockTypes)
                {
                    //updates the counters to get info on where the problem is
                    intStockTypeId = seedStockType.StockTypeId;
                    strStockTypeName = seedStockType.StockTypeName;

                    //try to find the artist in the database
                    StockType dbStockType = db.StockTypes.FirstOrDefault(c => c.StockTypeName == seedStockType.StockTypeName);
                    //Change db.Accounts to db.StockTypes post migration

                    //if the artist isn't in the database, dbStockType will be null
                    if (dbStockType == null)
                    {
                        //add the StockType to the database
                        db.StockTypes.Add(seedStockType);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStockType.StockTypeName = seedStockType.StockTypeName;
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
                msg.Append(strStockTypeName);
                msg.Append(" StockType (StockTypeID = ");
                msg.Append(intStockTypeId);
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