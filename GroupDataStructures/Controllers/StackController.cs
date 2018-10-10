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
            return View();
        }

        //declare vars
        static Stack<string> myStack = new Stack<string>();
        int iStackCount = 0;

        //method for adding to stack
        public ActionResult addToStack()
        {
            myStack.Push("New Entry " + (myStack.Count + 1) + " ");

            return View("Index");
        }

        //method for adding huge list of 2000 items to stack
        public ActionResult addListToStack()
        {
            myStack.Clear();

            for (iStackCount = 1; iStackCount < 2001; iStackCount++)
            {
                myStack.Push("New Entry " + iStackCount + " ");

            }

            return View("Index");
        }

        //method to display the stack for the user to see. ***use action result???
        public ActionResult displayStack()
        {
            return View("Index");
        } 

        //method to delete an item from the stack
        public ActionResult deleteFromStack()
        {
            myStack.Pop();

            return View("Index");

        }

        //method to clear the stack
        public ActionResult clearStack()
        {
            myStack.Clear();

            return View("Index");
        }

        public ActionResult searchStack()
        {


            return View("Index");
        }

        public ActionResult returnToMenu()
        {

            return View("Index");
        }

    }
}