using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01521496_assignment1_w2022.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// Route           api/Square/{id}           
        /// Description     find Square of given number that is id
        /// Access          public
        /// Method          Get
        /// Example         http://localhost:3xyz/api/Square/-2
        /// </summary>
        
        /// <param name="id">int (eg. -2)</param>
        
        /// <returns>4</returns>

        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
