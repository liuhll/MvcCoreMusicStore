﻿using MvcCoreDemo.Data.Repository.EntityFramework.Common;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository;

namespace MvcCoreDemo.Data.Repository.EntityFramework
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
    }
}
