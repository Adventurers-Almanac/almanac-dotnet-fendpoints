using FastEndpoints;

namespace AdventurersAlmanac.Almanac.Endpoints;

sealed class CreateProfileRequest
{
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }

    public required DateTime Birthdate { get; set; }

    public IFormFile ProfilePicture { get; set; }
}

sealed class Validator : Validator<CreateProfileRequest>
{
    public Validator()
    {
        
    }
}

sealed class CreateProfileResponse
{
    public string Message => "This endpoint hasn't been implemented yet!";
}
