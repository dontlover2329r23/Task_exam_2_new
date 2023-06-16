namespace Task_for_exam_2
{
    partial class Form1
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
            mainPanel = new Panel();
            btn = new Button();
            num1 = new TextBox();
            num2 = new TextBox();
            num3 = new TextBox();
            val_maxOX = new TextBox();
            val_maxOY = new TextBox();
            val_minOX = new TextBox();
            val_minOY = new TextBox();
            val_step = new TextBox();
            res = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            darkTheme = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(578, 426);
            mainPanel.TabIndex = 0;
            // 
            // btn
            // 
            btn.Location = new Point(683, 99);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 1;
            btn.Text = "Submit";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // num1
            // 
            num1.Location = new Point(672, 12);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 2;
            // 
            // num2
            // 
            num2.Location = new Point(672, 41);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 3;
            // 
            // num3
            // 
            num3.Location = new Point(672, 70);
            num3.Name = "num3";
            num3.Size = new Size(100, 23);
            num3.TabIndex = 4;
            // 
            // val_maxOX
            // 
            val_maxOX.Location = new Point(658, 155);
            val_maxOX.Name = "val_maxOX";
            val_maxOX.Size = new Size(100, 23);
            val_maxOX.TabIndex = 5;
            // 
            // val_maxOY
            // 
            val_maxOY.Location = new Point(658, 184);
            val_maxOY.Name = "val_maxOY";
            val_maxOY.Size = new Size(100, 23);
            val_maxOY.TabIndex = 6;
            // 
            // val_minOX
            // 
            val_minOX.Location = new Point(658, 243);
            val_minOX.Name = "val_minOX";
            val_minOX.Size = new Size(100, 23);
            val_minOX.TabIndex = 7;
            // 
            // val_minOY
            // 
            val_minOY.Location = new Point(658, 272);
            val_minOY.Name = "val_minOY";
            val_minOY.Size = new Size(100, 23);
            val_minOY.TabIndex = 8;
            // 
            // val_step
            // 
            val_step.Location = new Point(658, 313);
            val_step.Name = "val_step";
            val_step.Size = new Size(100, 23);
            val_step.TabIndex = 9;
            // 
            // res
            // 
            res.AutoSize = true;
            res.Location = new Point(702, 356);
            res.Name = "res";
            res.Size = new Size(13, 15);
            res.TabIndex = 10;
            res.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(647, 15);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 11;
            label1.Text = "a :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(647, 44);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 12;
            label2.Text = "b :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(647, 73);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 13;
            label3.Text = "c :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 158);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 14;
            label4.Text = "oX :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 187);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 15;
            label5.Text = "oY :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(625, 246);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 16;
            label6.Text = "oX :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(625, 275);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 17;
            label7.Text = "oY :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 316);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 18;
            label8.Text = "step :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(625, 220);
            label9.Name = "label9";
            label9.Size = new Size(146, 15);
            label9.TabIndex = 19;
            label9.Text = "Минимальные значения:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(621, 134);
            label10.Name = "label10";
            label10.Size = new Size(150, 15);
            label10.TabIndex = 20;
            label10.Text = "Максимальные значения:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(621, 356);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 21;
            label11.Text = "Результат: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3789229_business_grafik_management_media_presentation_icon;
            pictureBox1.Location = new Point(625, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // darkTheme
            // 
            darkTheme.Location = new Point(596, 7);
            darkTheme.Name = "darkTheme";
            darkTheme.Size = new Size(35, 23);
            darkTheme.TabIndex = 23;
            darkTheme.Text = "button1";
            darkTheme.UseVisualStyleBackColor = true;
            darkTheme.Click += darkTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(darkTheme);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(res);
            Controls.Add(val_step);
            Controls.Add(val_minOY);
            Controls.Add(val_minOX);
            Controls.Add(val_maxOY);
            Controls.Add(val_maxOX);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(btn);
            Controls.Add(mainPanel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button btn;
        private TextBox num1;
        private TextBox num2;
        private TextBox num3;
        private TextBox val_maxOX;
        private TextBox val_maxOY;
        private TextBox val_minOX;
        private TextBox val_minOY;
        private TextBox val_step;
        private Label res;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Button darkTheme;
    }
}