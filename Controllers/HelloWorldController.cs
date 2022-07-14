using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "This is my default action...";
        // }
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome(string name, int numTimes = 1)
        // {
        //     //return "This is the Welcome action method...";
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public string Date()
        {
            return $"Todays date: {DateTime.Now}";
        }
        public string Factorial(int Start=1)
        {
            string temp = "";
            int result = 1;
            while(Start > 1)
            {
                result *= Start;
                temp += $"{Start} * ";
                Start -= 1;
            }
            return $"{temp}1 = {result}";
        }
    }
}