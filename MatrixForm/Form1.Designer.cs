namespace MatrixForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CreateFirstMatrix = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.ProdButton = new System.Windows.Forms.Button();
            this.CreateSecondMatrix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RandomButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стовбці";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Рядки";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // CreateFirstMatrix
            // 
            this.CreateFirstMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CreateFirstMatrix.Location = new System.Drawing.Point(18, 78);
            this.CreateFirstMatrix.Name = "CreateFirstMatrix";
            this.CreateFirstMatrix.Size = new System.Drawing.Size(128, 37);
            this.CreateFirstMatrix.TabIndex = 4;
            this.CreateFirstMatrix.Text = "Створити";
            this.CreateFirstMatrix.UseVisualStyleBackColor = true;
            this.CreateFirstMatrix.Click += new System.EventHandler(this.CreateFirstMatrix_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(18, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 302);
            this.panel1.TabIndex = 5;
            // 
            // TransButton
            // 
            this.TransButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TransButton.Location = new System.Drawing.Point(328, 30);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(367, 38);
            this.TransButton.TabIndex = 6;
            this.TransButton.Text = "Транспонувати матрицю 1";
            this.TransButton.UseVisualStyleBackColor = true;
            this.TransButton.Click += new System.EventHandler(this.TransButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(391, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 302);
            this.panel2.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddButton.Location = new System.Drawing.Point(328, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 38);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SubButton.Location = new System.Drawing.Point(455, 78);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(117, 38);
            this.SubButton.TabIndex = 8;
            this.SubButton.Text = "Відняти";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // ProdButton
            // 
            this.ProdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProdButton.Location = new System.Drawing.Point(578, 78);
            this.ProdButton.Name = "ProdButton";
            this.ProdButton.Size = new System.Drawing.Size(117, 38);
            this.ProdButton.TabIndex = 9;
            this.ProdButton.Text = "Помножити";
            this.ProdButton.UseVisualStyleBackColor = true;
            this.ProdButton.Click += new System.EventHandler(this.ProdButton_Click);
            // 
            // CreateSecondMatrix
            // 
            this.CreateSecondMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CreateSecondMatrix.Location = new System.Drawing.Point(172, 78);
            this.CreateSecondMatrix.Name = "CreateSecondMatrix";
            this.CreateSecondMatrix.Size = new System.Drawing.Size(128, 37);
            this.CreateSecondMatrix.TabIndex = 14;
            this.CreateSecondMatrix.Text = "Створити";
            this.CreateSecondMatrix.UseVisualStyleBackColor = true;
            this.CreateSecondMatrix.Click += new System.EventHandler(this.CreateSecondMatrix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Рядки";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Стовбці";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Матриця 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(42, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Матриця 1";
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(328, 156);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(57, 23);
            this.RandomButton.TabIndex = 17;
            this.RandomButton.Text = "Random fill";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(328, 208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.resultsTextBox.Location = new System.Drawing.Point(714, 32);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(269, 391);
            this.resultsTextBox.TabIndex = 20;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(714, 432);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 21;
            this.FileName.Text = "results.txt";
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(820, 430);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveToFileButton.TabIndex = 22;
            this.saveToFileButton.Text = "Save to file";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(901, 430);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1002, 463);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateSecondMatrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ProdButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateFirstMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CreateFirstMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TransButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button ProdButton;
        private System.Windows.Forms.Button CreateSecondMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

