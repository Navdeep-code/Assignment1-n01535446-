using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01535446_.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Post request returns Hello World string
        /// </summary>
        /// <returns>Returns the string “Hello World!”</returns>
        /// <example>
        /// Post: /api/Greeting
        /// </example>
        public string Post()
        {
            return "Hello World";
        }

        /// <summary>
        /// Takes a input for number of people to greet then greet them using that number
        /// </summary>
        /// <param name="id">Takes the number of people to be greeted</param>
        /// <returns> Returns the string “Greetings to {id} people!” where id is an integer value</returns>
        /// <example>
        /// GET: /api/Greeting/3     -> Greetings to 3 people!
        /// GET: /api/Greeting/6     -> Greetings to 6 people!
        /// GET: /api/Greeting/0     -> Greetings to 0 people!
        /// </example>
        public string get(int id)
        {
            return "Greeting to "+id+" people";
        }
    }
}
