using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id {get; set;}
        [Required]
        public string Nome {get; set;}
    }
}