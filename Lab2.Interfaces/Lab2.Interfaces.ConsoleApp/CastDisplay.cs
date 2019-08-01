using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class CastDisplay : IDisplay {
        public void Display(object data) {
            Console.WriteLine($"Displaying from {nameof(CastDisplay)}");
        }
    }
}
