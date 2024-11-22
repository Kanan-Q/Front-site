using System.ComponentModel.DataAnnotations;

namespace WebApplication3.ViewModel.Sliders
{
    public class SliderCreateVM
    {
        [MaxLength(30, ErrorMessage = "30 dan cox ola bilmez")]
        [MinLength(3, ErrorMessage = "3 den az ola bilmez")]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "30 dan cox ola bilmez")]
        [MinLength(3, ErrorMessage = "3 den az ola bilmez")]
        [Required]
        public string Subitle { get; set; } = null!;
        public string? Link { get; set; }
        public IFormFile File { get; set; }
    }
}
