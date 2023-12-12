using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

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
			var regions = dbContext.Regions.ToList();
			
			return Ok(regions);
		}


        //GET Single Region (Get region by Id)
        //GET https://localhost:portnumber/api/regions/{id}
        [HttpGet]
		[Route("{id:Guid}")]
		public IActionResult GetById([FromRoute]Guid id)
		{
			// var region = dbContext.Regions.Find(id);
			var region = dbContext.Regions.FirstOrDefault(x => x.Id == id);

			if(region == null)
			{
				return NotFound();
			}
				return Ok(region);
		}
    }
}
