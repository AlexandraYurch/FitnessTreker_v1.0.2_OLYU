using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTreker_Domain.Interfaces;
using FitnessTreker_Domain.Data;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;


namespace FitnessTreker_Domain
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private Gym _context;
        private DbSet<T> _setContext;

        public BaseRepository(Gym context)
        {
            _context = context;
            _setContext = context.Set<T>();
        }
        
        public Task<T> DeleteRecordAsync(T entity)
        {

            _setContext.Remove(entity);
            return (Task<T>)Task.CompletedTask;
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertRecordAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveAsync()
        {
            throw new NotImplementedException();
        }

        Task<T> IBaseRepository<T>.UpdateRecordAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
