# VacancyManagementSystem
Vacancy Management System Backend
Vacancy Management System layihəsinin backend hissəsini tam olaraq yekunlaşdırmışam. Layihə zamanı istifadə olunan texnologiyalar, struktur və görülən işlər haqqında qısa məlumat qeyd etmişəm.

Layihəni .NET 8.0 ilə yazmışam. ORM olaraq həm Entity Framework, həm də Dapper-dən istifadə etmişəm. Entity Framework ilə generic repository qurmuşam və bütün cədvəllərin konfiqurasiyalarını ayrıca yazmışam. Dapper-i isə daha çox kompleks sorğular üçün istifadə etmişəm, çünki belə hallarda sürət baxımından daha effektivdir. Hər iki ORM-in birlikdə işlədilməsi lazım olan yerlərdə rahatlıq və performans balansını təmin etmək üçün olduqca faydalı olub.

Backend strukturu Onion Architecture ilə yazılıb. Bütün biznes məntiq service-lərdə toplanıb və hər bir funksionallıq ayrıca servislər vasitəsilə idarə olunur. Layihədə FluentValidation ilə doğrulama qaydalarını tam şəkildə qurmuşam. İstənilən giriş üçün lazımi validasiyalar mövcuddur və bu, sistemin etibarlılığını artırır.

Backend-də xüsusi bir custom middleware yazmışam. Bu middleware, global exception handling məqsədilə istifadə olunur və pipeline vasitəsilə bütün xətaların mərkəzi şəkildə idarə edilməsini təmin edir. Bu yanaşma sayəsində xətaları idarə etmək daha asan və sistemli olur.

Həmçinin, kiçik bir email servisi də əlavə etmişəm. Bu servis əsasən autentifikasiya üçün nəzərdə tutulub, lakin gələcəkdə digər məqsədlər üçün genişləndirilə bilər. Layihədə bütün API-lar tam işləkdir və istənilən funksionallıq üçün backend hazır vəziyyətdədir. Əlavə olaraq, layihədə istifadə olunan əsas cədvəllər üçün seed data da əlavə etmişəm, bu da başlanğıc məlumatların mövcud olmasını təmin edir.

Unit testlərə də xüsusi diqqət ayırmışam. Backend funksionallıqlarını NUnit ilə test etmişəm və hər bir kritik komponentin düzgün işlədiyindən əmin olmuşam. Bu testlər gələcəkdə layihəyə əlavə ediləcək yeniliklərin mövcud sistemə mənfi təsir etməməsini təmin edir.

Hal-hazırda işlədiyim işimdən gələn tapşırıqlar və vaxt məhdudiyyəti səbəbindən layihənin frontend hissəsinə lazımi qədər vaxt ayıra bilməmişəm. Frontend tərəfində backend API-larına sorğu göndərilməsi üçün Http Client Service strukturunu qurmuşam. Bundan əlavə, bəzi komponentlər üçün custom servislər yazmışam və Admin Layout bölməsində Vacancy CRUD funksionallıqları üçün UI komponentləri hazırdır. Lakin digər bölmələrin UI hissələrini tamamlamaq üçün kifayət qədər zamanım olmadı.

Əgər iş yüküm bir qədər az olsaydı və layihəyə daha çox vaxt ayıra bilsəydim, frontend hissəsini də tam şəkildə yekunlaşdırmaq mümkün olardı. Ümumilikdə, backend tam hazırdır və layihənin funksionallıqları ilə bağlı heç bir problem yoxdur.
