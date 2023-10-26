using Microsoft.EntityFrameworkCore;
using NLPCleanArchitecture.Application;
using NLPWithCleanArhitecture.Domain;
using NLPWithCleanArhitecture.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPClean.Infrastructure
{
    public class DependencyInjectionRepository : IDependencyInjectionRepository
    {
        private readonly Context _context;
        private List<Poscounter> Poscounters = new List<Poscounter>();
        public DependencyInjectionRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Poscounter>> GetAllPOSCounter()
        {
            try
            {
                var response = Poscounters.ToList();
                return response;
            }
            catch(Exception ex)
            {
                throw new Exception("Something Went Wrong");
            }
        }

        public async Task<List<Poscounter>> setPosCounter(long AccountId, long BranchId)
        {
            try
            {
                
                var response = await _context.Poscounters.Select(n => new Poscounter
                {
                    CounterId  = n.CounterId ,
                    CounterName = n.CounterName,
                    CounterCode = n.CounterCode,
                    AccountId  = n.AccountId ,
                    BranchId  = n.BranchId ,
                    OfficeId  = n.OfficeId ,
                    WarehouseId  = n.WarehouseId ,
                    CounterOpeningDate  = n.CounterOpeningDate ,
                    CounterClosingDate  = n.CounterClosingDate ,
                    ActionById  = n.ActionById ,
                    IsActive  = n.IsActive ,
                    LastActionDatetime  = n.LastActionDatetime ,
                    ServerDatetime  = n.ServerDatetime ,
                    UserId = n.UserId,
                    MessageId  = n.MessageId,
                }).Take(20).ToListAsync();

                Poscounters.AddRange(response);

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("Something Went Wrong");
            }
        }





    }
}
