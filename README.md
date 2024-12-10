# Vacancy Management System Backend

**Vacancy Management System** layihəsinin backend hissəsini tam olaraq yekunlaşdırmışam. Layihə zamanı istifadə olunan texnologiyalar, struktur və görülən işlər haqqında qısaca məlumat vermək istəyirəm.

## Texnologiyalar və İstifadə Olunan Alətlər
- **.NET 8.0**: Layihənin əsas texnologiyasıdır.
- **Entity Framework və Dapper**: ORM olaraq hər ikisindən istifadə edilib.
  - **Entity Framework** ilə generic repository qurulub və cədvəllərin konfiqurasiyaları ayrıca yazılıb.
  - **Dapper** isə daha çox kompleks sorğular və performans tələb edən yerlərdə istifadə olunub.
- **FluentValidation**: Giriş və sorğuların doğruluğunu təmin etmək üçün.
- **NUnit**: Backend funksionallıqlarını test etmək üçün.
- **Onion Architecture**: Kod strukturunun təmiz və oxunaqlı olması üçün.

## Backend Strukturu
Backend hissəsi tam strukturlu şəkildə yazılmışdır:
1. **Generic Repository və UnitOfWork**:
   - Generic repository vasitəsilə ORM-lər ilə asan və səmərəli işləmə imkanı təmin olunub.
   - Repository-lərə çıxış üçün vahid bir **UnitOfWork** qurulub.
2. **Service Layer**:
   - Bütün biznes məntiq servislərdə saxlanılıb və hər bir funksionallıq ayrı-ayrı servislərdə idarə olunur.
3. **Custom Middleware**:
   - **Global Exception Handling** məqsədilə xüsusi bir middleware yazılmışdır.
   - Bu middleware bütün xətaları mərkəzi şəkildə idarə edir və loglama funksionallığını təmin edir.
4. **Seed Data**:
   - Layihənin əsas cədvəlləri üçün ilkin məlumatlar təmin olunub.

## Layihədə Əlavə Olunan Funksionallıqlar
- **Email Servisi**:
  - Layihədə sadə bir email servisi qurulub, əsasən autentifikasiya məqsədi ilə istifadə olunur.
- **Unit Testing**:
  - Backend funksionallıqlarını test etmək üçün **NUnit** istifadə olunub. Testlər mövcud sistemin düzgün işlədiyini və gələcəkdə əlavə olunacaq xüsusiyyətlərin sistemi pozmayacağını təmin edir.

## Layihənin Mövcud Vəziyyəti
Backend tam hazırdır və bütün API-lar işlək vəziyyətdədir. Layihənin funksionallıqları ilə bağlı heç bir problem yoxdur.

Frontend hissəsində isə əsas struktur qurulmuş, lakin vaxt məhdudiyyəti səbəbindən bəzi UI komponentlərini tamamlamaq mümkün olmamışdır:
- **Http Client Service** hazırlanıb və backend API-larına sorğu göndərmək üçün istifadə edilir.
- **Admin Layout** bölməsində Vacancy CRUD funksionallığı üçün UI mövcuddur.
- Lakin digər bölmələrin UI komponentlərini tamamlamaq üçün kifayət qədər zaman olmamışdır.

## Nəticə
Layihənin backend hissəsi tam işlək vəziyyətdədir və bütün tələb olunan funksionallıqları təmin edir. Əgər daha çox vaxt və az iş yükü olsaydı, frontend də backend qədər funksional və istifadəyə hazır vəziyyətə gətirilə bilərdi.
