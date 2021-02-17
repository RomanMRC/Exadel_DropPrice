﻿using DAL.DataContext;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ImageRepository: Repository<Image>, IImageRepository 
    {
        public ImageRepository(ApplicationDbContext context)
            :base(context)
        {

        }

    }
}
