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
        public ActionResult<List<NumList>> Post([FromBody] List<NumList> input)
        {

            foreach (NumList nums in input)
            {
                System.Console.WriteLine(nums.First);
                System.Console.WriteLine(nums.Second);
                System.Console.WriteLine(nums.Third);
                System.Console.WriteLine(nums.Fourth);
                System.Console.WriteLine(nums.Fifth);



            }

            return Accepted(input);
        }

    }

    public class NumList
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public int Fourth { get; set; }
        public int Fifth { get; set; }

    }
}


// string[] result = greetings.Cast<string>().ToArray();
// int[] result = obj.Cast<int>().ToArray();