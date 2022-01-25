using ProjectShop.Data.Infrastructure;
using ProjectShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slider>
    {
    }

    public class SlideRepository : RepositoryBase<Slider>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
