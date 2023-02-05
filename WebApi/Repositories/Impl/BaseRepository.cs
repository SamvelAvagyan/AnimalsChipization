﻿using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        private readonly AnimalsChipizationDbContext _dbContext;

        public BaseRepository(AnimalsChipizationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
