﻿namespace WinFormsGUI.View
{
    partial class FormTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrain));
            rightButton = new PictureBox();
            leftButton = new PictureBox();
            exCompletedButton = new PictureBox();
            buttonsPanel = new Panel();
            trainPlanDataGridView = new DataGridView();
            startTrain = new Button();
            ExerciseTitle = new Label();
            exerciseCategoryTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)rightButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exCompletedButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainPlanDataGridView).BeginInit();
            SuspendLayout();
            // 
            // rightButton
            // 
            rightButton.Image = Properties.Resources.icons8_стрелка_вправо_в_круге_50;
            rightButton.Location = new Point(481, 390);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(45, 38);
            rightButton.SizeMode = PictureBoxSizeMode.Zoom;
            rightButton.TabIndex = 0;
            rightButton.TabStop = false;
            rightButton.Click += rightButton_Click;
            rightButton.MouseLeave += rightButton_MouseLeave;
            rightButton.MouseMove += rightButton_MouseMove;
            // 
            // leftButton
            // 
            leftButton.Image = (Image)resources.GetObject("leftButton.Image");
            leftButton.Location = new Point(354, 390);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(45, 38);
            leftButton.SizeMode = PictureBoxSizeMode.Zoom;
            leftButton.TabIndex = 1;
            leftButton.TabStop = false;
            leftButton.Click += leftButton_Click;
            leftButton.MouseLeave += leftButton_MouseLeave;
            leftButton.MouseMove += leftButton_MouseMove;
            // 
            // exCompletedButton
            // 
            exCompletedButton.Image = (Image)resources.GetObject("exCompletedButton.Image");
            exCompletedButton.Location = new Point(419, 390);
            exCompletedButton.Name = "exCompletedButton";
            exCompletedButton.Size = new Size(45, 38);
            exCompletedButton.SizeMode = PictureBoxSizeMode.Zoom;
            exCompletedButton.TabIndex = 2;
            exCompletedButton.TabStop = false;
            exCompletedButton.Click += exCompletedButton_Click;
            exCompletedButton.MouseLeave += exCompletedButton_MouseLeave;
            exCompletedButton.MouseMove += exCompletedButton_MouseMove;
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoScroll = true;
            buttonsPanel.BackColor = SystemColors.Window;
            buttonsPanel.Location = new Point(318, 192);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(250, 192);
            buttonsPanel.TabIndex = 27;
            // 
            // trainPlanDataGridView
            // 
            trainPlanDataGridView.BackgroundColor = SystemColors.Window;
            trainPlanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainPlanDataGridView.Location = new Point(12, 12);
            trainPlanDataGridView.Name = "trainPlanDataGridView";
            trainPlanDataGridView.Size = new Size(300, 372);
            trainPlanDataGridView.TabIndex = 28;
            // 
            // startTrain
            // 
            startTrain.BackColor = SystemColors.Window;
            startTrain.FlatStyle = FlatStyle.Flat;
            startTrain.Location = new Point(92, 390);
            startTrain.Name = "startTrain";
            startTrain.Size = new Size(129, 27);
            startTrain.TabIndex = 29;
            startTrain.Text = "Начать тренировку";
            startTrain.UseVisualStyleBackColor = false;
            startTrain.Click += startTrain_Click;
            // 
            // ExerciseTitle
            // 
            ExerciseTitle.AutoSize = true;
            ExerciseTitle.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExerciseTitle.Location = new Point(318, 127);
            ExerciseTitle.Name = "ExerciseTitle";
            ExerciseTitle.Size = new Size(0, 21);
            ExerciseTitle.TabIndex = 30;
            // 
            // exerciseCategoryTitle
            // 
            exerciseCategoryTitle.AutoSize = true;
            exerciseCategoryTitle.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exerciseCategoryTitle.Location = new Point(318, 158);
            exerciseCategoryTitle.Name = "exerciseCategoryTitle";
            exerciseCategoryTitle.Size = new Size(0, 21);
            exerciseCategoryTitle.TabIndex = 31;
            // 
            // FormTrain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(exerciseCategoryTitle);
            Controls.Add(ExerciseTitle);
            Controls.Add(startTrain);
            Controls.Add(trainPlanDataGridView);
            Controls.Add(buttonsPanel);
            Controls.Add(exCompletedButton);
            Controls.Add(leftButton);
            Controls.Add(rightButton);
            Name = "FormTrain";
            Text = "Тренировки";
            Load += FormTrain_Load;
            ((System.ComponentModel.ISupportInitialize)rightButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exCompletedButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainPlanDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox rightButton;
        private PictureBox leftButton;
        private PictureBox exCompletedButton;
        private Panel buttonsPanel;
        private DataGridView trainPlanDataGridView;
        private Button startTrain;
        private Label ExerciseTitle;
        private Label exerciseCategoryTitle;
    }
}