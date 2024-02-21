namespace WinFormsGUI.View.ChildForms.FormTrainPlan
{
    partial class AddExerciseInPlan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExerciseInPlan));
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            addButton = new Button();
            exitButton = new Label();
            panel2 = new Panel();
            categoryComboBox = new ComboBox();
            panel3 = new Panel();
            setsCountTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            buttonsPanel = new Panel();
            exerciseComboBox = new ComboBox();
            exerciseControllerBindingSource = new BindingSource(components);
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exerciseControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(109, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(192, 16);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Добавление упражнения";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(150, 540);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 25);
            addButton.TabIndex = 17;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(353, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 16;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(73, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 21;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FlatStyle = FlatStyle.Flat;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(73, 143);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(250, 23);
            categoryComboBox.TabIndex = 22;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(73, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 24;
            // 
            // setsCountTextBox
            // 
            setsCountTextBox.BackColor = SystemColors.Window;
            setsCountTextBox.BorderStyle = BorderStyle.None;
            setsCountTextBox.Location = new Point(73, 215);
            setsCountTextBox.Multiline = true;
            setsCountTextBox.Name = "setsCountTextBox";
            setsCountTextBox.PlaceholderText = "Количество подходов";
            setsCountTextBox.Size = new Size(250, 25);
            setsCountTextBox.TabIndex = 23;
            setsCountTextBox.TextChanged += setsCountTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.Window;
            descriptionTextBox.Location = new Point(73, 379);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Описание...";
            descriptionTextBox.Size = new Size(250, 114);
            descriptionTextBox.TabIndex = 25;
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoScroll = true;
            buttonsPanel.Location = new Point(73, 253);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(250, 120);
            buttonsPanel.TabIndex = 26;
            // 
            // exerciseComboBox
            // 
            exerciseComboBox.FlatStyle = FlatStyle.Flat;
            exerciseComboBox.FormattingEnabled = true;
            exerciseComboBox.Location = new Point(73, 179);
            exerciseComboBox.Name = "exerciseComboBox";
            exerciseComboBox.Size = new Size(250, 23);
            exerciseComboBox.TabIndex = 28;
            // 
            // exerciseControllerBindingSource
            // 
            exerciseControllerBindingSource.DataSource = typeof(GYMLog.BL.Controller.ExerciseController);
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(73, 208);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 27;
            // 
            // AddExerciseInPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(384, 577);
            Controls.Add(exerciseComboBox);
            Controls.Add(panel4);
            Controls.Add(buttonsPanel);
            Controls.Add(descriptionTextBox);
            Controls.Add(panel3);
            Controls.Add(setsCountTextBox);
            Controls.Add(categoryComboBox);
            Controls.Add(panel2);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(addButton);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddExerciseInPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExerciseInPlan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exerciseControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Button addButton;
        private Label exitButton;
        private Panel panel1;
        private TextBox exNameTextBox;
        private Panel panel2;
        private ComboBox categoryComboBox;
        private Panel panel3;
        private TextBox setsCountTextBox;
        private TextBox descriptionTextBox;
        private Panel buttonsPanel;
        private ComboBox exerciseComboBox;
        private Panel panel4;
        private BindingSource exerciseControllerBindingSource;
    }
}