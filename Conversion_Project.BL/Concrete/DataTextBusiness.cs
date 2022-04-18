using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.BL.Concrete
{
    using Abstract;
    using Conversion_Project.DAL.Abstact;
    using Conversion_Project.Entities;

    public class DataTextBusiness : IDataTextBusiness
    {
        IDataTextRepository _dataService;
        public DataTextBusiness(IDataTextRepository dataService)
        {
            _dataService = dataService;
        }
        public async Task Add(DataText entity)
        {
            await _dataService.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _dataService.Delete(id);
        }

        public IQueryable<DataText> GetAll(Func<DataText, bool> predicate = null)
        {
            return _dataService.GetAll(predicate);
        }

        public async Task<DataText> GetById(int id)
        {
            return await _dataService.GetById(id);
        }
    }
}
