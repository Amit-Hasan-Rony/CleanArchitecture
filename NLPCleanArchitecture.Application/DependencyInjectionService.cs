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


        /*
        public class HelperClass
        {
            public HelperClass() { 
            
            }
            public int HelperClassDoSomething()
            {
                return 0;
            }
        }
        public class MainClassAgain
        {
            private readonly HelperClass _helperClass1;
            public MainClassAgain(HelperClass helperClass)
            {
                _helperClass1 = helperClass;
            }

            public void MainDoSomething()
            {
                var ans = _helperClass1.HelperClassDoSomething();
                return;
            }
        }
        public class MainClass
        {
            public MainClass() { }
            public void MainDoSomething()
            {
                HelperClass helperClass = new HelperClass();
                var ans = helperClass.HelperClassDoSomething();
                return;
            }
        }
        */
        

    }
}
