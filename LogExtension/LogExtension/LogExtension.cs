using System;using NUnit.Engine;
using NUnit.Engine.Extensibility;

namespace LogExtension
{
    /// <summary>
    /// Расширение для тестов Nunit, которое слушает события тестов и отправляет результаты на TestRail.
    /// </summary>
    [Extension]
    public class TestRailListener : ITestEventListener
    { 
        /// <summary>
        /// Обрабатывает события тестов.
        /// </summary>
        /// <param name="report">XML отчет события.</param>
        public void OnTestEvent(string report)
        {
            Console.WriteLine("===============================");
            Console.WriteLine(report);
            Console.WriteLine("===============================");
        }
    }
}