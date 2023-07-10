using Book_Reading.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using DataAccessLayer;
using BusinessLayer.Interface;
using BusinessLayer;
using BusinessLayer.Repository;

namespace Book_Reading.Controllers
{
    /*[Authorize(Policy = "RequireAdminRole")]*/
    public class EventController : Controller
    {
        //private readonly ApplicationDbContext context;
        /*private readonly IEventBs eventBs;*/
        /*private IFacadeFactory Factory_Object;*/
        private readonly UserManager<ApplicationUser> userManager;
        private readonly FacadeEvent facade;
        

        public EventController(UserManager<ApplicationUser> userManager, FacadeFactory _obj)
        {
            //this.context = context;
            /*eventBs = _obj;*/
            this.userManager = userManager;
            facade = _obj.CreateFacadeObject();
        }

        public IActionResult Index()
        {
            var pastEvents = facade.past();
            var futureEvents = facade.future();
            var publicEvents = facade.publicEvent();

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
            var publicEvents = facade.Details(Id);
            return View(publicEvents);
        }

        [HttpGet]
        public IActionResult create()
        {
            ViewBag.TypeOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Public", Value = "Public"},
                new SelectListItem { Text = "Private", Value = "Private"}
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> create(CreateModel model)
        {
            var user = await userManager.GetUserAsync(User);
            var user_Id = user.Email;
            model.MailId = user_Id;

            if (ModelState.IsValid)
            {
                var data = new CreateModel
                {
                    MailId = model.MailId,
                    Title = model.Title,
                    Date = model.Date,
                    Location = model.Location,
                    StartTime = model.StartTime,
                    DurationInHours = model.DurationInHours,
                    Description = model.Description,
                    Type = model.Type,
                    OtherDetails = model.OtherDetails,
                    InviteByEmail = model.InviteByEmail
                };
                facade.create(data);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty field Cant Submit";
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            var eve = facade.GetEvent(id);
            facade.Delete(eve);
            return RedirectToAction("Index");
        }

        int num;

        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {
            ViewBag.TypeOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Public", Value = "Public"},
                new SelectListItem { Text = "Private", Value = "Private"}
            };
            num = id;
            //var eve = context.BookReading.SingleOrDefault(e => e.EventId == num);

            var eve = facade.GetEvent(id);
            var user = await userManager.GetUserAsync(User);
            if(eve.MailId == user.Email)
            {
                var result = new CreateModel()
                {
                    EventId = eve.EventId,
                    MailId = eve.MailId,
                    Title = eve.Title,
                    Date = eve.Date,
                    Location = eve.Location,
                    StartTime = eve.StartTime,
                    DurationInHours = eve.DurationInHours,
                    Description = eve.Description,
                    Type = eve.Type,
                    OtherDetails = eve.OtherDetails,
                    InviteByEmail = eve.InviteByEmail
                };
                return View(result);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(CreateModel model)
        {
            //var eve = context.Events.SingleOrDefault(e => e.UserId == num);
            var data = new CreateModel
            {
                EventId = model.EventId,
                MailId = model.MailId,
                Title = model.Title,
                Date = model.Date,
                Location = model.Location,
                StartTime = model.StartTime,
                DurationInHours = model.DurationInHours,
                Description = model.Description,
                Type = model.Type,
                OtherDetails = model.OtherDetails,
                InviteByEmail = model.InviteByEmail
            };
            facade.edit(data);
            return RedirectToAction("Index");
        }

        public IActionResult myevent()
        {
            var result = facade.MyEvents();
            return View(result);
        }

        public IActionResult eventsInvitedTo()
        {
            var result = facade.EventsInvitedTo();
            return View(result);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult allEvents()
        {
            var result = facade.AllEvents();
            return View(result);
        }
    }
}