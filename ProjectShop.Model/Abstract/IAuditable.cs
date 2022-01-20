using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { get; set; }
        bool Status { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

    }
}
