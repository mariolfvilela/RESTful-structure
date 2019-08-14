using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories.Queries;

namespace RESTfulstructure.Domain.Services.Interfaces
{
    /// <summary>
    /// Interface de serviço de domínio base.
    /// </summary>
    /// <typeparam name="TEntidade">Entidade que implementará o serviço de domínio base.</typeparam>
    public interface IServiceBase<TEntidade> : IDisposable
        where TEntidade : EntityBase
    {
        /// <summary>
        /// Incluir um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser incluída.</param>
        /// <returns>A entidade incluída.</returns>
        Task<TEntidade> SaveAsync(TEntidade entidade);

        /// <summary>
        /// Excluir um registro no banco de dados.
        /// </summary>
        /// <param name="id">Entidade a ser excluída.</param>
        Task<bool> DeleteAsync(int id);

        /// <summary>
        /// Alterar um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser alterada.</param>
        /// <returns>A entidade alterada.</returns>
        Task<TEntidade> UpdateAsync(TEntidade entidade);

        /// <summary>
        /// Selecionar um registro no banco de dados.
        /// </summary>
        /// <param name="id">ID do registro a ser retornado.</param>
        /// <returns>Entidade do registro encontrado.</returns>
        Task<TEntidade> FindByIdAsync(int id);

        /// <summary>
        /// Selecionar todos os registros no banco de dados para uma determinada entidade.
        /// </summary>
        /// <returns>Uma listagem dos registros encontrados.</returns>
        Task<IEnumerable<TEntidade>> ListAsync();

        Task<QueryResult<TEntidade>> ListAsync(BaseQuery query);
    }
}
