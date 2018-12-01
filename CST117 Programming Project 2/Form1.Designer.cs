namespace CST117_Programming_Project_2
{
    partial class passGenMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.includeNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.includeSpecialCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.includeUpperAndLowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.generateOnePassRadioButton = new System.Windows.Forms.RadioButton();
            this.generateFivePasswordsRadioButton = new System.Windows.Forms.RadioButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.generateRadioButtonContainer = new System.Windows.Forms.GroupBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.generateRadioButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // includeNumbersCheckBox
            // 
            this.includeNumbersCheckBox.AutoSize = true;
            this.includeNumbersCheckBox.Location = new System.Drawing.Point(12, 12);
            this.includeNumbersCheckBox.Name = "includeNumbersCheckBox";
            this.includeNumbersCheckBox.Size = new System.Drawing.Size(128, 17);
            this.includeNumbersCheckBox.TabIndex = 1;
            this.includeNumbersCheckBox.Text = "Include numbers (0-9)";
            this.includeNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeSpecialCharactersCheckBox
            // 
            this.includeSpecialCharactersCheckBox.AutoSize = true;
            this.includeSpecialCharactersCheckBox.Location = new System.Drawing.Point(13, 36);
            this.includeSpecialCharactersCheckBox.Name = "includeSpecialCharactersCheckBox";
            this.includeSpecialCharactersCheckBox.Size = new System.Drawing.Size(210, 17);
            this.includeSpecialCharactersCheckBox.TabIndex = 2;
            this.includeSpecialCharactersCheckBox.Text = "Include special characters (!@#$%^&*())";
            this.includeSpecialCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeUpperAndLowerCaseCheckBox
            // 
            this.includeUpperAndLowerCaseCheckBox.AutoSize = true;
            this.includeUpperAndLowerCaseCheckBox.Location = new System.Drawing.Point(12, 60);
            this.includeUpperAndLowerCaseCheckBox.Name = "includeUpperAndLowerCaseCheckBox";
            this.includeUpperAndLowerCaseCheckBox.Size = new System.Drawing.Size(169, 17);
            this.includeUpperAndLowerCaseCheckBox.TabIndex = 3;
            this.includeUpperAndLowerCaseCheckBox.Text = "Include upper- and lower-case";
            this.includeUpperAndLowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(12, 179);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(259, 186);
            this.resultsListBox.TabIndex = 4;
            this.resultsListBox.SelectedIndexChanged += new System.EventHandler(this.resultsListBox_SelectedIndexChanged);
            // 
            // generateOnePassRadioButton
            // 
            this.generateOnePassRadioButton.AutoSize = true;
            this.generateOnePassRadioButton.Location = new System.Drawing.Point(6, 19);
            this.generateOnePassRadioButton.Name = "generateOnePassRadioButton";
            this.generateOnePassRadioButton.Size = new System.Drawing.Size(138, 17);
            this.generateOnePassRadioButton.TabIndex = 5;
            this.generateOnePassRadioButton.TabStop = true;
            this.generateOnePassRadioButton.Text = "Generate one password";
            this.generateOnePassRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateFivePasswordsRadioButton
            // 
            this.generateFivePasswordsRadioButton.AutoSize = true;
            this.generateFivePasswordsRadioButton.Location = new System.Drawing.Point(6, 42);
            this.generateFivePasswordsRadioButton.Name = "generateFivePasswordsRadioButton";
            this.generateFivePasswordsRadioButton.Size = new System.Drawing.Size(142, 17);
            this.generateFivePasswordsRadioButton.TabIndex = 6;
            this.generateFivePasswordsRadioButton.TabStop = true;
            this.generateFivePasswordsRadioButton.Text = "Generate five passwords";
            this.generateFivePasswordsRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 383);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // generateRadioButtonContainer
            // 
            this.generateRadioButtonContainer.Controls.Add(this.generateOnePassRadioButton);
            this.generateRadioButtonContainer.Controls.Add(this.generateFivePasswordsRadioButton);
            this.generateRadioButtonContainer.Location = new System.Drawing.Point(13, 83);
            this.generateRadioButtonContainer.Name = "generateRadioButtonContainer";
            this.generateRadioButtonContainer.Size = new System.Drawing.Size(228, 72);
            this.generateRadioButtonContainer.TabIndex = 10;
            this.generateRadioButtonContainer.TabStop = false;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(104, 383);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // passGenMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 414);
            this.Controls.Add(this.generateRadioButtonContainer);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.includeUpperAndLowerCaseCheckBox);
            this.Controls.Add(this.includeSpecialCharactersCheckBox);
            this.Controls.Add(this.includeNumbersCheckBox);
            this.Name = "passGenMainWindow";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateRadioButtonContainer.ResumeLayout(false);
            this.generateRadioButtonContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox includeNumbersCheckBox;
        private System.Windows.Forms.CheckBox includeSpecialCharactersCheckBox;
        private System.Windows.Forms.CheckBox includeUpperAndLowerCaseCheckBox;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.RadioButton generateOnePassRadioButton;
        private System.Windows.Forms.RadioButton generateFivePasswordsRadioButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox generateRadioButtonContainer;
        private System.Windows.Forms.Button copyButton;
    }
}

