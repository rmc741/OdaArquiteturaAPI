
using OdaArquiteturaAPI.Entity;

namespace OdaArquiteturaAPI.Repository.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> GetAllProjects();
    Task<Project> GetProjectById(int id);
    Task<Project> AddProject(Project project);
    Task<Project> UpdateProject(Project project, int id);
    Task<bool> DeleteProject(int id);
}