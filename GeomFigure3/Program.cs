//Юсупов Ильяс 221 группа "Геометрические фигуры - 4"
using System;
using System.Collections.Generic;
using System.IO;

namespace GeomFigure3
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
            Application.Run(new GraphicEditor());
        }
    }
}
