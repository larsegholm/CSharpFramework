using System;
using System.Collections.Generic;

namespace Lab2.Interfaces.ConsoleApp {
    static class Program {
        static void Main(string[] args) {

            var playbackOptions = new List<IPlayback> {
                new AppleHeadset(),
                new PhoneSpeaker(),
                new SamsungHeadset(),
                new UnofficialHeadset()
            };

            var displayOptions = new List<IDisplay> {
                new InbuiltDisplay(),
                new CastDisplay()
            };

            var playbackChoice = ChooseFromList("playback components", playbackOptions);
            var displayChoice = ChooseFromList("display component", displayOptions);

            Console.WriteLine($"{playbackOptions[playbackChoice].Name()}, {displayOptions[displayChoice].Name()} selected.");

            var mobile = new SimCorpMobile {
                PlaybackComponent = playbackOptions[playbackChoice],
                DisplayComponent = displayOptions[displayChoice]
            };

            mobile.Play("");
            mobile.Display("");
        }

        private static int ChooseFromList(string choicesTitle, IReadOnlyList<INamedClass> choices) {
            Console.WriteLine($"Select {choicesTitle} index");
            for (var i = 0; i < choices.Count; i++) {
                Console.WriteLine($"{i}: {choices[i].Name()}");
            }
            return Convert.ToInt32(Console.ReadLine());
        }



    }
}
