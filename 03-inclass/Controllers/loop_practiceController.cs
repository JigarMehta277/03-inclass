using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _03_inclass.Controllers
{

    public class loop_practiceController : ApiController
    {
        /// <summary>
        /// The function takes input from user and outputs accordingly
        /// <returns>series pf numbers</returns>
        /// </summary>
        /// <example>api/loop/problemOne-> [0,1,2,3,4], [-10,0,10,20,30], [0], [-10,-12,-14,-16]</example>

        [HttpGet]
        [Route("api/loop_practice/problemOne/{start}/{limit}/{step}")]
        public string problemOne(int start, int limit, int step)
        {
            string message="";
            for(int i=start;i<=limit;i=i+step)
            {
                if(i==limit)
                {
                    message = message + i.ToString();
                }
                else
                {
                    message = message + i.ToString() + ",";
                }
                

            }
            return message;
        }

        [HttpGet]
        [Route("api/loop_practice/problemTwo/{start}/{limit}/{step}/{fizzy}/{buzzy}")]

        public string problemTwo(int start, int limit, int step, int Fizzy, int Buzzy)
        {
            string message = "";
            int reminder = 0;
            string fizzy = "Fizzy";
            string buzzy = "Buzzy";
            string delimeter = ",";
            for(int i=start;i<=limit;i+=step)
            {
                
                if (i % Fizzy == reminder && i % Buzzy == reminder)
                {
                    if (i == limit)
                    {
                        message = message + fizzy + buzzy;
                    }
                    else
                    {
                        message = message + fizzy + buzzy + delimeter;
                    }
                }
                else if(i%Buzzy==reminder)
                {
                    if(i==limit)
                    {
                        message = message + buzzy;
                    }
                    else
                    {
                        message = message + buzzy+ delimeter;
                    }
                }
                else if ((i % Fizzy) == reminder)
                {
                    if (i == limit)
                    {
                        message = message + fizzy;
                    }
                    else
                    {
                        message = message + fizzy + delimeter;
                    }
                }

                else
                {
                   if(i==limit)
                    {
                        message = message + i;
                    }
                   else
                    {
                        message = message + i + delimeter;
                    }
                }
            }

            return message;
        }
    }
}
