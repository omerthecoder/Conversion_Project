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


        public UserAccount GetUser(string userName, string password)
        {
            return _userAccountService.GetUser(userName,password);
        }
    }
}
