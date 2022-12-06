using Microsoft.AspNetCore.Mvc;
using TomaszWasielewski.Homepage.Models;
using TomaszWasielewski.Homepage.Services;
using static TomaszWasielewski.Homepage.Services.JsonFileProjectService;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    public ProjectsController(JsonFileProjectService projectService) =>
        ProjectService = projectService;

    public JsonFileProjectService ProjectService { get; }

    [HttpGet]
    public IEnumerable<Project> Get() => ProjectService.GetProjects();
}