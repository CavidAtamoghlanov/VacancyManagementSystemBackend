# Vacancy Management System Backend

**Vacancy Management System** layihəsinin backend hissəsini tam olaraq yekunlaşdırmışam. Layihə zamanı istifadə olunan texnologiyalar, struktur və görülən işlər haqqında qısa məlumat qeyd edmişəm.

## Texnologiyalar 
- **.NET 8.0**: Layihənin əsas texnologiyasıdır.
- **Entity Framework və Dapper**: ORM olaraq hər ikisindən istifadə edilib.
  - **Entity Framework** ilə generic repository qurulub və cədvəllərin konfiqurasiyaları ayrıca yazılıb.
  - **Dapper** isə daha çox kompleks sorğular və performans tələb edən yerlərdə istifadə olunub.
- **FluentValidation**: Bütün validsiyalar FluentValidation ilə yazılıb Dto-lar yoxlanılır.
- **NUnit**: Service-lerin unit testləri yazılıb. Bir çox unit test hazırdır.
- **Onion Architecture**: Kod strukturunun təmiz və oxunaqlı olması üçün.

## Backend Strukturu
Backend hissəsi tam strukturlu şəkildə yazmışam.
1. **Generic Repository və UnitOfWork**:
   - Generic repository vasitəsilə EF-də rahat işləyə bilirik. Həmcinin Dapper üçündə ayrıca bir DapperRepository qurmuşam ki standar işlər üçün hazırdır.
   - Repository-lərə çıxış üçün vahid bir **UnitOfWork** qurulub. Hər bir repository-yə bir bir müraciət etməmək üçün **UnitOfWork** Qurulub və genericdir.
2. **Service Layer**:
   - Bütün biznes məntiq servislərdə saxlanılıb və hər bir funksionallıq ayrı-ayrı servislərdə idarə olunur.
3. **Custom Middleware**:
   - **Global Exception Handling** məqsədilə xüsusi bir middleware yazılmışdır.
   - Bu middleware bütün xətaları  idarə edir. Global olaraq Bütünn Exceptionlar utulur və lazımı responce qaytarılır.
4. **Seed Data**:
   - Layihənin əsas cədvəlləri seed datalar vermişəm **Migration** etdiyiniz zaman gələcək.

## Layihədə Əlavə Olunan Funksionallıqlar
- **Email Servisi**:
  - Layihədə sadə bir email servisi qurulub, əsasən autentifikasiya məqsədi ilə istifadə olunur.
- **Unit Testing**:
  - Backend funksionallıqlarını test etmək üçün **NUnit** istifadə olunub. Service-lər üçün UnitTest yazılıb.

## Layihənin Mövcud Vəziyyəti
Backend tam hazırdır və bütün API-lar işlək vəziyyətdədir. Layihənin funksionallıqları ilə bağlı heç bir problem yoxdur.

Frontend hissəsində isə əsas struktur qurulmuş, lakin  **Hazırda öz işimdə Project Prodoction-a çıxma erefesində olduqu üçün iş çoxdu və Mən Taskın Baclen tərəfinin Structuru  yaxşı olsun deyə bir xeyli işlədim buna görədə Fronda Vaxt olmadı**   vaxt məhdudiyyəti səbəbindən bəzi UI komponentlərini tamamlamaq mümkün olmadı:
- **Http Client Service** hazırlanıb və backend API-larına sorğu göndərmək üçün istifadə edilir.
- **Admin Layout** bölməsində Vacancy CRUD funksionallığı üçün UI mövcuddur.
- Lakin digər bölmələrin UI komponentlərini tamamlamaq üçün kifayət qədər zaman olmamışdır.

## Nəticə
Layihənin backend hissəsi tam işlək vəziyyətdədir və bütün tələb olunan funksionallıqları təmin edir. Əgər daha çox vaxt və az iş yükü olsaydı, frontend də backend qədər funksional və istifadəyə hazır vəziyyətə gətirilə bilərdi.
