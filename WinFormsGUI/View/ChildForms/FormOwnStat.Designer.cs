namespace WinFormsGUI.View
{
    partial class FormOwnStat
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
            nameLabel = new Label();
            birthdayLabel = new Label();
            genderLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            activityDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)activityDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft YaHei", 9.75F);
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(132, 19);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя пользователя:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Microsoft YaHei", 9.75F);
            birthdayLabel.Location = new Point(12, 28);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(111, 19);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Microsoft YaHei", 9.75F);
            genderLabel.Location = new Point(12, 47);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(38, 19);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Пол:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Microsoft YaHei", 9.75F);
            heightLabel.Location = new Point(12, 66);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(41, 19);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Рост:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Microsoft YaHei", 9.75F);
            weightLabel.Location = new Point(12, 85);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(34, 19);
            weightLabel.TabIndex = 4;
            weightLabel.Text = "Вес:";
            // 
            // activityDataGridView
            // 
            activityDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            activityDataGridView.BackgroundColor = SystemColors.Window;
            activityDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activityDataGridView.Location = new Point(342, 9);
            activityDataGridView.Name = "activityDataGridView";
            activityDataGridView.Size = new Size(446, 429);
            activityDataGridView.TabIndex = 5;
            // 
            // FormOwnStat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(activityDataGridView);
            Controls.Add(weightLabel);
            Controls.Add(heightLabel);
            Controls.Add(genderLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(nameLabel);
            Name = "FormOwnStat";
            Text = "Личная статистика";
            Load += FormOwnStat_Load;
            ((System.ComponentModel.ISupportInitialize)activityDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label birthdayLabel;
        private Label genderLabel;
        private Label heightLabel;
        private Label weightLabel;
        private DataGridView activityDataGridView;
    }
}