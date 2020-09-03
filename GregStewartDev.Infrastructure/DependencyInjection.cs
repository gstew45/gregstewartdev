using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            FileBlogStore blogStore = new FileBlogStore();
            blogStore.Initalize();

            services.AddSingleton<IBlogStore>(blogStore);
        }
    }
}
