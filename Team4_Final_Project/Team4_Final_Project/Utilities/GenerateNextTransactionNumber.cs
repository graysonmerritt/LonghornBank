using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_Final_Project.DAL;

namespace Team4_Final_Project.Utilities
{
    public class GenerateNextTransactionNumber
    {
        public static Int64 GetNextTransactionNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int64 START_NUMBER = 1;

            Int64 intMaxTransNumber; //the current maximum course number
            Int64 intNextTransNumber; //the course number for the next class

            if (_context.Transactions.Count() == 0) //there are no registrations in the database yet
            {
                intMaxTransNumber = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                intMaxTransNumber = _context.Transactions.Max(t => t.Number); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxTransNumber < START_NUMBER)
            {
                intMaxTransNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextTransNumber = intMaxTransNumber + 1;

            //return the value
            return intNextTransNumber;
        }
    }
}

