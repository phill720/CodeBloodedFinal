﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBloodedFinal.Models.JsonDataModels
{
    public class Photo
    {
        public int id { get; set; }
        public string highres_link { get; set; }
        public string photo_link { get; set; }
        public string thumb_link { get; set; }
        public string type { get; set; }
        public string base_url { get; set; }
    }
}