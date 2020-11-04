using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository

    {
        public MemberRepository(ApplicationDbContext context): base(context)
        {
            
        }
        
    }
}