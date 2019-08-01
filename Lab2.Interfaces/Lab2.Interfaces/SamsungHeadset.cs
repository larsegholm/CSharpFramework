using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class SamsungHeadset : IPlayback {

        private readonly IOutput Output;

        public SamsungHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{Name()} sound");
        }
        public string Name() {
            return "SamsungHeadset";
        }
    }
}
