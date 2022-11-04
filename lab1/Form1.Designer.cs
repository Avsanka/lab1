namespace lab1
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
            this.buttonRand = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUserSet = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonBattle = new System.Windows.Forms.Button();
            this.labelTable2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(12, 12);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(131, 23);
            this.buttonRand.TabIndex = 0;
            this.buttonRand.Text = "Рандомная карта";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelTable.Location = new System.Drawing.Point(343, 158);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(19, 26);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "-";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(635, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Масть";
            // 
            // buttonUserSet
            // 
            this.buttonUserSet.Location = new System.Drawing.Point(635, 194);
            this.buttonUserSet.Name = "buttonUserSet";
            this.buttonUserSet.Size = new System.Drawing.Size(122, 23);
            this.buttonUserSet.TabIndex = 6;
            this.buttonUserSet.Text = "Кинуть карту на стол";
            this.buttonUserSet.UseVisualStyleBackColor = true;
            this.buttonUserSet.Click += new System.EventHandler(this.ButtonUserSet_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(632, 117);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Черви";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(708, 117);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Буби";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(632, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Крести";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(708, 158);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Пики";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonBattle
            // 
            this.buttonBattle.Location = new System.Drawing.Point(30, 223);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(75, 23);
            this.buttonBattle.TabIndex = 11;
            this.buttonBattle.Text = "Битва";
            this.buttonBattle.UseVisualStyleBackColor = true;
            this.buttonBattle.Click += new System.EventHandler(this.ButtonBattle_Click);
            // 
            // labelTable2
            // 
            this.labelTable2.AutoSize = true;
            this.labelTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelTable2.Location = new System.Drawing.Point(343, 213);
            this.labelTable2.Name = "labelTable2";
            this.labelTable2.Size = new System.Drawing.Size(19, 26);
            this.labelTable2.TabIndex = 12;
            this.labelTable2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ваша карта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Карта компьютера:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTable2);
            this.Controls.Add(this.buttonBattle);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonUserSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.buttonRand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUserSet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonBattle;
        private System.Windows.Forms.Label labelTable2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

