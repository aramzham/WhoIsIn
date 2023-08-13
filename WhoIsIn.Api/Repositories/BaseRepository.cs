using WhoIsIn.Api.Data;
using WhoIsIn.Api.Repositories.Contracts;

namespace WhoIsIn.Api.Repositories;

public abstract class BaseRepository : IBaseRepository, IAsyncDisposable
{
    protected readonly AppDbContext _db;

    public BaseRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _db.SaveChangesAsync() > 0;
    }

    public ValueTask DisposeAsync()
    {
        return _db.DisposeAsync();
    }
}