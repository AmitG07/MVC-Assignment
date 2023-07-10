using BusinessLayer.Interface;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repository
{
    class AbstractFactory : IAbstractFactory
    {
        private IEvents objectEvents;

        public AbstractFactory(IEvents objectEvents)
        {
            this.objectEvents = objectEvents;
        }

        public IEventBs CreateEventObject()
        {
            return new EventBs(objectEvents);
        }
    }
}
