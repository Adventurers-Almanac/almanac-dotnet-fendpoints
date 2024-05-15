
using AdventurersAlmanac.Domain.Entities;

namespace AdventurersAlmanac.Domain.Contracts
{
    public interface IProfileRepository
    {
        Task<string> SaveProfileAsync(Profile profile);
    }
}