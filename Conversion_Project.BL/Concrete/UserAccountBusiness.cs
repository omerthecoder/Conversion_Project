using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.BL.Concrete
{
    using Abstract;
    using DAL.Abstact;
    using Entities;
    public class UserAccountBusiness:IUserAccountBusiness
    {
        IUserAccountRepository _userAccountService;
        public UserAccountBusiness(IUserAccountRepository userAccountService)
        {
            _userAccountService = userAccountService;
        }

        public async Task Add(UserAccount entity)
        {
            await _userAccountService.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _userAccountService.Delete(id);
        }

        public IQueryable<UserAccount> GetAll(Func<UserAccount, bool> predicate = null)
        {
            return _userAccountService.GetAll(predicate);
        }

        public Task<UserAccount> GetById(int id)
        {
            return _userAccountService.GetById(id);
        }

        public UserAccount GetUser(string userName, string password)
        {
            return _userAccountService.GetUser(userName,password);
        }
    }
}
