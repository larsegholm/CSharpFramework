namespace Lab2.Interfaces {
    public class AppleHeadset : IPlayback {

        private readonly IOutput Output;

        public AppleHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{Name()} sound");
        }

        public string Name() {
            return "AppleHeadset";
        }
    }
}
