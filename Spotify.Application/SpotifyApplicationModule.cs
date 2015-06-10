using System.Reflection;
using Abp.Modules;

namespace Spotify
{
    [DependsOn(typeof(SpotifyCoreModule))]
    public class SpotifyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
