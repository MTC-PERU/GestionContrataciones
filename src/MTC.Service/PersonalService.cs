using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MTC.Model;
using MTC.Model.DTOs;
using MTC.Persistence.Database;
using MTC.Service.Commons;
using MTC.Service.Extensions;

namespace MTC.Service
{
    public interface IPersonalService
    {
        Task<PersonalDto> Create(PersonalCreateDto model);
        Task<PersonalDto> GetById(int id);
        Task Remove(int id);
        Task<DataCollection<PersonalDto>> GetAll(int page, int take);
        Task Update(int id, PersonalUpdateDto model);

    }

    public class PersonalService : IPersonalService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PersonalService(
            ApplicationDbContext context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PersonalDto> Create(PersonalCreateDto model)
        {
            var entry = new Personal
            {
                  Nombres = model.Nombres,
                  Apellido_Paterno = model.Apellido_Paterno,
                  Apellido_Materno = model.Apellido_Materno,
                  Email = model.Email,
                  Direccion = model.Direccion,
                  Dni = model.Dni,
                  EsCoordinador = model.EsCoordinador,
                  Experiencia_Especifica = model.Experiencia_Especifica,
                  Experiencia_General = model.Experiencia_General,
                  Perfil = model.Perfil,
                  CCI = model.CCI,
                  Nro_Celular = model.Nro_Celular,
                  Ruc = model.Ruc
                  

            };

            await _context.AddAsync(entry);
            await _context.SaveChangesAsync();

            return _mapper.Map<PersonalDto>(entry);
        }


        public async Task<PersonalDto> GetById(int id)
        {

            return _mapper.Map<PersonalDto>(
                await _context.Personal.SingleAsync(x => x.PersonalId == id)
            );
        }


        public async Task<DataCollection<PersonalDto>> GetAll(int page, int take)
        {

            return _mapper.Map<DataCollection<PersonalDto>>(
                await _context.Personal.OrderByDescending(x => x.PersonalId)
                    .AsQueryable()
                    .PagedAsync(page, take)
            );

        }


        public async Task Update(int id, PersonalUpdateDto model)
        {
            var entry = await _context.Personal.SingleAsync(x => x.PersonalId == id);

            entry.Nombres = model.Nombres;
            entry.Apellido_Paterno = model.Apellido_Paterno;
            entry.Apellido_Materno = model.Apellido_Materno;
            entry.Dni = model.Dni;
            entry.Ruc = model.Ruc;
            entry.Email = model.Email;
            entry.Nro_Celular = model.Nro_Celular;
            entry.Direccion = model.Direccion;
            entry.CCI = model.CCI;
            entry.EsCoordinador = model.EsCoordinador;
            entry.Experiencia_Especifica = model.Experiencia_Especifica;
            entry.Experiencia_General = model.Experiencia_General;
            entry.Perfil = model.Perfil;

            await _context.SaveChangesAsync();
        }


        public async Task Remove(int id)
        {
            _context.Personal.Remove(new Personal
            {
                PersonalId = id
            });

            await _context.SaveChangesAsync();
        }

    }
}
