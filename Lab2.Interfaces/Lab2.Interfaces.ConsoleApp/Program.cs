﻿using System;
using System.Collections.Generic;

namespace Lab2.Interfaces.ConsoleApp {
    internal static class Program {
        private static void Main() {

            var output = new ConsoleOutput();
            var mobileOptions = new MobileOptions(output);
            var playbackOptions = mobileOptions.PlaybackOptions;
            var displayOptions = mobileOptions.DisplayOptions;

            var playbackChoice = playbackOptions[ChooseFromList("playback components", playbackOptions, output)];
            var displayChoice = displayOptions[ChooseFromList("display component", displayOptions, output)];

            output.WriteLine($"{ playbackChoice.GetName()}, {displayChoice.GetName()} selected.");

            var mobile = new SimCorpMobile {
                PlaybackComponent = playbackChoice,
                DisplayComponent = displayChoice
            };
            mobile.Play("");
            mobile.Display("");
            Console.ReadLine();
        }

        private static int ChooseFromList(string choicesTitle, IReadOnlyList<INamedClass> choices, IOutput output) {
            output.WriteLine($"Select {choicesTitle} index");
            for (var i = 0; i < choices.Count; i++) {
                output.WriteLine($"{i}: {choices[i].GetName()}");
            }
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 0 || choice >= choices.Count) {
                throw new IndexOutOfRangeException($"Bad input for {choicesTitle}. Got {choice}");
            }
            return choice;
        }
    }
}
