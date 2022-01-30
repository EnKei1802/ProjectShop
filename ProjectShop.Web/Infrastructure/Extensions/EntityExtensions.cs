using ProjectShop.Model.Models;
using ProjectShop.Web.Models;


namespace ProjectShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory,
            PostCategoryViewModel postCategoryVM)
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.Image = postCategoryVM.Image;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.Description = postCategoryVM.Description;

            postCategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postCategory.CreatedDate = postCategoryVM.CreatedDate;
            postCategory.UpdateBy = postCategoryVM.UpdateBy;
            postCategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.Status = postCategoryVM.Status;
        }

        public static void UpdatePost(this Post post,
            PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Description = postVM.Description;
            post.HotFlag = postVM.HotFlag;
            post.ViewCount = postVM.ViewCount;
            post.CategoryID = postVM.CategoryID;
            post.Image = postVM.Image;
            post.Alias = postVM.Alias;
            post.Content = postVM.Content;

            post.UpdatedDate = postVM.UpdatedDate;
            post.CreatedDate = postVM.CreatedDate;
            post.UpdateBy = postVM.UpdateBy;
            post.UpdatedDate = postVM.UpdatedDate;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
        }
    }
}