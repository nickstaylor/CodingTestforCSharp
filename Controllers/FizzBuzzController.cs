using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    //'public' means anyone w/access to the code can look this up
    // 'the 'Controller' is inheritance, 'Controller' is 
    public class FizzBuzzController : Controller
    {
        //'controlling' what is going on
        //IActionResult anytime you see an 'I', that's Interface

        public interface ICar
        {
            int numOfDoors { get; set; }
            void go();
        }

        public class NicksCar : ICar
        {
            public NicksCar(int doors)
            {
                numOfDoors = doors;
            }
            public int numOfDoors { get; set; }

            public void go()
            {
                throw new NotImplementedException();
            }
        }

        public IActionResult Index()
        {


       
            var fizzBuzzList = new FizzBuzzList();


            for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                    fizzBuzzList.displayList.Add("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                    fizzBuzzList.displayList.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                    fizzBuzzList.displayList.Add("Buzz");
                    }
                    else
                    {
                    fizzBuzzList.displayList.Add(i.ToString());
                    }
        
               }
      
            




            return View(fizzBuzzList);
        }
    }
}