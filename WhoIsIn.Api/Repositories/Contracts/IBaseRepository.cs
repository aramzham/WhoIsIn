namespace WhoIsIn.Api.Repositories.Contracts;

public interface IBaseRepository
{
    Task<bool> SaveChangesAsync();
}