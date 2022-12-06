using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using TomaszWasielewski.Homepage.Models;
namespace TomaszWasielewski.Homepage.Services;


public class JsonFileProjectService
{
    public JsonFileProjectService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json");

    public IEnumerable<Project> GetProjects()
    {
        using var jsonFileReader = File.OpenText(JsonFileName);
        return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
    }
}
