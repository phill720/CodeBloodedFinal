using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBloodedFinal.Models.JsonDataModels
{
    public class Result
    {
        public double score { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string urlname { get; set; }
        public string description { get; set; }
        public object created { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string localized_country_name { get; set; }
        public string state { get; set; }
        public string join_mode { get; set; }
        public string visibility { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public int members { get; set; }
        public Organizer organizer { get; set; }
        public string who { get; set; }
        //public GroupPhoto group_photo { get; set; }
        //public KeyPhoto key_photo { get; set; }
        //public string timezone { get; set; }
        //public NextEvent next_event { get; set; }
        //public Category category { get; set; }
        //public List<Photo2> photos { get; set; }
    }
}