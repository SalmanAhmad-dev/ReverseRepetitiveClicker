<<<<<<< HEAD
using System;
using System.Windows.Forms;
=======
>>>>>>> d8c72f1 (Initial commit: Add ReverseRepetitiveClicker project with .gitignore)
namespace ReverseRepetitiveClicker
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
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new ReverseClicker());
=======
            Application.Run(new Form1());
>>>>>>> d8c72f1 (Initial commit: Add ReverseRepetitiveClicker project with .gitignore)
        }
    }
}