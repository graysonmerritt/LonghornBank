
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

    public static class SeedUsersTutorial
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125571146.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    MiddleInitial = "L",
                    LastName = "Baker",
                    Street = "1245 Lake Austin Blvd.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78733.0",
                    Birthday = DateTime.Parse("1991-02-07 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "gazing",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mb@aool.com",
                    Email = "mb@aool.com",
                    PhoneNumber = "2102678873.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    MiddleInitial = "",
                    LastName = "Banks",
                    Street = "1300 Tall Pine Lane",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78261.0",
                    Birthday = DateTime.Parse("1990-06-23 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "banquet",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "fd@aool.com",
                    Email = "fd@aool.com",
                    PhoneNumber = "8175659699.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    MiddleInitial = "V",
                    LastName = "Broccolo",
                    Street = "62 Browning Rd",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77019.0",
                    Birthday = DateTime.Parse("1986-05-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "666666.0",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wendy@ggmail.com",
                    Email = "wendy@ggmail.com",
                    PhoneNumber = "5125943222.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    MiddleInitial = "L",
                    LastName = "Chang",
                    Street = "202 Bellmont Hall",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78713.0",
                    Birthday = DateTime.Parse("1964-12-21 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "clover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "limchou@yaho.com",
                    Email = "limchou@yaho.com",
                    PhoneNumber = "2107724599.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    MiddleInitial = "",
                    LastName = "Chou",
                    Street = "1600 Teresa Lane",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78266.0",
                    Birthday = DateTime.Parse("1950-06-14 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "austin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "Dixon@aool.com",
                    Email = "Dixon@aool.com",
                    PhoneNumber = "2142643255.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    MiddleInitial = "D",
                    LastName = "Dixon",
                    Street = "234 Holston Circle",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75208.0",
                    Birthday = DateTime.Parse("1930-05-09 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "mailbox",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louann@ggmail.com",
                    Email = "louann@ggmail.com",
                    PhoneNumber = "8172556749.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    MiddleInitial = "K",
                    LastName = "Feeley",
                    Street = "600 S 8th Street W",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77010.0",
                    Birthday = DateTime.Parse("1930-02-24 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "aggies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tfreeley@minntonka.ci.state.mn.us",
                    Email = "tfreeley@minntonka.ci.state.mn.us",
                    PhoneNumber = "8173255687.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    MiddleInitial = "P",
                    LastName = "Freeley",
                    Street = "4448 Fairview Ave.",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77009.0",
                    Birthday = DateTime.Parse("1935-09-01 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "raiders",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mgar@aool.com",
                    Email = "mgar@aool.com",
                    PhoneNumber = "8176593544.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    MiddleInitial = "L",
                    LastName = "Garcia",
                    Street = "594 Longview",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77003.0",
                    Birthday = DateTime.Parse("1990-07-03 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "mustangs",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148475583.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    MiddleInitial = "E",
                    LastName = "Haley",
                    Street = "One Cowboy Pkwy",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75261.0",
                    Birthday = DateTime.Parse("1985-09-17 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "region",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jeff@ggmail.com",
                    Email = "jeff@ggmail.com",
                    PhoneNumber = "5126978613.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    MiddleInitial = "T",
                    LastName = "Hampton",
                    Street = "337 38th St.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1995-01-23 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "hungry",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148965621.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    MiddleInitial = "B",
                    LastName = "Hearn",
                    Street = "4225 North First",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75237.0",
                    Birthday = DateTime.Parse("1994-01-08 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "logicon",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",
                    PhoneNumber = "2105788965.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    MiddleInitial = "J",
                    LastName = "Hicks",
                    Street = "32 NE Garden Ln., Ste 910",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78239.0",
                    Birthday = DateTime.Parse("1990-10-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "doofus",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124678821.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    MiddleInitial = "S",
                    LastName = "Ingram",
                    Street = "6548 La Posada Ct.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78736.0",
                    Birthday = DateTime.Parse("1984-04-12 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "mother",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mother.Ingram@aool.com",
                    Email = "mother.Ingram@aool.com",
                    PhoneNumber = "5124653365.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    MiddleInitial = "L",
                    LastName = "Jacobs",
                    Street = "4564 Elm St.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78731.0",
                    Birthday = DateTime.Parse("1983-04-04 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "whimsical",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "victoria@aool.com",
                    Email = "victoria@aool.com",
                    PhoneNumber = "5129457399.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    MiddleInitial = "M",
                    LastName = "Lawrence",
                    Street = "6639 Butterfly Ln.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78761.0",
                    Birthday = DateTime.Parse("1961-02-03 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "nothing",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102449976.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Erik",
                    MiddleInitial = "W",
                    LastName = "Lineback",
                    Street = "1300 Netherland St",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78293.0",
                    Birthday = DateTime.Parse("1946-09-03 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "GoodFellow",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105344627.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    MiddleInitial = "S",
                    LastName = "Lowe",
                    Street = "3201 Pine Drive",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78279.0",
                    Birthday = DateTime.Parse("1992-02-07 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "impede",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "luce_chuck@ggmail.com",
                    Email = "luce_chuck@ggmail.com",
                    PhoneNumber = "2106983548.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Chuck",
                    MiddleInitial = "B",
                    LastName = "Luce",
                    Street = "2345 Rolling Clouds",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78268.0",
                    Birthday = DateTime.Parse("1942-10-25 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "LuceyDucey",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124748138.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    MiddleInitial = "D",
                    LastName = "MacLeod",
                    Street = "2504 Far West Blvd.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78731.0",
                    Birthday = DateTime.Parse("1965-08-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "cloudyday",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",
                    PhoneNumber = "5124579845.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Elizabeth",
                    MiddleInitial = "P",
                    LastName = "Markham",
                    Street = "7861 Chevy Chase",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78732.0",
                    Birthday = DateTime.Parse("1959-04-13 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "emarkbark",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",
                    PhoneNumber = "8174955201.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clarence",
                    MiddleInitial = "A",
                    LastName = "Martin",
                    Street = "87 Alcedo St.",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77045.0",
                    Birthday = DateTime.Parse("1990-01-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "smartinmartin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "smartinmartin.Martin@aool.com",
                    Email = "smartinmartin.Martin@aool.com",
                    PhoneNumber = "8178746718.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    MiddleInitial = "R",
                    LastName = "Martinez",
                    Street = "8295 Sunset Blvd.",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77030.0",
                    Birthday = DateTime.Parse("1987-10-09 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "looter",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177458615.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    MiddleInitial = "R",
                    LastName = "Miller",
                    Street = "8962 Main St.",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77031.0",
                    Birthday = DateTime.Parse("1984-07-21 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "chucky33",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",
                    PhoneNumber = "5122926966.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Kelly",
                    MiddleInitial = "T",
                    LastName = "Nelson",
                    Street = "2601 Red River",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78703.0",
                    Birthday = DateTime.Parse("1956-07-04 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "orange",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",
                    PhoneNumber = "2143125897.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Joe",
                    MiddleInitial = "C",
                    LastName = "Nguyen",
                    Street = "1249 4th SW St.",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75238.0",
                    Birthday = DateTime.Parse("1963-01-29 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "victorious",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103450925.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bill",
                    MiddleInitial = "T",
                    LastName = "O'Reilly",
                    Street = "8800 Gringo Drive",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78260.0",
                    Birthday = DateTime.Parse("1983-01-07 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "billyboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "or@aool.com",
                    Email = "or@aool.com",
                    PhoneNumber = "2142345566.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anka",
                    MiddleInitial = "L",
                    LastName = "Radkovich",
                    Street = "1300 Elliott Pl",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75260.0",
                    Birthday = DateTime.Parse("1980-03-31 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "radicalone",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123744746.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    MiddleInitial = "C",
                    LastName = "Rhodes",
                    Street = "4587 Enfield Rd.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78707.0",
                    Birthday = DateTime.Parse("1944-08-12 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "gohorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "erynrice@aool.com",
                    Email = "erynrice@aool.com",
                    PhoneNumber = "5123876657.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    MiddleInitial = "M",
                    LastName = "Rice",
                    Street = "3405 Rio Grande",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1934-08-02 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "iloveme",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178904374.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jorge",
                    MiddleInitial = "",
                    LastName = "Rodriguez",
                    Street = "6788 Cotter Street",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77057.0",
                    Birthday = DateTime.Parse("1989-08-11 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "greedy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128752943.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    MiddleInitial = "B",
                    LastName = "Rogers",
                    Street = "4965 Oak Hill",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78732.0",
                    Birthday = DateTime.Parse("1967-08-27 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "familiar",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "st-jean@home.com",
                    Email = "st-jean@home.com",
                    PhoneNumber = "2104145678.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Olivier",
                    MiddleInitial = "M",
                    LastName = "Saint-Jean",
                    Street = "255 Toncray Dr.",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78292.0",
                    Birthday = DateTime.Parse("1950-07-08 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "historical",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ss34@ggmail.com",
                    Email = "ss34@ggmail.com",
                    PhoneNumber = "5123497810.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Sarah",
                    MiddleInitial = "J",
                    LastName = "Saunders",
                    Street = "332 Avenue C",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1977-10-29 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "guiltless",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124510084.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "William",
                    MiddleInitial = "T",
                    LastName = "Sewell",
                    Street = "2365 51st St.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78709.0",
                    Birthday = DateTime.Parse("1941-04-21 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "frequent",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",
                    PhoneNumber = "5125479167.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    MiddleInitial = "J",
                    LastName = "Sheffield",
                    Street = "3886 Avenue A",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1937-11-10 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "history",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "johnsmith187@aool.com",
                    Email = "johnsmith187@aool.com",
                    PhoneNumber = "2108321888.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    MiddleInitial = "A",
                    LastName = "Smith",
                    Street = "23 Hidden Forge Dr.",
                    City = "San Antonio",
                    State = "TX",
                    Zipcode = "78280.0",
                    Birthday = DateTime.Parse("1954-10-26 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "squirrel",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142346667.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Dustin",
                    MiddleInitial = "P",
                    LastName = "Stroud",
                    Street = "1212 Rita Rd",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75221.0",
                    Birthday = DateTime.Parse("1932-09-01 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "snakes",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ericstuart@aool.com",
                    Email = "ericstuart@aool.com",
                    PhoneNumber = "5128178335.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    MiddleInitial = "D",
                    LastName = "Stuart",
                    Street = "5576 Toro Ring",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78746.0",
                    Birthday = DateTime.Parse("1930-12-28 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "landus",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174560903.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Peter",
                    MiddleInitial = "L",
                    LastName = "Stump",
                    Street = "1300 Kellen Circle",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77018.0",
                    Birthday = DateTime.Parse("1989-08-13 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "rhythm",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@ggmail.com",
                    Email = "tanner@ggmail.com",
                    PhoneNumber = "8174590929.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    MiddleInitial = "S",
                    LastName = "Tanner",
                    Street = "4347 Almstead",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77044.0",
                    Birthday = DateTime.Parse("1982-05-21 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "kindly",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",
                    PhoneNumber = "5124748452.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    MiddleInitial = "R",
                    LastName = "Taylor",
                    Street = "467 Nueces St.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1960-01-08 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "instrument",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "TayTaylor@aool.com",
                    Email = "TayTaylor@aool.com",
                    PhoneNumber = "5124512631.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Rachel",
                    MiddleInitial = "K",
                    LastName = "Taylor",
                    Street = "345 Longview Dr.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("1975-07-27 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "arched",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "teefrank@hootmail.com",
                    Email = "teefrank@hootmail.com",
                    PhoneNumber = "8178765543.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Frank",
                    MiddleInitial = "J",
                    LastName = "Tee",
                    Street = "5590 Lavell Dr",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77004.0",
                    Birthday = DateTime.Parse("1968-04-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "median",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",
                    PhoneNumber = "2148471154.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clent",
                    MiddleInitial = "J",
                    LastName = "Tucker",
                    Street = "312 Main St.",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75315.0",
                    Birthday = DateTime.Parse("1978-05-19 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "approval",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "avelasco@yaho.com",
                    Email = "avelasco@yaho.com",
                    PhoneNumber = "2143985638.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    MiddleInitial = "G",
                    LastName = "Velasco",
                    Street = "679 W. 4th",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75207.0",
                    Birthday = DateTime.Parse("1963-10-06 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "decorate",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148475244.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jake",
                    MiddleInitial = "T",
                    LastName = "West",
                    Street = "RR 3287",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75323.0",
                    Birthday = DateTime.Parse("1993-10-14 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "grover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louielouie@aool.com",
                    Email = "louielouie@aool.com",
                    PhoneNumber = "2145650098.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Louis",
                    MiddleInitial = "L",
                    LastName = "Winthorpe",
                    Street = "2500 Padre Blvd",
                    City = "Dallas",
                    State = "TX",
                    Zipcode = "75220.0",
                    Birthday = DateTime.Parse("1952-05-31 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "sturdy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124545242.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Reagan",
                    MiddleInitial = "B",
                    LastName = "Wood",
                    Street = "447 Westlake Dr.",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78746.0",
                    Birthday = DateTime.Parse("1992-04-24 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "decorous",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dman@wdwebsolutions.com",
                    Email = "dman@wdwebsolutions.com",
                    PhoneNumber = "5556409287.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Derek",
                    MiddleInitial = "",
                    LastName = "Dreibrodt",
                    Street = "423 Brentwood Dr",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("2001-01-01 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "nasus123",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jman@outlook.com",
                    Email = "jman@outlook.com",
                    PhoneNumber = "5558471234.0",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jacob",
                    MiddleInitial = "",
                    LastName = "Foster",
                    Street = "700 Fancy St",
                    City = "Austin",
                    State = "TX",
                    Zipcode = "78705.0",
                    Birthday = DateTime.Parse("2000-09-01 00:00:00"),
                    IsActive = true,
                    
                },
                Password = "pres4baseball",
                RoleName = "Customer"
            });

            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    // Took Utilities.AddUser from Relational Data Demo -> this is "Utilities/AddUser.cs"
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: " 
                    + errorFlag, ex);
            }

            return result;

        }
    }
}
