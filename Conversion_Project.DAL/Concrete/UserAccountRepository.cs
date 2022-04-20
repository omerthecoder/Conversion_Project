using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DAL.Concrete
{
    using Abstact;
    using Conversion_Project.DAL.Context.EF;
    using Conversion_Project.Entities;

    public class UserAccountRepository : IUserAccountRepository
    {
        DataContext _DB;
        public UserAccountRepository(DataContext DB)
        {
            _DB = DB;
        }
        public virtual async Task Add(UserAccount entity)
        {
            await _DB.UserAccount.AddAsync(entity);
            await _DB.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var entity = await GetById(id);
            _DB.UserAccount.Remove(entity);
            await _DB.SaveChangesAsync();
        }

        public IQueryable<UserAccount> GetAll(Func<UserAccount, bool> predicate = null)
        {
            var dbSet = _DB.UserAccount.AsQueryable();
            if (predicate != null)
            {
                dbSet = dbSet.Where(predicate).AsQueryable();
            }
            return dbSet;
        }

        public virtual async Task<UserAccount> GetById(int id)
        {
            return await _DB.UserAccount.FindAsync(id);
        }
        
        UserAccount IUserAccountRepository.GetUser(string userName, string password)
        {
            return (from t0 in _DB.UserAccount where t0.UserName == userName && t0.Password == password select t0).FirstOrDefault();
        }
    }
}
