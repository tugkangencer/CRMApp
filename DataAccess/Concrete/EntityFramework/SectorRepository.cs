﻿using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class SectorRepository : EfEntityRepositoryBase<Sector, DbContext>, ISectorRepository
    {

    }
}