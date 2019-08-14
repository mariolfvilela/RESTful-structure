using System;
namespace RESTfulstructure.Domain.Models
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Entidade base.
        /// </summary>
        public EntityBase() { }

        /// <summary>
        /// Identificação (Identity)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data de criação do registro.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Data de alteração do registro.
        /// </summary>
        public DateTime? DateChange { get; set; }
    }
}
