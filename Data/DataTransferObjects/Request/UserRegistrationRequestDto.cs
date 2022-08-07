using System.ComponentModel.DataAnnotations;

namespace Data.DataTransferObjects.Request;

public class UserRegistrationRequestDto
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
        
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    public string? Email { get; set; }
        
    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }
        
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }

    public string RoleName { get; set; } = "User";

}