using FastEndpoints;

namespace AdventurersAlmanac.Almanac;

sealed class CreateAlmanacRequest
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}

sealed class Validator : Validator<CreateAlmanacRequest>
{
    public Validator()
    {

    }
}

sealed class CreateAlmanacResponse
{
    public string Message => "This endpoint hasn't been implemented yet!";
}
