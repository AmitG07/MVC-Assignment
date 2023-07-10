using Book_Reading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IEventBs
    {
        public void create(CreateModel data);
        public void Delete(CreateModel eve);
        public bool edit(CreateModel data);

        public CreateModel GetEvent(int num);
        public CreateModel Details(int Id);

        public IEnumerable<CreateModel> MyEvents();
        public IEnumerable<CreateModel> EventsInvitedTo();
        public IEnumerable<CreateModel> AllEvents();

        public IQueryable<CreateModel> past();
        public IQueryable<CreateModel> future();
        public IQueryable<CreateModel> publicEvent();
    }
}
