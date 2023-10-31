using GYMLog.BL.Controller;
using GYMLog.BL.Model;
using System.ComponentModel.DataAnnotations;

//TODO: Переписать интерфейс в WPF(Окно регистрации, авторизации и основное)
Console.WriteLine("Вас приветствует приложение GYMLog");

Console.WriteLine("Введите название упражнения:");
var name = Console.ReadLine();

Console.WriteLine("Введите категорию упражнения:");
var category = Console.ReadLine();

//Console.WriteLine("Введите описания упражнения:");
//var description = Console.ReadLine();

ExerciseController exerciseController = new ExerciseController(name, category);


WorkoutExercise workout = new WorkoutExercise(5, 30, 40, exerciseController.CurrentExercise);

WorkoutPlanController work = new WorkoutPlanController(name);



//Console.WriteLine("Введите имя пользователя");
//var login = Console.ReadLine();

//Console.WriteLine("Введите пароль");
//var password = Console.ReadLine();

//Console.WriteLine("Введите пол");
//var genderName = Console.ReadLine();

//var gender = new Gender(genderName);

//Console.WriteLine("Введите дату рождения");
//var birthdate = DateTime.Parse(Console.ReadLine());

//Console.WriteLine("Введите вес");
//var weight = double.Parse(Console.ReadLine());

//Console.WriteLine("Введите рост");
//var height = double.Parse(Console.ReadLine());




