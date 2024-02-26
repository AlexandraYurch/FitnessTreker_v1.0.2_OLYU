using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTreker_Domain.Interfaces
{
    public interface IBaseRepository <T> where T : class
    {
        Task <T> GetByIdAsync(int id);
        Task <T> InsertRecordAsync(T entity);
        Task<T> DeleteRecordAsync(T entity);
        Task<T> UpdateRecordAsync(T entity);
        void SaveAsync();
    }

}
