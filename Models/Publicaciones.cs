using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSeC.web.Models
{
    public class Publicaciones
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set;}

        [MaxLength(60)]
        [Required]
        public string Titulo {get; set;}
        
        public string Descripcion { get; set; }
        public string Estado {get; set; }

        public int CategoriaID { get; set;} 
        public Categoria Categoria { get; set;}

        [Required]
        public int Precio {get; set;} 

    }

}
