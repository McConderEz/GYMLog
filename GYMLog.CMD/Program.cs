using GYMLog.BL.Controller;
using GYMLog.BL.Model;
using System.ComponentModel.DataAnnotations;

//TODO: Переписать интерфейс в WPF(Окно регистрации, авторизации и основное)
Console.WriteLine("Вас приветствует приложение GYMLog");

Console.WriteLine("Введите имя пользователя:");
var login = Console.ReadLine();

Console.WriteLine("Введите пароль:");
var password = Console.ReadLine();

var userController = new UserController(login, password);
var eatingController = new EatingController(userController.CurrentUser);

if (userController.IsNewUser)
{
    Console.WriteLine("Введите пол:");
    var genderName = Console.ReadLine();

    DateTime birthdate = ParseDateTime();

    double weight = ParseDouble("Введите вес:");


    var height = ParseDouble("Введите рост:");

    userController.SetNewUserData(genderName, birthdate, weight);
}

Console.WriteLine(userController.CurrentUser);

Console.WriteLine("Что вы хотите сделать?");
Console.WriteLine("E)Ввести прием пищи");
var key = Console.ReadKey();


switch (key.Key)
{
    case ConsoleKey.E:
        var foods = EnterEating();
        eatingController.Add(foods.Food, foods.Weight);
        
        foreach(var item in eatingController.Eating.Foods)
        {
            Console.WriteLine($"\t{item.Food} - {item.Weight}");
        }

        break;
    
}

static (Food Food, double Weight) EnterEating()
{
    Console.Write("\nВведите имя продукта:");
    var food = Console.ReadLine();

    var calories = ParseDouble("Введите калорийность: ");

    var proteins = ParseDouble("Введите кол-во белков: ");

    var carbohydrates = ParseDouble("Введите кол-во углеводов: ");

    var fats = ParseDouble("Введите кол-во жиров: ");

    double weight = ParseDouble("Введите вес порции: ");

    var product = new Food(food,proteins,fats,carbohydrates,calories);     

    return (Food: product,Weight: weight);
}

static DateTime ParseDateTime()
{
    Console.WriteLine("Введите дату рождения(dd.MM.yyyy):");
    DateTime birthdate;
    while (!DateTime.TryParse(Console.ReadLine(), out birthdate))
    {
        Console.WriteLine("Введите дату рождения(dd.MM.yyyy):");
    }

    return birthdate;
}

static double ParseDouble(string notifictaion)
{
    Console.WriteLine(notifictaion);
    double value;
    while (!double.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine(notifictaion);
    }

    return value;
}