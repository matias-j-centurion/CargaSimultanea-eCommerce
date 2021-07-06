using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSeC.web.Models
{
    public class Categoria
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set;}
        public string Descripcion { get; set; }
        public string Estado {get; set; }

    }

}
