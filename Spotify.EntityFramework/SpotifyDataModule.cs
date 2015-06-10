using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Spotify.EntityFramework;

namespace Spotify
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SpotifyCoreModule))]
    public class SpotifyDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SpotifyDbContext>(null);
        }
    }
}
