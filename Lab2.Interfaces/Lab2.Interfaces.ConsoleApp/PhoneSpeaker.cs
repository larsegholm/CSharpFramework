﻿using System;

namespace Lab2.Interfaces.ConsoleApp {
    public class PhoneSpeaker : IPlayback {

        private readonly IOutput Output;

        public PhoneSpeaker(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{Name()} sound");
        }

        public string Name() {
            return "PhoneSpeaker";
        }
    }
}
