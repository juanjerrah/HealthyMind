using System.Linq.Expressions;
using Domain.Humor.Interfaces;
using HumorDomain = Domain.Humor.Entities.Humor;
namespace Data.Humor.Repositories;

public class HumorRepository : IHumorRepository
{
    public Task<IEnumerable<HumorDomain>> GetHumores(Expression<Func<HumorDomain, bool>> predicate, int? start = null, int? length = null)
    {
        throw new NotImplementedException();
    }

    public Task<HumorDomain> GetHumorById(Guid? id)
    {
        throw new NotImplementedException();
    }

    public Task<Guid?> AddHumor(HumorDomain humor)
    {
        throw new NotImplementedException();
    }

    public Task UpdateHumor(HumorDomain humor)
    {
        throw new NotImplementedException();
    }

    public Task DeleteHumor(Guid id)
    {
        throw new NotImplementedException();
    }
}