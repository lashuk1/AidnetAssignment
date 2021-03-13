using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace AidnetAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly string _currencyApi;

        public CarController(ICarService carService, IConfiguration configuration)
        {
            _carService = carService;
            _currencyApi = configuration.GetValue<string>("CurrencyApi");
        }

        // Returns All Cars
        [HttpGet("Getall")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_carService.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Returns Car by Id
        [HttpGet("getById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_carService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Updates a Car
        [HttpPut("Put/{id}")]
        public IActionResult Put(int id, Car car)
        {
            try
            {
                _carService.Put(id, car, _currencyApi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Adds a new Car
        [HttpPost("Post")]
        public IActionResult Post(Car car)
        {
            try
            {
                _carService.Post(car, _currencyApi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Deletes a Car
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _carService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
