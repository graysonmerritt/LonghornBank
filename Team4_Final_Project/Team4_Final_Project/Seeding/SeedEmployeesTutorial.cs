
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

   public static class SeedEmployeesTutorial
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
                   UserName = "t.jacobs@longhornbank.neet",
                   Email = "t.jacobs@longhornbank.neet",
                   PhoneNumber = "8176593544.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Todd",
                   MiddleInitial = "L",
                   LastName = "Jacobs",
                   Street = "4564 Elm St.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "77003.0",
                   IsActive = true,
                   
               },
               Password = "society",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "e.rice@longhornbank.neet",
                   Email = "e.rice@longhornbank.neet",
                   PhoneNumber = "2148475583.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Eryn",
                   MiddleInitial = "M",
                   LastName = "Rice",
                   Street = "3405 Rio Grande",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "75261.0",
                   IsActive = true,
                   
               },
               Password = "ricearoni",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "b.ingram@longhornbank.neet",
                   Email = "b.ingram@longhornbank.neet",
                   PhoneNumber = "5126978613.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Brad",
                   MiddleInitial = "S",
                   LastName = "Ingram",
                   Street = "6548 La Posada Ct.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78705.0",
                   IsActive = true,
                   
               },
               Password = "ingram45",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "a.taylor@longhornbank.neet",
                   Email = "a.taylor@longhornbank.neet",
                   PhoneNumber = "2148965621.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Allison",
                   MiddleInitial = "R",
                   LastName = "Taylor",
                   Street = "467 Nueces St.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "75237.0",
                   IsActive = true,
                   
               },
               Password = "nostalgic",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "g.martinez@longhornbank.neet",
                   Email = "g.martinez@longhornbank.neet",
                   PhoneNumber = "2105788965.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Gregory",
                   MiddleInitial = "R",
                   LastName = "Martinez",
                   Street = "8295 Sunset Blvd.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78239.0",
                   IsActive = true,
                   
               },
               Password = "fungus",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "m.sheffield@longhornbank.neet",
                   Email = "m.sheffield@longhornbank.neet",
                   PhoneNumber = "5124678821.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Martin",
                   MiddleInitial = "J",
                   LastName = "Sheffield",
                   Street = "3886 Avenue A",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78736.0",
                   IsActive = true,
                   
               },
               Password = "longhorns",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "j.macleod@longhornbank.neet",
                   Email = "j.macleod@longhornbank.neet",
                   PhoneNumber = "5124653365.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Jennifer",
                   MiddleInitial = "D",
                   LastName = "MacLeod",
                   Street = "2504 Far West Blvd.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78731.0",
                   IsActive = true,
                   
               },
               Password = "smitty",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "j.tanner@longhornbank.neet",
                   Email = "j.tanner@longhornbank.neet",
                   PhoneNumber = "5129457399.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Jeremy",
                   MiddleInitial = "S",
                   LastName = "Tanner",
                   Street = "4347 Almstead",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78761.0",
                   IsActive = true,
                   
               },
               Password = "tanman",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "m.rhodes@longhornbank.neet",
                   Email = "m.rhodes@longhornbank.neet",
                   PhoneNumber = "2102449976.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Megan",
                   MiddleInitial = "C",
                   LastName = "Rhodes",
                   Street = "4587 Enfield Rd.",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78293.0",
                   IsActive = true,
                   
               },
               Password = "countryrhodes",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "e.stuart@longhornbank.neet",
                   Email = "e.stuart@longhornbank.neet",
                   PhoneNumber = "2105344627.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Eric",
                   MiddleInitial = "F",
                   LastName = "Stuart",
                   Street = "5576 Toro Ring",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78279.0",
                   IsActive = true,
                   
               },
               Password = "stewboy",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "l.chung@longhornbank.neet",
                   Email = "l.chung@longhornbank.neet",
                   PhoneNumber = "2106983548.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Lisa",
                   MiddleInitial = "N",
                   LastName = "Chung",
                   Street = "234 RR 12",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78268.0",
                   IsActive = true,
                   
               },
               Password = "lisssa",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "l.swanson@longhornbank.neet",
                   Email = "l.swanson@longhornbank.neet",
                   PhoneNumber = "5124748138.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Leon",
                   MiddleInitial = "",
                   LastName = "Swanson",
                   Street = "245 River Rd",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78731.0",
                   IsActive = true,
                   
               },
               Password = "swansong",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "w.loter@longhornbank.neet",
                   Email = "w.loter@longhornbank.neet",
                   PhoneNumber = "5124579845.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Wanda",
                   MiddleInitial = "K",
                   LastName = "Loter",
                   Street = "3453 RR 3235",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78732.0",
                   IsActive = true,
                   
               },
               Password = "lottery",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "j.white@longhornbank.neet",
                   Email = "j.white@longhornbank.neet",
                   PhoneNumber = "8174955201.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Jason",
                   MiddleInitial = "M",
                   LastName = "White",
                   Street = "12 Valley View",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "77045.0",
                   IsActive = true,
                   
               },
               Password = "evanescent",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "w.montgomery@longhornbank.neet",
                   Email = "w.montgomery@longhornbank.neet",
                   PhoneNumber = "8178746718.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Wilda",
                   MiddleInitial = "K",
                   LastName = "Montgomery",
                   Street = "210 Blanco Dr",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "77030.0",
                   IsActive = true,
                   
               },
               Password = "monty3",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "h.morales@longhornbank.neet",
                   Email = "h.morales@longhornbank.neet",
                   PhoneNumber = "8177458615.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Hector",
                   MiddleInitial = "N",
                   LastName = "Morales",
                   Street = "4501 RR 140",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "77031.0",
                   IsActive = true,
                   
               },
               Password = "hecktour",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "m.rankin@longhornbank.neet",
                   Email = "m.rankin@longhornbank.neet",
                   PhoneNumber = "5122926966.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Mary",
                   MiddleInitial = "T",
                   LastName = "Rankin",
                   Street = "340 Second St",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78703.0",
                   IsActive = true,
                   
               },
               Password = "rankmary",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "l.walker@longhornbank.neet",
                   Email = "l.walker@longhornbank.neet",
                   PhoneNumber = "2143125897.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Larry",
                   MiddleInitial = "G",
                   LastName = "Walker",
                   Street = "9 Bison Circle",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "75238.0",
                   IsActive = true,
                   
               },
               Password = "walkamile",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "g.chang@longhornbank.neet",
                   Email = "g.chang@longhornbank.neet",
                   PhoneNumber = "2103450925.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "George",
                   MiddleInitial = "M",
                   LastName = "Chang",
                   Street = "9003 Joshua St",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "78260.0",
                   IsActive = true,
                   
               },
               Password = "changalang",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "g.gonzalez@longhornbank.neet",
                   Email = "g.gonzalez@longhornbank.neet",
                   PhoneNumber = "2142345566.0",

                   // Add additional fields that you created on the AppUser class
                   //FirstName is included as an example
                   FirstName = "Gwen",
                   MiddleInitial = "J",
                   LastName = "Gonzalez",
                   Street = "103 Manor Rd",
                    City = "Austin",
                   State = "TX",
                   Zipcode = "75260.0",
                   IsActive = true,
                   
               },
               Password = "offbeat",
               RoleName = "Employee"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "dman@longhornbank.neet",
                   Email = "dman@longhornbank.neet",
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
                   IsActive = true,
                   
               },
               Password = "nasus123",
               RoleName = "Admin"
           });

           AllUsers.Add(new AddUserModel()
           {
               User = new AppUser()
               {
                   //populate the user properties that are from the 
                   //IdentityUser base class
                   UserName = "jman@longhornbank.neet",
                   Email = "jman@longhornbank.neet",
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
                   IsActive = true,
                   
               },
               Password = "pres4baseball",
               RoleName = "Admin"
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
