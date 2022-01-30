using AutoMapper;
using ProjectShop.Model.Models;
using ProjectShop.Web.Models;

namespace ProjectShop.Web.Mappings
{
    public class AutoMapperConfiguration :Profile
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
            });
            IMapper mapper = config.CreateMapper();
        }   
    }
}