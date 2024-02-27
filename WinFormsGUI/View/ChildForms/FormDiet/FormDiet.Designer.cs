namespace WinFormsGUI.View
{
    partial class FormDiet
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
            eatingsDataGridView = new DataGridView();
            AddNewEatingButton = new Button();
            DeleteEatingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)eatingsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eatingsDataGridView
            // 
            eatingsDataGridView.BackgroundColor = SystemColors.Window;
            eatingsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eatingsDataGridView.Location = new Point(12, 12);
            eatingsDataGridView.Name = "eatingsDataGridView";
            eatingsDataGridView.Size = new Size(398, 358);
            eatingsDataGridView.TabIndex = 1;
            // 
            // AddNewEatingButton
            // 
            AddNewEatingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddNewEatingButton.BackColor = SystemColors.Window;
            AddNewEatingButton.FlatStyle = FlatStyle.Flat;
            AddNewEatingButton.Location = new Point(418, 12);
            AddNewEatingButton.Name = "AddNewEatingButton";
            AddNewEatingButton.Size = new Size(157, 27);
            AddNewEatingButton.TabIndex = 2;
            AddNewEatingButton.Text = "Добавить приём пищи";
            AddNewEatingButton.UseVisualStyleBackColor = false;
            AddNewEatingButton.Click += AddNewEatingButton_Click;
            // 
            // DeleteEatingButton
            // 
            DeleteEatingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEatingButton.BackColor = SystemColors.Window;
            DeleteEatingButton.FlatStyle = FlatStyle.Flat;
            DeleteEatingButton.Location = new Point(418, 45);
            DeleteEatingButton.Name = "DeleteEatingButton";
            DeleteEatingButton.Size = new Size(157, 27);
            DeleteEatingButton.TabIndex = 3;
            DeleteEatingButton.Text = "Удалить приём пищи";
            DeleteEatingButton.UseVisualStyleBackColor = false;
            DeleteEatingButton.Click += DeleteEatingButton_Click;
            // 
            // FormDiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteEatingButton);
            Controls.Add(AddNewEatingButton);
            Controls.Add(eatingsDataGridView);
            Name = "FormDiet";
            Text = "Питание";
            Load += FormDiet_Load;
            ((System.ComponentModel.ISupportInitialize)eatingsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView eatingsDataGridView;
        private Button AddNewEatingButton;
        private Button DeleteEatingButton;
    }
}