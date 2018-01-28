using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockSwaggerApI.Controllers
{
    /// <summary>
    /// Fionancci series controller
    /// </summary>
    [Route("api/Fibonacci")]    
    public class FibonacciController : ApiController
    {
        /// <summary>
        /// return the nth no in fibonacci series
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public long Fibonacci(long no)
        {
            var firstno = 0L;
            var secondno = 1L;

            if (no == 1)
                return 0;
            else if (no == 2)
                return 1;

            for(long i = 2; i <= no; i++)
            {
                var sum = firstno + secondno;
                if (no == i)
                    return sum;
                firstno = secondno;
                secondno = sum;

                //Console.WriteLine(sum);
            }

            return 0;   // shouldn't never get here.
        }

    }
}
