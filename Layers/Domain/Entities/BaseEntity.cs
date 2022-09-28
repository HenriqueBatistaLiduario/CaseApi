using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntity  //Atributos comuns a todas as tabelas da base 
    {
        [Key]
        public Guid GUID { get; set; }
        private DateTime? _CREATEDON;
        public DateTime? CREATEDON
        {
            get { return _CREATEDON; }
            set { _CREATEDON = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UPDATEDON { get; set; }

    }
}
