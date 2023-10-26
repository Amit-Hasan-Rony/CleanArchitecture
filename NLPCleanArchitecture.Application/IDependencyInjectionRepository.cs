using NLPWithCleanArhitecture.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPCleanArchitecture.Application
{
    public interface IDependencyInjectionRepository
    {
        public Task<List<Poscounter>> GetAllPOSCounter();
        public Task<List<Poscounter>> setPosCounter(long AccountId, long BranchId);
    }
}
