using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectShop.Web.Models
{
    public class PostViewModel
    {


        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
        public string Content { get; set; }
        public int? HomneFlag { get; set; }
        public int? HotFlag { get; set; }
        public int? ViewCount { get; set; }


        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }


        public DateTime CreatedDate { get; set; }

        public string CreateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string UpdateBy { get; set; }

        public bool Status { get; set; }


        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }
    }
}