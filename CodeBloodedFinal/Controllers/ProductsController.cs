
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
using SloganHealth;

namespace CodeBloodedFinal.Controllers
{
    public class ProductsController : Controller
    {
        //------API key to access Meetup------
        private readonly string APIKEY = "5e1d7e6e714b153e30a0329197673";
        //------------------------------------

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
        public ActionResult Index(FormCollection Form, HealthyD userInfo)
        {

            //------Adding in datbase---------
            HealthyInD dbcontext = new HealthyInD();
            if (userInfo == null)
            {
                userInfo = new HealthyD();
            }
            userInfo.Name = Form["Name"].ToString();
            userInfo.Email = Form["Email"].ToString();
            //-------ZipRange method to check for valid zip-------
            string Zip = Form["Zip"].ToString();
            userInfo.Zip = ZipRange(Zip);
            //----------------------------------------------------

            //-------If no errors are returned-------
            if (ModelState.IsValid)
            {
                //-----Final save to database------
                dbcontext.HealthyDs.Add(userInfo);
                dbcontext.SaveChanges();
                //---------------------------------

                //-------Connecting to API--------
                //searchUrl = @"https://api.meetup.com/find/groups?photo-host=public&zip=48235&page=10&text=healthy%2C+Detroit&sig_id=214750620&sig=e1f04082a1c49310a93c6fb4d0a6c75a4d2a14ab";
                //String searchUrl = @"https://api.meetup.com/find/groups?key=5e1d7e6e714b153e30a0329197673&sign=true&photo-host=public&zip=48226&text=healthy,%20Detroit&page=10";
                String searchUrl = @"https://api.meetup.com/find/groups?key=" + APIKEY + $@"&sign=true&photo-host=public&zip=" + userInfo.Zip + $@"&text=healthy,%20Detroit&page=10";
                var jobject = MakeRequest(searchUrl);
                //--------------------------------

                //--------Reading/Formatting Data?--------
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                RootObject oRootObject = new RootObject();
                oRootObject = oJS.Deserialize<RootObject>(MakeRequest(searchUrl).ToString());
                var o = jobject["result"].ToList();
                //----------------------------------------

                //------Creates list for user info------
                List<ADTO> lst = new List<ADTO>();
                //-----Adds to list-----
                foreach (JObject r in o)
                {
                    ADTO record = new ADTO();
                    record.Name = r["name"].ToString();
                    record.link = r["link"].ToString();
                    record.Members = int.Parse(r["members"].ToString());
                    lst.Add(record);
                }
                //-----------------------
                ViewBag.results = lst;
                ViewBag.Slogan = SloganList.GetRandomSlogan();

                //----Displays searchResults page with info----
                return View("SearchResults", userInfo);
                //---------------------------------------------
            }

            //------If an error is returned------
            else
            {
                ViewBag.InvMessage = "Invalid Fields";
                return View();
            }
            //-----------------------------------
        }

        public JObject MakeRequest(string requestUrl)
        {
            JObject o;
            try
            {
                //------API access request------
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
                request.UseDefaultCredentials = true;
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                //------------------------------
                
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    //------Keep trying if not granted access------
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //o = JObject.Parse("{error:\"Server error\"}");
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    }
                    //---------------------------------------------

                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        //-----Remove beginning/end bracket-----
                        string result = reader.ReadToEnd();
                        if (result.Length > 0 && result.Substring(0, 1) == "[")
                        {
                            result = "{\"result\":" + result + "}";
                        }
                        o = JObject.Parse(result);
                        return o;
                        //----------Return parsed code----------
                    }
                }
            }
            catch (Exception e)
            {
                //-----catch exception and log it-----
                o = JObject.Parse("{error:\"" + e.Message + "\"}");
                return o;
                //------------------------------------
            }

        }

        public ActionResult Store()
        {
            return View();
        }

        public string ZipRange(string zip)
        {
            //---Return downtown if zip isn't in detroit---
            if (zip != "48201" &&  zip != "48202" && zip != "48204" && zip != "48205" && zip != "48206" && zip != "48207" && zip != "48208" && zip != "48209" && zip != "48210" && zip != "48211" && zip != "48213" && zip != "48214" && zip != "48215" && zip != "48216" && zip != "48217" && zip != "48219" && zip != "48221" && zip != "48222" && zip != "48223" && zip != "48224" && zip != "48226" && zip != "48227" && zip != "48228" && zip != "48231" && zip != "48232" && zip != "48233" && zip != "48234" && zip != "48235" && zip != "48238" && zip != "48242" && zip != "48243" && zip != "48244" && zip != "48255" && zip != "48260" && zip != "48264" && zip != "48265" && zip != "48266" && zip != "48267" && zip != "48268" && zip != "48269" && zip != "48272" && zip != "48275" && zip != "48277" && zip != "48278" && zip != "48279" && zip != "48288")
                {
                    ViewBag.OutCityZip = "Unfortunately your zip is out of Detroit, but here's a list of great Detroit Groups.";
                    return "48226";
                }

            //------Keep the same zip if in detroit------
            else
                {
                    ViewBag.OutCityZip = "";
                    return zip;
                }
            //---------------------------------------------
        }
    }
}