using StudentManage.Repositories.Interfaces;
using System;


namespace StudentManage.Repositories.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentManageContext _dbContext;
        private bool _disposed;

        public UnitOfWork(StudentManageContext context)
        {
            this._dbContext = context;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
