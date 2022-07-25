using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RightSolutions4u.Models;

namespace RightSolutions4u.Controllers
{
    public class ContactUsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public  ActionResult Create(IFormCollection collection)
        {
            var context = new RightSolutions4uContext();
            try

            {
                ContactUs contactUs = new ContactUs
                {
                    Name = collection["Name"],
                    Subject = collection["Subject"],
                    Email = collection["email"],
                    Message = collection["Message"]
                };
                context.ContactUs.Add(contactUs);
                context.SaveChanges();
                var a = contactUs.Name;
                ViewBag.Name = a;
                return View("Thanks"); 
            }
            catch(Exception e)
            {
                return View("Thanks"); 
            }
        }

    }
}
