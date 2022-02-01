using System;
using System.ComponentModel.DataAnnotations;

namespace BiuroP.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Nazwa")]
        public virtual string Title { get; set; }

        [Display(Name = "Krótki Opis")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Pełny Opis")]
        public virtual string Text { get; set; }

        [Display(Name = "Obraz")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
