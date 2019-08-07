using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2.Interfaces.WinForm {
    public partial class Form1 : Form {

        private readonly MobileOptions MobileOptions;
        private readonly Mobile Mobile;

        public Form1() {
            InitializeComponent();
            
            MobileOptions = new MobileOptions(
                new TextBoxOutput(OutputBox));

            MobileOptions.PlaybackOptions.ForEach(opt => comboBox1.Items.Add(opt.GetName()));
            MobileOptions.DisplayOptions.ForEach(opt => comboBox2.Items.Add(opt.GetName()));

            Mobile = new SimCorpMobile();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.PlaybackComponent = MobileOptions.PlaybackOptions
                .Single(opt => opt.GetName() == (string)comboBox1.SelectedItem);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.DisplayComponent = MobileOptions.DisplayOptions
                .Single(opt => opt.GetName() == (string)comboBox2.SelectedItem); 
        }

        private void Label1_Click(object sender, EventArgs e) {

        }

        private void Label2_Click(object sender, EventArgs e) {

        }

        private void Button1_Click(object sender, EventArgs e) {
            if (Mobile.DisplayComponent == null || Mobile.PlaybackComponent == null) {
                OutputBox.Text = @"Please select audio and visual components";
                return;
            }

            OutputBox.Text = string.Empty;
            Mobile.Play("");
            Mobile.Display("");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
