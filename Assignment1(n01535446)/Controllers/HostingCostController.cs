using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assignment1_n01535446_.Controllers
{

    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Clients are charged $5.50 / FN (fortnight = 14 days) for web hosting and maintenance plus an additional 13% HST.The input { id } represents the number of days which has elapse since the beginning of the hosting.
        /// The input is divided by 14 and then 1 is added to it which gives the number of fortnights.
        /// Number of fortnights is multiplied with the hostingcost for 1 fortnight to get the price.
        /// Tax amount for 13% tax is obtained through calculations and then its added with the price to give the total price.
        /// The method returns string values that displays the number of fornights , the price before the tax, the tax amount and the cost for it after adding the tax value.
        /// </summary>
        /// <param name="id">the number of days which has elapse since the beginning of the hosting</param>
        /// <returns>returns 3 strings which describe the total hosting cost</returns>
        /// <example>
        /// GET /api/HostingCost/0      ->"1 fortnights at $5.50/FN = $5.50 CAD" "HST 13% = $0.72 CAD" "Total = $6.22 CAD"
        /// GET /api/HostingCost/14      ->"2 fortnights at $5.50/FN = $11 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        /// GET /api/HostingCost/15      ->"2 fortnights at $5.50/FN = $11 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        /// GET /api/HostingCost/21      ->"2 fortnights at $5.50/FN = $11 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"
        /// GET /api/HostingCost/28       ->"3 fortnights at $5.50/FN = $16.5 CAD" "HST 13% = $2.145 CAD" "Total = $18.645 CAD"
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int value = id / 14;
            int fortnight = value + 1;
            double price = fortnight * 5.50;
            double tax = (price / 100) * 13;
            double total = price + tax;
            return new string[] { fortnight + " fortnights at $5.50/FN = $" + price+ " CAD","HST 13% = $"+tax+" CAD", "Total = $"+total+" CAD" };
        }

    }
}
