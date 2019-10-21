
namespace AutoMapperApi.Data.Repositories
{
    public class BaseRepository
    {
        private readonly AutoMapperContext _ctx;

        public BaseRepository(AutoMapperContext ctx)
        {
            _ctx = ctx;
        }


        public virtual bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}