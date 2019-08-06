namespace Lab2.Interfaces {
    public class InbuiltDisplay : IDisplay {

        private readonly IOutput Output;

        public InbuiltDisplay(IOutput output) {
            Output = output;
        }

        public void Display(object data) {
            Output.WriteLine($"Displaying from {Name()}");
        }

        public string Name() {
            return "InbuiltDisplay";
        }
    }
}
