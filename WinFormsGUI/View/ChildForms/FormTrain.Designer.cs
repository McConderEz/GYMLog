namespace WinFormsGUI.View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrain));
            rightButton = new PictureBox();
            leftButton = new PictureBox();
            exCompletedButton = new PictureBox();
            buttonsPanel = new Panel();
            trainPlanDataGridView = new DataGridView();
            startTrain = new Button();
            ExerciseDataGridView = new DataGridView();
            trainTime = new System.Windows.Forms.Timer(components);
            time = new Label();
            startExButton = new PictureBox();
            endTrainButton = new Button();
            exerciseTime = new Label();
            exerciseMakeTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)rightButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exCompletedButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainPlanDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExerciseDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startExButton).BeginInit();
            SuspendLayout();
            // 
            // rightButton
            // 
            rightButton.Image = Properties.Resources.icons8_стрелка_вправо_в_круге_50;
            rightButton.Location = new Point(527, 390);
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
            leftButton.Location = new Point(318, 390);
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
            exCompletedButton.Location = new Point(456, 390);
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
            buttonsPanel.BorderStyle = BorderStyle.FixedSingle;
            buttonsPanel.Location = new Point(318, 236);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(254, 148);
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
            startTrain.Location = new Point(12, 390);
            startTrain.Name = "startTrain";
            startTrain.Size = new Size(152, 27);
            startTrain.TabIndex = 29;
            startTrain.Text = "Начать тренировку";
            startTrain.UseVisualStyleBackColor = false;
            startTrain.Click += startTrain_Click;
            // 
            // ExerciseDataGridView
            // 
            ExerciseDataGridView.BackgroundColor = SystemColors.Window;
            ExerciseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExerciseDataGridView.Location = new Point(318, 12);
            ExerciseDataGridView.Name = "ExerciseDataGridView";
            ExerciseDataGridView.Size = new Size(254, 218);
            ExerciseDataGridView.TabIndex = 32;
            // 
            // trainTime
            // 
            trainTime.Tick += trainTime_Tick;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(578, 12);
            time.Name = "time";
            time.Size = new Size(0, 15);
            time.TabIndex = 33;
            // 
            // startExButton
            // 
            startExButton.Image = (Image)resources.GetObject("startExButton.Image");
            startExButton.Location = new Point(389, 390);
            startExButton.Name = "startExButton";
            startExButton.Size = new Size(45, 38);
            startExButton.SizeMode = PictureBoxSizeMode.Zoom;
            startExButton.TabIndex = 34;
            startExButton.TabStop = false;
            startExButton.Click += startExButton_Click;
            startExButton.MouseLeave += startExButton_MouseLeave;
            startExButton.MouseMove += startExButton_MouseMove;
            // 
            // endTrainButton
            // 
            endTrainButton.BackColor = SystemColors.Window;
            endTrainButton.FlatStyle = FlatStyle.Flat;
            endTrainButton.Location = new Point(170, 390);
            endTrainButton.Name = "endTrainButton";
            endTrainButton.Size = new Size(142, 27);
            endTrainButton.TabIndex = 35;
            endTrainButton.Text = "Закончить тренировку";
            endTrainButton.UseVisualStyleBackColor = false;
            endTrainButton.Click += endTrainButton_Click;
            // 
            // exerciseTime
            // 
            exerciseTime.AutoSize = true;
            exerciseTime.Location = new Point(578, 236);
            exerciseTime.Name = "exerciseTime";
            exerciseTime.Size = new Size(0, 15);
            exerciseTime.TabIndex = 36;
            // 
            // exerciseMakeTime
            // 
            exerciseMakeTime.Tick += exerciseMakeTime_Tick;
            // 
            // FormTrain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(exerciseTime);
            Controls.Add(endTrainButton);
            Controls.Add(startExButton);
            Controls.Add(time);
            Controls.Add(ExerciseDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)ExerciseDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)startExButton).EndInit();
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
        private DataGridView ExerciseDataGridView;
        private System.Windows.Forms.Timer trainTime;
        private Label time;
        private PictureBox startExButton;
        private Button endTrainButton;
        private Label exerciseTime;
        private System.Windows.Forms.Timer exerciseMakeTime;
    }
}