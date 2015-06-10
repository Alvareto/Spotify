using System.Reflection;
using Abp.Modules;

namespace Spotify
{
    public class SpotifyCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
