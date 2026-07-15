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
public async Task<IActionResult> EnrollStudent(int courseId, EnrollStudentRequest request, CancellationToken ct)
{
throw new NotImplementedException();
}
}