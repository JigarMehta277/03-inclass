using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _03_inclass.Controllers
{
    public class loopsController : ApiController
    {
        /// <summary>
        /// While loop example
        /// </summary>
        /// <returns>returns the number from one to ten</returns>
        /// <example>
        /// GET: api/loops/whileLoop -> 35,28,21,14</example>
        [HttpGet]
        public string whileLoop()
        {
            string message = "";
            int incrementor = 35;
            string delimiter = ",";
            int limit = 14;
            int step = -7;
            while (incrementor>=limit) 
            {

                if(incrementor==limit)
                {
                    delimiter = "";
                }
               
                message = message + incrementor.ToString() + delimiter;
 
                incrementor = incrementor + step;
            }

            return message;
        }

        /// <summary>
        /// counts to 10
        /// </summary>
        /// <returns>a string of numbers from 1 to 10</returns>
        /// <example>
        /// api/loop/ForLoop-> 12345678910
        /// </example>

        [HttpGet]
        public string ForLoop()
        {
            string message = "";

            //var fruits = ["apple","banana","strawberry"];
            //start at 0
            //continue by 1
            //liit at the length of the fruits -1
            List<String> Fruits = new List<String> { "Apple", "banana", "strawberry" };


            for (int i=0; i<Fruits.Count(); i++)
            {
                message = message+"I like "+ Fruits[i];
            }
            return message;
        }

        [HttpGet]

        public string forEachLoop()
        {
            string message = "";
            List<String> Movies = new List<string> { "Kill Bill", "Frozen", "Godfather", "Goodfellas" };
            foreach (string Movie in Movies)
            {
                message += Movie;
            }

            return message;
        }
    }
}
