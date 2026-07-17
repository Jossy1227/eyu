/*using Microsoft.AspNetCore.Mvc;
using TmsApi.Entities;
using Tms.Api.Services;
namespace Tms.Api.Controllers;
using Tms.Api.Dtos;



/*[ApiController]
[Route("api/courses")]
public class CoursesController(ICourseService courseService) : ControllerBase
{
[HttpGet("{id:int}", Name = nameof(GetCourseById))]
public async Task<IActionResult> GetCourseById(int id, CancellationToken ct)
{
// TODO 3: Call courseService.GetByIdAsync(id, ct).
var course = await courseService.GetByIdAsync(id, ct);
return course is not null ? Ok(course) : NotFound();


}
[HttpPost]
public async Task<IActionResult> CreateCourse(CreateCourseRequest request, CancellationToken ct)
{
// TODO 4: Call courseService.CreateAsync(course, ct).
var result = await courseService.CreateAsync(request, ct);
return CreatedAtAction(nameof(GetCourseById), new { id = result.Id }, result);
//Return CreatedAtAction(nameof(GetCourseById), new {id = result.Id }, result).ly.
//CreatedAtAction sets the Location header automatical
//throw new NotImplementedException();
}

public async Task<IActionResult> GetCourses(
[FromQuery] PagedRequest request, CancellationToken ct)
    {
        var result = await courseService.GetCoursesAsync(request, ct);
return Ok(result);
    }
}*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Tms.Api.Dtos;
using Tms.Api.Services;
namespace Tms.Api.Controllers;
[ApiController]
[Route("api/courses")]
public class CoursesController(
ICourseService courseService,
LinkGenerator linkGenerator) : ControllerBase
{
}
