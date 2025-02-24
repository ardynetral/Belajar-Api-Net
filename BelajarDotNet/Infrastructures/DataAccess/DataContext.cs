﻿using BelajarDotNet.Domains.Movie.Entites;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BelajarDotNet.Infrastructures.DataAccess
{
    public class DataContext : DbContext
    {
        public virtual DbSet<MovieEntity> MovieEntities { get; set; }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        
    }

}
