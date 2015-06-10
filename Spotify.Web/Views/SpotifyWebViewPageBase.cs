using Abp.Web.Mvc.Views;

namespace Spotify.Web.Views
{
    public abstract class SpotifyWebViewPageBase : SpotifyWebViewPageBase<dynamic>
    {

    }

    public abstract class SpotifyWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SpotifyWebViewPageBase()
        {
            LocalizationSourceName = SpotifyConsts.LocalizationSourceName;
        }
    }
}