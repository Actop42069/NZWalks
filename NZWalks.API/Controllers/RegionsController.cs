using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
	// https:localhost:1234/api/regions
	[Route("api/[controller]")]
	[ApiController]
	public class RegionsController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetAll()
		{
			var regions = new List<Region>
			{
				new Region
				{
					Id = Guid.NewGuid(),
					Name = "Dhapakhel Region",
					Code = "DPK",
					RegionImageUrl = "https://images.unsplash.com/photo-1580424917967-a8867a6e676e?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
				},
				new Region
				{
					Id = Guid.NewGuid(),
					Name = "Sanepa Region",
					Code = "SNP",
					RegionImageUrl = "https://images.unsplash.com/photo-1602102488252-c4c3daadf1c2?q=80&w=2074&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
				}
			};
			return Ok(regions);
		}
	}
}
