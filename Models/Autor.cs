using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Autor
    {
        [Key]
        [Required]
        public int Id {get; set;}
        [Required]
        public string Nome {get; set;}
        [Required]
        public string SobreNome { get; set; }
    }
}