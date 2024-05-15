namespace AdventurersAlmanac.Domain.Entities
{

public class Profile: Entity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public byte[] ProfilePicture { get; set; }

    public IList<string> Hobbies { get; set; } = new List<string>();

    public Profile(string firstName, string lastName, DateTime dateOfBirth): base()
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;

        this.ProfilePicture = [];
    }

    public void AddHobby(string hobby)
    {
        if(this.Hobbies == null) 
        {
            this.Hobbies = new List<string>();
        }

        this.Hobbies.Add(hobby);
    }

    public void SetProfilePicture(byte[] profilePicture)
    {
        this.ProfilePicture = profilePicture;
    }
}

}