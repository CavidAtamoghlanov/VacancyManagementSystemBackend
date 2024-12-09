using System.Linq.Expressions;
using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Repositories.Commons;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.Tests.UnitTests.Services;

public class AnswerOptionServiceTests
{
    private Mock<IUnitOfWork> _unitOfWorkMock;
    private Mock<IAutoMapperConfiguration> _mapperMock;
    private AnswerOptionService _answerOptionService;

    [SetUp]
    public void Setup()
    {
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _mapperMock = new Mock<IAutoMapperConfiguration>();
        _answerOptionService = new AnswerOptionService(_unitOfWorkMock.Object, _mapperMock.Object);
    }

    [Test]
    public async Task GetAnswerOptionsForQuestion_AnswerOptionsExist_ReturnsAnswerOptionsSuccessfully()
    {
        // Arrange
        var questionId = 1;
        var answerOptions = new List<AnswerOption>
    {
        new AnswerOption { Id = 1, OptionText = "Option 1", IsCorrect = true, QuestionBankId = questionId },
        new AnswerOption { Id = 2, OptionText = "Option 2", IsCorrect = false, QuestionBankId = questionId }
    }.AsQueryable();

        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();
        repositoryMock
            .Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<AnswerOption, bool>>>(), false, null, It.IsAny<Expression<Func<AnswerOption, object>>[]>()))
            .ReturnsAsync(answerOptions);

        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);

        _mapperMock
            .Setup(m => m.Map<List<AnswerOptionDto>, List<AnswerOption>>(It.IsAny<List<AnswerOption>>()))
            .Returns(new List<AnswerOptionDto>
            {
            new AnswerOptionDto { OptionText = "Option 1", IsCorrect = true, QuestionBankId = questionId },
            new AnswerOptionDto { OptionText = "Option 2", IsCorrect = false, QuestionBankId = questionId }
            });

        // Act
        var response = await _answerOptionService.GetAnswerOptionsForQuestion(questionId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response.Content, Is.InstanceOf<List<AnswerOptionDto>>());
            Assert.That(actual: response.Content as List<AnswerOptionDto>, Has.Count.EqualTo(2));
        });
    }

    [Test]
    public async Task GetAnswerOptionById_AnswerOptionNotFound_ReturnsNotFound()
    {
        // Arrange
        var id = 1;
        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(id, false)).ReturnsAsync((AnswerOption)null);
        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _answerOptionService.GetAnswerOptionById(id);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Answer option not found."));
        });
    }

    [Test]
    public async Task CreateAnswerOption_ValidDto_CreatesAnswerOptionSuccessfully()
    {
        // Arrange
        var answerOptionDto = new AnswerOptionDto { OptionText = "New Option", IsCorrect = true, QuestionBankId = 1 };
        var answerOption = new AnswerOption { OptionText = "New Option", IsCorrect = true, QuestionBankId = 1 };

        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();
        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);
        _mapperMock.Setup(m => m.Map<AnswerOption, AnswerOptionDto>(answerOptionDto)).Returns(answerOption);

        // Act
        var response = await _answerOptionService.CreateAnswerOption(answerOptionDto);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(response?.Content?.ToString(), Is.EqualTo("Answer option successfully created."));
        });
        repositoryMock.Verify(r => r.AddAsync(answerOption), Times.Once);
        _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
    }

    [Test]
    public async Task UpdateAnswerOption_AnswerOptionNotFound_ReturnsNotFound()
    {
        // Arrange
        var answerOptionDto = new UpdateAnswerOptionDto { OptionText = "Updated Option", IsCorrect = true, QuestionBankId = 1 };
        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(It.IsAny<int>(), false)).ReturnsAsync((AnswerOption)null);

        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _answerOptionService.UpdateAnswerOption(answerOptionDto);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Answer option not found."));
        });
    }

    [Test]
    public async Task DeleteAnswerOption_AnswerOptionNotFound_ReturnsNotFound()
    {
        // Arrange
        var id = 1;
        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(id, false)).ReturnsAsync((AnswerOption)null);
        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _answerOptionService.DeleteAnswerOption(id);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Answer option not found."));
        });
    }

    [Test]
    public async Task RestoreAnswerOption_AnswerOptionNotFound_ReturnsNotFound()
    {
        // Arrange
        var id = 1;
        var repositoryMock = new Mock<IGenericRepository<AnswerOption, int>>();

        repositoryMock.Setup(r => r.GetByIdAsync(id, false)).ReturnsAsync((AnswerOption)null);
        _unitOfWorkMock.Setup(u => u.GetRepository<AnswerOption, int>()).Returns(repositoryMock.Object);

        // Act
        var response = await _answerOptionService.RestoreAnswerOption(id);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(404));
            Assert.That(response.ExceptionMessage, Is.EqualTo("Answer option not found."));
        });
    }

}
