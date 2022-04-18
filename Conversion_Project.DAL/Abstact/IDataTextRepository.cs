using Conversion_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DAL.Abstact
{
    public interface IDataTextRepository
    {
        IQueryable<DataText> GetAll(Func<DataText, bool> predicate = null);
        Task<DataText> GetById(int id);
        Task Add(DataText entity);
        Task Delete(int id);
    }
}
