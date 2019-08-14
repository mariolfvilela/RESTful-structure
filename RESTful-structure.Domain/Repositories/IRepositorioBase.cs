using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories.Queries;

namespace RESTfulstructure.Domain.Repositories
{
    public interface IRepositorioBase<TEntidade> : IDisposable
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
        /// <param name="id">ID do registro a ser excluído.</param>
        Task<bool> DeleteAsync(int id);

        /// <summary>
        /// Alterar um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser alterada.</param>
        /// <returns>A entidade alterada.</returns>
        Task<TEntidade> UpdateAsync(TEntidade entidade);

        /// <summary>
        /// Alterar um registro no banco de dados.
        /// </summary>
        /// <param name="id">Id da entidade a ser alterada.</param>
        /// <param name="entidade">Entidade a ser alterada.</param>
        /// <returns>A entidade alterada.</returns>
        Task<TEntidade> UpdateAsync(int id, TEntidade entidade);

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

        /// <summary>
        /// Selecionar todos os registros no banco de dados para uma determinada entidade com query.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<QueryResult<TEntidade>> ListAsync(BaseQuery query);
    }
}
