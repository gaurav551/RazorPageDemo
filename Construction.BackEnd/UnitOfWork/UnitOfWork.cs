using Construction.BackEnd.Data;
using Construction.BackEnd.Repository;

namespace Construction.BackEnd.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            memberRepository = new MemberRepository(_context);
            contactRepository = new ContactRepository(_context);
            projectRepository = new ProjectRepository(_context);
            serviceRepository = new ServiceRepository(_context);
            jobRepository = new JobRepository(_context);
             privacyRepository = new PrivacyRepository(_context);



        }
        public IMemberRepository memberRepository { get; private set;}

        public IContactRepository contactRepository {get;private set;}
         public IProjectRepository projectRepository {get;private set;}

        public IServiceRepository serviceRepository {get;private set;}

        public IJobRepository jobRepository {get;private set;}

        public IPrivacyRepository privacyRepository {get;private set;}

        public int Commit()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}