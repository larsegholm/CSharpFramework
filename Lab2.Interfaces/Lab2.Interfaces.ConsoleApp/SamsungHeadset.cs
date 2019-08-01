using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class SamsungHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{Name()} sound");
        }
        public string Name() {
            return "SamsungHeadset";
        }
    }
}
