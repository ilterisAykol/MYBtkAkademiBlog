using AutoMapper;
using MYBtkAkademiBlog.WebApi.Dtos.ArticleDtos;
using MYBtkAkademiBlog.WebApi.Entities;

namespace MYBtkAkademiBlog.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() {
            CreateMap<Article, ResultArticleWithCategoryDto>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
            CreateMap<Article, CreateArticleDto>().ReverseMap();
            CreateMap<Article, UpdateArticleDto>().ReverseMap();
            CreateMap<Article, GetArticleByIdDto>().ReverseMap();
        }
    }
}
