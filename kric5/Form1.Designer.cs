namespace kric5
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.chkNegSum = new System.Windows.Forms.CheckBox();
            this.chkIndex3 = new System.Windows.Forms.CheckBox();
            this.chkMaxMinProd = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.txtRes2 = new System.Windows.Forms.TextBox();
            this.txtRes3 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(238, 38);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(572, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 55);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(48, 151);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(715, 30);
            this.lstArray.TabIndex = 2;
            // 
            // chkNegSum
            // 
            this.chkNegSum.AutoSize = true;
            this.chkNegSum.Location = new System.Drawing.Point(48, 255);
            this.chkNegSum.Name = "chkNegSum";
            this.chkNegSum.Size = new System.Drawing.Size(140, 17);
            this.chkNegSum.TabIndex = 3;
            this.chkNegSum.Text = "Сумма отрицательных";
            this.chkNegSum.UseVisualStyleBackColor = true;
            // 
            // chkIndex3
            // 
            this.chkIndex3.AutoSize = true;
            this.chkIndex3.Location = new System.Drawing.Point(48, 307);
            this.chkIndex3.Name = "chkIndex3";
            this.chkIndex3.Size = new System.Drawing.Size(237, 17);
            this.chkIndex3.TabIndex = 4;
            this.chkIndex3.Text = "Сумма элементов с индексом кратным 3";
            this.chkIndex3.UseVisualStyleBackColor = true;
            // 
            // chkMaxMinProd
            // 
            this.chkMaxMinProd.AutoSize = true;
            this.chkMaxMinProd.Location = new System.Drawing.Point(48, 361);
            this.chkMaxMinProd.Name = "chkMaxMinProd";
            this.chkMaxMinProd.Size = new System.Drawing.Size(143, 17);
            this.chkMaxMinProd.TabIndex = 5;
            this.chkMaxMinProd.Text = " произведение max*min";
            this.chkMaxMinProd.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(164, 399);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(95, 39);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtRes1
            // 
            this.txtRes1.Location = new System.Drawing.Point(368, 253);
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(100, 20);
            this.txtRes1.TabIndex = 7;
            // 
            // txtRes2
            // 
            this.txtRes2.Location = new System.Drawing.Point(368, 304);
            this.txtRes2.Name = "txtRes2";
            this.txtRes2.Size = new System.Drawing.Size(100, 20);
            this.txtRes2.TabIndex = 8;
            // 
            // txtRes3
            // 
            this.txtRes3.Location = new System.Drawing.Point(368, 358);
            this.txtRes3.Name = "txtRes3";
            this.txtRes3.Size = new System.Drawing.Size(100, 20);
            this.txtRes3.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "введите число элементов массива";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRes3);
            this.Controls.Add(this.txtRes2);
            this.Controls.Add(this.txtRes1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chkMaxMinProd);
            this.Controls.Add(this.chkIndex3);
            this.Controls.Add(this.chkNegSum);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.CheckBox chkNegSum;
        private System.Windows.Forms.CheckBox chkIndex3;
        private System.Windows.Forms.CheckBox chkMaxMinProd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtRes1;
        private System.Windows.Forms.TextBox txtRes2;
        private System.Windows.Forms.TextBox txtRes3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

