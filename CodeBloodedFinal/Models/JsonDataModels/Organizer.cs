using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBloodedFinal.Models.JsonDataModels
{
    public class Organizer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string bio { get; set; }
        public Photo photo { get; set; }
    }
}