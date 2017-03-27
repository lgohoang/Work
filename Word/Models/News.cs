using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Word.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description {get;set;}
        public string content { get; set; }
        public int ID_User { get; set; }
        public DateTime Create_Day { get; set; }
        public DateTime Update_day { get; set; }


    }
}