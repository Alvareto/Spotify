using Abp.Application.Services;

namespace Spotify
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SpotifyAppServiceBase : ApplicationService
    {
        protected SpotifyAppServiceBase()
        {
            LocalizationSourceName = SpotifyConsts.LocalizationSourceName;
        }
    }
}