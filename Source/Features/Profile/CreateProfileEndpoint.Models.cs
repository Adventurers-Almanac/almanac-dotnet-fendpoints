using FastEndpoints;

namespace AdventurersAlmanac.Almanac.Endpoints;

sealed class CreateProfileRequest
{
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }

    public required DateTime Birthdate { get; set; }

    public string ProfileImageBase64 { get; set; }
}

sealed class Validator : Validator<CreateProfileRequest>
{
    public Validator()
    {
        
    }
}

sealed class CreateProfileResponse
{
    public string Result { get; set; }
}
