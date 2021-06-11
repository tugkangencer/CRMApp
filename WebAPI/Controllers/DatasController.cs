using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DatasController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DatasController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("getcountries")]
        public IActionResult GetCountries()
        {
            var result = _dataService.GetCountries();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcities")]
        public IActionResult GetCities(int countryId)
        {
            var result = _dataService.GetCities(countryId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getdistricts")]
        public IActionResult GetDistricts(int cityId)
        {
            var result = _dataService.GetDistricts(cityId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getneighborhoods")]
        public IActionResult GetNeighborhoods(int districtId)
        {
            var result = _dataService.GetNeighborhoods(districtId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getoccupations")]
        public IActionResult GetOccupations()
        {
            var result = _dataService.GetOccupations();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getsectors")]
        public IActionResult GetSectors()
        {
            var result = _dataService.GetSectors();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}