using Belajar_Api_Net.Domains.Movie.Repositories;
namespace Belajar_Api_Net
{
    public partial class Startup
    {
        public void Repositories(IServiceCollection services)
        {
            services.AddScoped<MovieRepository>();
        }
    }
}
