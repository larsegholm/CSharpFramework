namespace Lab2.Interfaces {
    public class CastDisplay : IDisplay {

        private readonly IOutput Output;

        public CastDisplay(IOutput output) {
            Output = output;
        }

        public void Display(object data) {
            Output.WriteLine($"Displaying from {Name()}");
        }

        public string Name() {
            return "CastDisplay";
        }
    }
}
