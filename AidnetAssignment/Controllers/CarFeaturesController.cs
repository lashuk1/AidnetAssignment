using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AidnetAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly ICarFeaturesService _carFeaturesService;

        public CarFeaturesController(ICarFeaturesService carFeaturesService)
        {
            _carFeaturesService = carFeaturesService;
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_carFeaturesService.GetCarFeatures());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Put/{id}")]
        public IActionResult Put(int id, CarFeatures carFeatures)
        {
            try
            {
                _carFeaturesService.Put(id, carFeatures);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("Post")]
        public IActionResult Post(CarFeatures carFeatures)
        {
            try
            {
                _carFeaturesService.Post(carFeatures);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _carFeaturesService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
