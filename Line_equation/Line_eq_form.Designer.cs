namespace Line_equation
{
    partial class Line_eq_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_eq_form));
            this.A1 = new System.Windows.Forms.TextBox();
            this.D1 = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.TextBox();
            this.C2 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.num2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.den3 = new System.Windows.Forms.Label();
            this.den1 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.eq2 = new System.Windows.Forms.Label();
            this.eq1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.den2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.A1.Location = new System.Drawing.Point(7, 41);
            this.A1.Margin = new System.Windows.Forms.Padding(2);
            this.A1.Name = "A1";
            this.A1.ShortcutsEnabled = false;
            this.A1.Size = new System.Drawing.Size(27, 29);
            this.A1.TabIndex = 0;
            this.A1.Text = "1";
            this.A1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // D1
            // 
            this.D1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.D1.Location = new System.Drawing.Point(221, 41);
            this.D1.Margin = new System.Windows.Forms.Padding(2);
            this.D1.Name = "D1";
            this.D1.ShortcutsEnabled = false;
            this.D1.Size = new System.Drawing.Size(27, 29);
            this.D1.TabIndex = 1;
            this.D1.Text = "5";
            this.D1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // C1
            // 
            this.C1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.C1.Location = new System.Drawing.Point(149, 41);
            this.C1.Margin = new System.Windows.Forms.Padding(2);
            this.C1.Name = "C1";
            this.C1.ShortcutsEnabled = false;
            this.C1.Size = new System.Drawing.Size(27, 29);
            this.C1.TabIndex = 2;
            this.C1.Text = "3";
            this.C1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // B1
            // 
            this.B1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.B1.Location = new System.Drawing.Point(79, 41);
            this.B1.Margin = new System.Windows.Forms.Padding(2);
            this.B1.Name = "B1";
            this.B1.ShortcutsEnabled = false;
            this.B1.Size = new System.Drawing.Size(27, 29);
            this.B1.TabIndex = 3;
            this.B1.Text = "-1";
            this.B1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputGroupBox.Controls.Add(this.solveButton);
            this.inputGroupBox.Controls.Add(this.label6);
            this.inputGroupBox.Controls.Add(this.label7);
            this.inputGroupBox.Controls.Add(this.label8);
            this.inputGroupBox.Controls.Add(this.label9);
            this.inputGroupBox.Controls.Add(this.label10);
            this.inputGroupBox.Controls.Add(this.D2);
            this.inputGroupBox.Controls.Add(this.C2);
            this.inputGroupBox.Controls.Add(this.B2);
            this.inputGroupBox.Controls.Add(this.A2);
            this.inputGroupBox.Controls.Add(this.label5);
            this.inputGroupBox.Controls.Add(this.label4);
            this.inputGroupBox.Controls.Add(this.label3);
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Controls.Add(this.label1);
            this.inputGroupBox.Controls.Add(this.D1);
            this.inputGroupBox.Controls.Add(this.C1);
            this.inputGroupBox.Controls.Add(this.B1);
            this.inputGroupBox.Controls.Add(this.A1);
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.inputGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.inputGroupBox.Location = new System.Drawing.Point(8, 8);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.inputGroupBox.Size = new System.Drawing.Size(396, 123);
            this.inputGroupBox.TabIndex = 4;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Ввод";
            // 
            // solveButton
            // 
            this.solveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.solveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.solveButton.Location = new System.Drawing.Point(295, 75);
            this.solveButton.Margin = new System.Windows.Forms.Padding(2);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(97, 43);
            this.solveButton.TabIndex = 18;
            this.solveButton.Text = "Расчет";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(251, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "=0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(180, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "z +";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(109, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "y +";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(37, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "x +";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(4, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Уравнение второй плоскости:";
            // 
            // D2
            // 
            this.D2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.D2.Location = new System.Drawing.Point(221, 89);
            this.D2.Margin = new System.Windows.Forms.Padding(2);
            this.D2.Name = "D2";
            this.D2.ShortcutsEnabled = false;
            this.D2.Size = new System.Drawing.Size(27, 29);
            this.D2.TabIndex = 10;
            this.D2.Text = "0";
            this.D2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // C2
            // 
            this.C2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.C2.Location = new System.Drawing.Point(149, 89);
            this.C2.Margin = new System.Windows.Forms.Padding(2);
            this.C2.Name = "C2";
            this.C2.ShortcutsEnabled = false;
            this.C2.Size = new System.Drawing.Size(27, 29);
            this.C2.TabIndex = 11;
            this.C2.Text = "-1";
            this.C2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // B2
            // 
            this.B2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.B2.Location = new System.Drawing.Point(79, 89);
            this.B2.Margin = new System.Windows.Forms.Padding(2);
            this.B2.Name = "B2";
            this.B2.ShortcutsEnabled = false;
            this.B2.Size = new System.Drawing.Size(27, 29);
            this.B2.TabIndex = 12;
            this.B2.Text = "2";
            this.B2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // A2
            // 
            this.A2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.A2.Location = new System.Drawing.Point(7, 89);
            this.A2.Margin = new System.Windows.Forms.Padding(2);
            this.A2.Name = "A2";
            this.A2.ShortcutsEnabled = false;
            this.A2.Size = new System.Drawing.Size(27, 29);
            this.A2.TabIndex = 9;
            this.A2.Text = "3";
            this.A2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Abc_Block);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(251, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "=0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(180, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "z +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(109, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "y +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "x +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Уравнение первой плоскости:";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputGroupBox.Controls.Add(this.num2);
            this.outputGroupBox.Controls.Add(this.num1);
            this.outputGroupBox.Controls.Add(this.den3);
            this.outputGroupBox.Controls.Add(this.den1);
            this.outputGroupBox.Controls.Add(this.num3);
            this.outputGroupBox.Controls.Add(this.label13);
            this.outputGroupBox.Controls.Add(this.eq2);
            this.outputGroupBox.Controls.Add(this.eq1);
            this.outputGroupBox.Controls.Add(this.label11);
            this.outputGroupBox.Controls.Add(this.label12);
            this.outputGroupBox.Controls.Add(this.den2);
            this.outputGroupBox.Controls.Add(this.label17);
            this.outputGroupBox.Controls.Add(this.label18);
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.outputGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputGroupBox.Location = new System.Drawing.Point(8, 136);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(396, 185);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Вывод";
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F, System.Drawing.FontStyle.Underline);
            this.num2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num2.Location = new System.Drawing.Point(109, 132);
            this.num2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(65, 27);
            this.num2.TabIndex = 25;
            this.num2.Text = "y - y0";
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F, System.Drawing.FontStyle.Underline);
            this.num1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num1.Location = new System.Drawing.Point(5, 132);
            this.num1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(65, 27);
            this.num1.TabIndex = 24;
            this.num1.Text = "x - x0";
            // 
            // den3
            // 
            this.den3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.den3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.den3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.den3.Location = new System.Drawing.Point(214, 156);
            this.den3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.den3.Name = "den3";
            this.den3.Size = new System.Drawing.Size(19, 27);
            this.den3.TabIndex = 29;
            this.den3.Text = "1";
            // 
            // den1
            // 
            this.den1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.den1.AutoSize = true;
            this.den1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.den1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.den1.Location = new System.Drawing.Point(3, 156);
            this.den1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.den1.Name = "den1";
            this.den1.Size = new System.Drawing.Size(72, 27);
            this.den1.TabIndex = 27;
            this.den1.Text = "x1 - x0";
            // 
            // num3
            // 
            this.num3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F, System.Drawing.FontStyle.Underline);
            this.num3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num3.Location = new System.Drawing.Point(213, 132);
            this.num3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(23, 27);
            this.num3.TabIndex = 26;
            this.num3.Text = "z";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(4, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Уравнение прямой:";
            // 
            // eq2
            // 
            this.eq2.AutoSize = true;
            this.eq2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.eq2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eq2.Location = new System.Drawing.Point(5, 88);
            this.eq2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eq2.Name = "eq2";
            this.eq2.Size = new System.Drawing.Size(231, 27);
            this.eq2.TabIndex = 22;
            this.eq2.Text = "A2x + B2y + C2z +D2 = 0";
            // 
            // eq1
            // 
            this.eq1.AutoSize = true;
            this.eq1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.eq1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eq1.Location = new System.Drawing.Point(5, 40);
            this.eq1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eq1.Name = "eq1";
            this.eq1.Size = new System.Drawing.Size(215, 27);
            this.eq1.TabIndex = 21;
            this.eq1.Text = "A1x + B1y + C1z +D1 = 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(4, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Уравнение второй плоскости:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(4, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Уравнение первой плоскости:";
            // 
            // den2
            // 
            this.den2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.den2.AutoSize = true;
            this.den2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F);
            this.den2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.den2.Location = new System.Drawing.Point(107, 156);
            this.den2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.den2.Name = "den2";
            this.den2.Size = new System.Drawing.Size(72, 27);
            this.den2.TabIndex = 28;
            this.den2.Text = "y1 - y0";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20F);
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(76, 142);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 33);
            this.label17.TabIndex = 30;
            this.label17.Text = "=";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20F);
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(184, 142);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 33);
            this.label18.TabIndex = 31;
            this.label18.Text = "=";
            // 
            // Line_eq_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(412, 337);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(428, 376);
            this.Name = "Line_eq_form";
            this.Text = "Line equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox D2;
        private System.Windows.Forms.TextBox C2;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label eq2;
        private System.Windows.Forms.Label eq1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label den3;
        private System.Windows.Forms.Label den1;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label den2;
    }
}

