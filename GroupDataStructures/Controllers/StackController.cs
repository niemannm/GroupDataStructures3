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
        Stack<string> myStack = new Stack<string>();
        int iStackCount = 0;

        //method for adding to stack
        public void addToStack()
        {
            ++iStackCount;
            myStack.Push("New Entry " + iStackCount);  
        }

        //method for adding huge list of 2000 items to stack
        public void addListToStack()
        {
                myStack.Clear();
                for (iStackCount = 0; iStackCount < 2001; ++iStackCount)
                {
                    myStack.Push("New Entry " + iStackCount);
                }
        }

        public displayStack()
        {

            return View();
        } 

        public void deleteFromStack()
        {


        }

        public void clearStack()
        {


        }

        public void searchStack()
        {


        }

        public void returnToMenu()
        {


        }

    }
}