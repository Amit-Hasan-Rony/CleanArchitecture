using NLPWithCleanArhitecture.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPCleanArchitecture.Application
{
    public interface IDependencyInjectionService
    {
        public Task<List<Poscounter>> GetAllPOSCounter();
        public Task<List<Poscounter>> setPosCounter(long AccountId, long BranchId);
        public Task<List<Poscounter>> setAndGetPosCounter(long AccountId, long BranchId);
    }
}
