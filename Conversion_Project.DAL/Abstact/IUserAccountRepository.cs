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
        UserAccount GetUser(string userName,string password);
    }
}
