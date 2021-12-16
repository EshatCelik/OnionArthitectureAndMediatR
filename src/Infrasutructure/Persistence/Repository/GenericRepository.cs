using Application.Interfaces.Repositoy;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _db;

        public GenericRepository(ApplicationContext db)
        {
            this._db = db;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.Set<T>().addAsync
            throw new NotImplementedException();

        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
