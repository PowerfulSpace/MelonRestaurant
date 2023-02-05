# MelonRestaurant
testProgect

1.Создание репозитория
2.Создание проекта
3.Разделение на FrontEnd и Services ( Создаём директории)
4.В директории FrontEnd создаём проект: Веб приложение ASP.NET Core (MVC) 
    PS.MelonRestaurant.Web
5.В директории Services создаём проект: Веб-API ASP.NET Core
    PS.MelonRestaurant.Services.ProductAPI
6.Установка Nuget пакетов для PS.MelonRestaurant.Services.ProductAPI
	AutoMapper
	AutoMapper.Extensions.Microsoft.DependencyInjection
	Microsoft.AspNetCore.Authentication.JwtBearer
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools
	Swashbuckle.AspNetCore
	Swashbuckle.AspNetCore.Annotations
	Swashbuckle.AspNetCore.SwaggerUI
7.Устанавливает директории для проекта PS.MelonRestaurant.Services.ProductAPI
    Controllers
    DbContext
    Models
    Repository
8.Добавили модель в PS.MelonRestaurant.Services.ProductAPI.Models
    Product
8.Добавили Dto модели в PS.MelonRestaurant.Services.ProductAPI.Models
    ProductDto - описывает нашу модель Product
    ResponseDto - для получение ответа
9.Настройка контекста бд для ProductAPI
    -Создание класса ApplicationDbContext для работы с бд
    -Добавил в конфигурацию appsettings строку подключения DefaultConnection
    -Подкоючил в Program работу в бд
10.Добавление миграции в проект PS.MelonRestaurant.Services.ProductAPI
11.Создание репозитория для выполнения всех CRUD операций в PS.MelonRestaurant.Services.ProductAPI в дериктории Repository
    ProductRepository
    IProductRepository
12.Создаём в PS.MelonRestaurant.Services.ProductAPI конфигурацию для маппинга
    MappingConfig






