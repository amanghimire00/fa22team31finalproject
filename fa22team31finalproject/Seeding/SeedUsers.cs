
using fa22team31finalproject.DAL;
using fa22team31finalproject.Models;
using fa22team31finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa22team31finalproject.Seeding
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
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125571146",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    MI = "L",
                    Address = "1245 Lake Austin Blvd.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78733",
                    DOB = new DateTime(1991, 2, 7),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2102678873",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Banks",
                    MI = "nan",
                    Address = "1300 Tall Pine Lane",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78261",
                    DOB = new DateTime(1990, 6, 23),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8175659699",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    MI = "V",
                    Address = "62 Browning Rd",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77019",
                    DOB = new DateTime(1986, 5, 6),
                    Fired = false,
                    isActive = true,
                },
                Password = "666666",
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
                    PhoneNumber = "5125943222",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    LastName = "Chang",
                    MI = "L",
                    Address = "202 Bellmont Hall",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78713",
                    DOB = new DateTime(1964, 12, 21),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2107724599",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    LastName = "Chou",
                    MI = "nan",
                    Address = "1600 Teresa Lane",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78266",
                    DOB = new DateTime(1950, 6, 14),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2142643255",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    LastName = "Dixon",
                    MI = "D",
                    Address = "234 Holston Circle",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75208",
                    DOB = new DateTime(1930, 5, 9),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8172556749",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    MI = "K",
                    Address = "600 S 8th Street W",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77010",
                    DOB = new DateTime(1930, 2, 24),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8173255687",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    MI = "P",
                    Address = "4448 Fairview Ave.",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77009",
                    DOB = new DateTime(1935, 9, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8176593544",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    MI = "L",
                    Address = "594 Longview",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77003",
                    DOB = new DateTime(1990, 7, 3),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148475583",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Haley",
                    MI = "E",
                    Address = "One Cowboy Pkwy",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75261",
                    DOB = new DateTime(1985, 9, 17),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5126978613",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    MI = "T",
                    Address = "337 38th St.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1995, 1, 23),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148965621",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Hearn",
                    MI = "B",
                    Address = "4225 North First",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75237",
                    DOB = new DateTime(1994, 1, 8),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2105788965",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    MI = "J",
                    Address = "32 NE Garden Ln., Ste 910",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78239",
                    DOB = new DateTime(1990, 10, 6),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124678821",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Ingram",
                    MI = "S",
                    Address = "6548 La Posada Ct.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78736",
                    DOB = new DateTime(1984, 4, 12),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124653365",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MI = "L",
                    Address = "4564 Elm St.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    DOB = new DateTime(1983, 4, 4),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5129457399",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    MI = "M",
                    Address = "6639 Butterfly Ln.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78761",
                    DOB = new DateTime(1961, 2, 3),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2102449976",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Erik",
                    LastName = "Lineback",
                    MI = "W",
                    Address = "1300 Netherland St",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78293",
                    DOB = new DateTime(1946, 9, 3),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2105344627",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    MI = "S",
                    Address = "3201 Pine Drive",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78279",
                    DOB = new DateTime(1992, 2, 7),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2106983548",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Chuck",
                    LastName = "Luce",
                    MI = "B",
                    Address = "2345 Rolling Clouds",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78268",
                    DOB = new DateTime(1942, 10, 25),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124748138",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    MI = "D",
                    Address = "2504 Far West Blvd.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    DOB = new DateTime(1965, 8, 6),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124579845",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    MI = "P",
                    Address = "7861 Chevy Chase",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78732",
                    DOB = new DateTime(1959, 4, 13),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8174955201",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clarence",
                    LastName = "Martin",
                    MI = "A",
                    Address = "87 Alcedo St.",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77045",
                    DOB = new DateTime(1990, 1, 6),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8178746718",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    MI = "R",
                    Address = "8295 Sunset Blvd.",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77030",
                    DOB = new DateTime(1987, 10, 9),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8177458615",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Miller",
                    MI = "R",
                    Address = "8962 Main St.",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77031",
                    DOB = new DateTime(1984, 7, 21),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5122926966",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    MI = "T",
                    Address = "2601 Red River",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78703",
                    DOB = new DateTime(1956, 7, 4),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2143125897",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    MI = "C",
                    Address = "1249 4th SW St.",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75238",
                    DOB = new DateTime(1963, 1, 29),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2103450925",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    MI = "T",
                    Address = "8800 Gringo Drive",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78260",
                    DOB = new DateTime(1983, 1, 7),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2142345566",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    MI = "L",
                    Address = "1300 Elliott Pl",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75260",
                    DOB = new DateTime(1980, 3, 31),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5123744746",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    MI = "C",
                    Address = "4587 Enfield Rd.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78707",
                    DOB = new DateTime(1944, 8, 12),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5123876657",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    MI = "M",
                    Address = "3405 Rio Grande",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1934, 8, 2),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8178904374",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    MI = "nan",
                    Address = "6788 Cotter Street",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77057",
                    DOB = new DateTime(1989, 8, 11),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5128752943",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Rogers",
                    MI = "B",
                    Address = "4965 Oak Hill",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78732",
                    DOB = new DateTime(1967, 8, 27),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2104145678",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    MI = "M",
                    Address = "255 Toncray Dr.",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78292",
                    DOB = new DateTime(1950, 7, 8),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5123497810",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    MI = "J",
                    Address = "332 Avenue C",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1977, 10, 29),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124510084",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "William",
                    LastName = "Sewell",
                    MI = "T",
                    Address = "2365 51st St.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78709",
                    DOB = new DateTime(1941, 4, 21),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5125479167",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    MI = "J",
                    Address = "3886 Avenue A",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1937, 11, 10),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2108321888",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Smith",
                    MI = "A",
                    Address = "23 Hidden Forge Dr.",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78280",
                    DOB = new DateTime(1954, 10, 26),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2142346667",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    MI = "P",
                    Address = "1212 Rita Rd",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75221",
                    DOB = new DateTime(1932, 9, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5128178335",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    LastName = "Stuart",
                    MI = "D",
                    Address = "5576 Toro Ring",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78746",
                    DOB = new DateTime(1930, 12, 28),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8174560903",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Peter",
                    LastName = "Stump",
                    MI = "L",
                    Address = "1300 Kellen Circle",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77018",
                    DOB = new DateTime(1989, 8, 13),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8174590929",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    MI = "S",
                    Address = "4347 Almstead",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77044",
                    DOB = new DateTime(1982, 5, 21),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124748452",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",
                    MI = "R",
                    Address = "467 Nueces St.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1960, 1, 8),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124512631",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    MI = "K",
                    Address = "345 Longview Dr.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1975, 7, 27),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8178765543",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Frank",
                    LastName = "Tee",
                    MI = "J",
                    Address = "5590 Lavell Dr",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77004",
                    DOB = new DateTime(1968, 4, 6),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148471154",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clent",
                    LastName = "Tucker",
                    MI = "J",
                    Address = "312 Main St.",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75315",
                    DOB = new DateTime(1978, 5, 19),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2143985638",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Velasco",
                    MI = "G",
                    Address = "679 W. 4th",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75207",
                    DOB = new DateTime(1963, 10, 6),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148475244",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jake",
                    LastName = "West",
                    MI = "T",
                    Address = "RR 3287",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75323",
                    DOB = new DateTime(1993, 10, 14),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2145650098",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    MI = "L",
                    Address = "2500 Padre Blvd",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75220",
                    DOB = new DateTime(1952, 5, 31),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124545242",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Reagan",
                    LastName = "Wood",
                    MI = "B",
                    Address = "447 Westlake Dr.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78746",
                    DOB = new DateTime(1992, 4, 24),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5556409287",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    MI = "nan",
                    Address = "423 Brentwood Dr",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(2001, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5558471234",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jacob",
                    LastName = "Foster",
                    MI = "nan",
                    Address = "700 Fancy St",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(2000, 9, 1),
                    Fired = false,
                    isActive = true,
                },
                Password = "pres4baseball",
                RoleName = "Customer"
            });
            
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "t.jacobs@longhornbank.neet",
                    Email = "t.jacobs@longhornbank.neet",
                    PhoneNumber = "8176593544",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MI = "L",
                    Address = "4564 Elm St.",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77003",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148475583",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    MI = "M",
                    Address = "3405 Rio Grande",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75261",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5126978613",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Ingram",
                    MI = "S",
                    Address = "6548 La Posada Ct.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2148965621",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",
                    MI = "R",
                    Address = "467 Nueces St.",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75237",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2105788965",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    MI = "R",
                    Address = "8295 Sunset Blvd.",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78239",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124678821",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    MI = "J",
                    Address = "3886 Avenue A",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78736",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124653365",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    MI = "D",
                    Address = "2504 Far West Blvd.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5129457399",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    MI = "S",
                    Address = "4347 Almstead",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78761",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2102449976",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    MI = "C",
                    Address = "4587 Enfield Rd.",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78293",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2105344627",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    LastName = "Stuart",
                    MI = "F",
                    Address = "5576 Toro Ring",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78279",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2106983548",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lisa",
                    LastName = "Chung",
                    MI = "N",
                    Address = "234 RR 12",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78268",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124748138",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Leon",
                    LastName = "Swanson",
                    MI = "nan",
                    Address = "245 River Rd",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5124579845",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wanda",
                    LastName = "Loter",
                    MI = "K",
                    Address = "3453 RR 3235",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78732",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8174955201",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jason",
                    LastName = "White",
                    MI = "M",
                    Address = "12 Valley View",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77045",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8178746718",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wilda",
                    LastName = "Montgomery",
                    MI = "K",
                    Address = "210 Blanco Dr",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77030",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "8177458615",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Hector",
                    LastName = "Morales",
                    MI = "N",
                    Address = "4501 RR 140",
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77031",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5122926966",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Mary",
                    LastName = "Rankin",
                    MI = "T",
                    Address = "340 Second St",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78703",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2143125897",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Larry",
                    LastName = "Walker",
                    MI = "G",
                    Address = "9 Bison Circle",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75238",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2103450925",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "George",
                    LastName = "Chang",
                    MI = "M",
                    Address = "9003 Joshua St",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78260",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "2142345566",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gwen",
                    LastName = "Gonzalez",
                    MI = "J",
                    Address = "103 Manor Rd",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75260",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5556409287",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    MI = "nan",
                    Address = "423 Brentwood Dr",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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
                    PhoneNumber = "5558471234",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jacob",
                    LastName = "Foster",
                    MI = "nan",
                    Address = "700 Fancy St",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    DOB = new DateTime(1900, 1, 1),
                    Fired = false,
                    isActive = true,
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

