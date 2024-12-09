using System.Linq.Expressions;
using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Repositories.Commons;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.Tests.UnitTests.Services;

public class ApplicantServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IAutoMapperConfiguration> _mapperMock;
    private ApplicantService _applicantService;

    [SetUp]
    public void Setup()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IAutoMapperConfiguration>();
        _applicantService = new ApplicantService(_unitOfWorkMock.Object, _mapperMock.Object);
    }

    [Test]
    public async Task GetAllApplicantsForVacancyAsync_ApplicantsExist_ReturnsApplicantsSuccessfully()
    {
        // Arrange
        var vacancyId = 1;
        var applicants = new List<Applicant>
    {
        new Applicant { Id = 1, FirstName = "John", LastName = "Doe", VacancyId = vacancyId, TestScore = 85, Email = "john.doe@example.com" },
        new Applicant { Id = 2, FirstName = "Jane", LastName = "Doe", VacancyId = vacancyId, TestScore = 90, Email = "jane.doe@example.com" }
    }.AsQueryable();

        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();
        repositoryMock
            .Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<Applicant, bool>>>(), false, null, It.IsAny<Expression<Func<Applicant, object>>[]>()))
            .ReturnsAsync(applicants);

        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        _mapperMock
            .Setup(m => m.Map<List<GetApplicantDto>, IQueryable<Applicant>>(It.IsAny<IQueryable<Applicant>>()))
            .Returns(new List<GetApplicantDto>
            {
            new GetApplicantDto { Id = 1, UserId = "1", VacancyId = vacancyId, TestScore = 85, CVPath = "/path/to/cv1" },
            new GetApplicantDto { Id = 2, UserId = "2", VacancyId = vacancyId, TestScore = 90, CVPath = "/path/to/cv2" }
            });

        // Act
        var response = await _applicantService.GetAllApplicantsForVacancyAsync(vacancyId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
        });
    }

    [Test]
    public async Task GetAllApplicantsForVacancyAsync_NoApplicantsFound_ReturnsNotFound()
    {
        // Arrange
        var vacancyId = 1;
        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();
        repositoryMock
            .Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<Applicant, bool>>>(), false, null, It.IsAny<Expression<Func<Applicant, object>>[]>()))
            .ReturnsAsync((new List<Applicant>()).AsQueryable());

        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _applicantService.GetAllApplicantsForVacancyAsync(vacancyId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("No applicants found for this vacancy."));
        });
    }

    [Test]
    public async Task GetApplicantByIdAsync_ApplicantExists_ReturnsApplicantSuccessfully()
    {
        // Arrange
        var applicantId = 1;
        var applicant = new Applicant { Id = applicantId, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };

        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();
        repositoryMock.Setup(r => r.GetByIdAsync(applicantId, false)).ReturnsAsync(applicant);

        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        _mapperMock
            .Setup(m => m.Map<GetApplicantDto, Applicant>(It.IsAny<Applicant>()))
            .Returns(new GetApplicantDto { Id = applicantId, UserId = "1", VacancyId = 1, TestScore = 85, CVPath = "/path/to/cv" });

        // Act
        var response = await _applicantService.GetApplicantByIdAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.InstanceOf<GetApplicantDto>());
            Assert.That((response.Content as GetApplicantDto).UserId, Is.EqualTo("1"));
        });
    }

    [Test]
    public async Task GetApplicantByIdAsync_ApplicantNotFound_ReturnsNotFound()
    {
        // Arrange
        var applicantId = 1;

        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();
        repositoryMock.Setup(r => r.GetByIdAsync(applicantId, false)).ReturnsAsync((Applicant)null);

        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _applicantService.GetApplicantByIdAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Applicant not found."));
        });
    }

    [Test]
    public async Task CreateApplicantAsync_ValidDto_CreatesApplicantSuccessfully()
    {
        // Arrange
        var applicantDto = new AddApplicantDto { UserId = 1, VacancyId = 1, TestScore = 85, CVPath = "/path/to/cv", FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123456789" };
        var applicant = new Applicant
        {
            UserId = 1,
            VacancyId = 1,
            TestScore = 85,
            CVPath = "/path/to/cv",
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123456789"
        };

        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();
        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        _mapperMock.Setup(m => m.Map<Applicant, AddApplicantDto>(It.IsAny<AddApplicantDto>())).Returns(applicant);

        // Act
        var response = await _applicantService.CreateApplicantAsync(applicantDto);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content?.ToString(), Is.EqualTo("Applicant successfully created."));
        });

        repositoryMock.Verify(r => r.AddAsync(applicant), Times.Once);
        _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
    }

    [Test]
    public async Task UpdateApplicantAsync_ApplicantNotFound_ReturnsNotFound()
    {
        // Arrange
        var applicantDto = new UpdateApplicantDto { Id = 1, TestScore = 95, CVPath = "/path/to/cv", FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123456789" };
        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(It.IsAny<int>(), false)).ReturnsAsync((Applicant)null);
        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _applicantService.UpdateApplicantAsync(applicantDto);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Applicant not found."));
        });
    }

    [Test]
    public async Task DeleteApplicantAsync_ApplicantNotFound_ReturnsNotFound()
    {
        // Arrange
        var applicantId = 1;
        var repositoryMock = new Mock<IGenericRepository<Applicant, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(applicantId, false)).ReturnsAsync((Applicant)null);
        _unitOfWorkMock.Setup(u => u.GetRepository<Applicant, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _applicantService.DeleteApplicantAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Applicant not found."));
        });
    }
}
