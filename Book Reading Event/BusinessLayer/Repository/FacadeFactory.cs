using BusinessLayer.Interface;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repository
{
    public class FacadeFactory
    {
        private IEventBs Events;

        public FacadeFactory(IEvents objectEvents)
        {
            this.Events = new AbstractFactory(objectEvents).CreateEventObject();
        }

        public FacadeEvent CreateFacadeObject()
        {
            return new FacadeEvent(Events);
        }
    }
}
