using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DataAccess
{
    public class Slider : BaseEntity
    {
        [MaxLength(30, ErrorMessage = "30 dan cox ola bilmez")]
        [MinLength(3, ErrorMessage = "3 den az ola bilmez")]
        public string Title { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "30 dan cox ola bilmez")]
        [MinLength(3, ErrorMessage = "3 den az ola bilmez")]
        public string Subitle { get; set; } = null!;
        public string Link { get; set; }
        public string ImageUrl { get; set; } = null!;


    }
}
