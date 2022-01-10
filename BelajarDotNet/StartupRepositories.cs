using BelajarDotNet.Domains.Movie.Repositories;
namespace BelajarDotNet
{
    public partial class Startup
    {
        public void Repositories(IServiceCollection services)
        {
            services.AddScoped<MovieRepository>();
        }
    }
}
