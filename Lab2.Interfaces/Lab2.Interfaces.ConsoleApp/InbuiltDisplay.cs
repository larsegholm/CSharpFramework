using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class InbuiltDisplay : IDisplay {
        public void Display(object data) {
            Console.WriteLine($"Displaying from {Name()}");
        }

        public string Name() {
            return "InbuiltDisplay";
        }
    }
}
