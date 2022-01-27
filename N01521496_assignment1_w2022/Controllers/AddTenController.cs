using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01521496_assignment1_w2022.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Route           api/AddTen/{id}           
        /// Description     to add 10 to given number that is id
        /// Access          public
        /// Method          Get
        /// Example         http://localhost:3xyz/api/AddTen/0
        /// </summary>

        /// <param name="id">int (eg. 0)</param>

        /// <returns>10</returns>
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }


    }
}
