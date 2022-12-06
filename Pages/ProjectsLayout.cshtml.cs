using Microsoft.AspNetCore.Mvc.RazorPages;
using TomaszWasielewski.Homepage.Models;
using TomaszWasielewski.Homepage.Services;

namespace TomaszWasielewski.Homepage.Pages
{
    public class ProjectsLayout : PageModel
    {

        public ProjectsLayout(JsonFileProjectService projectService) => ProjectService = projectService;
        public IEnumerable<Project> Projects { get; private set; }
        public JsonFileProjectService ProjectService { get; }
        public void OnGet() => Projects = ProjectService.GetProjects();
    }
}
