using Belajar_Api_Net.Domains.Movie.Entites;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Belajar_Api_Net.Infrastructures.DataAccess
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
