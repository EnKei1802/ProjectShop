using ProjectShop.Data.Infrastructure;
using ProjectShop.Model.Models;

namespace ProjectShop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    { }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
