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

    public Task<List<Project>> GetAllProjects()
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetProjectById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Project> AddProject(Project project)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProject(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Project> UpdateProject(Project project, int id)
    {
        throw new NotImplementedException();
    }
}
