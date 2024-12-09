using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.Tests.UnitTests.Services;

public class TokenServiceTests
{
    private Mock<IConfiguration> _configurationMock;
    private TokenService _tokenService;

    [SetUp]
    public void Setup()
    {
        _configurationMock = new Mock<IConfiguration>();

        _configurationMock.Setup(c => c["JwtSettings:SecretKey"]).Returns("VerySecureSecretKey12345");
        _configurationMock.Setup(c => c["JwtSettings:Issuer"]).Returns("https://example.com");
        _configurationMock.Setup(c => c["JwtSettings:Audience"]).Returns("https://example.com");

        _tokenService = new TokenService(_configurationMock.Object);
    }

    [Test]
    public void GenerateAccessToken_ValidUser_ReturnsValidToken()
    {
        // Arrange
        _configurationMock.Setup(c => c["JwtSettings:SecretKey"]).Returns(new string('A', 32));
        _configurationMock.Setup(c => c["JwtSettings:Issuer"]).Returns("https://example.com");
        _configurationMock.Setup(c => c["JwtSettings:Audience"]).Returns("https://example.com");

        var user = new ApplicationUser
        {
            Id = Random.Shared.Next(),
            UserName = "testuser",
            Email = "testuser@example.com",
            Roles = new List<ApplicationRole>
        {
            new ApplicationRole { Role = "Admin" },
            new ApplicationRole { Role = "User" }
        }
        };

        // Act
        var token = _tokenService.GenerateAccessToken(user);

        // Assert
        Assert.That(token, Is.Not.Null.And.Not.Empty, "Token should not be null or empty.");

        var handler = new JwtSecurityTokenHandler();
        Assert.That(handler.CanReadToken(token), Is.True, "Generated token should be readable.");

        var jwtToken = handler.ReadJwtToken(token);
        Assert.Multiple(() =>
        {
            Assert.That(jwtToken.Issuer, Is.EqualTo("https://example.com"), "Issuer should match.");
            Assert.That(jwtToken.Audiences, Does.Contain("https://example.com"), "Audience should match.");
        });

        var claims = jwtToken.Claims.ToList();
        Assert.Multiple(() =>
        {
            Assert.That(claims, Has.Exactly(1).Matches<Claim>(c => c.Type == ClaimTypes.NameIdentifier && c.Value == user.Id.ToString()));
            Assert.That(claims, Has.Exactly(1).Matches<Claim>(c => c.Type == ClaimTypes.Name && c.Value == user.UserName));
            Assert.That(claims, Has.Exactly(1).Matches<Claim>(c => c.Type == ClaimTypes.Email && c.Value == user.Email));
            Assert.That(claims, Has.Exactly(1).Matches<Claim>(c => c.Type == ClaimTypes.Role && c.Value == "Admin,User"));
        });
    }

    [Test]
    public void GenerateAccessToken_InvalidConfiguration_ThrowsException()
    {
        // Arrange
        _configurationMock.Setup(c => c["JwtSettings:SecretKey"]).Returns((string)null);

        var user = new ApplicationUser
        {
            Id = Random.Shared.Next(),
            UserName = "testuser",
            Email = "testuser@example.com",
            Roles = new List<ApplicationRole>()
        };

        // Act & Assert
        var ex = Assert.Throws<ArgumentNullException>(() => _tokenService.GenerateAccessToken(user));

        Assert.Multiple(() =>
        {
            Assert.That(ex, Is.Not.Null, "Exception should not be null.");
            Assert.That(ex.ParamName, Is.EqualTo("s"), "Parameter name should be 's' as expected by SymmetricSecurityKey.");
            Assert.That(ex.Message, Does.Contain("Value cannot be null"), "Exception message should indicate null value.");
        });
    }

}
