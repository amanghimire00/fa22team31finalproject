
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


    public static class SeedBankAccount
    {
        public static void SeedAllBankAccounts(AppDbContext db)
        {
            List<BankAccount> AllBankAccounts = new List<BankAccount>();
    


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000002,
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "willsheff@email.com"),
                AccountName = "William's Savings",
                Balance = 40035.50m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000003,
                Customer = "smartinmartin.Martin@aool.com",
                AccountName = "Gregory's Checking",
                Balance = 39779.49m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000004,
                Customer = "avelasco@yaho.com",
                AccountName = "Allen's Checking",
                Balance = 47277.33m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000005,
                Customer = "rwood@voyager.net",
                AccountName = "Reagan's Checking",
                Balance = 70812.15m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000006,
                Customer = "nelson.Kelly@aool.com",
                AccountName = "Kelly's Savings",
                Balance = 21901.97m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000007,
                Customer = "erynrice@aool.com",
                AccountName = "Eryn's Checking",
                Balance = 70480.99m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000008,
                Customer = "westj@pioneer.net",
                AccountName = "Jake's Savings",
                Balance = 7916.40m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000010,
                Customer = "jeff@ggmail.com",
                AccountName = "Jeffrey's Savings",
                Balance = 69576.83m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000012,
                Customer = "erynrice@aool.com",
                AccountName = "Eryn's Checking 2",
                Balance = 30279.33m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000013,
                Customer = "mackcloud@pimpdaddy.com",
                AccountName = "Jennifer's IRA",
                Balance = 53177.21m,
                AccountType = AccountType.IRA,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000014,
                Customer = "ss34@ggmail.com",
                AccountName = "Sarah's Savings",
                Balance = 11958.08m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000015,
                Customer = "tanner@ggmail.com",
                AccountName = "Jeremy's Savings",
                Balance = 72990.47m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000016,
                Customer = "liz@ggmail.com",
                AccountName = "Elizabeth's Savings",
                Balance = 7417.20m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000017,
                Customer = "ra@aoo.com",
                AccountName = "Allen's IRA",
                Balance = 75866.69m,
                AccountType = AccountType.IRA,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000019,
                Customer = "mclarence@aool.com",
                AccountName = "Clarence's Savings",
                Balance = 1642.82m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000020,
                Customer = "ss34@ggmail.com",
                AccountName = "Sarah's Checking",
                Balance = 84421.45m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000021,
                Customer = "cbaker@freezing.co.uk",
                AccountName = "CBaker's Checking",
                Balance = 4523.00m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000022,
                Customer = "cbaker@freezing.co.uk",
                AccountName = "CBaker's Savings",
                Balance = 1000.00m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000023,
                Customer = "cbaker@freezing.co.uk",
                AccountName = "CBaker's IRA",
                Balance = 1000.00m,
                AccountType = AccountType.IRA,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000025,
                Customer = "chaley@thug.com",
                AccountName = "C-dawg's Checking",
                Balance = 4.04m,
                AccountType = AccountType.Checking,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000026,
                Customer = "chaley@thug.com",
                AccountName = "C-dawg's Savings",
                Balance = 350.00m,
                AccountType = AccountType.Savings,
            }) ; 


            AllBankAccounts.Add(new BankAccount
            {
                AccountNumber = 2290000027,
                Customer = "mgar@aool.com",
                AccountName = "Margaret's IRA",
                Balance = 3500.00m,
                AccountType = AccountType.IRA,
            }) ; 

            //create a counter and flag to help with debugging
            int intBankAccountID = 0;
            String strBankAccountName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (BankAccount seedBankAccount in AllBankAccounts)
                {
                    //updates the counters to get info on where the problem is
                    intBankAccountID = seedBankAccount.BankAccountID;
                    strBankAccountName = seedBankAccount.AccountName;

                    //try to find the artist in the database
                    BankAccount dbBankAccount = db.Accounts.FirstOrDefault(c => c.AccountName == seedBankAccount.AccountName);
                    //Change db.Accounts to db.BankAccounts post migration

                    //if the artist isn't in the database, dbBankAccount will be null
                    if (dbBankAccount == null)
                    {
                        //add the BankAccount to the database
                        db.Accounts.Add(seedBankAccount);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbBankAccount.AccountNumber = seedBankAccount.AccountNumber;
                        dbBankAccount.AppUser = seedBankAccount.AppUser;
                        dbBankAccount.AccountName = seedBankAccount.AccountName;
                        dbBankAccount.Balance = seedBankAccount.Balance;
                        dbBankAccount.AccountType = seedBankAccount.AccountType;
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
                msg.Append(strBankAccountName);
                msg.Append(" artist (BankAccountID = ");
                msg.Append(intBankAccountID);
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
