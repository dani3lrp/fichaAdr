using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace fichaAdr.Models
{
    public class Ficha
    {
        public int Id { get; set; }
        [Required]
        public int NumeroAdr { get; set; }
        
        [StringLength(255)]
        public string Nombre { get; set; }

        public ICollection<Tipo> Tipos { get; set; }

        public Ficha()
        {

            Tipos = new Collection<Tipo>();

        }
    }



    
}