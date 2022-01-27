using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01521496_assignment1_w2022.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// ******* Que.5 ***********
        /// Route           api/NumberMachine/{id}
        /// Description     This number machine will take a number
        ///                 and will perform 4 mathematical operation in following order (take 2 as input)
        ///                 1. adding 5 to num  (2+5 = 7)
        ///                 2. squaring the previous result  (7*7 = 49)
        ///                 3. dividing previous result by 2 (49/2 = 24.5)
        ///                 4. finally subtracting 10 from previous result (24.5-10 = 14.5)
        /// Access          public
        /// Method          Get
        /// Example         http://localhost:3xyz/api/NumberMachine/2
        /// </summary>
        
        /// <param name="id">int (eg. 2)</param>
        
        /// <returns> Output to the number you entered into number machine is 14.5</returns>
         

        public string Get(int id)
        {
            int number = id; // storing parameter into variable "number"
            int addingFive = number + 5; // adding 5 to given number
            int square = addingFive * addingFive; // taking square of result we got after adding five
            double divideByTwo = square / (double)2; // dividing output by 2 to the number which got after getting square 
                                                     // here we are type casting 2 to double otherwise it will divide and convert o/p to int (14.5 => 14)
                                                     // https://www.w3schools.com/cs/cs_type_casting.php

            double subTen = divideByTwo - 10; // subtracting 10 from result we got after dividing number by 2

            double result = subTen; // storing answer into final result variable 

            string finalString = $"Output to the number you entered into number machine is {result}";
            return finalString;
        }
    }
}
