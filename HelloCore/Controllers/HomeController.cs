using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HelloCore.Entities;
using HelloCore.Services;
using HelloCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IGreeter _greeter;
        private readonly IMapper _mapper;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter, IMapper mapper)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //return Content("Hello, from the HomeController");
            //return this.Redirect("https://www.google.be");
            var model = new HomePageViewModel();

            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();
        
            return new ObjectResult(model);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {

            var restaurant = _restaurantData.Get(id);

            if(restaurant == null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }

        [HttpPost]
        public IActionResult Create([FromBody]RestaurantCreateViewModel restaurantCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newResto = _mapper.Map<Restaurant>(restaurantCreateViewModel);
            _restaurantData.Add(newResto);
            return CreatedAtAction(nameof(Detail), new { newResto.Id }, newResto);
        }

        //hier voegen we een delete action 
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //we testen eerst of deze restaurant all bestaat
            var restaurant = _restaurantData.Get(id);
            if (restaurant == null)
            {
                //als die niet bestaat geven we een 404 not found pagina terug
                return NotFound();
            }
            //als die wel bestaat verwijderen we die en geven we een 204 nocontent
            _restaurantData.Delete(restaurant);
            return NoContent();

        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody]RestaurantUpdateViewModel restaurantUpdateViewModel)
        {
            if(!ModelState.IsValid) //witl zeggen of onze required aanvaardbaar is 
            {
                return BadRequest(ModelState);
            }
            var restaurant = _restaurantData.Get(id);

            if (restaurant == null)
            {
                return NotFound();

            }

            var uptedResto = new Restaurant
            {
                Id = restaurant.Id,
                Name = restaurantUpdateViewModel.Name,
                CuisineType = restaurantUpdateViewModel.CuisineType
            };

            _restaurantData.Update(uptedResto);

            return NoContent();
        }
        
    }

}
