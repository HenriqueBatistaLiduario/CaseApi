using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces.Services.Bill
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
