using System;
using RESTfulstructure.Domain.Models;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Infra.Contexts;

namespace RESTfulstructure.Infra.Repositories
{
    public abstract class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade>
        where TEntidade : EntityBase
    {
        protected readonly Context contexto;

        public RepositorioBase(Contexto contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public TEntidade Alterar(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Attach(entidade);
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();
            return entidade;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Excluir(int id)
        {
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Remove(entidade);
                contexto.SendChanges();
            }
        }

        public void Excluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();
        }

        public TEntidade Incluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Add(entidade);
            contexto.SendChanges();
            return entidade;
        }

        public TEntidade SelecionarPorId(int id)
        {
            return contexto.Set<TEntidade>().Find(id);
        }

        public virtual IEnumerable<TEntidade> SelecionarTodos()
        {
            return contexto.Set<TEntidade>().ToList();
        }
    }
}
