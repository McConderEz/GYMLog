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