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
11.Создаём в PS.MelonRestaurant.Services.ProductAPI конфигурацию для маппинга
    MappingConfig
12.Подключаем мапинг продукта в Program   
13.Создание репозитория для выполнения всех CRUD операций в PS.MelonRestaurant.Services.ProductAPI в дериктории Repository, и реализуем
    ProductRepository
    IProductRepository
14.Создать API Controller для работы с API в PS.MelonRestaurant.Services.ProductAPI.Models и реализовать там все методы CRUD операций
    ProductAPIController
15.Добавление Seed для наших продуктов в бд, По желанию. Выполнить миграцию
16.Подключаем API сервис в WEB приложении PS.MelonRestaurant.Web
    в appsettings.json создаём urls сервисы



