using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01535446_.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// A method which has an input {id}, and applies four mathematical operations to it one by one.
        /// 
        /// </summary>
        /// <param name="id">Takes a number</param>
        /// <returns>Answer obtained after performing the four mathematical operation </returns>
        /// <example>
        /// GET: api/NumberMachine/10    -> 11
        /// 10-2=8
        /// 8+7=15
        /// 15*3=45
        /// 45/4=11
        /// GET: api/NumberMachine/-5   -> 0
        /// -5-2=-7
        /// -7+7=0
        /// 0*3=0
        /// 0/4=0
        /// GET: api/NumberMachine/30  -> 26
        /// 30-2=28
        /// 28+7=35
        /// 35*3=105
        /// 105/4=11
        /// </example>
        public int Get(int id)
        {
            id = id - 2;
            id = id + 7;
            id = id * 3;
            id = id / 4; 
            return id; 
          
        }
    }
}
