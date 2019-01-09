using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fichaAdr.Models
{
    [Table("Tipos")]
    public class Tipo
    {
        public int Id { get; set; }
         [Required]
         [StringLength(255)]
        public string Nombre { get; set; }
        public Ficha Ficha { get; set; }
        public int FichaId { get; set; }

    }
}