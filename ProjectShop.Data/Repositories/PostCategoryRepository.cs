﻿using ProjectShop.Data.Infrastructure;
using ProjectShop.Model.Models;

namespace ProjectShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory> { }
    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
