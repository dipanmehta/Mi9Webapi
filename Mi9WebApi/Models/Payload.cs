using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Mi9Project.Models
{
    public class Payload
    {
    
        public List<Show> payload { get; set; }

    
        public int skip { get; set; }

    
        public int take { get; set; }

    
        public int totalRecords { get; set; }

    }
}
