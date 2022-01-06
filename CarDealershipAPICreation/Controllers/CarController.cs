using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealershipAPICreation.Models;

namespace CarDealershipAPICreation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public List<Car> Cars = new List<Car>()
        {
        new Car(){ Make = "Dodge", Model = "Dart", Color = "White", Year = "2015"},
        new Car(){ Make = "Ford", Model = "Focus", Color = "Blue", Year = "2020"},
        new Car(){ Make = "Land Rover", Model = "Evoque", Color = "Dark Green", Year = "2021"},
        new Car(){ Make = "BMW", Model = "X6", Color = "Red", Year = "2019"}
        };

        [HttpGet]
        public string GetAllCars()
        {
            string result ="";
            foreach (Car c in Cars)
            {
                //result += c.ToString();
                string x = result;
                result = x + c.ToString();
            }
            return result;
        }

        [HttpGet("GetCar/{index}")]
        public string GetCarsByIndex(int index)
        {
            try
            {
                return Cars[index].ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                return $"{index} is not a valid Car Id, please input a number between 0 and {Cars.Count-1}";
            }
        }

        [HttpGet("GetCar/Search/{search}")]
        public string Search(string search)
        {
            return search;
        }
       
    }
}
