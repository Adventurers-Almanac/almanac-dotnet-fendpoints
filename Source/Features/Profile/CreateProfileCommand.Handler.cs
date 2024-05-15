
using System.Drawing;
using AdventurersAlmanac.Domain.Contracts;
using AdventurersAlmanac.Domain.Entities;

sealed class CreateProfileCommandHandler : ICommandHandler<CreateProfileCommand, string>
{

    private readonly IProfileRepository profileRepository;

    public CreateProfileCommandHandler(IProfileRepository profileRepository)
    {
        Colorful.Console.WriteLine("Creating CreateProfileCommandHandler", Color.Coral);

        this.profileRepository = profileRepository;
    }


    public async Task<string> ExecuteAsync(CreateProfileCommand command, CancellationToken ct)
    {
        Colorful.Console.WriteLine("Calling CreateProfileCommandHandler.ExecuteAsync", Color.LightCoral);

        Profile profile = new Profile(
            command.FirstName,
            command.LastName,
            command.Birthdate
        );

        if (command.ProfileImageBase64 != null)
        {
            profile.SetProfilePicture(Convert.FromBase64String(command.ProfileImageBase64));
        }

        await this.profileRepository.SaveProfileAsync(profile);

        return await Task.FromResult(string.Empty);
    }
}
