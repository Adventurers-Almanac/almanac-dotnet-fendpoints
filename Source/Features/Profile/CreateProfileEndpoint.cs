using System.Drawing;
using FastEndpoints;

namespace AdventurersAlmanac.Almanac.Endpoints;

sealed class CreateProfileEndpoint : Endpoint<CreateProfileRequest, CreateProfileResponse, Mapper>
{
    public override void Configure()
    {
        Post("api/profile");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateProfileRequest req, CancellationToken ct)
    {
        Colorful.Console.WriteLine("CreateProfileEndpoint.HandleAsync", Color.LightCoral);

        var result = await new CreateProfileCommand()
        {
            FirstName = req.FirstName,
            LastName = req.LastName,
            Birthdate = req.Birthdate,
            ProfileImageBase64 = req.ProfileImageBase64
        }.ExecuteAsync(ct);

        Response.Result = result;

        await SendOkAsync(Response, ct);
    }
}