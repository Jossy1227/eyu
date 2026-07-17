using Microsoft.AspNetCore.Mvc;
using Tms.Api.Dtos;
using Tms.Api.Services;
namespace Tms.Api.Controllers;
[ApiController]
[Route("api/courses/{courseId:int}/enrollments")]
public class EnrollmentsController(
ICourseService courseService,
IEnrollmentService enrollmentService) : ControllerBase
{
[HttpGet("{id:int}", Name = nameof(GetEnrollment))]
public async Task<IActionResult> GetEnrollment(int courseId, int id,
CancellationToken ct)
{
var enrollment = await enrollmentService.GetByIdAsync(courseId,
id, ct);
return enrollment is not null ? Ok(enrollment) : NotFound();
}
public async Task<IActionResult> GetEnrollments(int courseId, CancellationToken ct)
{
// TODO 4: Confirm the parent course exists (courseService.GetByIdAsync); 404 if not.
//
//Then return Ok(await enrollmentService.GetByCourseAsync(courseId, ct))
//onseDto>.where GetByCourseAsync projects to a List<EnrollmentResp
throw new NotImplementedException();
}
}