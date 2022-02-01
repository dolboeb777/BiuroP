using System.ComponentModel.DataAnnotations;

namespace BiuroP.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Nazwa")]
        public override string Title { get; set; } = "Srtona informacyjna";

        [Display(Name = "Zawartość strony")]
        public override string Text { get; set; } = "Wypełnia administrator";
    }
}
