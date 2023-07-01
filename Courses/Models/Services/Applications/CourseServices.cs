//           .         .                                                                                                                                                      
//          ,8.       ,8.           8 8888     ,o888888o.        ,o888888o.    8 8888888888   8 8888           d888888o.       ,o888888o.     8 8888888888 8888888 8888888888 
//         ,888.     ,888.          8 8888    8888     `88.     8888     `88.  8 8888         8 8888         .`8888:' `88.  . 8888     `88.   8 8888             8 8888       
//        .`8888.   .`8888.         8 8888 ,8 8888       `8. ,8 8888       `8. 8 8888         8 8888         8.`8888.   Y8 ,8 8888       `8b  8 8888             8 8888       
//       ,8.`8888. ,8.`8888.        8 8888 88 8888           88 8888           8 8888         8 8888         `8.`8888.     88 8888        `8b 8 8888             8 8888       
//      ,8'8.`8888,8^8.`8888.       8 8888 88 8888           88 8888           8 888888888888 8 8888          `8.`8888.    88 8888         88 8 888888888888     8 8888       
//     ,8' `8.`8888' `8.`8888.      8 8888 88 8888           88 8888           8 8888         8 8888           `8.`8888.   88 8888         88 8 8888             8 8888       
//    ,8'   `8.`88'   `8.`8888.     8 8888 88 8888           88 8888           8 8888         8 8888            `8.`8888.  88 8888        ,8P 8 8888             8 8888       
//   ,8'     `8.`'     `8.`8888.    8 8888 `8 8888       .8' `8 8888       .8' 8 8888         8 8888        8b   `8.`8888. `8 8888       ,8P  8 8888             8 8888       
//  ,8'       `8        `8.`8888.   8 8888    8888     ,88'     8888     ,88'  8 8888         8 8888        `8b.  ;8.`8888  ` 8888     ,88'   8 8888             8 8888       
// ,8'         `         `8.`8888.  8 8888     `8888888P'        `8888888P'    8 888888888888 8 888888888888 `Y8888P ,88P'     `8888888P'     8 8888             8 8888       


//Creazione del Servizio Applicativo dei Corsi il cui obiettivo è quello di restituire dei dati


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses.Models.ViewModels;
using Courses.Models.ValueObjects;
using Courses.Models.Enums;

namespace Courses.Models.Services.Applications
{
    public class CourseServices
    {
        public List<CoursesViewModel> GetServices()
        {
            var courseList = new List<CoursesViewModel>();
            Random rand = new Random();

            for(int i = 0; i < 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble()* 10.0 + 10.0);
                var course = new CoursesViewModel
                {
                    Id = Guid.NewGuid(),
                    Title = $"Titolo {i}",
                    Rating = rand.NextDouble() * 5.0,
                    Author = "Nome Finto",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price -1),
                    ImagePath = "~/images/logo.svg"
                };

                courseList.Add(course);   

            }

            return courseList;
        }
    }
}