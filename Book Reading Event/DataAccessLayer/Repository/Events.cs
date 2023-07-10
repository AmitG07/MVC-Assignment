using Book_Reading.Models;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class Events : IEvents
    {
        private ApplicationDbContext context;
        DateTime currentDate = DateTime.Now.Date;

        public Events(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void create(CreateModel data)
        {
            context.BookReading.Add(data);
            context.SaveChanges();
        }

        public void Delete(CreateModel eve)
        {
            context.BookReading.Remove(eve);
            context.SaveChanges();
        }

        public bool edit(CreateModel data)
        {
            context.BookReading.Update(data);
            context.SaveChanges();
            return true;
        }

        public CreateModel GetEvent(int num)
        {
            var eve = context.BookReading.SingleOrDefault(e => e.EventId == num);
            return eve;
        }

        public CreateModel Details(int Id)
        {
            var publicEvents = context.BookReading.Find(Id);
            return publicEvents;
        }

        public IEnumerable<CreateModel> MyEvents()
        {
            var result = context.BookReading.ToList();
            return result;
        }

        public IEnumerable<CreateModel> EventsInvitedTo()
        {
            var result = context.BookReading.OrderBy(e => e.Date).ToList();
            return result;
        }

        public IEnumerable<CreateModel> AllEvents()
        {
            var result = context.BookReading.OrderBy(e => e.Date).ToList();
            return result;
        }

        public IQueryable<CreateModel> past()
        {
            return context.BookReading.Where(e => e.Date < currentDate);
        }

        public IQueryable<CreateModel> future()
        {
            return context.BookReading.Where(e => e.Date >= currentDate);
        }

        public IQueryable<CreateModel> publicEvent()
        {
            return context.BookReading.Where(e => e.Type == "Public");
        }
    }
}
