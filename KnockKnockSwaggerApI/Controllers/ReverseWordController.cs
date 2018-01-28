using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnockSwaggerApI.Controllers
{
    /// <summary>
    /// Reverses the word Controller
    /// </summary>
    [Route("api/ReverseWord")]
    public class ReverseWordController : ApiController
    {
        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <param name="sentence">A sentence</param>
        /// <returns></returns>
        public string ReverseWord(string sentence)
        {
            var index = sentence.IndexOf(" ");
            if(index>0)
            {
                var substring = new string(sentence.Substring(0, index).Reverse().ToArray());
                sentence = sentence.Substring(index + 1);
                var reverSubSentence = "";
                if (substring.Length > 0)
                    reverSubSentence = ReverseWord(sentence);
                return substring + " " + reverSubSentence;
            }
            return new string(sentence.Reverse().ToArray());
        }
    }
}
