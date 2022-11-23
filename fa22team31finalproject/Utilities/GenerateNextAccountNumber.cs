using fa22team31finalproject.DAL;
using System;
using System.Linq;


namespace fa22team31finalproject.Utilities
{
    public static class GenerateNextAccountNumber
    {
        public static Int32 GetNextAccountNumber(AppDbContext _context)
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

            Int32 intMaxAccountNumber; //the current maximum
                                     //
                                     //
                                     //
                                     //
                                     //
                                     //number
            Int32 intNextAccountNumber; //the product number for the next class

            if (_context.Accounts.Count() == 0) //there are no orders in the database yet
            {
                intMaxAccountNumber = START_NUMBER; //order numbers start at 101
            }
            else
            {
                intMaxAccountNumber = _context.Accounts.Max(c => c.AccountNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxAccountNumber < START_NUMBER)
            {
                intMaxAccountNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextAccountNumber = intMaxAccountNumber + 1;

            //return the value
            return intNextAccountNumber;
        }

    }
}