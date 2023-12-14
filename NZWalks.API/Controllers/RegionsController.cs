using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Controllers
{
	// https:localhost:1234/api/regions
	[Route("api/[controller]")]
	[ApiController]
	public class RegionsController : ControllerBase
	{
		private readonly NZWalksDbContext dbContext;

		public RegionsController(NZWalksDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
        [HttpGet]
		public IActionResult GetAll()
		{
			// Get Data from the database - Domain models
			var regionsDomain = dbContext.Regions.ToList();

			//Map Domain MOdels to DTOs
			var regionsDto = new List<RegionDto>();
			foreach (var regionDomain in regionsDomain)
			{
				regionsDto.Add(new RegionDto()
				{
					Id = regionDomain.Id,
					Code = regionDomain.Code,
					Name = regionDomain.Name,
					RegionImageUrl = regionDomain.RegionImageUrl,
				});
			}	
			//Return DTOs
			return Ok(regionsDto);
		}


        //GET Single Region (Get region by Id)
        //GET https://localhost:portnumber/api/regions/{id}
        [HttpGet]
		[Route("{id:Guid}")]
		public IActionResult GetById([FromRoute]Guid id)
		{
			// var region = dbContext.Regions.Find(id);
			// Get Region Domain MOdel From Database
			var regionDomain = dbContext.Regions.FirstOrDefault(x => x.Id == id);

			if(regionDomain == null)
			{
				return NotFound();
			}
			// Map or Convert Region Model to Region Dto

			var regionDto = new RegionDto
			{
				Id = regionDomain.Id,
				Code = regionDomain.Code,
				Name = regionDomain.Name,
				RegionImageUrl = regionDomain.RegionImageUrl
			};
			// Return DTO to client
			return Ok(regionDto);
		}
    }
}
