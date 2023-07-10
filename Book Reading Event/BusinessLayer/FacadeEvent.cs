using Book_Reading.Models;
using BusinessLayer.Decorator;
using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class FacadeEvent
    {
        private IEventBs Events;

        public FacadeEvent(IEventBs Events)
        {
            this.Events = Events;
        }

        public void create(CreateModel data)
        {
            Events.create(data);
        }

        public void Delete(CreateModel eve)
        {
            Events.Delete(eve);
        }

        public bool edit(CreateModel data)
        {
            return Events.edit(data);
        }

        public CreateModel GetEvent(int num)
        {
            try
            {
                return Events.GetEvent(num);
            }
            catch(Exception exe)
            {
                CustomExceptionHandler.HandleException(exe);
                return null;
            }
        }

        public CreateModel Details(int Id)
        {
            try
            {
                return Events.Details(Id);
            }
            catch (Exception exe)
            {
                CustomExceptionHandler.HandleException(exe);
                return null;
            }
        }

        public IEnumerable<CreateModel> MyEvents()
        {
            return Events.MyEvents();
        }

        public IEnumerable<CreateModel> EventsInvitedTo()
        {
            return Events.EventsInvitedTo();
        }

        public IEnumerable<CreateModel> AllEvents()
        {
            return Events.AllEvents();
        }

        public IQueryable<CreateModel> past()
        {
            return Events.past();
        }

        public IQueryable<CreateModel> future()
        {
            return Events.future();
        }

        public IQueryable<CreateModel> publicEvent()
        {
            return Events.publicEvent();
        }
    }
}
