namespace WinFormsGUI.View
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            loginButton = new Label();
            regButton = new Button();
            logoLabel = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            hideButton = new Label();
            exitButton = new Label();
            passwordTextBox = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            userNameTextBox = new TextBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            heightTextBox = new TextBox();
            panel5 = new Panel();
            pictureBox7 = new PictureBox();
            weightTextBox = new TextBox();
            panel6 = new Panel();
            genderComboBox = new ComboBox();
            ageTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.AutoSize = true;
            loginButton.Location = new Point(154, 513);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(105, 15);
            loginButton.TabIndex = 24;
            loginButton.Text = "Уже есть аккаунт?";
            loginButton.Click += loginButton_Click;
            loginButton.MouseLeave += loginButton_MouseLeave;
            loginButton.MouseMove += loginButton_MouseMove;
            // 
            // regButton
            // 
            regButton.BackColor = SystemColors.ButtonHighlight;
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Location = new Point(134, 481);
            regButton.Name = "regButton";
            regButton.Size = new Size(141, 29);
            regButton.TabIndex = 23;
            regButton.Text = "Зарегистрироваться";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.BackColor = Color.White;
            logoLabel.Font = new Font("AniMe Matrix - MB_EN", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.Black;
            logoLabel.Location = new Point(107, 101);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(168, 32);
            logoLabel.TabIndex = 22;
            logoLabel.Text = "GYMLog";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(144, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(39, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // hideButton
            // 
            hideButton.AutoSize = true;
            hideButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hideButton.Location = new Point(332, 4);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(17, 21);
            hideButton.TabIndex = 18;
            hideButton.Text = "_";
            hideButton.Click += hideButton_Click;
            hideButton.MouseLeave += hideButton_MouseLeave;
            hideButton.MouseMove += hideButton_MouseMove;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(357, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 17;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(81, 208);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 25);
            passwordTextBox.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(81, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(81, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 14;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Location = new Point(81, 166);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(250, 25);
            userNameTextBox.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(39, 245);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(81, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 25;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(39, 289);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(81, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 28;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(39, 333);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // heightTextBox
            // 
            heightTextBox.BorderStyle = BorderStyle.None;
            heightTextBox.Location = new Point(81, 341);
            heightTextBox.Multiline = true;
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(250, 25);
            heightTextBox.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(81, 368);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 1);
            panel5.TabIndex = 31;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(39, 376);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            // 
            // weightTextBox
            // 
            weightTextBox.BorderStyle = BorderStyle.None;
            weightTextBox.Location = new Point(81, 384);
            weightTextBox.Multiline = true;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(250, 25);
            weightTextBox.TabIndex = 35;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(81, 411);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 1);
            panel6.TabIndex = 34;
            // 
            // genderComboBox
            // 
            genderComboBox.FlatStyle = FlatStyle.Flat;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            genderComboBox.Location = new Point(81, 251);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(250, 23);
            genderComboBox.TabIndex = 37;
            // 
            // ageTimePicker
            // 
            ageTimePicker.Format = DateTimePickerFormat.Short;
            ageTimePicker.Location = new Point(81, 299);
            ageTimePicker.Name = "ageTimePicker";
            ageTimePicker.Size = new Size(250, 23);
            ageTimePicker.TabIndex = 38;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(382, 540);
            Controls.Add(ageTimePicker);
            Controls.Add(genderComboBox);
            Controls.Add(pictureBox7);
            Controls.Add(weightTextBox);
            Controls.Add(panel6);
            Controls.Add(pictureBox6);
            Controls.Add(heightTextBox);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(panel3);
            Controls.Add(loginButton);
            Controls.Add(regButton);
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
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginButton;
        private Button regButton;
        private Label logoLabel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label hideButton;
        private Label exitButton;
        private TextBox passwordTextBox;
        private Panel panel2;
        private Panel panel1;
        private TextBox userNameTextBox;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Panel panel4;
        private PictureBox pictureBox6;
        private TextBox heightTextBox;
        private Panel panel5;
        private PictureBox pictureBox7;
        private TextBox weightTextBox;
        private Panel panel6;
        private ComboBox genderComboBox;
        private DateTimePicker ageTimePicker;
    }
}