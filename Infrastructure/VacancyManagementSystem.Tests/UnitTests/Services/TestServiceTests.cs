using System.Linq.Expressions;
using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Repositories.Commons;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.Tests.UnitTests.Services;

public class TestServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IAutoMapperConfiguration> _mapperMock;
    private TestService _testService;

    [SetUp]
    public void Setup()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IAutoMapperConfiguration>();
        _testService = new TestService(_unitOfWorkMock.Object, _mapperMock.Object);
    }

    [Test]
    public async Task GetTestQuestionsAsync_NoQuestionsFound_ReturnsNotFoundResponse()
    {
        // Arrange
        var vacancyId = 1;
        var repositoryMock = new Mock<IGenericRepository<VacancyQuestion, int>>();
        repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<VacancyQuestion, bool>>>(), false, null, It.IsAny<Expression<Func<VacancyQuestion, object>>[]>())).ReturnsAsync(new List<VacancyQuestion>().AsQueryable());

        _unitOfWorkMock.Setup(u => u.GetRepository<VacancyQuestion, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.GetTestQuestionsAsync(vacancyId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("No questions found for this vacancy."));
        });
    }

    [Test]
    public async Task GetTestQuestionsAsync_QuestionsFound_ReturnsQuestionDtos()
    {
        // Arrange
        var vacancyId = 1;
        var questions = new List<VacancyQuestion>
        {
            new VacancyQuestion
            {
                Id = 1,
                VacancyId = vacancyId,
                QuestionBank = new QuestionBank
                {
                    QuestionText = "Sample question?",
                    AnswerOptions = new List<AnswerOption>
                    {
                        new AnswerOption { Id = 1, OptionText = "Option 1", IsCorrect = true },
                        new AnswerOption { Id = 2, OptionText = "Option 2", IsCorrect = false }
                    }
                }
            }
        }.AsQueryable();

        var repositoryMock = new Mock<IGenericRepository<VacancyQuestion, int>>();
        repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<VacancyQuestion, bool>>>(), false, null, It.IsAny<Expression<Func<VacancyQuestion, object>>[]>())).ReturnsAsync(questions);

        _unitOfWorkMock.Setup(u => u.GetRepository<VacancyQuestion, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.GetTestQuestionsAsync(vacancyId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.InstanceOf<List<GetTestQuestionDto>>());
        });
    }

    [Test]
    public async Task GetTestResultsAsync_NoResultsFound_ReturnsNotFoundResponse()
    {
        // Arrange
        var applicantId = 1;
        var repositoryMock = new Mock<IGenericRepository<TestAnswer, int>>();
        repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<TestAnswer, bool>>>(), false, null, It.IsAny<Expression<Func<TestAnswer, object>>[]>())).ReturnsAsync(new List<TestAnswer>().AsQueryable());

        _unitOfWorkMock.Setup(u => u.GetRepository<TestAnswer, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.GetTestResultsAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("No test results found for this applicant."));
        });
    }

    [Test]
    public async Task GetTestResultsAsync_ResultsFound_ReturnsResultDto()
    {
        // Arrange
        var applicantId = 1;
        var testAnswers = new List<TestAnswer>
        {
            new TestAnswer
            {
                ApplicantId = applicantId,
                IsCorrect = true,
                VacancyQuestion = new VacancyQuestion
                {
                    QuestionBank = new QuestionBank { QuestionText = "Sample question?" }
                },
                AnswerOption = new AnswerOption { OptionText = "Option 1" }
            }
        }.AsQueryable();

        var repositoryMock = new Mock<IGenericRepository<TestAnswer, int>>();
        repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<TestAnswer, bool>>>(), false, null, It.IsAny<Expression<Func<TestAnswer, object>>[]>())).ReturnsAsync(testAnswers);

        _unitOfWorkMock.Setup(u => u.GetRepository<TestAnswer, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.GetTestResultsAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.InstanceOf<GetTestResultDto>());
        });
    }

    [Test]
    public async Task ResumeTestAsync_NoAnswersFound_ReturnsNotFoundResponse()
    {
        // Arrange
        var applicantId = 1;
        var repositoryMock = new Mock<IGenericRepository<TestAnswer, int>>();
        repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<TestAnswer, bool>>>(), false, null, It.IsAny<Expression<Func<TestAnswer, object>>[]>())).ReturnsAsync(new List<TestAnswer>().AsQueryable());

        _unitOfWorkMock.Setup(u => u.GetRepository<TestAnswer, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.ResumeTestAsync(applicantId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Test not found for this applicant."));
        });
    }

    [Test]
    public async Task SubmitTestAsync_ValidAnswers_SubmitsSuccessfully()
    {
        // Arrange
        var testAnswers = new List<TestAnswerDto>
        {
            new TestAnswerDto
            {
                ApplicantId = 1,
                VacancyQuestionId = 1,
                AnswerOptionId = 1,
                IsCorrect = true
            }
        };

        var repositoryMock = new Mock<IGenericRepository<TestAnswer, int>>();
        _unitOfWorkMock.Setup(u => u.GetRepository<TestAnswer, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _testService.SubmitTestAsync(testAnswers);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.InstanceOf<object>());
        });
        repositoryMock.Verify(r => r.AddAsync(It.IsAny<TestAnswer>()), Times.Once);
        _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
    }
}
