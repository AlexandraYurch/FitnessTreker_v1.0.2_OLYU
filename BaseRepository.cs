using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using FitnessTreker_v1._0._2_OLYU.Interfaces;
using FitnessTreker_v1._0._2_OLYU.Data;

namespace FitnessTreker_v1._0._2_OLYU
{
    /*public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private Gym _context;
        private DbSet<T> _setContext;

        public BaseRepository(Gym context)
        {
            _context = context;
            _setContext = context.Set<T>();
        }

        public async Task<T> DeleteRecordAsync(T entity)
        {

            _setContext.Remove(entity);
            return await (Task<T>)Task.CompletedTask;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertRecordAsync(T entity)
        {
            _setContext.Remove(entity);
            return await (Task<T>)Task.CompletedTask;
        }

        public async void SaveAsync()
        {
            throw new NotImplementedException();
        }

        async Task<T> IBaseRepository<T>.UpdateRecordAsync(T entity)
        {
            _setContext.Remove(entity);
            return await (Task<T>)Task.CompletedTask;
        }
    }*/
}
