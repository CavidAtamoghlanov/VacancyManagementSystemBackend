using Microsoft.AspNetCore.Http;
using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.Commons;

namespace VacancyManagementSystem.Infrastructure.Services.InternalServices;

public class ApplicantService : BaseService, IApplicantService
{
    public ApplicantService(IUnitOfWork unitOfWork, IAutoMapperConfiguration autoMapper)
        : base(unitOfWork, autoMapper)
    {
    }

    public async Task<Response> GetAllApplicantsForVacancyAsync(int vacancyId)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicants = await applicantRepository.GetAllAsync(a => a.VacancyId == vacancyId);

        if (applicants == null || !applicants.Any())
            return NotFound("No applicants found for this vacancy.");

        var applicantDtos = _autoMapper.Map<List<GetApplicantDto>, IEnumerable<Applicant>>(applicants);
        return Success(applicantDtos);
    }

    public async Task<Response> GetAllApplicantsAsync()
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicants = await applicantRepository.GetAllAsync();

        if (applicants == null || !applicants.Any())
            return NotFound("No applicants found for this vacancy.");

        var applicantDtos = _autoMapper.Map<List<GetApplicantDto>, IEnumerable<Applicant>>(applicants);
        return Success(applicantDtos);
    }

    public async Task<Response> GetApplicantByIdAsync(int id)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(id);

        if (applicant == null)
            return NotFound("Applicant not found.");

        var applicantDto = _autoMapper.Map<GetApplicantDto, Applicant>(applicant);
        return Success(applicantDto);
    }

    public async Task<Response> CreateApplicantAsync(AddApplicantDto applicantDto)
    {
        var applicant = _autoMapper.Map<Applicant, AddApplicantDto>(applicantDto);
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        await applicantRepository.AddAsync(applicant);
        await _unitOfWork.Commit();
        return Success("Applicant successfully created.");
    }

    public async Task<Response> UpdateApplicantAsync(UpdateApplicantDto applicantDto)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(applicantDto.Id);

        if (applicant == null)
            return NotFound("Applicant not found.");

        applicant = _autoMapper.Map<Applicant, UpdateApplicantDto>(applicantDto);
        applicantRepository.Update(applicant);
        await _unitOfWork.Commit();
        return Success("Applicant successfully updated.");
    }

    public async Task<Response> DeleteApplicantAsync(int id)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(id);

        if (applicant == null)
            return NotFound("Applicant not found.");

        applicant.IsDeleted = true;
        applicantRepository.Update(applicant);
        await _unitOfWork.Commit();
        return Success("Applicant successfully deleted.");
    }

    public async Task<Response> GetApplicantTestResultsAsync(int applicantId)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(applicantId);

        if (applicant == null)
            return NotFound("Applicant not found.");

        return Success(new GetApplicantTestResultsDto
        {
            ApplicantId = applicantId,
            TestScore = applicant.TestScore
        });
    }

    public async Task<Response> UploadApplicantCVAsync(int applicantId, IFormFile file)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(applicantId);

        if (applicant == null)
            return NotFound("Applicant not found.");

        var fileExtension = Path.GetExtension(file.FileName);
        var uniqueFileName = Guid.NewGuid().ToString() + fileExtension;


        var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);


        var filePath = Path.Combine(directoryPath, uniqueFileName);


        using var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);



        applicant.CVPath = $"{uniqueFileName}";
        applicantRepository.Update(applicant);
        await _unitOfWork.Commit();

        return Success("Applicant CV uploaded successfully.");
    }

    public async Task<Response> SearchApplicantsAsync(SearchApplicantDto searchDto)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var query = (await applicantRepository.GetAllAsync()).AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchDto.FullName))
            query = query.Where(a => a.FullName.Contains(searchDto.FullName));

        if (!string.IsNullOrWhiteSpace(searchDto.Email))
            query = query.Where(a => a.Email == searchDto.Email);

        if (searchDto.MinTestScore.HasValue)
            query = query.Where(a => a.TestScore >= searchDto.MinTestScore);

        if (searchDto.MaxTestScore.HasValue)
            query = query.Where(a => a.TestScore <= searchDto.MaxTestScore);

        if (searchDto.IsDeleted.HasValue)
            query = query.Where(a => a.IsDeleted == searchDto.IsDeleted);

        var applicants = query.ToList();

        if (!applicants.Any())
            return NotFound("No applicants match the search criteria.");

        var applicantDtos = _autoMapper.Map<List<GetApplicantDto>, List<Applicant>>(applicants);

        return Success(applicantDtos);
    }

    public async Task<Response> DownloadApplicantCvAsync(int applicantId)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(applicantId);

        if (applicant == null)
            return NotFound("Applicant Not found.");

        var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
        var filePath = Path.Combine(directoryPath, applicant.CVPath);

        if (string.IsNullOrWhiteSpace(applicant.CVPath) || !File.Exists(filePath))
            return NotFound("CV not found.");

        var fileBytes = await File.ReadAllBytesAsync(filePath);
        var fileName = Path.GetFileName(filePath);

        return Success(new { FileName = fileName, FileContent = Convert.ToBase64String(fileBytes) });
    }

    public async Task<Response> EvaluateApplicantAnswersAsync(ApplicantAnswersDto dto)
    {
        var testAnswerRepository = _unitOfWork.GetRepository<TestAnswer, int>();
        var vacancyQuestionRepository = _unitOfWork.GetRepository<VacancyQuestion, int>();
        var answerOptionRepository = _unitOfWork.GetRepository<AnswerOption, int>();

        int totalQuestions = dto.Answers.Count;
        int correctAnswers = 0;

        foreach (var answer in dto.Answers)
        {
            var vacancyQuestion = await vacancyQuestionRepository.GetByIdAsync(answer.VacancyQuestionId);
            if (vacancyQuestion == null)
                continue;

            var correctOption = vacancyQuestion.QuestionBank.AnswerOptions.FirstOrDefault(o => o.IsCorrect);
            if (correctOption != null && correctOption.Id == answer.AnswerOptionId)
            {
                correctAnswers++;
            }

            var testAnswer = new TestAnswer
            {
                ApplicantId = dto.ApplicantId,
                VacancyQuestionId = answer.VacancyQuestionId,
                AnswerOptionId = answer.AnswerOptionId,
                IsCorrect = correctOption != null && correctOption.Id == answer.AnswerOptionId
            };
            await testAnswerRepository.AddAsync(testAnswer);
        }

        await _unitOfWork.Commit();
        return Success("Answer  Saved");
    }

    public async Task<Response> GetApplicantVacanciesAsync(int applicantId)
    {
        var applicantRepository = _unitOfWork.GetRepository<Applicant, int>();
        var applicant = await applicantRepository.GetByIdAsync(applicantId);

        if (applicant == null)
            return NotFound("Applicant not found.");

        if (applicant.Vacancy == null)
            return NotFound("No vacancies found for this applicant.");

        var vacancies = applicant.Vacancy.VacancyQuestions
            .Select(vq => new ApplicantVacancyDto
            {
                VacancyId = vq.Vacancy.Id,
                Title = vq.Vacancy.Title,
                Description = vq.Vacancy.Description,
                StartDate = vq.Vacancy.StartDate,
                EndDate = vq.Vacancy.EndDate,
                IsActive = vq.Vacancy.IsActive
            }).ToList();

        return Success(vacancies);
    }

    public async Task<Response> GetApplicantAnswersForVacancyAsync(int applicantId, int vacancyId)
    {
        var vacancyRepository = _unitOfWork.GetRepository<Vacancy, int>();
        var testAnswerRepository = _unitOfWork.GetRepository<TestAnswer, int>();
        var vacancyQuestionRepository = _unitOfWork.GetRepository<VacancyQuestion, int>();

        var vacancy = await vacancyRepository.GetByIdAsync(vacancyId);
        if (vacancy == null)
            return NotFound("Vacancy not found.");

        var vacancyQuestions = await vacancyQuestionRepository.GetAllAsync(vq => vq.VacancyId == vacancyId);

        var testAnswers = await testAnswerRepository.GetAllAsync(ta => ta.ApplicantId == applicantId && ta.VacancyQuestion.VacancyId == vacancyId);

        var questions = vacancyQuestions.ToList().Select(vq =>
        {
            var questionBank = vq.QuestionBank;

            return new QuestionDetailsDto
            {
                QuestionId = questionBank.Id,
                QuestionText = questionBank.QuestionText,
                AnswerOptions = questionBank.AnswerOptions.Select(ao => new AnswerOptionDetailsDto
                {
                    AnswerOptionId = ao.Id,
                    OptionText = ao.OptionText,
                    IsCorrect = ao.IsCorrect,
                    ApplicantAnswer = testAnswers.Any(ta => ta.AnswerOptionId == ao.Id)
                }).ToList()
            };
        }).ToList();

        var result = new VacancyWithQuestionsAndAnswersDto
        {
            VacancyDetails = new VacancyDetailsDto
            {
                VacancyId = vacancy.Id,
                Title = vacancy.Title,
                Description = vacancy.Description,
                StartDate = vacancy.StartDate,
                EndDate = vacancy.EndDate,
                IsActive = vacancy.IsActive
            },
            Questions = questions
        };

        return Success(result);
    }
}
