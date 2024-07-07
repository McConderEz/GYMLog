using GYMLog.BL.Controller;
using GYMLog.BL.Helper;
using GYMLog.BL.Model;
using GYMLog.CMD.Languages;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Resources;




var culture = CultureInfo.CreateSpecificCulture("en-us");
var resourceManager = new ResourceManager("GYMLog.CMD.Languages.Messages", typeof(Program).Assembly);

Console.WriteLine(resourceManager.GetString("Hello", culture)+"\n");

Console.WriteLine(resourceManager.GetString("LoginRequest", culture));
var login = Console.ReadLine();

Console.WriteLine(resourceManager.GetString("PasswordRequest", culture));
var password = Console.ReadLine();

var userController = new UserController(login, password);
var eatingController = new EatingController(null /*userController.CurrentUser*/);
ExerciseController exerciseController;
WorkoutPlanController workoutPlanController;
WorkoutExerciseController workoutExerciseController;

if (userController.IsNewUser)
{
    Console.WriteLine(resourceManager.GetString("GenderRequest", culture));
    var genderName = Console.ReadLine();

    DateTime birthdate = ParseDateTime();

    double weight = ParseDouble(resourceManager.GetString("WeightRequest", culture));


    var height = ParseDouble(resourceManager.GetString("HeightRequest", culture));

    userController.SetNewUserData(genderName, birthdate, weight,height);
}

Console.WriteLine(userController.CurrentUser);

while (true)
{
    Console.WriteLine(resourceManager.GetString("WhatYouWantRequest", culture));
    Console.WriteLine("E)Ввести прием пищи");
    Console.WriteLine("A)Создать упражнение");
    Console.WriteLine("D)Создать план тренировок");
    Console.WriteLine("F)Добавить упражнение в план тренировок");
    Console.WriteLine("Q)Выход");
    var key = Console.ReadKey();

    if (key.Key == ConsoleKey.Q)
    {
        Console.WriteLine("Завершение работы...");
        break;
    }

    switch (key.Key)
    {
        case ConsoleKey.E:
            var foods = EnterEating();
            eatingController.Add(foods.Food, foods.Weight);

            foreach (var item in eatingController.Eating.Foods)
            {
                Console.WriteLine($"\t{item.Food} - {item.Weight}");
            }

            break;
        case ConsoleKey.A:
            var exercise = EnterExercise();
            exerciseController = new ExerciseController(exercise.Name, exercise.Category);
            exerciseController.SetNewExerciseData(exercise.Description);

            foreach (var item in exerciseController.Exercises)
            {
                Console.WriteLine($"\t{item.Name} - {item.Category}");
            }

            break;
        case ConsoleKey.D:
            workoutPlanController = new WorkoutPlanController(userController.CurrentUser);
            var result = EnterWorkoutPlan();
            workoutPlanController.SetNewWorkoutPlanData(result.Item1, result.Item2);
            break;
        case ConsoleKey.F:
            var _exercise = EnterExercise();
            var _params = ExerciseParams();
            workoutPlanController = new WorkoutPlanController(userController.CurrentUser);
            workoutPlanController.Add(_exercise, _params.Item1,_params.Item2);

            Console.WriteLine($"{workoutPlanController.WorkoutPlan.PlanName}:");
            foreach(var item in workoutPlanController.WorkoutPlan.ExerciseList)
            {
                Console.WriteLine($"\t{item}");
                foreach (var item2 in item.ExerciseParams)
                {
                    Console.WriteLine($"\t\t{item2.Iterations} - {item2.Weight}");
                }
            }
            break;

    }


    Thread.Sleep(5000);
    Console.Clear();
}

static (int ,List<ExerciseParams>) ExerciseParams()
{
    Console.WriteLine("Введите количество подходов:");
    var sets = int.Parse(Console.ReadLine());
    var exerciseParams = new List<ExerciseParams>();
    
    for(var i = 0;i < sets; i++)
    {
        Console.WriteLine($"Введите количество итераций для {i+1} подхода:");
        int iterations = int.Parse(Console.ReadLine());
        double weight = ParseDouble($"Введите вес(если упражнение с весом) для {i + 1} подхода:");
        exerciseParams.Add(new ExerciseParams(iterations,weight));
    }

    return (sets,exerciseParams);
}


static (string,string) EnterWorkoutPlan()
{
    Console.WriteLine("Введите название плана тренировок:");
    var planName = Console.ReadLine();
    Console.WriteLine("Введите заметки(если есть):");
    var notes = Console.ReadLine();

    return (planName, notes);
}

static Exercise EnterExercise()
{
    Console.WriteLine("Введите название упражнения:");
    var name = Console.ReadLine();
    Console.WriteLine("Введите категорию упражнения:");
    var category = Console.ReadLine();
    Console.WriteLine("Введите описание упражнения:");
    var description = Console.ReadLine();

    var exercise = new Exercise(name, category, description);

    return exercise;
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