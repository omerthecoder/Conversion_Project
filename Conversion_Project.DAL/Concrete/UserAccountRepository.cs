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
        UserAccount IUserAccountRepository.GetUser(string userName, string password)
        {
            return (from t0 in _DB.UserAccount where t0.UserName == userName && t0.Password == password select t0).FirstOrDefault();
        }
    }
}
