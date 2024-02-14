namespace WinFormsGUI.View.ChildForms.FormTrainPlan
{
    partial class EditWorkoutPlan
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
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            editButton = new Button();
            exitButton = new Label();
            descriptionTextBox = new TextBox();
            panel1 = new Panel();
            planNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(50, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(232, 16);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Изменение плана тренировки";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_план_50;
            pictureBox1.Location = new Point(142, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(118, 430);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 25);
            editButton.TabIndex = 17;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(288, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 16;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.Window;
            descriptionTextBox.Location = new Point(39, 181);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Описание...";
            descriptionTextBox.Size = new Size(250, 114);
            descriptionTextBox.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(39, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 14;
            // 
            // planNameTextBox
            // 
            planNameTextBox.BackColor = SystemColors.Window;
            planNameTextBox.BorderStyle = BorderStyle.None;
            planNameTextBox.Location = new Point(39, 127);
            planNameTextBox.Multiline = true;
            planNameTextBox.Name = "planNameTextBox";
            planNameTextBox.PlaceholderText = "Название плана тренировки";
            planNameTextBox.Size = new Size(250, 25);
            planNameTextBox.TabIndex = 13;
            // 
            // EditWorkoutPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(319, 467);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(editButton);
            Controls.Add(exitButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(panel1);
            Controls.Add(planNameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditWorkoutPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditWorkoutPlan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Button editButton;
        private Label exitButton;
        private TextBox descriptionTextBox;
        private Panel panel1;
        private TextBox planNameTextBox;
    }
}