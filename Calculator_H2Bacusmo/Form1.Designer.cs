namespace Calculator_H2Bacusmo
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            AllClear = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            multiply = new Button();
            subtraction = new Button();
            addition = new Button();
            Del = new Button();
            Divide = new Button();
            Equal = new Button();
            tb_display = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(69, 62);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BNum;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 213);
            button2.Name = "button2";
            button2.Size = new Size(69, 62);
            button2.TabIndex = 1;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BNum;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(87, 145);
            button3.Name = "button3";
            button3.Size = new Size(69, 62);
            button3.TabIndex = 1;
            button3.Text = "8";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BNum;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(87, 213);
            button4.Name = "button4";
            button4.Size = new Size(69, 62);
            button4.TabIndex = 2;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BNum;
            // 
            // button5
            // 
            button5.BackColor = Color.LightBlue;
            button5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(162, 145);
            button5.Name = "button5";
            button5.Size = new Size(69, 62);
            button5.TabIndex = 3;
            button5.Text = "9";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BNum;
            // 
            // button6
            // 
            button6.BackColor = Color.LightBlue;
            button6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(162, 213);
            button6.Name = "button6";
            button6.Size = new Size(69, 62);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BNum;
            // 
            // button7
            // 
            button7.BackColor = Color.LightBlue;
            button7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(12, 281);
            button7.Name = "button7";
            button7.Size = new Size(69, 62);
            button7.TabIndex = 5;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += BNum;
            // 
            // button8
            // 
            button8.BackColor = Color.LightBlue;
            button8.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(87, 281);
            button8.Name = "button8";
            button8.Size = new Size(69, 62);
            button8.TabIndex = 6;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += BNum;
            // 
            // button9
            // 
            button9.BackColor = Color.LightBlue;
            button9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(162, 281);
            button9.Name = "button9";
            button9.Size = new Size(69, 62);
            button9.TabIndex = 7;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += BNum;
            // 
            // AllClear
            // 
            AllClear.BackColor = Color.LightBlue;
            AllClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            AllClear.Location = new Point(12, 349);
            AllClear.Name = "AllClear";
            AllClear.Size = new Size(69, 62);
            AllClear.TabIndex = 8;
            AllClear.Text = "AC";
            AllClear.UseVisualStyleBackColor = false;
            AllClear.Click += AllClear_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.LightBlue;
            button11.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(87, 349);
            button11.Name = "button11";
            button11.Size = new Size(69, 62);
            button11.TabIndex = 9;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += BNum;
            // 
            // button12
            // 
            button12.BackColor = Color.LightBlue;
            button12.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(162, 349);
            button12.Name = "button12";
            button12.Size = new Size(69, 62);
            button12.TabIndex = 10;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ActiveCaption;
            button13.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(261, 145);
            button13.Name = "button13";
            button13.Size = new Size(69, 62);
            button13.TabIndex = 11;
            button13.Text = "+/-";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.ActiveCaption;
            multiply.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            multiply.Location = new Point(261, 213);
            multiply.Name = "multiply";
            multiply.Size = new Size(69, 62);
            multiply.TabIndex = 12;
            multiply.Text = "x";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // subtraction
            // 
            subtraction.BackColor = SystemColors.ActiveCaption;
            subtraction.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            subtraction.Location = new Point(261, 281);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(69, 62);
            subtraction.TabIndex = 13;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = false;
            subtraction.Click += subtraction_Click;
            // 
            // addition
            // 
            addition.BackColor = SystemColors.ActiveCaption;
            addition.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            addition.Location = new Point(261, 349);
            addition.Name = "addition";
            addition.Size = new Size(69, 62);
            addition.TabIndex = 14;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = false;
            addition.Click += button16_Click;
            // 
            // Del
            // 
            Del.BackColor = SystemColors.ActiveCaption;
            Del.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Del.Location = new Point(336, 145);
            Del.Name = "Del";
            Del.Size = new Size(69, 62);
            Del.TabIndex = 15;
            Del.Text = "Del";
            Del.UseVisualStyleBackColor = false;
            Del.Click += Del_Click;
            // 
            // Divide
            // 
            Divide.BackColor = SystemColors.ActiveCaption;
            Divide.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Divide.Location = new Point(336, 213);
            Divide.Name = "Divide";
            Divide.Size = new Size(69, 62);
            Divide.TabIndex = 16;
            Divide.Text = "÷";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += button18_Click;
            // 
            // Equal
            // 
            Equal.BackColor = SystemColors.ActiveCaption;
            Equal.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Equal.Location = new Point(336, 281);
            Equal.Name = "Equal";
            Equal.Size = new Size(69, 130);
            Equal.TabIndex = 17;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // tb_display
            // 
            tb_display.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            tb_display.Location = new Point(12, 36);
            tb_display.Multiline = true;
            tb_display.Name = "tb_display";
            tb_display.Size = new Size(393, 83);
            tb_display.TabIndex = 18;
            tb_display.Text = "0";
            tb_display.TextAlign = HorizontalAlignment.Right;
            tb_display.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(412, 423);
            Controls.Add(tb_display);
            Controls.Add(Equal);
            Controls.Add(Divide);
            Controls.Add(Del);
            Controls.Add(addition);
            Controls.Add(subtraction);
            Controls.Add(multiply);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(AllClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button AllClear;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button multiply;
        private Button subtraction;
        private Button addition;
        private Button Del;
        private Button Divide;
        private Button Equal;
        private TextBox tb_display;
    }
}