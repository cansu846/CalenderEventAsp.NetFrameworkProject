using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalenderEventAsp.NetFrameworkProject.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}