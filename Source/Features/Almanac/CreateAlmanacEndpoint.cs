using FastEndpoints;

namespace AdventurersAlmanac.Almanac;

sealed class Endpoint : Endpoint<CreateAlmanacRequest, CreateAlmanacResponse, Mapper>
{
    public override void Configure()
    {
        Post("api/almanac");
    }

    public override Task HandleAsync(CreateAlmanacRequest req, CancellationToken ct)
    {
        return SendOkAsync(Response, ct);
    }
}