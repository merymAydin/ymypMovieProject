﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using ymypMovieProject.DataAccess.Context;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProject.DataAccess.Repositories.Concrete
{
    public class EfDirectorRepository : EfGenericRepository<Director, MovieDbContext>, IDirectorRepository
    {
        public EfDirectorRepository(MovieDbContext context) : base(context)
        {
        }

    }
}
