using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdaArquiteturaAPI.Entity;
using OdaArquiteturaAPI.Repository.Interfaces;

namespace OdaArquiteturaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectRepository _projectRepository;

    public ProjectController(IProjectRepository projectRepository) { 
        _projectRepository = projectRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetAllProjects()
    {
        var projects = await _projectRepository.GetAllProjects();
        if (projects == null)
        {
            return NotFound();
        }
        return Ok(projects);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetProjectId(int id)
    {
        var project = await _projectRepository.GetProjectById(id);
        if (project == null)
        {
            return NotFound();
        }
        return Ok(project);
    }
}
