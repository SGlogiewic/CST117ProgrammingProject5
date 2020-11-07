namespace CST117ProgrammingProject5
{
    partial class LuckyNumber
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
            this.comboBox1_birthYear = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.comboBox2_birthMonth = new System.Windows.Forms.ComboBox();
            this.comboBox3_birthday = new System.Windows.Forms.ComboBox();
            this.comboBox4_color = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1_birthYear
            // 
            this.comboBox1_birthYear.FormattingEnabled = true;
            this.comboBox1_birthYear.Location = new System.Drawing.Point(413, 43);
            this.comboBox1_birthYear.Name = "comboBox1_birthYear";
            this.comboBox1_birthYear.Size = new System.Drawing.Size(121, 28);
            this.comboBox1_birthYear.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(70, 40);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(263, 31);
            this.Year.TabIndex = 1;
            this.Year.Text = "Enter your birth year:";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.Location = new System.Drawing.Point(70, 122);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(289, 31);
            this.Month.TabIndex = 2;
            this.Month.Text = "Enter your birth month:";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(70, 201);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(256, 31);
            this.Day.TabIndex = 3;
            this.Day.Text = "Enter your birth day:";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(70, 281);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(301, 31);
            this.Color.TabIndex = 4;
            this.Color.Text = "Enter your favorite color:";
            // 
            // comboBox2_birthMonth
            // 
            this.comboBox2_birthMonth.FormattingEnabled = true;
            this.comboBox2_birthMonth.Location = new System.Drawing.Point(412, 125);
            this.comboBox2_birthMonth.Name = "comboBox2_birthMonth";
            this.comboBox2_birthMonth.Size = new System.Drawing.Size(121, 28);
            this.comboBox2_birthMonth.TabIndex = 5;
            // 
            // comboBox3_birthday
            // 
            this.comboBox3_birthday.FormattingEnabled = true;
            this.comboBox3_birthday.Location = new System.Drawing.Point(412, 204);
            this.comboBox3_birthday.Name = "comboBox3_birthday";
            this.comboBox3_birthday.Size = new System.Drawing.Size(121, 28);
            this.comboBox3_birthday.TabIndex = 6;
            // 
            // comboBox4_color
            // 
            this.comboBox4_color.FormattingEnabled = true;
            this.comboBox4_color.Location = new System.Drawing.Point(413, 284);
            this.comboBox4_color.Name = "comboBox4_color";
            this.comboBox4_color.Size = new System.Drawing.Size(121, 28);
            this.comboBox4_color.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Location = new System.Drawing.Point(242, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get Lucky Number!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LuckyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(637, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4_color);
            this.Controls.Add(this.comboBox3_birthday);
            this.Controls.Add(this.comboBox2_birthMonth);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.comboBox1_birthYear);
            this.Name = "LuckyNumber";
            this.Text = "LuckyNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_birthYear;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox comboBox2_birthMonth;
        private System.Windows.Forms.ComboBox comboBox3_birthday;
        private System.Windows.Forms.ComboBox comboBox4_color;
        public System.Windows.Forms.Button button1;
    }
}

