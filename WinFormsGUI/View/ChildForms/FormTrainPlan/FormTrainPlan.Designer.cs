﻿namespace WinFormsGUI.View
{
    partial class FormTrainPlan
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
            trainPlanDataGridView = new DataGridView();
            addPlanButton = new Button();
            deletePlanButton = new Button();
            changeTrainPlan = new Button();
            ExerciseDataGridView = new DataGridView();
            OutputExerciseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)trainPlanDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExerciseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // trainPlanDataGridView
            // 
            trainPlanDataGridView.BorderStyle = BorderStyle.None;
            trainPlanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainPlanDataGridView.Location = new Point(12, 12);
            trainPlanDataGridView.Name = "trainPlanDataGridView";
            trainPlanDataGridView.Size = new Size(329, 305);
            trainPlanDataGridView.TabIndex = 0;
            // 
            // addPlanButton
            // 
            addPlanButton.Anchor = AnchorStyles.Left;
            addPlanButton.FlatStyle = FlatStyle.Flat;
            addPlanButton.Location = new Point(12, 323);
            addPlanButton.Name = "addPlanButton";
            addPlanButton.Size = new Size(172, 29);
            addPlanButton.TabIndex = 1;
            addPlanButton.Text = "Добавить план тренировки";
            addPlanButton.UseVisualStyleBackColor = true;
            addPlanButton.Click += addPlanButton_Click;
            // 
            // deletePlanButton
            // 
            deletePlanButton.Anchor = AnchorStyles.Left;
            deletePlanButton.FlatStyle = FlatStyle.Flat;
            deletePlanButton.Location = new Point(12, 358);
            deletePlanButton.Name = "deletePlanButton";
            deletePlanButton.Size = new Size(172, 29);
            deletePlanButton.TabIndex = 2;
            deletePlanButton.Text = "Удалить план тренировки";
            deletePlanButton.UseVisualStyleBackColor = true;
            deletePlanButton.Click += deletePlanButton_Click;
            // 
            // changeTrainPlan
            // 
            changeTrainPlan.Anchor = AnchorStyles.Left;
            changeTrainPlan.FlatStyle = FlatStyle.Flat;
            changeTrainPlan.Location = new Point(12, 393);
            changeTrainPlan.Name = "changeTrainPlan";
            changeTrainPlan.Size = new Size(172, 29);
            changeTrainPlan.TabIndex = 3;
            changeTrainPlan.Text = "Изменить план тренировки";
            changeTrainPlan.UseVisualStyleBackColor = true;
            changeTrainPlan.Click += changeTrainPlan_Click;
            // 
            // ExerciseDataGridView
            // 
            ExerciseDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExerciseDataGridView.BorderStyle = BorderStyle.None;
            ExerciseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExerciseDataGridView.Location = new Point(347, 12);
            ExerciseDataGridView.Name = "ExerciseDataGridView";
            ExerciseDataGridView.Size = new Size(441, 305);
            ExerciseDataGridView.TabIndex = 4;
            // 
            // OutputExerciseButton
            // 
            OutputExerciseButton.Anchor = AnchorStyles.Right;
            OutputExerciseButton.FlatStyle = FlatStyle.Flat;
            OutputExerciseButton.Location = new Point(347, 323);
            OutputExerciseButton.Name = "OutputExerciseButton";
            OutputExerciseButton.Size = new Size(172, 29);
            OutputExerciseButton.TabIndex = 5;
            OutputExerciseButton.Text = "Вывести упражнения плана";
            OutputExerciseButton.UseVisualStyleBackColor = true;
            OutputExerciseButton.Click += OutputExerciseButton_Click;
            // 
            // FormTrainPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(OutputExerciseButton);
            Controls.Add(ExerciseDataGridView);
            Controls.Add(changeTrainPlan);
            Controls.Add(deletePlanButton);
            Controls.Add(addPlanButton);
            Controls.Add(trainPlanDataGridView);
            Name = "FormTrainPlan";
            Text = "План тренировки";
            Load += FormTrainPlan_Load;
            ((System.ComponentModel.ISupportInitialize)trainPlanDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExerciseDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView trainPlanDataGridView;
        private Button addPlanButton;
        private Button deletePlanButton;
        private Button changeTrainPlan;
        private DataGridView ExerciseDataGridView;
        private Button OutputExerciseButton;
    }
}