
namespace Application.User.DTOs.RequestDTOs
{
    public record RegisterUserDto
    (
        string UserName,
        string Password,
        string Email,
        string FirstName,
        string LastName,
        string PhoneNumber,
        string Passport
    );
}
