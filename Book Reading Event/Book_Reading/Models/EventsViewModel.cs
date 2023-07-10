using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading.Models
{
    public class EventsViewModel
    {
        public List<CreateModel> PastEvents { get; set; }
        public List<CreateModel> FutureEvents { get; set; }
        public List<CreateModel> PublicEvents { get; set; }
    }
}
