namespace CalculatorApp
{
    partial class CalculateForm
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
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_step
            // 
            this.textBox_step.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_step.Location = new System.Drawing.Point(12, 12);
            this.textBox_step.Multiline = true;
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(180, 38);
            this.textBox_step.TabIndex = 0;
            this.textBox_step.Text = "0";
            this.textBox_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_result.Location = new System.Drawing.Point(12, 70);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(180, 38);
            this.textBox_result.TabIndex = 1;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(112, 114);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 35);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "退格";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 114);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 35);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "归零";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(100, 165);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(38, 33);
            this.btn_nine.TabIndex = 4;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(56, 165);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(38, 33);
            this.btn_eight.TabIndex = 5;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(12, 165);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(38, 33);
            this.btn_seven.TabIndex = 6;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(100, 204);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(38, 33);
            this.btn_six.TabIndex = 4;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(56, 204);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(38, 33);
            this.btn_five.TabIndex = 5;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(12, 204);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(38, 33);
            this.btn_four.TabIndex = 6;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(100, 243);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(38, 33);
            this.btn_three.TabIndex = 4;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(56, 243);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(38, 33);
            this.btn_two.TabIndex = 5;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(12, 243);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(38, 33);
            this.btn_one.TabIndex = 6;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(56, 282);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(38, 33);
            this.btn_zero.TabIndex = 5;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            // 
            // btn_point
            // 
            this.btn_point.Location = new System.Drawing.Point(12, 282);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(38, 33);
            this.btn_point.TabIndex = 5;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(100, 282);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(38, 33);
            this.btn_equal.TabIndex = 5;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(144, 165);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(48, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(144, 204);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(48, 33);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(144, 243);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(48, 33);
            this.btn_mult.TabIndex = 4;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(144, 282);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(48, 33);
            this.btn_div.TabIndex = 4;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 320);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_step);
            this.MaximizeBox = false;
            this.Name = "CalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
    }
}

