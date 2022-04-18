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

    public class DataTextRepository : IDataTextRepository
    {
        private DataContext _DB;
        public DataTextRepository(DataContext DB)
        {
            _DB = DB;
        }
        public virtual async Task Add(DataText entity)
        {
            await _DB.DataText.AddAsync(entity);
            await _DB.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var entity = await GetById(id);
            _DB.Remove(entity);
            await _DB.SaveChangesAsync();
        }

        public IQueryable<DataText> GetAll(Func<DataText, bool> predicate = null)
        {
            var dbSet = _DB.DataText.AsQueryable();
            if (predicate != null) 
            {
                dbSet = dbSet.Where(predicate).AsQueryable();
            }
            return dbSet;
        }

        public virtual async Task<DataText> GetById(int id)
        {
            return await _DB.DataText.FindAsync(id);
        }
    }
}
