using Microsoft.EntityFrameworkCore;
using OdaArquiteturaAPI.Data;
using OdaArquiteturaAPI.Entity;
using OdaArquiteturaAPI.Repository.Interfaces;

namespace OdaArquiteturaAPI.Repository;

public class ProjectRepository : IProjectRepository
{
    private readonly OdaDBContext _dbContext;
    public ProjectRepository(OdaDBContext odaDBContext) {
        _dbContext = odaDBContext;
    }

    public async Task<List<Project>> GetAllProjects()
    {
        return await _dbContext.Projects.ToListAsync();
    }

    public async Task<Project> GetProjectById(int id)
    {
        return await _dbContext.Projects.FirstOrDefaultAsync(obj => obj.Id == id);
    }

    public async Task<Project> AddProject(Project project)
    {
        _dbContext.Projects.Add(project);
        _dbContext.SaveChanges();
        return project;
    }

    public async Task<bool> DeleteProject(int id)
    {
        Project projectById = await GetProjectById(id);
        
        _dbContext.Projects.Remove(projectById);
        _dbContext.SaveChanges();

        return true;
    }

    public async  Task<Project> UpdateProject(Project project, int id)
    {
        Project projectById = await GetProjectById(id);

        projectById.Name = project.Name;
        projectById.Description = project.Description;
        projectById.Status = project.Status;

        _dbContext.Update(projectById);
        _dbContext.SaveChanges();
        return projectById;
    }
}
