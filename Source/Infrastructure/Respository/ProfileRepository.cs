
using System.Drawing;
using AdventurersAlmanac.Domain.Contracts;
using AdventurersAlmanac.Domain.Entities;

public class ProfileRepository : IProfileRepository
{
    private IProfileDataProvider profileDataProvider;

    public ProfileRepository(IProfileDataProvider profileDataProvider)
    {
        Colorful.Console.WriteLine("Creating ProfileRepository", Color.Coral);

        this.profileDataProvider = profileDataProvider;
    }

    public async Task<string> SaveProfileAsync(Profile profile)
    {
        Colorful.Console.WriteLine("Calling ProfileRepository.SaveProfileAsync", Color.LightCoral);

        await this.profileDataProvider.SaveProfileAsync(profile);
        await this.profileDataProvider.SaveProfilePictureAsync(profile.ProfilePicture);

        return await Task.FromResult(string.Empty);
    }

}