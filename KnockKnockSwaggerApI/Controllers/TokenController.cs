using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockSwaggerApI.Controllers
{
    /// <summary>
    /// Token Controller
    /// </summary>
    [Route("api/Token")]    
    public class TokenController : ApiController
    {
        /// <summary>
        /// Your Token
        /// </summary>
        /// <returns></returns>
        public string Token()
        {
            string guid = Guid.NewGuid().ToString();
            return guid;
        }
    }
}
