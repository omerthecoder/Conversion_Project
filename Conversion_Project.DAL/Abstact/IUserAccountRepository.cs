using Conversion_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DAL.Abstact
{
    public interface IUserAccountRepository
    {
        IQueryable<UserAccount> GetAll(Func<UserAccount, bool> predicate = null);
        Task<UserAccount> GetById(int id);
        Task Add(UserAccount entity);
        Task Delete(int id);
        UserAccount GetUser(string userName,string password);
    }
}
