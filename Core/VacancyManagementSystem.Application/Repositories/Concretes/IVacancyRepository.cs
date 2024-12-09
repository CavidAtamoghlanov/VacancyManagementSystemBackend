﻿using VacancyManagementSystem.Application.Repositories.Commons;
using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Application.Repositories.Concretes;

public interface IVacancyRepository : IGenericRepository<Vacancy, int>
{
}
