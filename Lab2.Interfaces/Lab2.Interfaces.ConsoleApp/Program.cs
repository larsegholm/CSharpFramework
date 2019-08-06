using System;
using System.Collections.Generic;

namespace Lab2.Interfaces.ConsoleApp {
    static class Program {
        static void Main(string[] args) {

            var output = new ConsoleOutput();
            var mobileOptions = new MobileOptions(output);
            var playbackOptions = mobileOptions.PlaybackOptions;
            var displayOptions = mobileOptions.DisplayOptions;

            var playbackChoice = playbackOptions[ChooseFromList("playback components", playbackOptions, output)];
            var displayChoice = displayOptions[ChooseFromList("display component", displayOptions, output)];

            output.WriteLine($"{ playbackChoice.Name()}, {displayChoice.Name()} selected.");
                
            var mobile = new SimCorpMobile {
                PlaybackComponent = playbackChoice,
                DisplayComponent = displayChoice
            };
            mobile.Play("");
            mobile.Display("");
        }

        private static int ChooseFromList(string choicesTitle, IReadOnlyList<INamedClass> choices, IOutput output) {
            output.WriteLine($"Select {choicesTitle} index");
            for (var i = 0; i < choices.Count; i++) {
                output.WriteLine($"{i}: {choices[i].Name()}");
            }
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
