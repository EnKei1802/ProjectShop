using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectShop.Data.Infrastructure;
using ProjectShop.Data.Repositories;
using ProjectShop.Model.Models;
using System.Linq;

namespace ProjectShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest 
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Tets-category";
            category.Status = true;
            category.CreatedDate = System.DateTime.Now;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostCategory_Ropository_GetAll()
        {
            var result = objRepository.GetAll().ToList();
            Assert.AreEqual(4, result.Count);

        }
    }
}
