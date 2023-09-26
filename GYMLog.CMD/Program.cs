using GYMLog.BL.Controller;
using GYMLog.BL.Model;
using System.ComponentModel.DataAnnotations;

//TODO: Переписать интерфейс в WPF(Окно регистрации, авторизации и основное)
Console.WriteLine("Вас приветствует приложение GYMLog");




Console.WriteLine("Введите имя пользователя");
var login = Console.ReadLine();

Console.WriteLine("Введите пароль");
var password = Console.ReadLine();

Console.WriteLine("Введите пол");
var genderName = Console.ReadLine();

var gender = new Gender(genderName);

Console.WriteLine("Введите дату рождения");
var birthdate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Введите вес");
var weight = double.Parse(Console.ReadLine());

Console.WriteLine("Введите рост");
var height = double.Parse(Console.ReadLine());




