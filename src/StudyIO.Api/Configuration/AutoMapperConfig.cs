﻿using AutoMapper;
using StudyIO.Api.ViewModels;
using StudyIO.Business.Models;

namespace StudyIO.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>();

            CreateMap<Produto, ProdutoViewModel>()
               .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}