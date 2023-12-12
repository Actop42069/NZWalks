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
	}
}
