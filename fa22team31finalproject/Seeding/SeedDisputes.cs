
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
    public static class SeedDisputes
    {
        public static void SeedAllDisputes(AppDbContext db)
        {
            List<Dispute> AllDisputes = new List<Dispute>();

            AllDisputes.Add(new Dispute
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                Transaction = db.Transactions.FirstOrDefault(u => u.TransactionNumber == 8),
                CorrectAmount = 300.00m,
                DisputeDescription = "I don’t remember buying so many snacks",
                DisputeStatus = DisputeStatus.Submitted,
            });


            AllDisputes.Add(new Dispute
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "ss34@ggmail.com"),
                Transaction = db.Transactions.FirstOrDefault(u => u.TransactionNumber == 10),
                CorrectAmount = 0.00m,
                DisputeDescription = "You rapscallions are trying to steal my money!!!",
                DisputeStatus = DisputeStatus.Submitted,
            });


            //create a counter and flag to help with debugging
            int intDisputeID = 0;
            decimal decCorrectAmount = 0;

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (Dispute seedDispute in AllDisputes)
                {
                    //updates the counters to get info on where the problem is
                    intDisputeID = seedDispute.DisputeID;
                    decCorrectAmount = seedDispute.CorrectAmount;

                    //try to find the artist in the database
                    Dispute dbDispute = db.Disputes.FirstOrDefault(c => c.DisputeID == seedDispute.DisputeID);
                    //Change db.Accounts to db.Disputes post migration

                    //if the artist isn't in the database, dbDispute will be null
                    if (dbDispute == null)
                    {
                        //add the Dispute to the database
                        db.Disputes.Add(seedDispute);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbDispute.AppUser = seedDispute.AppUser;
                        dbDispute.Transaction = seedDispute.Transaction;
                        dbDispute.CorrectAmount = seedDispute.CorrectAmount;
                        dbDispute.DisputeDescription = seedDispute.DisputeDescription;
                        dbDispute.DisputeStatus = seedDispute.DisputeStatus;
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
                msg.Append(decCorrectAmount);
                msg.Append(" Correct Amount (DisputeID = ");
                msg.Append(intDisputeID);
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