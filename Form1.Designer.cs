namespace BarbellBar_weight_calculator_app_using_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InfoLabel = new Label();
            TextBox = new TextBox();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(38, 85);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(85, 25);
            InfoLabel.TabIndex = 0;
            InfoLabel.Text = "InfoLabel";
            // 
            // TextBox
            // 
            TextBox.Location = new Point(38, 127);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(248, 31);
            TextBox.TabIndex = 1;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(38, 173);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(248, 58);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 268);
            Controls.Add(CalculateButton);
            Controls.Add(TextBox);
            Controls.Add(InfoLabel);
            Name = "Form1";
            Text = "BarbellBar Weight Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private TextBox TextBox;
        private Button CalculateButton;
    }
}