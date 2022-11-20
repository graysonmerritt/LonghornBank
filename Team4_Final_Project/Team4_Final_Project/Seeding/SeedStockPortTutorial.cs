
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;
using Team4_Final_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Team4_Final_Project.Seeding
{


    public static class SeedStockPortTutorial
    {
        public static void SeedAllStockPort(AppDbContext db)
        {
            List<StockPortfolio> AllStockPort= new List<StockPortfolio>();
    


            AllStockPort.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "Dixon@aool.com"),
                AccountNumber = Convert.ToInt64(2290000001.0),
                Nickname = "Shan's Stock",
                AvailableCash = 0.00m,
                IsActive = true,

            }) ; 


            AllStockPort.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "mb@aool.com"),
                AccountNumber = Convert.ToInt64(2290000009.0),
                Nickname = "Michelle's Stock",
                AvailableCash = 8888.88m,
                IsActive = true,

            }) ; 


            AllStockPort.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "nelson.Kelly@aool.com"),
                AccountNumber = Convert.ToInt64(2290000011.0),
                Nickname = "Kelly's Stock",
                AvailableCash = 420.00m,
                IsActive = true,

            }) ; 


            AllStockPort.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "johnsmith187@aool.com"),
                AccountNumber = Convert.ToInt64(2290000018.0),
                Nickname = "John's Stock",
                AvailableCash = 0.00m,
                IsActive = true,

            }) ; 


            AllStockPort.Add(new StockPortfolio
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                AccountNumber = Convert.ToInt64(2290000024.0),
                Nickname = "CBaker's Stock",
                AvailableCash = 6900.00m,
                IsActive = true,

            }) ; 

            //create a counter and flag to help with debugging
            int intAccountID = 0;
            String strAccountCustomer = "Start";
            

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (StockPortfolio seedPort in AllStockPort)
                {
                    //updates the counters to get info on where the problem is
                    intAccountID = seedPort.StockPortfolioID;
                    strAccountCustomer = seedPort.AppUser.FirstName + seedPort.AppUser.LastName;
                    

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    StockPortfolio dbPort = db.StockPortfolios.FirstOrDefault(c => (c.AccountNumber == seedPort.AccountNumber)      
                                                                                  );

                    //if the artistRating isn't in the database, dbPort will be null
                    if (dbPort == null)
                    {
                        //add the ArtistRating to the database
                        db.StockPortfolios.Add(seedPort);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbPort.Nickname = seedPort.Nickname;
                        dbPort.AvailableCash = seedPort.AvailableCash;
                        dbPort.IsActive = seedPort.IsActive;


  
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
                msg.Append(strAccountCustomer);
                
                msg.Append(" strAccountCustomer (AccountID = ");
                msg.Append(intAccountID);
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
