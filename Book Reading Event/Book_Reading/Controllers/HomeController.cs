using Book_Reading.Models;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public object ShowMe()
        {
            throw new NotImplementedException();
        }

        public object[] Id { get; private set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

       /* public ViewResult Details()
        {
            throw new NotImplementedException();
        }*/

        public IActionResult Index()
        {
            var currentDate = DateTime.Now.Date;
            var pastEvents = context.BookReading.Where(e => e.Date < currentDate);
            var futureEvents = context.BookReading.Where(e => e.Date >= currentDate);

            var publicEvents = context.BookReading.Where(e => e.Type == "Public");

            var model = new EventsViewModel
            {
                PastEvents = pastEvents.ToList(),
                FutureEvents = futureEvents.ToList(),
                PublicEvents = publicEvents.ToList()
            };

            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var publicEvents = context.BookReading.Find(Id);
            return View(publicEvents);
        }

        public IActionResult ShowUs()
        {
            return View("ShowUs");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
