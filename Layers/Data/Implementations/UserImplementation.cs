using System.Threading.Tasks;
using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }
        public async Task<UserEntity> FindByLogin(string email) //SELECT através do e-mail
        {
            return await _dataset.FirstOrDefaultAsync(u => u.USEREMAIL.Equals(email)); //Traz o primeiro que encontrar, se não encontrar nada retorna nulo.
        }
    }
}
