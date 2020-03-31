using MTC.Model.DTOs;
using MTC.Persistence.Database;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MTC.Model;

namespace MTC.Service
{
    public interface IUsuarioService
    {
        Task Create(UsuarioCreateDto model);
        Task<UsuarioDto> GetById(int id);
    }
   
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UsuarioService( 
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UsuarioDto> GetById(int id)
        {
            
            return _mapper.Map<UsuarioDto>(
                await _context.Usuarios.SingleAsync(x => x.UsuarioId == id)
                );
        }

        public async Task Create(UsuarioCreateDto model)
        {
            var entry = new Usuario
            {
                Nombre = model.Nombre,
                ApellidoPaterno = model.ApellidoPaterno,
                ApellidoMaterno = model.ApellidoMaterno,
                DNI = model.DNI,
                RUC = model.RUC

            };
            await _context.AddAsync(entry);
            await _context.SaveChangesAsync();
        }
    }
}
