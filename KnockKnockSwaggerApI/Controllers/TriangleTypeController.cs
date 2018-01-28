using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockSwaggerApI.Controllers
{
    /// <summary>
    /// Triangle Type Controller
    /// </summary>
    [Route("api/TriangleType")]
    public class TriangleTypeController : ApiController
    {
        /// <summary>
        /// Returns the type of triange given the lengths of its sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string TriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isosceles";
            }
            else
                return "Scalene";
        }
    }
}
