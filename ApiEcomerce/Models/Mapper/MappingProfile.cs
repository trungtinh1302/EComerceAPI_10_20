using ApiEcomerce.Models.ViewModels;
using AutoMapper;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.Models.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountViewModel>();
            CreateMap<AccountCategory, AccountCategory>();
            CreateMap<ArticleMainCategory, ArticleMainCategoryViewModel>();
            CreateMap<ArticleCategory, ArticleCategoryViewModel>();
            CreateMap<Article, ArticleViewModel>();
            CreateMap<ProductMainCategory, ProductMainCategoryViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ContactCategory, ContactCategoryViewModel>();
            CreateMap<Contact, ContactViewModel>();
        }
    }
}
