using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.Commons;

namespace VacancyManagementSystem.Infrastructure.Services.InternalServices;

public class QuestionBankService : BaseService, IQuestionBankService
{
    public QuestionBankService(IUnitOfWork unitOfWork, IAutoMapperConfiguration autoMapper) : base(unitOfWork, autoMapper)
    {
    }

    public async Task<Response> AddQuestionAsync(CreateQuestionDto questionDto)
    {
        if (questionDto.AnswerOptions.Count(a => a.IsCorrect) != 1)
        {
            return BadRequest("A question must have exactly one correct answer.");
        }

        var questionRepository = _unitOfWork.GetRepository<QuestionBank, int>();
        var answerOptionRepository = _unitOfWork.GetRepository<AnswerOption, int>();

        var question = new QuestionBank
        {
            QuestionText = questionDto.QuestionText,
            CategoryId = questionDto.CategoryId
        };

        await questionRepository.AddAsync(question);
        await _unitOfWork.Commit();

        foreach (var answerDto in questionDto.AnswerOptions)
        {
            var answerOption = new AnswerOption
            {
                OptionText = answerDto.OptionText,
                IsCorrect = answerDto.IsCorrect,
                QuestionBankId = question.Id
            };

            await answerOptionRepository.AddAsync(answerOption);
        }

        await _unitOfWork.Commit();
        return Success("Question and answers added successfully.");
    }

    public async Task<Response> AddQuestionsToVacancyAsync(AddQuestionToVacancyDto dto)
    {
        var vacancyRepository = _unitOfWork.GetRepository<Vacancy, int>();
        var vacancyQuestionRepository = _unitOfWork.GetRepository<VacancyQuestion, int>();

        var vacancy = await vacancyRepository.GetByIdAsync(dto.VacancyId);
        if (vacancy == null)
            return NotFound("Vacancy not found");

        foreach (var questionId in dto.QuestionIds)
        {
            var vacancyQuestion = new VacancyQuestion
            {
                VacancyId = dto.VacancyId,
                QuestionBankId = questionId
            };
            await vacancyQuestionRepository.AddAsync(vacancyQuestion);
        }

        await _unitOfWork.Commit();
        return Success("Questions added to vacancy.");
    }

    public async Task<Response> UpdateQuestionAsync(UpdateQuestionDto dto)
    {
        var questionRepository = _unitOfWork.GetRepository<QuestionBank, int>();

        var question = await questionRepository.GetByIdAsync(dto.Id);
        if (question == null)
            return NotFound("Question not found");

        question.QuestionText = dto.QuestionText;
        question.CategoryId = dto.CategoryId;
        question.ModifiedDate = DateTime.Now;

        questionRepository.Update(question);
        await _unitOfWork.Commit();

        return Success("Question updated successfully.");
    }

    public async Task<Response> DeleteQuestionAsync(int id)
    {
        var questionRepository = _unitOfWork.GetRepository<QuestionBank, int>();

        var question = await questionRepository.GetByIdAsync(id);
        if (question == null)
            return NotFound("Question not found");

        questionRepository.Delete(question);
        await _unitOfWork.Commit();

        return Success("Question deleted successfully.");
    }

}
