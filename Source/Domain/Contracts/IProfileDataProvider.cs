using AdventurersAlmanac.Domain.Entities;

namespace AdventurersAlmanac.Domain.Contracts
{
    public interface IProfileDataProvider
    {
        Task<string> SaveProfileAsync(Profile profile);
        
        Task<string> SaveProfilePictureAsync(byte[] profilePicture);
    }
}