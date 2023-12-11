using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{

	// https://localhost:portnumber/api/students
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		// GET: https://localhost:portnumber/api/students
		[HttpPost]
		public IActionResult GetAllStudents()
		{
			string[] studentNames = new string[] { "Rabik", "Anamika", "Rebina", "Rohan" };
			return Ok(studentNames);
		}
	}
}
