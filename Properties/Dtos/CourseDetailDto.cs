using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Tms.Api.Services;

namespace Tms.Api.Dtos;
public record CourseDetailDto
{
public required int Id { get; init; }
public required string Code { get; init; }
public required string Title { get; init; }
public required int MaxCapacity { get; init; }
public required int EnrollmentCount { get; init; }
public required IReadOnlyList<LinkDto> Links { get; init; }




public async Task<IActionResult> GetCourseById(int id, CancellationToken ct)

{
//var course = await Courseservice.GetByIdAsync(id, ct);
//if (course is null) return NotFound();

throw new NotImplementedException();
}
}