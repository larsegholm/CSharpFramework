using System.Collections.Generic;

namespace Lab2.Interfaces {
    public class MobileOptions {
        public readonly List<IPlayback> PlaybackOptions;
        public readonly List<IDisplay> DisplayOptions;

        public MobileOptions(IOutput output) {

            PlaybackOptions = new List<IPlayback> {
                new AppleHeadset(output),
                new PhoneSpeaker(output),
                new SamsungHeadset(output),
                new UnofficialHeadset(output)
            };

            DisplayOptions = new List<IDisplay> {
                new InbuiltDisplay(output),
                new CastDisplay(output)
            };
        }
    }
}
