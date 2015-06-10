using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Spotify.EntityFramework.Repositories
{
    public abstract class SpotifyRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SpotifyDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SpotifyRepositoryBase(IDbContextProvider<SpotifyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SpotifyRepositoryBase<TEntity> : SpotifyRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SpotifyRepositoryBase(IDbContextProvider<SpotifyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
