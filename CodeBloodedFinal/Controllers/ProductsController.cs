
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeBloodedFinal.Controllers;
using CodeBloodedFinal.Models;
using System.Web.Script.Serialization;
using CodeBloodedFinal.Models.JsonDataModels;

namespace CodeBloodedFinal.Controllers
{
    public class ProductsController : Controller
    {
        private readonly string APIKEY = "5e1d7e6e714b153e30a0329197673";
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Name, string Email, string Zip)
        {

            //searchUrl = @"https://api.meetup.com/find/groups?photo-host=public&zip=48235&page=10&text=healthy%2C+Detroit&sig_id=214750620&sig=e1f04082a1c49310a93c6fb4d0a6c75a4d2a14ab";
            //String searchUrl = @"https://api.meetup.com/find/groups?key=5e1d7e6e714b153e30a0329197673&sign=true&photo-host=public&zip=48226&text=healthy,%20Detroit&page=10";

            String searchUrl = @"https://api.meetup.com/find/groups?key=" + APIKEY + $@"&sign=true&photo-host=public&zip=" + Zip + $@"&text=healthy,%20Detroit&page=10";
            var jobject = MakeRequest(searchUrl);

            JavaScriptSerializer oJS = new JavaScriptSerializer();
            RootObject oRootObject = new RootObject();
            oRootObject = oJS.Deserialize<RootObject>(MakeRequest(searchUrl).ToString());
            var junk = jobject["name"];

            var o = jobject["name"]["link"]["members"].ToList();

            List<string> lst = new List<string>();

            foreach (var r in o)
            {
                lst.Add(r.ToString());
            }
            ViewBag.results = lst;

            //ViewBag.location = jobject["location"]["areaDescription"].ToString();
            
            return View("SearchResults");
        }

        public JObject MakeRequest(string requestUrl)
        {
            JObject o;
            try
            {

                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
                request.UseDefaultCredentials = true;
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //o = JObject.Parse("{error:\"Server error\"}");
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    }
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        string result = reader.ReadToEnd();
                        if (result.Length>0 && result.Substring(0,1)=="[") {
                            result = "{\"result\":"+result+"}";
                        }
                        o = JObject.Parse(result); 
                        return o;
                    }
                } }
            catch (Exception e)
            {
                // catch exception and log it
                o = JObject.Parse("{error:\"" + e.Message + "\"}");

                return o;
            }

        }


    }

}