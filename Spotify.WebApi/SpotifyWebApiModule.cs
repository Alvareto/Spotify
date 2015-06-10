using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Spotify
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SpotifyApplicationModule))]
    public class SpotifyWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SpotifyApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
