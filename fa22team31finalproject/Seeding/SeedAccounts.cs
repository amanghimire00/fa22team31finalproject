﻿using fa22team31finalproject.DAL;
//TODO: Update these using statements to include your project name
using fa22team31finalproject.Models;
using fa22team31finalproject.Utilities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//TODO: Upddate this namespace to match your project name
namespace fa22team31finalproject.Seeding
{
    public static class SeedAccounts
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

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Admin",
                    LastName = "Example",
                    MI = "M",
                    Address = "123 L",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78701",
                    DOB = "11/28/22"

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
                    UserName = "bevo@example.com",
                    Email = "bevo@example.com",
                    PhoneNumber = "(512)555-5555",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bevo",
                    LastName = "Longhorn",
                    MI = "M",
                    Address = "123 L",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78701",
                    DOB = "11/28/22"
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
