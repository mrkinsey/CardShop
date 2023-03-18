using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CardShop.Data.Entities;
using CardShop.Models.CardSetModels;
using CardShop.Models.CardSingleModels;
using CardShop.Models.CategoryModels;

namespace CardShop.Services.Configurations
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            CreateMap<Category, CategoryCreate>().ReverseMap();
            CreateMap<Category, CategoryListItem>().ReverseMap();

            CreateMap<CardSet, CardSetCreate>().ReverseMap();
            CreateMap<CardSet, CardSetListItem>().ReverseMap();
            CreateMap<CardSet, CardSetUpdate>().ReverseMap();
            CreateMap<CardSet, CardSetDetails>().ReverseMap();
            CreateMap<CardSet, CardSetDelete>().ReverseMap();

            CreateMap<CardSingle, CardSingleCreate>().ReverseMap();
            CreateMap<CardSingle, CardSingleListItem>().ReverseMap();
            CreateMap<CardSingle, CardSingleUpdate>().ReverseMap();
            CreateMap<CardSingle, CardSingleDetails>().ReverseMap();
            CreateMap<CardSingle, CardSingleDelete>().ReverseMap();
        }
    }
}