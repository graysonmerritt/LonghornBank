
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


    public static class SeedAccountsTutorial
    {
        public static void SeedAllAccounts(AppDbContext db)
        {
            List<Account> AllAccounts= new List<Account>();
    


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "willsheff@email.com"),
                AccountNumber = Convert.ToInt64(2290000002.0),
                Nickname = "William's Savings",
                Type = AccountType.Savings,
                Balance = 40035.50m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "smartinmartin.Martin@aool.com"),
                AccountNumber = Convert.ToInt64(2290000003.0),
                Nickname = "Gregory's Checking",
                Type = AccountType.Checking,
                Balance = 39779.49m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "avelasco@yaho.com"),
                AccountNumber = Convert.ToInt64(2290000004.0),
                Nickname = "Allen's Checking",
                Type = AccountType.Checking,
                Balance = 47277.33m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "rwood@voyager.net"),
                AccountNumber = Convert.ToInt64(2290000005.0),
                Nickname = "Reagan's Checking",
                Type = AccountType.Checking,
                Balance = 70812.15m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "nelson.Kelly@aool.com"),
                AccountNumber = Convert.ToInt64(2290000006.0),
                Nickname = "Kelly's Savings",
                Type = AccountType.Savings,
                Balance = 21901.97m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "erynrice@aool.com"),
                AccountNumber = Convert.ToInt64(2290000007.0),
                Nickname = "Eryn's Checking",
                Type = AccountType.Checking,
                Balance = 70480.99m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "westj@pioneer.net"),
                AccountNumber = Convert.ToInt64(2290000008.0),
                Nickname = "Jake's Savings",
                Type = AccountType.Savings,
                Balance = 7916.40m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "jeff@ggmail.com"),
                AccountNumber = Convert.ToInt64(2290000010.0),
                Nickname = "Jeffrey's Savings",
                Type = AccountType.Savings,
                Balance = 69576.83m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "erynrice@aool.com"),
                AccountNumber = Convert.ToInt64(2290000012.0),
                Nickname = "Eryn's Checking 2",
                Type = AccountType.Checking,
                Balance = 30279.33m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "mackcloud@pimpdaddy.com"),
                AccountNumber = Convert.ToInt64(2290000013.0),
                Nickname = "Jennifer's IRA",
                Type = AccountType.IRA,
                Balance = 53177.21m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "ss34@ggmail.com"),
                AccountNumber = Convert.ToInt64(2290000014.0),
                Nickname = "Sarah's Savings",
                Type = AccountType.Savings,
                Balance = 11958.08m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "tanner@ggmail.com"),
                AccountNumber = Convert.ToInt64(2290000015.0),
                Nickname = "Jeremy's Savings",
                Type = AccountType.Savings,
                Balance = 72990.47m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "liz@ggmail.com"),
                AccountNumber = Convert.ToInt64(2290000016.0),
                Nickname = "Elizabeth's Savings",
                Type = AccountType.Savings,
                Balance = 7417.20m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com"),
                AccountNumber = Convert.ToInt64(2290000017.0),
                Nickname = "Allen's IRA",
                Type = AccountType.IRA,
                Balance = 75866.69m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "mclarence@aool.com"),
                AccountNumber = Convert.ToInt64(2290000019.0),
                Nickname = "Clarence's Savings",
                Type = AccountType.Savings,
                Balance = 1642.82m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "ss34@ggmail.com"),
                AccountNumber = Convert.ToInt64(2290000020.0),
                Nickname = "Sarah's Checking",
                Type = AccountType.Checking,
                Balance = 84421.45m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                AccountNumber = Convert.ToInt64(2290000021.0),
                Nickname = "CBaker's Checking",
                Type = AccountType.Checking,
                Balance = 4523.00m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                AccountNumber = Convert.ToInt64(2290000022.0),
                Nickname = "CBaker's Savings",
                Type = AccountType.Savings,
                Balance = 1000.00m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "cbaker@freezing.co.uk"),
                AccountNumber = Convert.ToInt64(2290000023.0),
                Nickname = "CBaker's IRA",
                Type = AccountType.IRA,
                Balance = 1000.00m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com"),
                AccountNumber = Convert.ToInt64(2290000025.0),
                Nickname = "C-dawg's Checking",
                Type = AccountType.Checking,
                Balance = 4.04m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com"),
                AccountNumber = Convert.ToInt64(2290000026.0),
                Nickname = "C-dawg's Savings",
                Type = AccountType.Savings,
                Balance = 350.00m,
                isActive = true,

            }) ; 


            AllAccounts.Add(new Account
            {
                AppUser = db.Users.FirstOrDefault(u => u.UserName == "mgar@aool.com"),
                AccountNumber = Convert.ToInt64(2290000027.0),
                Nickname = "Margaret's IRA",
                Type = AccountType.IRA,
                Balance = 3500.00m,
                isActive = true,

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
                foreach (Account seedAccount in AllAccounts)
                {
                    //updates the counters to get info on where the problem is
                    intAccountID = seedAccount.AccountID;
                    strAccountCustomer = seedAccount.AppUser.FirstName + seedAccount.AppUser.LastName;
                    

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Account dbAccount = db.Accounts.FirstOrDefault(c => (c.AccountNumber == seedAccount.AccountNumber)      
                                                                                  );

                    //if the artistRating isn't in the database, dbAccount will be null
                    if (dbAccount == null)
                    {
                        //add the ArtistRating to the database
                        db.Accounts.Add(seedAccount);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbAccount.Nickname = seedAccount.Nickname;
                        dbAccount.Type = seedAccount.Type;
                        dbAccount.Balance = seedAccount.Balance;
                        dbAccount.isActive = seedAccount.isActive;


  
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
