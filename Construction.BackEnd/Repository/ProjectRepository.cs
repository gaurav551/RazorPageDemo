using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context): base(context)
        {
            
        }
    }
}