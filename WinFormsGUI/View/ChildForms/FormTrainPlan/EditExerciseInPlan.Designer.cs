namespace WinFormsGUI.View.ChildForms.FormTrainPlan
{
    partial class EditExerciseInPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExerciseInPlan));
            buttonsPanel = new Panel();
            descriptionTextBox = new TextBox();
            panel3 = new Panel();
            setsCountTextBox = new TextBox();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            editButton = new Button();
            exitButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoScroll = true;
            buttonsPanel.Location = new Point(73, 105);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(250, 120);
            buttonsPanel.TabIndex = 38;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.Window;
            descriptionTextBox.Location = new Point(73, 231);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Описание...";
            descriptionTextBox.Size = new Size(250, 114);
            descriptionTextBox.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(73, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 36;
            // 
            // setsCountTextBox
            // 
            setsCountTextBox.BackColor = SystemColors.Window;
            setsCountTextBox.BorderStyle = BorderStyle.None;
            setsCountTextBox.Location = new Point(73, 67);
            setsCountTextBox.Multiline = true;
            setsCountTextBox.Name = "setsCountTextBox";
            setsCountTextBox.PlaceholderText = "Количество подходов";
            setsCountTextBox.Size = new Size(250, 25);
            setsCountTextBox.TabIndex = 35;
            setsCountTextBox.TextChanged += setsCountTextBox_TextChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(111, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(185, 16);
            titleLabel.TabIndex = 32;
            titleLabel.Text = "Изменение упражнения";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(152, 540);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 25);
            editButton.TabIndex = 30;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(355, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 29;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // EditExerciseInPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(384, 577);
            Controls.Add(buttonsPanel);
            Controls.Add(descriptionTextBox);
            Controls.Add(panel3);
            Controls.Add(setsCountTextBox);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(editButton);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditExerciseInPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditExerciseInPlan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel buttonsPanel;
        private TextBox descriptionTextBox;
        private Panel panel3;
        private TextBox setsCountTextBox;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private Button editButton;
        private Label exitButton;
    }
}