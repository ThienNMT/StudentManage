using Serilog;
using StudentManage.Domain.Entities;
using StudentManage.Repositories.Data;
using StudentManage.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace StudentManage.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StudentManageContext _dbContext;
        private IDbSet<T> _entities;
        private IDbSet<T> Entities => _entities ?? (_entities = _dbContext.Set<T>());

        public GenericRepository(StudentManageContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return this.Entities.ToList();
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_GetAll_Errors: {ex.Message}");
                return Enumerable.Empty<T>();
            }
        }

        public T GetById(int id)
        {
            try
            {
                return this.Entities.Find(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_GetById_Errors: {ex.Message}");
                return null;
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> condition)
        {
            try
            {
                return this.Entities.Where(condition);
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_Where_Errors: {ex.Message}");
                return null;
            }
        }

        public IQueryable<T> ToQueryable()
        {
            try
            {
                return this.Entities;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_ToQueryable_Errors: {ex.Message}");
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public T Create(T entity)
        {
            if (entity is null)
            {
                Log.Logger.Error($"GenericRepository_Create_Errors_{nameof(entity)}");
                return null;
            }
            try
            {
                this.Entities.Add(entity);
                return entity;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_Create_Errors: {ex.Message}");
                return null;
            }
        }

        public bool Create(IEnumerable<T> entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    this.Entities.AddOrUpdate(entity);
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_Create_Errors: {ex.Message}");
                return false;
            }
        }

        public bool Update(T entity)
        {
            if (entity is null)
            {
                Log.Logger.Error($"GenericRepository_Update_Errors");
                return false;
            }
            try
            {
                this.Entities.AddOrUpdate(entity);
                return true;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepositor_Update_Errors: {ex.Message}");
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                this.Entities.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_Delete_Errors: {ex.Message}");
                return false;
            }
        }

        public bool Delete(IEnumerable<T> entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    this.Entities.Remove(entity);
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"GenericRepository_Delete_Errors: {ex.Message}");
                return false;
            }
        }
    }
}
