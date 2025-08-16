namespace EFCore.Data.Entities;

public class User
{
    public User()
    {
        Products = [];
    }

    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public required string Username { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Address { get; set; }

    public required string City { get; set; }

    public required string Region { get; set; }

    public required string PostalCode { get; set; }

    public required string Country { get; set; }

    public List<Product> Products { get; set; }
}
