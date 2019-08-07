namespace Lab2.Interfaces.WinForm {
    partial class ComponentSelectionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AudioBox = new System.Windows.Forms.ComboBox();
            this.DisplayBox = new System.Windows.Forms.ComboBox();
            this.AudioLabel = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ApplyComponentsButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AudioBox
            // 
            this.AudioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioBox.FormattingEnabled = true;
            this.AudioBox.Location = new System.Drawing.Point(15, 25);
            this.AudioBox.Name = "AudioBox";
            this.AudioBox.Size = new System.Drawing.Size(121, 21);
            this.AudioBox.TabIndex = 4;
            this.AudioBox.SelectedIndexChanged += new System.EventHandler(this.AudioBox_SelectedIndexChanged);
            // 
            // DisplayBox
            // 
            this.DisplayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayBox.FormattingEnabled = true;
            this.DisplayBox.Location = new System.Drawing.Point(142, 25);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(121, 21);
            this.DisplayBox.TabIndex = 5;
            this.DisplayBox.SelectedIndexChanged += new System.EventHandler(this.DisplayBox_SelectedIndexChanged);
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Location = new System.Drawing.Point(12, 9);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(115, 13);
            this.AudioLabel.TabIndex = 6;
            this.AudioLabel.Text = "Audio playback device";
            this.AudioLabel.Click += new System.EventHandler(this.AudioLabel_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(139, 9);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(41, 13);
            this.DisplayLabel.TabIndex = 7;
            this.DisplayLabel.Text = "Display";
            this.DisplayLabel.Click += new System.EventHandler(this.DisplayLabel_Click);
            // 
            // ApplyComponentsButton
            // 
            this.ApplyComponentsButton.Location = new System.Drawing.Point(269, 23);
            this.ApplyComponentsButton.Name = "ApplyComponentsButton";
            this.ApplyComponentsButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyComponentsButton.TabIndex = 8;
            this.ApplyComponentsButton.Text = "Apply";
            this.ApplyComponentsButton.UseVisualStyleBackColor = true;
            this.ApplyComponentsButton.Click += new System.EventHandler(this.ApplyComponentsButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(16, 65);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(328, 186);
            this.OutputBox.TabIndex = 9;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // ComponentSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 269);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ApplyComponentsButton);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.AudioLabel);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.AudioBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 308);
            this.Name = "ComponentSelectionForm";
            this.Text = "Lab2.Interfaces GUI application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox AudioBox;
        private System.Windows.Forms.ComboBox DisplayBox;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button ApplyComponentsButton;
        private System.Windows.Forms.TextBox OutputBox;
    }
}

