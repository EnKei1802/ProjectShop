﻿using ProjectShop.Data.Infrastructure;
using ProjectShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail> { }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(DbFactory dbFactory):base(dbFactory) { }
    }
}
