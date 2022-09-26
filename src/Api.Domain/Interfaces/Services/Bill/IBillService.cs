using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Bill
{
    public interface IBillService
    {
        Task<BillEntity> Get(Guid GUID);
        Task<IEnumerable<BillEntity>> GetAll();
        Task<BillEntity> Post(BillEntity bulletins);
        Task<BillEntity> Put(BillEntity bulletins);
        Task<bool> Delete(Guid GUID);
    }
}
