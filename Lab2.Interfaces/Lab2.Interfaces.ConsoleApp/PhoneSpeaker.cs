using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class PhoneSpeaker : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
