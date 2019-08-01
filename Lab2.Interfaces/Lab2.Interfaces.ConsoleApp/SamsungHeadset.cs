using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class SamsungHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
