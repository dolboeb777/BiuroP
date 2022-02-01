using System.ComponentModel.DataAnnotations;

namespace BiuroP.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Wpiszcie Nazwę")]
        [Display(Name = "Nazwa")]
        public override string Title { get; set; }

        [Display(Name = "Krótki Opis")]
        public override string Subtitle { get; set; }

        [Display(Name = "Pełny Opis")]
        public override string Text { get; set; }
    }
}
