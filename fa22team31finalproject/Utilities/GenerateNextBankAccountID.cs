using fa22team31finalproject.DAL;
using System;
using System.Linq;


namespace fa22team31finalproject.Utilities
{
    public static class GenerateNextBankAccountID
    {
        public static Int32 GetNextBankAccountID(AppDbContext _context)
        {
            //set a constant to designate where the
            //
            //
            //
            //
            //
            //numbers 
            //should start
            const Int32 START_NUMBER = 0;

            Int32 intMaxBankAccountID; //the current maximum
                                     //
                                     //
                                     //
                                     //
                                     //
                                     //number
            Int32 intNextBankAccountID; //the product number for the next class

            if (_context.BankAccounts.Count() == 0) //there are no orders in the database yet
            {
                intMaxBankAccountID = START_NUMBER; //order numbers start at 101
            }
            else
            {
                intMaxBankAccountID = _context.BankAccounts.Max(c => c.BankAccountID); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxBankAccountID < START_NUMBER)
            {
                intMaxBankAccountID = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextBankAccountID = intMaxBankAccountID + 1;

            //return the value
            return intNextBankAccountID;
        }

    }
}