namespace WinFormsGUI.View.ChildForms.FormDiet
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            addButton = new Button();
            exitButton = new Label();
            panel1 = new Panel();
            foodName = new TextBox();
            panel2 = new Panel();
            proteinsTextBox = new TextBox();
            panel3 = new Panel();
            fatsTextBox = new TextBox();
            panel4 = new Panel();
            carbohydratesTextBox = new TextBox();
            panel5 = new Panel();
            caloriesTextBox = new TextBox();
            panel6 = new Panel();
            weightTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(68, 47);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(198, 16);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Добавление приёма пищи";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(116, 429);
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
            exitButton.Location = new Point(286, 8);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(19, 21);
            exitButton.TabIndex = 16;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseMove += exitButton_MouseMove;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(37, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 14;
            // 
            // foodName
            // 
            foodName.BackColor = SystemColors.Window;
            foodName.BorderStyle = BorderStyle.None;
            foodName.Location = new Point(37, 126);
            foodName.Multiline = true;
            foodName.Name = "foodName";
            foodName.PlaceholderText = "Название еды";
            foodName.Size = new Size(250, 25);
            foodName.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(37, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 21;
            // 
            // proteinsTextBox
            // 
            proteinsTextBox.BackColor = SystemColors.Window;
            proteinsTextBox.BorderStyle = BorderStyle.None;
            proteinsTextBox.Location = new Point(37, 160);
            proteinsTextBox.Multiline = true;
            proteinsTextBox.Name = "proteinsTextBox";
            proteinsTextBox.PlaceholderText = "Белки";
            proteinsTextBox.Size = new Size(250, 25);
            proteinsTextBox.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(37, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 23;
            // 
            // fatsTextBox
            // 
            fatsTextBox.BackColor = SystemColors.Window;
            fatsTextBox.BorderStyle = BorderStyle.None;
            fatsTextBox.Location = new Point(37, 194);
            fatsTextBox.Multiline = true;
            fatsTextBox.Name = "fatsTextBox";
            fatsTextBox.PlaceholderText = "Жиры";
            fatsTextBox.Size = new Size(250, 25);
            fatsTextBox.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(37, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 25;
            // 
            // carbohydratesTextBox
            // 
            carbohydratesTextBox.BackColor = SystemColors.Window;
            carbohydratesTextBox.BorderStyle = BorderStyle.None;
            carbohydratesTextBox.Location = new Point(37, 228);
            carbohydratesTextBox.Multiline = true;
            carbohydratesTextBox.Name = "carbohydratesTextBox";
            carbohydratesTextBox.PlaceholderText = "Углеводы";
            carbohydratesTextBox.Size = new Size(250, 25);
            carbohydratesTextBox.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(37, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 1);
            panel5.TabIndex = 27;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.BackColor = SystemColors.Window;
            caloriesTextBox.BorderStyle = BorderStyle.None;
            caloriesTextBox.Location = new Point(37, 262);
            caloriesTextBox.Multiline = true;
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.PlaceholderText = "Калории";
            caloriesTextBox.Size = new Size(250, 25);
            caloriesTextBox.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(37, 323);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 1);
            panel6.TabIndex = 29;
            // 
            // weightTextBox
            // 
            weightTextBox.BackColor = SystemColors.Window;
            weightTextBox.BorderStyle = BorderStyle.None;
            weightTextBox.Location = new Point(37, 296);
            weightTextBox.Multiline = true;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.PlaceholderText = "Вес";
            weightTextBox.Size = new Size(250, 25);
            weightTextBox.TabIndex = 28;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(319, 467);
            Controls.Add(panel6);
            Controls.Add(weightTextBox);
            Controls.Add(panel5);
            Controls.Add(caloriesTextBox);
            Controls.Add(panel4);
            Controls.Add(carbohydratesTextBox);
            Controls.Add(panel3);
            Controls.Add(fatsTextBox);
            Controls.Add(panel2);
            Controls.Add(proteinsTextBox);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(addButton);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(foodName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Button addButton;
        private Label exitButton;
        private Panel panel1;
        private TextBox foodName;
        private Panel panel2;
        private TextBox proteinsTextBox;
        private Panel panel3;
        private TextBox fatsTextBox;
        private Panel panel4;
        private TextBox carbohydratesTextBox;
        private Panel panel5;
        private TextBox caloriesTextBox;
        private Panel panel6;
        private TextBox weightTextBox;
    }
}