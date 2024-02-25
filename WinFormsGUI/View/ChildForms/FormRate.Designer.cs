namespace WinFormsGUI.View
{
    partial class FormRate
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
            rateDataGridView = new DataGridView();
            indicator = new Label();
            activityCountRateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)rateDataGridView).BeginInit();
            SuspendLayout();
            // 
            // rateDataGridView
            // 
            rateDataGridView.BackgroundColor = SystemColors.Window;
            rateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rateDataGridView.Location = new Point(12, 12);
            rateDataGridView.Name = "rateDataGridView";
            rateDataGridView.Size = new Size(385, 426);
            rateDataGridView.TabIndex = 0;
            // 
            // indicator
            // 
            indicator.AutoSize = true;
            indicator.Font = new Font("ROG Fonts", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            indicator.Location = new Point(403, 12);
            indicator.Name = "indicator";
            indicator.Size = new Size(81, 25);
            indicator.TabIndex = 1;
            indicator.Text = "Рейтинг";
            // 
            // activityCountRateButton
            // 
            activityCountRateButton.BackColor = SystemColors.Window;
            activityCountRateButton.FlatStyle = FlatStyle.Flat;
            activityCountRateButton.Location = new Point(403, 40);
            activityCountRateButton.Name = "activityCountRateButton";
            activityCountRateButton.Size = new Size(162, 28);
            activityCountRateButton.TabIndex = 2;
            activityCountRateButton.Text = "Лучшие по активности";
            activityCountRateButton.UseVisualStyleBackColor = false;
            activityCountRateButton.Click += activityCountRateButton_Click;
            // 
            // FormRate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(activityCountRateButton);
            Controls.Add(indicator);
            Controls.Add(rateDataGridView);
            Name = "FormRate";
            Text = "Рейтинг";
            Load += FormRate_Load;
            ((System.ComponentModel.ISupportInitialize)rateDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView rateDataGridView;
        private Label indicator;
        private Button activityCountRateButton;
    }
}