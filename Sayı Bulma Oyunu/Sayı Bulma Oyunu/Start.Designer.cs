namespace Sayı_Bulma_Oyunu
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.btn_NumOfDigits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RandNumOfDigits = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.cBoxRepetitive = new System.Windows.Forms.CheckBox();
            this.cBoxUnrepeated = new System.Windows.Forms.CheckBox();
            this.lbl_num10 = new System.Windows.Forms.Label();
            this.lbl_num9 = new System.Windows.Forms.Label();
            this.lbl_num8 = new System.Windows.Forms.Label();
            this.lbl_num7 = new System.Windows.Forms.Label();
            this.lbl_num6 = new System.Windows.Forms.Label();
            this.lbl_num5 = new System.Windows.Forms.Label();
            this.lbl_num4 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.btn_try = new System.Windows.Forms.Button();
            this.lbl_getNum = new System.Windows.Forms.Label();
            this.txt_numPredicted = new System.Windows.Forms.TextBox();
            this.numeric_NumOfDigits = new System.Windows.Forms.NumericUpDown();
            this.numeric_choseRight = new System.Windows.Forms.NumericUpDown();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_basNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NumOfDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_choseRight)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NumOfDigits
            // 
            this.btn_NumOfDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_NumOfDigits.Location = new System.Drawing.Point(286, 52);
            this.btn_NumOfDigits.Name = "btn_NumOfDigits";
            this.btn_NumOfDigits.Size = new System.Drawing.Size(75, 25);
            this.btn_NumOfDigits.TabIndex = 1;
            this.btn_NumOfDigits.Text = "Seçiniz";
            this.btn_NumOfDigits.UseVisualStyleBackColor = true;
            this.btn_NumOfDigits.Click += new System.EventHandler(this.btn_NumOfDigits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Basamak Sayısı Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rastgele Basamak Sayısı Seçiniz :";
            // 
            // btn_RandNumOfDigits
            // 
            this.btn_RandNumOfDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_RandNumOfDigits.Location = new System.Drawing.Point(286, 83);
            this.btn_RandNumOfDigits.Name = "btn_RandNumOfDigits";
            this.btn_RandNumOfDigits.Size = new System.Drawing.Size(75, 25);
            this.btn_RandNumOfDigits.TabIndex = 1;
            this.btn_RandNumOfDigits.Text = "Seçiniz";
            this.btn_RandNumOfDigits.UseVisualStyleBackColor = true;
            this.btn_RandNumOfDigits.Click += new System.EventHandler(this.btn_RandNumOfDigits_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(61, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hak Sayısı Belirleyin :";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Start.Location = new System.Drawing.Point(64, 274);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(125, 35);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Oyunu Başlat";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cBoxRepetitive
            // 
            this.cBoxRepetitive.AutoSize = true;
            this.cBoxRepetitive.Location = new System.Drawing.Point(64, 149);
            this.cBoxRepetitive.Name = "cBoxRepetitive";
            this.cBoxRepetitive.Size = new System.Drawing.Size(98, 17);
            this.cBoxRepetitive.TabIndex = 5;
            this.cBoxRepetitive.Text = "Rakam Tekrarlı";
            this.cBoxRepetitive.UseVisualStyleBackColor = true;
            this.cBoxRepetitive.CheckedChanged += new System.EventHandler(this.cBoxRepetitive_CheckedChanged);
            // 
            // cBoxUnrepeated
            // 
            this.cBoxUnrepeated.AutoSize = true;
            this.cBoxUnrepeated.Location = new System.Drawing.Point(64, 172);
            this.cBoxUnrepeated.Name = "cBoxUnrepeated";
            this.cBoxUnrepeated.Size = new System.Drawing.Size(106, 17);
            this.cBoxUnrepeated.TabIndex = 5;
            this.cBoxUnrepeated.Text = "Rakam Tekrarsız";
            this.cBoxUnrepeated.UseVisualStyleBackColor = true;
            this.cBoxUnrepeated.CheckedChanged += new System.EventHandler(this.cBoxUnrepeated_CheckedChanged);
            // 
            // lbl_num10
            // 
            this.lbl_num10.AutoSize = true;
            this.lbl_num10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num10.Location = new System.Drawing.Point(385, 327);
            this.lbl_num10.Name = "lbl_num10";
            this.lbl_num10.Size = new System.Drawing.Size(36, 25);
            this.lbl_num10.TabIndex = 12;
            this.lbl_num10.Text = "__";
            this.lbl_num10.Visible = false;
            // 
            // lbl_num9
            // 
            this.lbl_num9.AutoSize = true;
            this.lbl_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num9.Location = new System.Drawing.Point(343, 327);
            this.lbl_num9.Name = "lbl_num9";
            this.lbl_num9.Size = new System.Drawing.Size(36, 25);
            this.lbl_num9.TabIndex = 13;
            this.lbl_num9.Text = "__";
            this.lbl_num9.Visible = false;
            // 
            // lbl_num8
            // 
            this.lbl_num8.AutoSize = true;
            this.lbl_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num8.Location = new System.Drawing.Point(301, 327);
            this.lbl_num8.Name = "lbl_num8";
            this.lbl_num8.Size = new System.Drawing.Size(36, 25);
            this.lbl_num8.TabIndex = 14;
            this.lbl_num8.Text = "__";
            this.lbl_num8.Visible = false;
            // 
            // lbl_num7
            // 
            this.lbl_num7.AutoSize = true;
            this.lbl_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num7.Location = new System.Drawing.Point(259, 327);
            this.lbl_num7.Name = "lbl_num7";
            this.lbl_num7.Size = new System.Drawing.Size(36, 25);
            this.lbl_num7.TabIndex = 15;
            this.lbl_num7.Text = "__";
            this.lbl_num7.Visible = false;
            // 
            // lbl_num6
            // 
            this.lbl_num6.AutoSize = true;
            this.lbl_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num6.Location = new System.Drawing.Point(217, 327);
            this.lbl_num6.Name = "lbl_num6";
            this.lbl_num6.Size = new System.Drawing.Size(36, 25);
            this.lbl_num6.TabIndex = 16;
            this.lbl_num6.Text = "__";
            this.lbl_num6.Visible = false;
            // 
            // lbl_num5
            // 
            this.lbl_num5.AutoSize = true;
            this.lbl_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num5.Location = new System.Drawing.Point(175, 327);
            this.lbl_num5.Name = "lbl_num5";
            this.lbl_num5.Size = new System.Drawing.Size(36, 25);
            this.lbl_num5.TabIndex = 17;
            this.lbl_num5.Text = "__";
            this.lbl_num5.Visible = false;
            // 
            // lbl_num4
            // 
            this.lbl_num4.AutoSize = true;
            this.lbl_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num4.Location = new System.Drawing.Point(138, 327);
            this.lbl_num4.Name = "lbl_num4";
            this.lbl_num4.Size = new System.Drawing.Size(36, 25);
            this.lbl_num4.TabIndex = 18;
            this.lbl_num4.Text = "__";
            this.lbl_num4.Visible = false;
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num3.Location = new System.Drawing.Point(96, 327);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(36, 25);
            this.lbl_num3.TabIndex = 19;
            this.lbl_num3.Text = "__";
            this.lbl_num3.Visible = false;
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num2.Location = new System.Drawing.Point(54, 327);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(36, 25);
            this.lbl_num2.TabIndex = 20;
            this.lbl_num2.Text = "__";
            this.lbl_num2.Visible = false;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_num1.Location = new System.Drawing.Point(12, 327);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(36, 25);
            this.lbl_num1.TabIndex = 21;
            this.lbl_num1.Text = "__";
            this.lbl_num1.Visible = false;
            // 
            // btn_try
            // 
            this.btn_try.Location = new System.Drawing.Point(264, 373);
            this.btn_try.Name = "btn_try";
            this.btn_try.Size = new System.Drawing.Size(75, 29);
            this.btn_try.TabIndex = 8;
            this.btn_try.Text = "Sayı Dene";
            this.btn_try.UseVisualStyleBackColor = true;
            this.btn_try.Visible = false;
            this.btn_try.Click += new System.EventHandler(this.btn_try_Click);
            // 
            // lbl_getNum
            // 
            this.lbl_getNum.AutoSize = true;
            this.lbl_getNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_getNum.Location = new System.Drawing.Point(90, 376);
            this.lbl_getNum.Name = "lbl_getNum";
            this.lbl_getNum.Size = new System.Drawing.Size(62, 17);
            this.lbl_getNum.TabIndex = 7;
            this.lbl_getNum.Text = "Sayı Gir:";
            this.lbl_getNum.Visible = false;
            // 
            // txt_numPredicted
            // 
            this.txt_numPredicted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_numPredicted.Location = new System.Drawing.Point(158, 373);
            this.txt_numPredicted.Name = "txt_numPredicted";
            this.txt_numPredicted.Size = new System.Drawing.Size(100, 29);
            this.txt_numPredicted.TabIndex = 6;
            this.txt_numPredicted.Visible = false;
            this.txt_numPredicted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numPredicted_KeyPress);
            // 
            // numeric_NumOfDigits
            // 
            this.numeric_NumOfDigits.Location = new System.Drawing.Point(226, 55);
            this.numeric_NumOfDigits.Name = "numeric_NumOfDigits";
            this.numeric_NumOfDigits.Size = new System.Drawing.Size(54, 20);
            this.numeric_NumOfDigits.TabIndex = 24;
            this.numeric_NumOfDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_NumOfDigits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numeric_choseRight
            // 
            this.numeric_choseRight.Location = new System.Drawing.Point(226, 117);
            this.numeric_choseRight.Name = "numeric_choseRight";
            this.numeric_choseRight.Size = new System.Drawing.Size(54, 20);
            this.numeric_choseRight.TabIndex = 24;
            this.numeric_choseRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_choseRight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_score.Location = new System.Drawing.Point(90, 413);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(57, 17);
            this.lbl_score.TabIndex = 25;
            this.lbl_score.Text = "Skor : 0";
            this.lbl_score.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_restart.Location = new System.Drawing.Point(236, 274);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(125, 35);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Yeniden Başlat";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_name.Location = new System.Drawing.Point(155, 204);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 23);
            this.txt_name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(61, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "İsim Giriniz : ";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_right.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_right.Location = new System.Drawing.Point(246, 413);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(93, 17);
            this.lbl_right.TabIndex = 25;
            this.lbl_right.Text = "Kalan Hak : 0";
            this.lbl_right.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_time.Location = new System.Drawing.Point(171, 413);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(66, 17);
            this.lbl_time.TabIndex = 25;
            this.lbl_time.Text = "Süre : 15";
            this.lbl_time.Visible = false;
            // 
            // lbl_basNum
            // 
            this.lbl_basNum.AutoSize = true;
            this.lbl_basNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_basNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_basNum.Location = new System.Drawing.Point(147, 444);
            this.lbl_basNum.Name = "lbl_basNum";
            this.lbl_basNum.Size = new System.Drawing.Size(127, 17);
            this.lbl_basNum.TabIndex = 25;
            this.lbl_basNum.Text = "Basamak Sayısı : 5";
            this.lbl_basNum.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 491);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_basNum);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.numeric_choseRight);
            this.Controls.Add(this.numeric_NumOfDigits);
            this.Controls.Add(this.lbl_num10);
            this.Controls.Add(this.lbl_num9);
            this.Controls.Add(this.lbl_num8);
            this.Controls.Add(this.lbl_num7);
            this.Controls.Add(this.lbl_num6);
            this.Controls.Add(this.lbl_num5);
            this.Controls.Add(this.lbl_num4);
            this.Controls.Add(this.lbl_num3);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.btn_try);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_getNum);
            this.Controls.Add(this.txt_numPredicted);
            this.Controls.Add(this.cBoxUnrepeated);
            this.Controls.Add(this.cBoxRepetitive);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RandNumOfDigits);
            this.Controls.Add(this.btn_NumOfDigits);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NumOfDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_choseRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_NumOfDigits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RandNumOfDigits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_getNum;
        private System.Windows.Forms.NumericUpDown numeric_NumOfDigits;
        private System.Windows.Forms.NumericUpDown numeric_choseRight;
        public System.Windows.Forms.Label lbl_num10;
        public System.Windows.Forms.Label lbl_num9;
        public System.Windows.Forms.Label lbl_num8;
        public System.Windows.Forms.Label lbl_num7;
        public System.Windows.Forms.Label lbl_num6;
        public System.Windows.Forms.Label lbl_num5;
        public System.Windows.Forms.Label lbl_num4;
        public System.Windows.Forms.Label lbl_num3;
        public System.Windows.Forms.Label lbl_num2;
        public System.Windows.Forms.Label lbl_num1;
        public System.Windows.Forms.CheckBox cBoxRepetitive;
        public System.Windows.Forms.CheckBox cBoxUnrepeated;
        public System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_right;
        public System.Windows.Forms.Button btn_try;
        public System.Windows.Forms.TextBox txt_numPredicted;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_basNum;
    }
}

