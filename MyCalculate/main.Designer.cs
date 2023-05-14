namespace MyCalculate
{
    partial class main
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1min = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnfloat = new System.Windows.Forms.Button();
            this.btneaq = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(2, 56);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(930, 200);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btndiv
            // 
            this.btndiv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btndiv.BackColor = System.Drawing.Color.Gold;
            this.btndiv.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndiv.Location = new System.Drawing.Point(699, 262);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(225, 201);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.NumberOpritor);
            // 
            // btnmod
            // 
            this.btnmod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnmod.BackColor = System.Drawing.Color.Gray;
            this.btnmod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmod.Location = new System.Drawing.Point(468, 262);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(225, 201);
            this.btnmod.TabIndex = 3;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.NumberOpritor);
            // 
            // btndel
            // 
            this.btndel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btndel.BackColor = System.Drawing.Color.Gray;
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndel.Location = new System.Drawing.Point(6, 262);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(225, 201);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "del";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnclear.BackColor = System.Drawing.Color.Gray;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Location = new System.Drawing.Point(237, 262);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(225, 201);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "c";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(237, 469);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(225, 201);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(6, 469);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(225, 201);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(468, 469);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(225, 201);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btnmul
            // 
            this.btnmul.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnmul.BackColor = System.Drawing.Color.Gold;
            this.btnmul.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmul.Location = new System.Drawing.Point(699, 469);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(225, 201);
            this.btnmul.TabIndex = 7;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.NumberOpritor);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(237, 676);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(225, 201);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(6, 676);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(225, 201);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(468, 676);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(225, 201);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn1min
            // 
            this.btn1min.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn1min.BackColor = System.Drawing.Color.Gold;
            this.btn1min.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1min.Location = new System.Drawing.Point(699, 676);
            this.btn1min.Name = "btn1min";
            this.btn1min.Size = new System.Drawing.Size(225, 201);
            this.btn1min.TabIndex = 12;
            this.btn1min.Text = "-";
            this.btn1min.UseVisualStyleBackColor = false;
            this.btn1min.Click += new System.EventHandler(this.NumberOpritor);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(237, 883);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(225, 201);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(6, 883);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(225, 201);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(468, 883);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(225, 201);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btnplus
            // 
            this.btnplus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnplus.BackColor = System.Drawing.Color.Gold;
            this.btnplus.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnplus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnplus.Location = new System.Drawing.Point(699, 883);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(225, 201);
            this.btnplus.TabIndex = 17;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.NumberOpritor);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(6, 1090);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(456, 201);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btnfloat
            // 
            this.btnfloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnfloat.BackColor = System.Drawing.Color.Silver;
            this.btnfloat.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfloat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfloat.Location = new System.Drawing.Point(468, 1090);
            this.btnfloat.Name = "btnfloat";
            this.btnfloat.Size = new System.Drawing.Size(225, 201);
            this.btnfloat.TabIndex = 23;
            this.btnfloat.Text = ".";
            this.btnfloat.UseVisualStyleBackColor = false;
            this.btnfloat.Click += new System.EventHandler(this.EnterNumberss);
            // 
            // btneaq
            // 
            this.btneaq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btneaq.BackColor = System.Drawing.Color.Gold;
            this.btneaq.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneaq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneaq.Location = new System.Drawing.Point(699, 1090);
            this.btneaq.Name = "btneaq";
            this.btneaq.Size = new System.Drawing.Size(225, 201);
            this.btneaq.TabIndex = 22;
            this.btneaq.Text = "=";
            this.btneaq.UseVisualStyleBackColor = false;
            this.btneaq.Click += new System.EventHandler(this.btneaq_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sientifique ",
            "Main"});
            this.comboBox1.Location = new System.Drawing.Point(2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 56);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Fille";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(932, 1305);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnfloat);
            this.Controls.Add(this.btneaq);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1min);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.textBox);
            this.Name = "main";
            this.Text = "Main Calculator";
            this.Load += new System.EventHandler(this.main_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private Button btndiv;
        private Button btnmod;
        private Button btndel;
        private Button btnclear;
        private Button btn8;
        private Button btn7;
        private Button btn9;
        private Button btnmul;
        private Button btn5;
        private Button btn4;
        private Button btn6;
        private Button btn1min;
        private Button btn2;
        private Button btn1;
        private Button btn3;
        private Button btnplus;
        private Button btn0;
        private Button btnfloat;
        private Button btneaq;
        private ComboBox comboBox1;
    }
}