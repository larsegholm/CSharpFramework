namespace Lab2.Interfaces {
    public class SamsungHeadset : IPlayback {

        private readonly IOutput Output;

        public SamsungHeadset(IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.WriteLine($"{GetName()} sound");
        }
        public string GetName() {
            return "SamsungHeadset";
        }
    }
}
