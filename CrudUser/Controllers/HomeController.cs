using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudUser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string input = "one two three four five";

            //split the string into list of strings
            List<string> stringList = input.Split(' ').ToList();
            string merged = "";
            //loop into the main list of strings
            foreach( string stg in stringList)
            {// loop and reverse each element of the main list
                for ( int i=stg.Length-1; i>=0; i--)
                {
                    merged = merged + stg[i];
                }
                merged = merged + " ";
            }


            string duplicate = "";
            string temp = "";
            for(int i = 0; i<= input.Length -1;i++)
            {

                int count=repeatcount(input, input[i]);

                if (count > 1)
                {
                    duplicate = duplicate + "/ " + input[i] + " repeated " + count + " times";
                   
                }
            }


            List<string> stringLists = duplicate.Split('/').ToList();

            List<string> stringtxt = stringLists.Distinct().ToList();
            string distinctStringsRes = "";
            foreach(string dist in stringtxt)
            {
                if(dist != "   repeated 4 times")
                distinctStringsRes = distinctStringsRes+"/ "+ dist;

            }



            ViewBag.merged = merged;
            ViewBag.duplicate = distinctStringsRes;

            return View();
        }

        //------------------
        public int repeatcount(string str, char ch)
        {

            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    count++;
                }

            }

            return count;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            string input = "one two three four five";
            List<string> stringList = input.Split(' ').ToList();



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}