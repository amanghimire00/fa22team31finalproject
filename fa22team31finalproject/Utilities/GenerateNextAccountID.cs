using fa22team31finalproject.DAL;
using System;
using System.Linq;


namespace fa22team31finalproject.Utilities
{
    public static class GenerateNextAccountID
    {
        public static Int64 GetNextAccountID(AppDbContext _context)
        {
            //set a constant to designate where the number
            //should start
            const Int64 START_NUMBER = 2290000001;

            Int64 intMaxAccountID; //the current maximum
            Int64 intNextAccountID; //the product number for the next class


            intMaxAccountID = _context.Accounts.Max(c => c.AccountNumber); //this is the highest number in the database right now
          

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
