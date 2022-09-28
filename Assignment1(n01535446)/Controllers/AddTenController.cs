using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01535446_.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 to the input number and returns the value
        /// </summary>
        /// <param name="id">Takes an Integer value</param>
        /// <returns>Returns 10 more than the integer input {id}</returns>
        /// <example> 
        /// GET: /api/AddTen/21 ->31
        /// </example>
        public int Get(int id)
        {
            return (id + 10);
        }

    }
}
