using AutoMapper;
using Newsy_Job_Assignment.Models;
using Newsy_Job_Assignment.Models.DTO;

namespace Newsy_Job_Assignment.Mapping
{
    public class NewsyMappingProfile : Profile
    {

        public NewsyMappingProfile()
        {

            CreateMap<News_User, NewsUserDTORead>();
            CreateMap<NewsUserDTOInsertUpdate, News_User>();

            CreateMap<News_Article, NewsArticleDTORead>();
            CreateMap<NewsArticleDTOInsertUpdate, News_Article>();

        }

    }
}
