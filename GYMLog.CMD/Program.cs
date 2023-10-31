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


WorkoutExerciseController workout = new WorkoutExerciseController("Подтягивания", "Мышцы спины", 5, 40, 20, 18, 15, 12, 10);
WorkoutExerciseController workout2 = new WorkoutExerciseController("Отжимания на брусьях", "Мышцы груди", 5, 40, 30, 25, 25, 20, 15);

WorkoutPlanController work = new WorkoutPlanController(name);
work.AddExercise(workout.CurrentExercise);
work.AddExercise(workout2.CurrentExercise);


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




