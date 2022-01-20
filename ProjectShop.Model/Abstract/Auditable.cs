﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { get ; set; }
        [MaxLength(256)]
        public string CreateBy { get ; set; }
        public DateTime? UpdatedDate { get ; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set ; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}
