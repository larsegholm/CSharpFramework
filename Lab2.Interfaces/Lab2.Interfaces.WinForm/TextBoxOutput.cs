using System;
using System.Windows.Forms;

namespace Lab2.Interfaces.WinForm {
    public class TextBoxOutput : IOutput {

        private readonly TextBox TextBox;

        public TextBoxOutput(TextBox textBox) {
            TextBox = textBox;
            TextBox.Text = "";
        }

        public void Write(string text) {
            TextBox.Text += text;
        }

        public void WriteLine(string text) {
            TextBox.Text += text + Environment.NewLine;
        }
    }
}
