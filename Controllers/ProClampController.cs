using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProClamp.Controllers
{
    public class ProClampController : Controller
    {
        /*// This Index string was previously used to display a Index message and return message This is my default action....
         * I tested this by typing /ProClamp in the url  after local host of page and this worked.
         * 
        // GET: /ProClamp/

        public string Index()  
        {
            return "This is my default action...";
        }*/

        //-------------------------------------

        // This Index string handles requests to the default page of the website.
        public IActionResult Index()  
        {
            return View();
        }


        //-------------------------------------

        // This Welcome string was previously used to display a welcome message and return message This is the welcome action.
        //I tested this by typing ProClamp/Welcome in the url after local host. of page and this worked 

        /*// GET: /ProClamp/Welcome/   

        public string Welcome()   
        {
            return "This is the Welcome action method...";
        }

        */

        //-------------------------------------

        //This Welcome string was previously used to display a welcome message. 
        //I tested this by typing ProClamp/Welcome?name=Rick&numtimes=4 in the url  after local host of page and this worked

        /*// GET: /ProClamp/Welcome/ 

        public string Welcome(string name, int numTimes = 1){
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        
        */

        //-------------------------------------

        /* //This Welcome string previously used to answers the requests for the ProClamp section's Welcome page and accepts two optional parameters: name and ID.
         //I tested this by typing ProClamp/Welcome/3?name=Prabhjot Singh in the url  after local host of page and this worked.

         public string Welcome(string name, int ID = 1)    
         {
             return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
         }*/

        //-------------------------------------

        //This Welcome string now answers to requests for the ProClamp section's Welcome page and accepts two optional parameters: name and numTimes.
        //I tested this by writing my name and this worked.
        public IActionResult Welcome(string name, int numTimes = 1) 
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
