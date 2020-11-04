using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext c) : base(c)
        {
            
        }
        
    }
}