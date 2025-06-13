using HistoryOfChristianity.Application.Mapping;

namespace HistoryOfChristianity.Web.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(MappingProfiles));
        }
    }
}
