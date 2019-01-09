using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace fichaAdr.Controllers.Resources
{
    public class FichaAdrResource
    {
        public int Id { get; set; }
        public int NumeroAdr { get; set; }

        public string Nombre { get; set; }

        public ICollection<TipoResource> Tipos { get; set; }

        public FichaAdrResource()
        {

            Tipos = new Collection<TipoResource>();


        }
    }
}