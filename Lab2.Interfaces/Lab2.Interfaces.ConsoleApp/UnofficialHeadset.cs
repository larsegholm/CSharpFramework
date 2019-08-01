using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class UnofficialHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{nameof(UnofficialHeadset)} sound");
        }

        public string Name() {
            return "UnofficialHeadset";
        }
    }
}
