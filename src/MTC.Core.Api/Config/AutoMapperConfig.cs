﻿using AutoMapper;
using MTC.Model;
using MTC.Model.DTOs;
using MTC.Service.Commons;

namespace MTC.Core.Api.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<DataCollection<Usuario>, DataCollection<UsuarioDto>>();
        }
    }
}
