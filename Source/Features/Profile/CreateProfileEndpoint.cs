using FastEndpoints;

namespace AdventurersAlmanac.Almanac.Endpoints;

sealed class Endpoint : Endpoint<CreateProfileRequest, CreateProfileResponse, Mapper>
{
    public override void Configure()
    {
        Post("api/profile");
        AllowFileUploads();
    }

    public override Task HandleAsync(CreateProfileRequest req, CancellationToken ct)
    {
        return SendOkAsync(Response, ct);
    }
}