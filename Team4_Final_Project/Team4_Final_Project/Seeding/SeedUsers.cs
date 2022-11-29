using Microsoft.AspNetCore.Identity;


using Team4_Final_Project.Models;
using Team4_Final_Project.Utilities;
using Team4_Final_Project.DAL;

namespace Team4_Final_Project.Seeding
{
    public static class SeedUsers
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
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    PhoneNumber = "(512)555-1234",

                   
                    //FirstName is included as an example
                    FirstName = "Admin",
                    LastName = "Example",
                    MiddleInitial = "D",
                    Street = "123 Willow Street",
                    City= "Houston",
                    Zipcode = "23456",
                    State = "Texas",
                    Birthday = new DateTime(1988, 05, 09, 9, 15, 0),
                    IsActive = true



        },
                Password = "Abc123!",
                RoleName = "Admin"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "employee@example.com",
                    Email = "employee@example.com",
                    PhoneNumber = "(512)555-1234",

                   
                    //FirstName is included as an example
                    FirstName = "Enployee",
                    LastName = "Example",
                    MiddleInitial = "D",
                    Street = "123 Cedar Street",
                    City = "Houston",
                    Zipcode = "23456",
                    State = "Texas",
                    Birthday = new DateTime(2001, 12, 31, 9, 15, 0),
                    IsActive = true



                },
                Password = "Abc123!",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bevo@example.com",
                    Email = "bevo@example.com",
                    PhoneNumber = "(512)555-5555",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bevo",
                    LastName = "Example",
                    MiddleInitial = "E",
                    Street = "123 Oak Street",
                    City = "Houston",
                    Zipcode = "23456",
                    State = "Texas",
                    Birthday = new DateTime(1998, 05, 19, 9, 15, 0),
                    IsActive = true

                },
                Password = "Password123!",
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
