using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Word.Models
{
    public class History
    {
        public int ID { get; set; }
        public string Name_file { get; set; }
        public string Content { get; set; }
        public int User_ID { get; set; }
        public DateTime Time_Create { get; set; }
        public bool Status { get; set; }
    }
}