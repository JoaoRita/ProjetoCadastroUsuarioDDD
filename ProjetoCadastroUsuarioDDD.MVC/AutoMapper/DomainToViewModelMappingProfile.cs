using AutoMapper;
using ProjetoCadastroUsuarioDDD.Domain.Entities;
using ProjetoCadastroUsuarioDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCadastroUsuarioDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           // this.CreateMap<UsuarioViewModel, Usuario>();

            Mapper.Initialize(cfg =>  cfg.CreateMap<UsuarioViewModel, Usuario>().ReverseMap()); 

        }
    }
}