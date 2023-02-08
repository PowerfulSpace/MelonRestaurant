# MelonRestaurant
testProgect

1. Создание репозитория
2. Создание проекта
3. Разделение на FrontEnd и Services ( Создаём директории)
4. В директории FrontEnd создаём проект: Веб приложение ASP.NET Core (MVC) 
    PS.MelonRestaurant.Web
5. В директории Services создаём проект: Веб-API ASP.NET Core
    PS.MelonRestaurant.Services.ProductAPI



6. Установка Nuget пакетов для PS.MelonRestaurant.Services.ProductAPI
	AutoMapper
	AutoMapper.Extensions.Microsoft.DependencyInjection
	Microsoft.AspNetCore.Authentication.JwtBearer
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools
	Swashbuckle.AspNetCore
	Swashbuckle.AspNetCore.Annotations
	Swashbuckle.AspNetCore.SwaggerUI
7. Устанавливает директории для проекта PS.MelonRestaurant.Services.ProductAPI
    Controllers
    DbContext
    Models
    Repository
8. Добавили модель в PS.MelonRestaurant.Services.ProductAPI.Models
    Product
8. Добавили Dto модели в PS.MelonRestaurant.Services.ProductAPI.Models
    ProductDto - описывает нашу модель Product
    ResponseDto - для получение ответа
9. Настройка контекста бд для ProductAPI
    -Создание класса ApplicationDbContext для работы с бд
    -Добавил в конфигурацию appsettings строку подключения DefaultConnection
    -Подкоючил в Program работу в бд
10. Добавление миграции в проект PS.MelonRestaurant.Services.ProductAPI
11. Создаём в PS.MelonRestaurant.Services.ProductAPI конфигурацию для маппинга
    MappingConfig
12. Подключаем мапинг продукта в Program   
13. Создание репозитория для выполнения всех CRUD операций в PS.MelonRestaurant.Services.ProductAPI в дериктории Repository, и реализуем
    ProductRepository
    IProductRepository
14. Создать API Controller для работы с API в PS.MelonRestaurant.Services.ProductAPI.Models и реализовать там все методы CRUD операций
    ProductAPIController
15. Добавление Seed для наших продуктов в бд, По желанию. Выполнить миграцию



16. Подключаем API сервис в WEB приложении PS.MelonRestaurant.Web
    в appsettings.json создаём urls сервисы
17. Создаём класс для удобства в работе с API который будет статическим и хранить константы
    SD
18. Добавили Nuget пакет в  PS.MelonRestaurant.Web
    Newtonsoft.Json
    Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
19. Создание своих собственной модели DTO для работы с product в PS.MelonRestaurant.Web
    ProductDto
    ResponseDto
20. Создание дериктории Services в PS.MelonRestaurant.Web для работы с репозиториями подключенных сервисов
21. Создание интерфейса сервиса со всеми CRUD операциями в PS.MelonRestaurant.Web в директории Services.IServices
    IProductService
22. Создание модели запроссов который будет использоваться для отправки на разные сервисы API
    APIRequest
23. Создание интерфейса базового сервиса и его реализация
    IBaseService
    BaseService
24. Реализация IProductService
    ProductService
25. Настроить доступ к сервисам, через внедрение зависимости в Program PS.MelonRestaurant.Web
    builder.Services.AddHttpClient<IProductService, ProductService>();
    builder.Services.AddScoped<IProductService, ProductService>();
26. Настроить базовый путь для ProductAPIBase
    SD.ProductAPIBase = builder.Configuration["ServiceUrls:ProductAPI"];
27. Подключение в _Layout Program PS.MelonRestaurant.Web работу с иконками
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css" integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous" />
29. Изменение стиля страницы, по желанию
    Добавление логотипа
    Изменение колонтиутлов на тёмный
30. Добавление контроллера в PS.MelonRestaurant.Web
    ProductController
30. Добавление представления в PS.MelonRestaurant.Web
    ProductIndex