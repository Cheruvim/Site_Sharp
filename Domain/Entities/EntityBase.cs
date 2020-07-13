using System;
using System.ComponentModel.DataAnnotations;

namespace Work.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Категория")]
        public virtual string Category { get; set; }

        [Display(Name = "Сумма")]
        public virtual int Sum { get; set; }

        [Display(Name = "Комментарий")]
        public virtual string Comment { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
