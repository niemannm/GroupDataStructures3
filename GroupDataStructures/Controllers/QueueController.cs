using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupDataStructures.Controllers
{
    public class QueueController : Controller
    {
        static Queue<int> numbers = new Queue<int>();

        // GET: Queue
     
        public ActionResult Index()
        {
            ViewBag.MyQueue = numbers;
            return View();
        }

        public ActionResult addQueueItem()
        {
            numbers.Enqueue(numbers.Count + 1);
            ViewBag.MyQueue = numbers;
            return View("Index");
        }

        public ActionResult addQueueList()
        {
            for (var i = 0; i < 2000; i++)
                {
                    numbers.Enqueue(i);
                    ViewBag.MyList += ViewBag.MyList + i;
                }
            return View("Index");

        }
    }
}