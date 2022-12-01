using fa22team31finalproject.DAL;
using System;
using System.Linq;


namespace fa22team31finalproject.Utilities
{
    public static class GenerateNextTransactionID
    {
        public static Int64 GetNextTransactionID(AppDbContext _context)
        {
            //set a constant to designate where the number
            //should start
            const Int64 START_NUMBER = 0;

            Int64 intMaxTransactionID; //the current maximum
            Int64 intNextTransactionID; //the product number for the next class


            intMaxTransactionID = _context.Transactions.Max(c => c.TransactionNumber); //this is the highest number in the database right now


            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxTransactionID < START_NUMBER)
            {
                intMaxTransactionID = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextTransactionID = intMaxTransactionID + 1;

            //return the value
            return intNextTransactionID;
        }

    }

}
