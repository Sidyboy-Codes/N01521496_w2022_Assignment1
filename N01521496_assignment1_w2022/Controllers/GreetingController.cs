using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01521496_assignment1_w2022.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// ********** Que 3 *************
        /// Route           api/Greeting
        /// Description     Display Greeting msg
        /// Access          public
        /// Methods         Post
        /// Example         using cmd to see o/p: curl -d "" "http://localhost:50695/api/Greeting"
        /// </summary>

        /// <returns>Hello World! from Siddhant</returns>

        public string Post()
        {
            string msg = "Hello World! from Siddhant";
            return msg;
            
        }


        /// <summary>
        /// ********** Que 4 *************
        /// Route           api/Greeting/{id}
        /// Description     Display Greeting msg to number of people
        /// Access          public
        /// Methods         Get
        /// Example         http://localhost:3xyz/api/Greeting/6
        /// </summary>

        /// <param name="id">int (eg. 6)</param>

        /// <returns>Greetings to 6 people!</returns>

        public string Get(int id)
        {
            int numOfPeople = id;
            string msg = "Greetings to " + numOfPeople + " people!";
            return msg;

        }

    }
}
