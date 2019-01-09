using AutoMapper;
using fichaAdr.Controllers.Resources;
using fichaAdr.Models;

namespace fichaAdr.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Ficha, FichaAdrResource>();
            CreateMap<Tipo, TipoResource>();
        }
        
    }
}