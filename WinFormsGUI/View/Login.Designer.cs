
namespace WinFormsGUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userNameTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            passwordTextBox = new TextBox();
            exitButton = new Label();
            hideButton = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            logoLabel = new Label();
            loginButton = new Button();
            signUpButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Location = new Point(89, 202);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(250, 25);
            userNameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(89, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(89, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(89, 256);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 25);
            passwordTextBox.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(367, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 5;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // hideButton
            // 
            hideButton.AutoSize = true;
            hideButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hideButton.Location = new Point(342, 9);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(17, 21);
            hideButton.TabIndex = 6;
            hideButton.Text = "_";
            hideButton.Click += hideButton_Click;
            hideButton.MouseLeave += hideButton_MouseLeave;
            hideButton.MouseMove += hideButton_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(154, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.BackColor = Color.White;
            logoLabel.Font = new Font("AniMe Matrix - MB_EN", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.Black;
            logoLabel.Location = new Point(117, 106);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(168, 32);
            logoLabel.TabIndex = 10;
            logoLabel.Text = "GYMLog";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ButtonHighlight;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(144, 452);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(141, 29);
            loginButton.TabIndex = 11;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.AutoSize = true;
            signUpButton.Location = new Point(164, 484);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(107, 15);
            signUpButton.TabIndex = 12;
            signUpButton.Text = "Ещё нет аккаунта?";
            signUpButton.Click += signUpButton_Click;
            signUpButton.MouseLeave += signUpButton_MouseLeave;
            signUpButton.MouseMove += signUpButton_MouseMove;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(398, 529);
            Controls.Add(signUpButton);
            Controls.Add(loginButton);
            Controls.Add(logoLabel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(hideButton);
            Controls.Add(exitButton);
            Controls.Add(passwordTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(userNameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox userNameTextBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox passwordTextBox;
        private Label exitButton;
        private Label hideButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label logoLabel;
        private Button loginButton;
        private Label signUpButton;
    }
}
