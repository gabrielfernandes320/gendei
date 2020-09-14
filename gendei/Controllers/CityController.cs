using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gendei.Entities;
using gendei.Repositories.contract;
using gendei.Repositories.implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gendei.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IGendeiRepository<City> _cityRepository;

        public CityController(IGendeiRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        
        [HttpGet]
        public async Task<object> GetAllCity()
        {
            var city = await _cityRepository.GetAll();
            return Ok(city);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _cityRepository.Get(id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

      
        [HttpPut("{id}")]
        public async Task<ActionResult<City>> UpdateCityAsync(int id, City city)
        {

            if (id != city.Id)
            {
                return BadRequest();
            }

            var updateReturn = await _cityRepository.Update(id, city);

            if (updateReturn != null)
            {
                return Ok(city);
            }

            return BadRequest();
        }

       
        [HttpPost]
        public async Task<ActionResult<City>> AddCityAsync(City city)
        {
            var addReturn = await _cityRepository.Add(city);

            if (addReturn != null)
            {
                return CreatedAtAction("GetCity", new { id = city.Id }, city);
            }

            return BadRequest();
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<City>> DeleteCityAsync(int id)
        {
            var city = await _cityRepository.Get(id);
            if (city == null)
            {
                return NotFound();
            }

            var deleteReturn = _cityRepository.Delete(city);

            if (deleteReturn != null)
            {
                return CreatedAtAction("GetCity", new { id = city.Id }, city);
            }

            return BadRequest();

        }
    }
}
