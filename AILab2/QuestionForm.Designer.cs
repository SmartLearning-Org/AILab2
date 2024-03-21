using System.Windows.Forms;

namespace AILab2
{
    partial class QuestionForm
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
            label1 = new Label();
            QuestionBox = new TextBox();
            label2 = new Label();
            YesNoButton = new RadioButton();
            ShortAnswerButton = new RadioButton();
            LongAnswerButton = new RadioButton();
            AnswerButton = new Button();
            AnswerLabel = new Label();
            ProgressBar = new ProgressBar();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 0;
            label1.Text = "Hvilket spørgsmål vil du have svar på?";
            // 
            // QuestionBox
            // 
            QuestionBox.Location = new Point(46, 78);
            QuestionBox.Multiline = true;
            QuestionBox.Name = "QuestionBox";
            QuestionBox.Size = new Size(622, 134);
            QuestionBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 234);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 2;
            label2.Text = "Hvilken type svar vil du have?";
            // 
            // YesNoButton
            // 
            YesNoButton.AutoSize = true;
            YesNoButton.Location = new Point(52, 273);
            YesNoButton.Name = "YesNoButton";
            YesNoButton.Size = new Size(72, 24);
            YesNoButton.TabIndex = 3;
            YesNoButton.TabStop = true;
            YesNoButton.Text = "Ja/Nej";
            YesNoButton.UseVisualStyleBackColor = true;
            // 
            // ShortAnswerButton
            // 
            ShortAnswerButton.AutoSize = true;
            ShortAnswerButton.Location = new Point(167, 273);
            ShortAnswerButton.Name = "ShortAnswerButton";
            ShortAnswerButton.Size = new Size(88, 24);
            ShortAnswerButton.TabIndex = 4;
            ShortAnswerButton.TabStop = true;
            ShortAnswerButton.Text = "Kort svar";
            ShortAnswerButton.UseVisualStyleBackColor = true;
            // 
            // LongAnswerButton
            // 
            LongAnswerButton.AutoSize = true;
            LongAnswerButton.Location = new Point(290, 273);
            LongAnswerButton.Name = "LongAnswerButton";
            LongAnswerButton.Size = new Size(97, 24);
            LongAnswerButton.TabIndex = 5;
            LongAnswerButton.TabStop = true;
            LongAnswerButton.Text = "Langt svar";
            LongAnswerButton.UseVisualStyleBackColor = true;
            // 
            // AnswerButton
            // 
            AnswerButton.Location = new Point(484, 268);
            AnswerButton.Name = "AnswerButton";
            AnswerButton.Size = new Size(184, 29);
            AnswerButton.TabIndex = 6;
            AnswerButton.Text = "Besvar spørgsmålet";
            AnswerButton.UseVisualStyleBackColor = true;
            AnswerButton.Click += AnswerButton_Click;
            // 
            // AnswerLabel
            // 
            AnswerLabel.Location = new Point(3, 9);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.TabIndex = 7;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(51, 309);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(611, 29);
            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.TabIndex = 8;
            ProgressBar.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(AnswerLabel);
            panel1.Location = new Point(52, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 125);
            panel1.TabIndex = 9;
            panel1.AutoScroll = true;

            AnswerLabel.Size = new Size(panel1.Width - 20, 0); // Bredde tilpasset panelet, højde bliver justeret
            AnswerLabel.AutoSize = true; // Tillader kontrol at justere højde
            AnswerLabel.MaximumSize = new Size(panel1.Width - 20, 0);

            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(ProgressBar);
            Controls.Add(AnswerButton);
            Controls.Add(LongAnswerButton);
            Controls.Add(ShortAnswerButton);
            Controls.Add(YesNoButton);
            Controls.Add(label2);
            Controls.Add(QuestionBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "QuestionForm";
            Text = "Stil et spørgsmål";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox QuestionBox;
        private Label label2;
        private RadioButton YesNoButton;
        private RadioButton ShortAnswerButton;
        private RadioButton LongAnswerButton;
        private Button AnswerButton;
        private Label AnswerLabel;
        private ProgressBar ProgressBar;
        private Panel panel1;
    }
}