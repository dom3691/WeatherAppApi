using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOASS.Models
{
    public class TodoModel
    {
        public Guid id { get; set; }    
        public string Description { get; set; }
        
        public string IsDone { get; set; }
        public string Status { get; set; }
        public string Datetime { get; set; }

    }
}