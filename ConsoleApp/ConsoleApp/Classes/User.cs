namespace ConsoleApp.Classes;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public override string ToString()
        => $"User: {Name}, {Email}";

    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return Name == user.Name && Email == user.Email;
        return false;
    }

    public override int GetHashCode()
    {
        int test = Name.GetHashCode() + Email.GetHashCode();
        return test;
    }
}
