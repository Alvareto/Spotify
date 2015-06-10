using Abp.Web.Mvc.Controllers;

namespace Spotify.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SpotifyControllerBase : AbpController
    {
        protected SpotifyControllerBase()
        {
            LocalizationSourceName = SpotifyConsts.LocalizationSourceName;
        }
    }
}