using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupDataStructures.Controllers
{
    public class StackController : Controller
    {
        // GET: Stack
        public ActionResult Index()
        {
            return View("Index");
        }

        //declare vars
        static Stack<string> myStack = new Stack<string>();
        static int iStackCount = 0;

        //method for adding to stack
        public ActionResult addToStack()
        {
<<<<<<< HEAD
            ++iStackCount;
            myStack.Push("New Entry " + iStackCount + " ");
=======
            myStack.Push("New Entry " + (myStack.Count + 1) + " ");
>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482

            return View("Index");
        }

        //method for adding huge list of 2000 items to stack
        public ActionResult addListToStack()
        {
            myStack.Clear();

<<<<<<< HEAD
            for (iStackCount = 0; iStackCount < 2000; iStackCount++)
            {
                myStack.Push("New Entry " + (iStackCount + 1) + " ");
=======
            for (iStackCount = 1; iStackCount < 2001; iStackCount++)
            {
                myStack.Push("New Entry " + iStackCount + " ");

>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482
            }

            return View("Index");
        }



        //method to display the stack for the user to see. ***use action result???
        public ActionResult displayStack()
        {
<<<<<<< HEAD


            foreach (string s in myStack)
            {
                ViewBag.displayStack += s;
            }
            return View("Index");

        }
=======
            return View("Index");
        } 
>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482

        //method to delete an item from the stack
        public ActionResult deleteFromStack()
        {
            myStack.Pop();
<<<<<<< HEAD
            iStackCount--;
=======

>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482
            return View("Index");

        }

        //method to clear the stack
        public ActionResult clearStack()
        {
            myStack.Clear();
<<<<<<< HEAD
            iStackCount = 0;
=======

>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482
            return View("Index");
        }

        public ActionResult searchStack()
        {
            System.Diagnostics.Stopwatch timeMe = new System.Diagnostics.Stopwatch();

            timeMe.Start();

<<<<<<< HEAD
            bool isFound = false;
            foreach (string s in myStack)
            {
                if (s == "New Entry 12 ")
                {
                    ViewBag.isFound = "The number twelve was found in the stack. It took:";
                    isFound = true;
                }
            }
=======
            return View("Index");
        }
>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482

            timeMe.Stop();

<<<<<<< HEAD
            if (isFound == false)
            {
                ViewBag.isFound = "The number twelve was not found in the stack. We searched for:";
            }

            TimeSpan ts = timeMe.Elapsed;
=======
            return View("Index");
        }
>>>>>>> d54f159825dc6c48c25ad61f9e563f88009e5482

            ViewBag.time = ts;
            return View("Index");

        }
    }
}