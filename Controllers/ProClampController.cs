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
        // 
        // GET: /ProClamp/

        public string Index()  //I tested this by typing /ProClamp in the url of page and this worked
        {
            return "This is my default action...";
        }

        //-------------------------------------

        /*// GET: /ProClamp/Welcome/   

        public string Welcome()   //I tested this by typing ProClamp/Welcome in the url of page and this worked
        {
            return "This is the Welcome action method...";
        
        //now comment this string for the new Welcome string
        */

        //-------------------------------------

        /*// GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)  //I tested this by typing ProClamp/Welcome?name=Rick&numtimes=4 in the url of page and this worked
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        //now comment this string for the new Welcome string
        */

        //-------------------------------------

        public string Welcome(string name, int ID = 1) //I tested this by typing ProClamp/Welcome/3?name=Prabhjot Singh in the url of page and this worked
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
