
sealed class CreateProfileCommand: ICommand<string>
{
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }

    public required DateTime Birthdate { get; set; }

    public string? ProfileImageBase64 { get; set; }
}