using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Infrastructure.Services.Commons;

namespace VacancyManagementSystem.Tests.Services.Commons;

[TestFixture]
public class ResponceMethodsTests
{
    private ResponceMethods _responceMethods;

    [SetUp]
    public void Setup()
    {
        _responceMethods = new ResponceMethods();
    }

    [Test]
    public void Success_ReturnsResponseWithStatusCode200AndContent()
    {
        // Arrange
        var content = new { Message = "Operation successful" };

        // Act
        var response = _responceMethods.Success(content);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.EqualTo(content));
        });
    }

    [Test]
    public void Success_ReturnsResponseWithStatusCode200AndNullContent_WhenContentIsNotProvided()
    {
        // Act
        var response = _responceMethods.Success();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.Null);
        });
    }

    [TestCase(400, "Bad Request")]
    [TestCase(404, "Not Found")]
    [TestCase(401, "Unauthorized")]
    [TestCase(403, "Forbidden")]
    [TestCase(500, "Internal Server Error")]
    [TestCase(422, "Unprocessable Entity")]
    [TestCase(409, "Conflict")]
    [TestCase(405, "Method Not Allowed")]
    [TestCase(408, "Request Timeout")]
    public void ResponseMethods_WithExceptionMessages_ReturnsExpectedStatusAndMessages(
        int expectedStatusCode,
        string method)
    {
        // Arrange
        var exceptionMessage = "An error occurred";
        var innerExceptionMessage = "Inner exception details";
        Response response = method switch
        {
            "Bad Request" => _responceMethods.BadRequest(exceptionMessage, innerExceptionMessage),
            "Not Found" => _responceMethods.NotFound(exceptionMessage, innerExceptionMessage),
            "Unauthorized" => _responceMethods.Unauthorized(exceptionMessage, innerExceptionMessage),
            "Forbidden" => _responceMethods.Forbidden(exceptionMessage, innerExceptionMessage),
            "Internal Server Error" => _responceMethods.Error(exceptionMessage, innerExceptionMessage),
            "Unprocessable Entity" => _responceMethods.UnprocessableEntity(exceptionMessage, innerExceptionMessage),
            "Conflict" => _responceMethods.Conflict(exceptionMessage, innerExceptionMessage),
            "Method Not Allowed" => _responceMethods.MethodNotAllowed(exceptionMessage, innerExceptionMessage),
            "Request Timeout" => _responceMethods.RequestTimeout(exceptionMessage, innerExceptionMessage),
            _ => throw new ArgumentException("Invalid method")
        };

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(expectedStatusCode));
            Assert.That(response.ExceptionMessage, Is.EqualTo(exceptionMessage));
            Assert.That(response.InnerExceptionMessage, Is.EqualTo(innerExceptionMessage));
        });
    }

    [Test]
    public void NoContent_ReturnsResponseWithStatusCode204()
    {
        // Act
        var response = _responceMethods.NoContent();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(204));
            Assert.That(response.Content, Is.Null);
            Assert.That(response.ExceptionMessage, Is.Null);
            Assert.That(response.InnerExceptionMessage, Is.Null);
        });
    }

    [Test]
    public void ResponseMethods_WithNullInnerExceptionMessage_ReturnsResponseWithNullInnerException()
    {
        // Arrange
        var exceptionMessage = "An error occurred";

        // Act
        var response = _responceMethods.BadRequest(exceptionMessage);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(400));
            Assert.That(response.ExceptionMessage, Is.EqualTo(exceptionMessage));
            Assert.That(response.InnerExceptionMessage, Is.Null);
        });
    }
}
