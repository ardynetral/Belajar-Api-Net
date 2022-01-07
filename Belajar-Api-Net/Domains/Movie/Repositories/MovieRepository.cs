using Belajar_Api_Net.Infrastructures;
using Belajar_Api_Net.Infrastructures.DataAccess;

namespace Belajar_Api_Net.Domains.Movie.Repositories
{
    public class MovieRepository : BaseRepository
    {
        public MovieRepository(DataContext dataContext) : base(dataContext)
        {
        }

    }
}
