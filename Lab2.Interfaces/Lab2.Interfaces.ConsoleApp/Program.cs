namespace Lab2.Interfaces.ConsoleApp {
    static class Program {
        static void Main(string[] args) {

            var output = new ConsoleOutput();
            var mobile = new MobileBuilder(output).Mobile;
            mobile.Play("");
            mobile.Display("");
        }
    }
}
