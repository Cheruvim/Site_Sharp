using System.ComponentModel.DataAnnotations;

namespace Work.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните категорию")]
        [Display(Name = "Категория")]
        public override string Category { get; set; }

        [Required(ErrorMessage = "Заполните сумму")]
        [Display(Name = "Сумма")]
        public override int Sum { get; set; }

        [Display(Name = "Комментарий")]
        public override string Comment { get; set; }
    }
}
