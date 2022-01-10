using BelajarDotNet.Infrastructures;
using BelajarDotNet.Infrastructures.DataAccess;
using BelajarDotNet.Domains.Movie.Entites;

namespace BelajarDotNet.Domains.Movie.Repositories
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
