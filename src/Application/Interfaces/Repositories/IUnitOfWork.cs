using System;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Boilerplate.Domain;

namespace WebApi.Boilerplate.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> CommitAsync(CancellationToken cancellationToken);

        Task Rollback();
    }
}