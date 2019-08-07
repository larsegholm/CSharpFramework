namespace Lab2.Interfaces {
    public class UnofficialHeadset : IPlayback {

        private readonly IOutput Output;

        public UnofficialHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(UnofficialHeadset)} sound");
        }

        public string GetName() {
            return "UnofficialHeadset";
        }
    }
}
