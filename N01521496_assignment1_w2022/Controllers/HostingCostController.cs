using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01521496_assignment1_w2022.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// ************** Que 6 *********
        /// Route           api/HostingCost/{id}
        /// Description     showing prices for web hosting and maintance per fortnight
        /// Access          public
        /// Method          Get
        /// Example         http://localhost:3xyz/api/HostingCost/15
        /// </summary>
        
        /// <param name="id">int (eg. 15)</param>
        
        /// <returns>
        /// <string>2 fortnights at $5.50/FN = 11 CAD</string>
        /// <string>HST 13% = $1.43 CAD</string>
        /// <string>Total = $12.43</string>
        /// </returns>

        public IEnumerable<string> Get(int id)
        {
            double pricePerFN = 5.50;
            double HST = 13;            
            double daysPassed = id;

            double fn; // fortnight
            double priceAfterCalc; // basic price * fortnight
            double HSTAfterCalc;
            double total;          // total = HST + calculated price 


            // if day passed is more than or equal 14, charge accordingly.
            if (daysPassed >= 14)
            {
                fn = Math.Floor(daysPassed / 14) +1; // adding 1 cuz already we are counting after 14 days so +1 (1st fortnight). 14 days = 1 fortnight so "x/14"
                                                     // https://www.geeksforgeeks.org/c-sharp-math-floor-method/

                priceAfterCalc = pricePerFN * fn;
                HSTAfterCalc = Math.Round(((priceAfterCalc * HST) / 100),2); //rounding till 2 decimal places 
                                                                             //https://www.geeksforgeeks.org/c-sharp-math-round-method-set-1/


                total = priceAfterCalc + HSTAfterCalc; // HST + Price

                string finalPriceString = $"{fn} fortnights at $5.50/FN = {priceAfterCalc} CAD";
                string finalHSTString = $"HST {HST}% = ${HSTAfterCalc} CAD";
                string finalTotalString = $"Total = ${total} CAD";

                return new string[] { finalPriceString, finalHSTString, finalTotalString };
            }

            // if day passed not more than or equal to 13 days, charge accordingly... in this case we will show charge for 1st fortnight only which is not completed yet
            else
            {
                fn = 1;
                priceAfterCalc = pricePerFN * fn;
                HSTAfterCalc = Math.Round(((priceAfterCalc * HST) / 100), 2);

                total = priceAfterCalc + HSTAfterCalc;

                string finalPriceString = $"{fn} fortnights at $5.50/FN = {priceAfterCalc} CAD";
                string finalHSTString = $"HST {HST}% = ${HSTAfterCalc} CAD";
                string finalTotalString = $"Total = ${total} CAD";

                return new string[] { finalPriceString, finalHSTString, finalTotalString };
            }

            // using C# string interpolation .. ref. https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            // string finalPriceString = $"{fn} fortnights at $5.50/FN = {priceAfterCalc} CAD";
            
            // why Im not able to use variable after if statment?

            
        }
    }
}
