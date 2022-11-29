using fa22team31finalproject.DAL;
//TODO: Update this using statement to include your project name
using fa22team31finalproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//TODO: Upddate this namespace to match your project name
namespace fa22team31finalproject.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;

        public SeedController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedAllTransactions()
        {
            try
            {
                Seeding.SeedTransactions.SeedAllTransactions(_context);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedAllAccounts()
        {
            try
            {
                Seeding.SeedAccounts.SeedAllAccounts(_context);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding repositories to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }
    }
}
