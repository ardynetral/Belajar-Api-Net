using Belajar_Api_Net.Infrastructures;
using Belajar_Api_Net.Infrastructures.DataAccess;
using Belajar_Api_Net.Domains.Movie.Entites;

namespace Belajar_Api_Net.Domains.Movie.Repositories
{
    public class MovieRepository : BaseRepository
    {
        public MovieRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<MovieEntity> GetListMovie()
        {
            return _dbContext.MovieEntities.Where(x => x.id > 1);
        }

    }
}
