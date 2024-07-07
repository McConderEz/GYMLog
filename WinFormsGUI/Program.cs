using GYMLog.BL.Controller;
using WinFormsGUI.View;

namespace WinFormsGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ExerciseController exerciseController = new ExerciseController();
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}