
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectShop.Data.Infrastructure;
using ProjectShop.Data.Repositories;
using ProjectShop.Model.Models;
using ProjectShop.Service;
using System.Collections.Generic;

namespace ProjectShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {

        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockOfWork;
        private IPostCategoryService _categoryServie;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockOfWork = new Mock<IUnitOfWork>();
            _mockRepository = new Mock<IPostCategoryRepository>();
            _categoryServie = new PostCategoryService(_mockRepository.Object, _mockOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory(){ ID = 1, Name = "DM1",Status= true},
                new PostCategory(){ ID = 2, Name ="DM2",Status= true},
                new PostCategory{ ID = 3, Name ="DM3",Status = true},
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Setup Method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);


            //call action
            var result = _categoryServie.GetAll() as List<PostCategory>;


            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });

            var result = _categoryServie.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1,result.ID);
        }
    }
}
