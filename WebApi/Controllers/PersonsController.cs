using Microsoft.AspNetCore.Mvc;
using System;
using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }
        /// <summary>
        /// findAll
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public IActionResult FindAll()
        {
            var result = _personService.FindAll();
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
        /// <summary>
        /// findById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var result = _personService.FindById(id);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
        /// <summary>
        /// findByName
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            var result = _personService.FindByName(name);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
        /// <summary>
        /// save
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPost("save")]
        public IActionResult Save(Person person)
        {
            try
            {
                _personService.Save(person);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
        /// <summary>
        /// update
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPut("update/{id}")]
        public IActionResult Update(Person person,int id)
        {
            try
            {
                person.Id = id;
                _personService.Update(person);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete( int id)
        {
            try
            {
                var person = new Person()
                {
                    Id = id
                };
                _personService.Delete(person);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
