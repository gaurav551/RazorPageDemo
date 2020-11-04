using System;
using Construction.BackEnd.Repository;

namespace Construction.BackEnd.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
         IMemberRepository memberRepository{ get; }
           IProjectRepository projectRepository{ get; }
         IContactRepository contactRepository{ get; }
         IServiceRepository serviceRepository{ get; }
         IJobRepository jobRepository{ get; }
         IPrivacyRepository privacyRepository{get;}
         int Commit();
    }
}