using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainAPI : ControllerBase
    {

        [HttpPost(Name = "GetWeatherForecast")]
        public ActionResult<List<string>> IntListWork(List<int> parentList)
        {
            List<string> slist = new List<string>();
            List<int> childList = new List<int>();

            int counter = 0;
            double standev = 0.0f;

            parentList.Sort();


            foreach (int i in parentList)
            {
                int number = parentList.ElementAt(counter);
                childList.Add(number);
                
                // Call standard deviation function for current childList
                standev = standardDeviation(childList);
               

                if (counter == 0)
                {
                    slist.Add("Element " + (counter + 1) + ": List too small.");
                }
                else
                {
                    slist.Add("Element " + (counter + 1) + ": Current standard deviation is: " + standev);
                }

                counter++;
            }

            Console.WriteLine("Standard Deviation = " + standev);

            return Accepted(slist);
        }

        // Function for calculating standard deviation of an int list parameter
        static double standardDeviation(IEnumerable<int> sequence)
        {
            double result = 0;

            if (sequence.Any())
            {
                double average = sequence.Average();
                double sum = sequence.Sum(d => Math.Pow(d - average, 2));
                result = Math.Sqrt((sum) / (sequence.Count() - 1));
            }
            
            // pointless comment
            return result;
        }
    }
}