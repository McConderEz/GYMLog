namespace WinFormsGUI.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sideBar = new Panel();
            dietButton = new Button();
            rateButton = new Button();
            trainPlanButton = new Button();
            trainButton = new Button();
            ownStatButton = new Button();
            topSideBar = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelTitle = new Panel();
            titleLabel = new Label();
            panelDesktopPanel = new Panel();
            sideBar.SuspendLayout();
            topSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(51, 51, 76);
            sideBar.Controls.Add(dietButton);
            sideBar.Controls.Add(rateButton);
            sideBar.Controls.Add(trainPlanButton);
            sideBar.Controls.Add(trainButton);
            sideBar.Controls.Add(ownStatButton);
            sideBar.Controls.Add(topSideBar);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(241, 601);
            sideBar.TabIndex = 0;
            // 
            // dietButton
            // 
            dietButton.Dock = DockStyle.Top;
            dietButton.FlatAppearance.BorderSize = 0;
            dietButton.FlatStyle = FlatStyle.Flat;
            dietButton.ForeColor = Color.Gainsboro;
            dietButton.Image = (Image)resources.GetObject("dietButton.Image");
            dietButton.ImageAlign = ContentAlignment.MiddleLeft;
            dietButton.Location = new Point(0, 320);
            dietButton.Name = "dietButton";
            dietButton.Size = new Size(241, 60);
            dietButton.TabIndex = 6;
            dietButton.Text = "Питание";
            dietButton.UseVisualStyleBackColor = true;
            dietButton.Click += dietButton_Click;
            // 
            // rateButton
            // 
            rateButton.Dock = DockStyle.Top;
            rateButton.FlatAppearance.BorderSize = 0;
            rateButton.FlatStyle = FlatStyle.Flat;
            rateButton.ForeColor = Color.Gainsboro;
            rateButton.Image = (Image)resources.GetObject("rateButton.Image");
            rateButton.ImageAlign = ContentAlignment.MiddleLeft;
            rateButton.Location = new Point(0, 260);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(241, 60);
            rateButton.TabIndex = 5;
            rateButton.Text = "Рейтинг";
            rateButton.UseVisualStyleBackColor = true;
            rateButton.Click += rateButton_Click;
            // 
            // trainPlanButton
            // 
            trainPlanButton.Dock = DockStyle.Top;
            trainPlanButton.FlatAppearance.BorderSize = 0;
            trainPlanButton.FlatStyle = FlatStyle.Flat;
            trainPlanButton.ForeColor = Color.Gainsboro;
            trainPlanButton.Image = (Image)resources.GetObject("trainPlanButton.Image");
            trainPlanButton.ImageAlign = ContentAlignment.MiddleLeft;
            trainPlanButton.Location = new Point(0, 200);
            trainPlanButton.Name = "trainPlanButton";
            trainPlanButton.Size = new Size(241, 60);
            trainPlanButton.TabIndex = 4;
            trainPlanButton.Text = "План тренировки";
            trainPlanButton.UseVisualStyleBackColor = true;
            trainPlanButton.Click += trainPlanButton_Click;
            // 
            // trainButton
            // 
            trainButton.Dock = DockStyle.Top;
            trainButton.FlatAppearance.BorderSize = 0;
            trainButton.FlatStyle = FlatStyle.Flat;
            trainButton.ForeColor = Color.Gainsboro;
            trainButton.Image = (Image)resources.GetObject("trainButton.Image");
            trainButton.ImageAlign = ContentAlignment.MiddleLeft;
            trainButton.Location = new Point(0, 140);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(241, 60);
            trainButton.TabIndex = 3;
            trainButton.Text = "Тренировка";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += trainButton_Click;
            // 
            // ownStatButton
            // 
            ownStatButton.Dock = DockStyle.Top;
            ownStatButton.FlatAppearance.BorderSize = 0;
            ownStatButton.FlatStyle = FlatStyle.Flat;
            ownStatButton.ForeColor = Color.Gainsboro;
            ownStatButton.Image = (Image)resources.GetObject("ownStatButton.Image");
            ownStatButton.ImageAlign = ContentAlignment.MiddleLeft;
            ownStatButton.Location = new Point(0, 80);
            ownStatButton.Name = "ownStatButton";
            ownStatButton.Size = new Size(241, 60);
            ownStatButton.TabIndex = 2;
            ownStatButton.Text = "Личная статистика";
            ownStatButton.UseVisualStyleBackColor = true;
            ownStatButton.Click += ownStatButton_Click;
            // 
            // topSideBar
            // 
            topSideBar.BackColor = Color.FromArgb(39, 39, 58);
            topSideBar.Controls.Add(pictureBox1);
            topSideBar.Controls.Add(label1);
            topSideBar.Dock = DockStyle.Top;
            topSideBar.Location = new Point(0, 0);
            topSideBar.Name = "topSideBar";
            topSideBar.Size = new Size(241, 80);
            topSideBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 2;
            label1.Text = "GYMLog";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(46, 148, 191);
            panelTitle.Controls.Add(titleLabel);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(241, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(903, 80);
            panelTitle.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(392, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(118, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "ГЛАВНАЯ";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(241, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(903, 521);
            panelDesktopPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 601);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitle);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GYMLog";
            sideBar.ResumeLayout(false);
            topSideBar.ResumeLayout(false);
            topSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Panel topSideBar;
        private Button ownStatButton;
        private Button dietButton;
        private Button rateButton;
        private Button trainPlanButton;
        private Button trainButton;
        private Panel panelTitle;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelDesktopPanel;
    }
}