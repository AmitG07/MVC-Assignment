using Book_Reading.Models;
using BusinessLayer.Interface;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Repository
{
    public class EventBs : IEventBs
    {
        private IEvents objEvents;

        public EventBs(IEvents obj)
        {
            objEvents = obj;
        }

        public void create(CreateModel data)
        {
            objEvents.create(data);
        }

        public void Delete(CreateModel eve)
        {
            objEvents.Delete(eve);
        }

        public bool edit(CreateModel data)
        {
            return objEvents.edit(data);
        }

        public CreateModel GetEvent(int num)
        {
            return objEvents.GetEvent(num);
        }

        public CreateModel Details(int Id)
        {
            return objEvents.Details(Id);
        }

        public IEnumerable<CreateModel> MyEvents()
        {
            return objEvents.MyEvents();
        }

        public IEnumerable<CreateModel> EventsInvitedTo()
        {
            return objEvents.EventsInvitedTo();
        }

        public IEnumerable<CreateModel> AllEvents()
        {
            return objEvents.AllEvents();
        }

        public IQueryable<CreateModel> past()
        {
            return objEvents.past();
        }

        public IQueryable<CreateModel> future()
        {
            return objEvents.future();
        }

        public IQueryable<CreateModel> publicEvent()
        {
            return objEvents.publicEvent();
        }
    }
}
