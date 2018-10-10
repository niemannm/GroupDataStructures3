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
            ++iStackCount;
            myStack.Push("New Entry " + iStackCount);
            myStack.Push("New Entry " + (myStack.Count + 1) + " ");

            return View();
        }

        //method for adding huge list of 2000 items to stack
        public ActionResult addListToStack()
        {
            myStack.Clear();

            for (iStackCount = 1; iStackCount < 2001; iStackCount++)
            {
<<<<<<< HEAD
                myStack.Push("New Entry " + iStackCount + " \n");
=======
                myStack.Push("New Entry " + iStackCount);
>>>>>>> a630cb238fd8f4ca45033af93384fa72b3cd0f10
                myStack.Push("New Entry " + iStackCount + " ");
            }

            return View();
        }

        //method to display the stack for the user to see. ***use action result???
        public ActionResult displayStack()
        {
            return View("Stack");
        } 

        //method to delete an item from the stack
        public ActionResult deleteFromStack()
        {
            myStack.Pop();

            return View();

        }

        //method to clear the stack
        public ActionResult clearStack()
        {
            myStack.Clear();

            return View("Index");
        }

        public ActionResult searchStack()
        {


            return View();
        }

        public ActionResult returnToMenu()
        {

            return View();
        }

    }
}