using System.ComponentModel.DataAnnotations;

namespace RestaurentMnagemntSytem.View.Models.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Category Image")]
        public IFormFile? ImageFile { get; set; }

        public string? ImagePath { get; set; }
        public int ItemCount { get; set; }
        public int Priority { get; set; }
        public bool IsAvailable { get; set; }
    }
}
