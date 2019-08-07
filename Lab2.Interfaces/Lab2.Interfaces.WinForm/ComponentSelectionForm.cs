using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2.Interfaces.WinForm {
    public partial class ComponentSelectionForm : Form {

        private readonly MobileOptions MobileOptions;
        private readonly Mobile Mobile;

        public ComponentSelectionForm() {
            InitializeComponent();
            
            MobileOptions = new MobileOptions(
                new TextBoxOutput(OutputBox));

            MobileOptions.PlaybackOptions.ForEach(opt => AudioBox.Items.Add(opt.GetName()));
            MobileOptions.DisplayOptions.ForEach(opt => DisplayBox.Items.Add(opt.GetName()));

            Mobile = new SimCorpMobile();
        }

        private void AudioBox_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.PlaybackComponent = MobileOptions.PlaybackOptions
                .Single(opt => opt.GetName() == (string)AudioBox.SelectedItem);
        }

        private void DisplayBox_SelectedIndexChanged(object sender, EventArgs e) {
            Mobile.DisplayComponent = MobileOptions.DisplayOptions
                .Single(opt => opt.GetName() == (string)DisplayBox.SelectedItem); 
        }

        private void AudioLabel_Click(object sender, EventArgs e) {

        }

        private void DisplayLabel_Click(object sender, EventArgs e) {

        }

        private void ApplyComponentsButton_Click(object sender, EventArgs e) {
            if (Mobile.DisplayComponent == null || Mobile.PlaybackComponent == null) {
                OutputBox.Text = @"Please select audio and visual components";
                return;
            }

            OutputBox.Text = string.Empty;
            Mobile.Play("");
            Mobile.Display("");
        }

        private void OutputBox_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
