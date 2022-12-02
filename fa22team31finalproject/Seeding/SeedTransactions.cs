
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


    public static class SeedTransactions
    {
        public static void SeedAllTransactions(AppDbContext db)
        {
            List<Transaction> AllTransactions = new List<Transaction>();



            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 1,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Deposit,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000021),
                TransactionAmount = 4000.00m,
                TransactionDate = new DateTime(2022, 1, 15),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 2,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Deposit,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000022),
                TransactionAmount = 2200.00m,
                TransactionDate = new DateTime(2022, 3, 5),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "This transaction went so well! I will be using this bank again for sure!!",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 3,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Deposit,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000022),
                TransactionAmount = 6000.00m,
                TransactionDate = new DateTime(2022, 3, 9),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 4,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Transfer,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000021),
                TransactionAmount = 1200.00m,
                TransactionDate = new DateTime(2022, 4, 14),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "Jacob Foster has a GPA of 1.92. LOL",

            });

            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 4,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Transfer,                
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000022),
                TransactionAmount = -1200.00m,
                TransactionDate = new DateTime(2022, 4, 14),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "Jacob Foster has a GPA of 1.92. LOL",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 5,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Withdraw,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000022),                
                TransactionAmount = 352.00m,
                TransactionDate = new DateTime(2022, 4, 21),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "Longhorn Bank is my favorite bank! I couldn't dream of putting my money anywhere else.",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 6,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Deposit,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000023),
                TransactionAmount = 1500.00m,
                TransactionDate = new DateTime(2022, 3, 8),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 7,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Transfer,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000021),
                TransactionAmount = 3000.00m,
                TransactionDate = new DateTime(2022, 4, 20),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });

            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 7,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Transfer,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000024),
                TransactionAmount = -3000.00m,
                TransactionDate = new DateTime(2022, 4, 20),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 8,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                TransactionType = TransactionType.Withdraw,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000021),
                TransactionAmount = 578.12m,
                TransactionDate = new DateTime(2022, 4, 19),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "K project snack expenses",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 9,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com"),
                TransactionType = TransactionType.Transfer,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000025),
                TransactionAmount = 52.00m,
                TransactionDate = new DateTime(2022, 4, 29),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });

            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 9,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com"),
                TransactionType = TransactionType.Transfer,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000026),
                TransactionAmount = -52.00m,
                TransactionDate = new DateTime(2022, 4, 29),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 10,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "ss34@ggmail.com"),
                TransactionType = TransactionType.Withdraw,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000020),
                TransactionAmount = 4000.00m,
                TransactionDate = new DateTime(2022, 3, 7),
                TransactionApproved = TransactionApproved.Yes,
                TransactionComment = "This is totally not fraudulent 0_o",

            });


            AllTransactions.Add(new Transaction
            {
                TransactionNumber = 11,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "liz@ggmail.com"),
                TransactionType = TransactionType.Deposit,
                BankAccount = db.Accounts.FirstOrDefault(u => u.AccountNumber == 2290000016),
                TransactionAmount = 6000.00m,
                TransactionDate = new DateTime(2022, 5, 1),
                TransactionApproved = TransactionApproved.No,
                TransactionComment = "I got this money from my new business at the Blue Cat Lodge",

            });

            //create a counter and flag to help with debugging
            int intTransactionID = 0;
            int intTransactionNumber = 0;

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Transaction seedTransaction in AllTransactions)
                {
                    //updates the counters to get info on where the problem is
                    intTransactionID = seedTransaction.TransactionID;
                    intTransactionNumber = seedTransaction.TransactionNumber;

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Transaction dbTransaction = db.Transactions.FirstOrDefault(c => (c.TransactionID== seedTransaction.TransactionID) &&
                                                                                       (c.TransactionType == seedTransaction.TransactionType)
                                                                                  );

                    //if the artistRating isn't in the database, dbTransaction will be null
                    if (dbTransaction == null)
                    {
                        //add the Transaction to the database
                        db.Transactions.Add(seedTransaction);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbTransaction.TransactionNumber = seedTransaction.TransactionNumber;
                        dbTransaction.AppUser = seedTransaction.AppUser;
                        dbTransaction.TransactionType = seedTransaction.TransactionType;
                        dbTransaction.BankAccount = seedTransaction.BankAccount;
                        dbTransaction.TransactionAmount = seedTransaction.TransactionAmount;
                        dbTransaction.TransactionDate = seedTransaction.TransactionDate;
                        dbTransaction.TransactionApproved = seedTransaction.TransactionApproved;
                        dbTransaction.TransactionComment = seedTransaction.TransactionComment;

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
                msg.Append(intTransactionNumber);
                msg.Append(" intTransactionNumber and intTransactionID (TransactionID = ");
                msg.Append(intTransactionID);
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
