using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalenderEventAsp.NetFrameworkProject.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public bool AllDay { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public int CategoryId { get; set; }
    }
}