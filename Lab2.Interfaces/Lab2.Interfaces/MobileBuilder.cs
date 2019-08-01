using System;
using System.Collections.Generic;
using Lab2.Interfaces.ConsoleApp;

namespace Lab2.Interfaces {
    public class MobileBuilder {

        private readonly IOutput Output;
        public Mobile Mobile { get; }

        public MobileBuilder(IOutput output) {

            Output = output;

            var playbackOptions = new List<IPlayback> {
                new AppleHeadset(output),
                new PhoneSpeaker(output),
                new SamsungHeadset(output),
                new UnofficialHeadset(output)
            };

            var displayOptions = new List<IDisplay> {
                new InbuiltDisplay(output),
                new CastDisplay(output)
            };

            var playbackChoice = ChooseFromList("playback components", playbackOptions);
            var displayChoice = ChooseFromList("display component", displayOptions);

            Output.WriteLine($"{playbackOptions[playbackChoice].Name()}, {displayOptions[displayChoice].Name()} selected.");

            Mobile = new SimCorpMobile {
                PlaybackComponent = playbackOptions[playbackChoice],
                DisplayComponent = displayOptions[displayChoice]
            };
        }

        private int ChooseFromList(string choicesTitle, IReadOnlyList<INamedClass> choices) {
            Output.WriteLine($"Select {choicesTitle} index");
            for (var i = 0; i < choices.Count; i++) {
                Output.WriteLine($"{i}: {choices[i].Name()}");
            }
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
