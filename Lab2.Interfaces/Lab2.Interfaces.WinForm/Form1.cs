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

            MobileOptions.PlaybackOptions.ForEach(opt => comboBox1.Items.Add(opt.Name()));
            MobileOptions.DisplayOptions.ForEach(opt => comboBox2.Items.Add(opt.Name()));

            Mobile = new SimCorpMobile();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.PlaybackComponent = MobileOptions.PlaybackOptions
                .Single(opt => opt.Name() == (string)comboBox1.SelectedItem);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.DisplayComponent = MobileOptions.DisplayOptions
                .Single(opt => opt.Name() == (string)comboBox2.SelectedItem); 
        }

        private void Label1_Click(object sender, EventArgs e) {

        }

        private void Label2_Click(object sender, EventArgs e) {

        }

        private void Button1_Click(object sender, EventArgs e) {
            Mobile.Play("");
            Mobile.Display("");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
