using System;
using System.Threading.Tasks;

namespace RESTfulstructure.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
