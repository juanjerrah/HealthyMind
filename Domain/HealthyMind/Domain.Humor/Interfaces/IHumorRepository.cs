using System.Linq.Expressions;
using HumorDomain = Domain.Humor.Entities.Humor;
namespace Domain.Humor.Interfaces;

public interface IHumorRepository
{
    Task<IEnumerable<HumorDomain>> GetHumores(Expression<Func<HumorDomain, bool>> predicate, int? start = null,
        int? length = null);
    Task<HumorDomain> GetHumorById(Guid? id);
    Task<Guid?> AddHumor(HumorDomain humor);
    Task UpdateHumor(HumorDomain humor);
    Task DeleteHumor(Guid id);
}