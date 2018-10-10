using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupDataStructures.Controllers
{
    public class DictionaryController : Controller
    {
        public static Dictionary<String, int> dUserDictionary = new Dictionary<string, int>();
        public static int myCount = 1;
        public static String myKey = "";

        // GET: Dictionary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddOne()
        {
            myKey = "Entry #" + myCount.ToString();
            dUserDictionary.Add(myKey, myCount);
            ViewBag.vUserDictionary = dUserDictionary;
            return View("Index");
        }
    }
}