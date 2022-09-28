using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01535446_.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Takes a number and returns the square of that number
        /// </summary>
        /// <param name="id">Take an integer input</param>
        /// <returns>Returns the square of the integer input {id}</returns>
        /// <example>
        /// GET: /api/Square/2 ->  4
        /// </example>
        public int Get(int id)
        {
            return (id*id);
        }
    }
}
