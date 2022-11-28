using fa22team31finalproject.DAL;
using System;
using System.Linq;


namespace fa22team31finalproject.Utilities
{
    public static class GenerateNextAccountID
    {
        public static Int32 GetNextAccountID(AppDbContext _context)
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

            Int32 intMaxAccountID; //the current maximum
                                     //
                                     //
                                     //
                                     //
                                     //
                                     //number
            Int32 intNextAccountID; //the product number for the next class

            if (_context.Accounts.Count() == 0) //there are no orders in the database yet
            {
                intMaxAccountID = START_NUMBER; //order numbers start at 101
            }
            else
            {
                intMaxAccountID = _context.Accounts.Max(c => c.AccountID); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxAccountID < START_NUMBER)
            {
                intMaxAccountID = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextAccountID = intMaxAccountID + 1;

            //return the value
            return intNextAccountID;
        }

    }
}