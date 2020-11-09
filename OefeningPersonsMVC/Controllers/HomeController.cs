using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OefeningPersonsMVC.Entities;
using OefeningPersonsMVC.Services;
using OefeningPersonsMVC.ViewModels;

namespace OefeningPersonsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonData _personData;
        private readonly IMapper _mapper;

        public HomeController(IPersonData personData, IMapper mapper)
        {
            _personData = personData;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Person = _personData.GetAll();
            return new ObjectResult(model);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var person = _personData.Get(id);

            if(person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody]PersonCreateViewModel personCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newPerson = _mapper.Map<Person>(personCreateViewModel);

            _personData.Add(newPerson);
            return CreatedAtAction(nameof(Detail), new { newPerson.Id }, newPerson);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //we testen eerst of deze restaurant all bestaat
            var person = _personData.Get(id);
            if (person == null)
            {
                //als die niet bestaat geven we een 404 not found pagina terug
                return NotFound();
            }
            _personData.Delete(person);
            return NoContent();

        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody]PersonUpdateViewModel personUpdateViewModel)
        {
            //als de modelstate dus bv als je de required niet voldoet
            //
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = _personData.Get(id);
            //als deze persoon niet bestaat dan geven we een notfound pagina terug
            if(person == null)
            {
                return NotFound();
            }

            //hier maken we een nieuwe 
            var uptedPerson = new Person
            {
                Id = person.Id,
                FirstName = personUpdateViewModel.FirstName,
                LastName = personUpdateViewModel.LastName,
                Address = personUpdateViewModel.Address,
                Gender = personUpdateViewModel.Gender,
            };

            _personData.Update(uptedPerson);
            return NoContent();
        }
    }
}
