namespace Lab2.Interfaces {
    public class PhoneSpeaker : IPlayback {

        private readonly IOutput Output;

        public PhoneSpeaker(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{GetName()} sound");
        }

        public string GetName() {
            return "PhoneSpeaker";
        }
    }
}
