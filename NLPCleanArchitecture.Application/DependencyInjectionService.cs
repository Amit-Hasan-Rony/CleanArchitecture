using NLPWithCleanArhitecture.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPCleanArchitecture.Application
{
    public class DependencyInjectionService : IDependencyInjectionService
    {
        private readonly IDependencyInjectionRepository _iDependencyInjectionRepository;
        private readonly IDependencyInjectionRepository _iDependencyInjectionRepositoryScoped;
        public DependencyInjectionService(IDependencyInjectionRepository iDependencyInjectionRepository, IDependencyInjectionRepository iDependencyInjectionRepositoryScoped)
        {
            _iDependencyInjectionRepository = iDependencyInjectionRepository;
            _iDependencyInjectionRepositoryScoped = iDependencyInjectionRepositoryScoped;
        }
        public async Task<List<Poscounter>> GetAllPOSCounter()
        {
            return (await _iDependencyInjectionRepository.GetAllPOSCounter());
        }


        public async Task<List<Poscounter>> setPosCounter(long AccountId, long BranchId)
        {
            return (await _iDependencyInjectionRepository.setPosCounter(AccountId, BranchId));
        }

        public async Task<List<Poscounter>> setAndGetPosCounter(long AccountId, long BranchId)
        {
            var response = await _iDependencyInjectionRepository.setPosCounter(AccountId, BranchId);
            return (await _iDependencyInjectionRepositoryScoped.GetAllPOSCounter());
        }

    }
}
