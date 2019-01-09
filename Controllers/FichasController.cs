using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fichaAdr.Controllers.Resources;
using fichaAdr.Models;
using fichaAdr.Persistence;


namespace fichaAdr.Controllers
{
    public class FichasController : Controller
    {
        private readonly FichaAdrDbContext context;
        private readonly IMapper mapper;
        public FichasController(FichaAdrDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }


        [HttpGet("/api/fichas")]
        public async Task<IEnumerable<FichaAdrResource>> GetFichas()
        {
            var fichas = await context.Fichas.Include(m => m.Tipos).ToListAsync();

            return mapper.Map<List<Ficha>, List<FichaAdrResource>>(fichas);
        }
    }
}