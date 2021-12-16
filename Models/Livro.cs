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
        [Required]
        public string Isbn {get; set;}
        [Required]
        public string preco {get; set;}

        [Required]
        public int AutorId_autor {get; set;}
        public Autor Autor {get; set;}
        [Required]
        public int EditoraId_editora {get; set;}
        public Editora Editora {get; set;}
    }
}