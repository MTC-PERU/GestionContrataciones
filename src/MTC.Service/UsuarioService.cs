﻿using System.Linq;
using MTC.Model.DTOs;
using MTC.Persistence.Database;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MTC.Model;
using MTC.Service.Commons;
using MTC.Service.Extensions;

namespace MTC.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Create(UsuarioCreateDto model);
        Task<UsuarioDto> GetById(int id);
        Task Update(int id, UsuarioUpdateDto model);
        Task Remove(int id);
        Task<DataCollection<UsuarioDto>> GetAll(int page, int take );
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

        public async Task<DataCollection<UsuarioDto>> GetAll(int page, int take)
        {

           return _mapper.Map<DataCollection<UsuarioDto>>(
                await _context.Usuarios.OrderByDescending(x=>x.UsuarioId)
                    .AsQueryable()
                    .PagedAsync(page,take)
               );

        }

        public async Task<UsuarioDto> GetById(int id)
        {
            
            return _mapper.Map<UsuarioDto>(
                await _context.Usuarios.SingleAsync(x => x.UsuarioId == id)
                );
        }

        public async Task<UsuarioDto> Create(UsuarioCreateDto model)
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

            return _mapper.Map<UsuarioDto>(entry);
        }

        public async Task Update (int id , UsuarioUpdateDto model)
        {
            var entry = await _context.Usuarios.SingleAsync(x => x.UsuarioId == id);

            entry.Nombre = model.Nombre;
            entry.ApellidoPaterno = model.ApellidoPaterno;
            entry.ApellidoMaterno = model.ApellidoMaterno;
            entry.DNI = model.DNI;
            entry.RUC = model.RUC;

            await _context.SaveChangesAsync();
        }


        public async Task Remove(int id)
        {
            _context.Usuarios.Remove(new Usuario
            {
                UsuarioId = id
            });

            await _context.SaveChangesAsync();
        }
    }
}
