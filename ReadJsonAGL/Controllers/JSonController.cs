using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using Newtonsoft.Json;
using ReadJsonAGL.Helpers;

namespace ReadJsonAGL.Controllers
{
    public class JSonController : Controller
    {
        [System.Web.Mvc.HttpGet]
        public ActionResult GetCats()
        {
            //IEnumerable<OwnersandPets> maleOwners = new List<OwnersandPets>();
            //IEnumerable<Pet> maleownerpets = new List<Pet>();
            //IEnumerable<string> catsWithMaleOwnersList = new List<string>();
            using(var w = new WebClient()){
            var jsonurl = "http://agl-developer-test.azurewebsites.net/people.json";
            var JSonData = string.Empty;
            try
            {
                JSonData = w.DownloadString(jsonurl);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to fetch the Json data with exception: "+ex);
            }

            var AllJsonList = JsonConvert.DeserializeObject<List<OwnersandPets>>(JSonData);
           // maleOwners = AllJsonList.Where(x => x.gender == "male").ToList();

            //maleownerpets = maleOwners.Select(y => y.pets).ToList();
                //catsWithMaleOwnersList =maleownerpets.Select()
            //return "test";
                return Json(AllJsonList,JsonRequestBehavior.AllowGet) ;
            }
        }
        //
        // GET: /JSon/
        public ActionResult Index()
        {
            return View();
        }
	}
}