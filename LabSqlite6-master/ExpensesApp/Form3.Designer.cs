﻿namespace ExpensesApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.filterName = new System.Windows.Forms.TextBox();
            this.filterMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterDateStart = new System.Windows.Forms.DateTimePicker();
            this.filterDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "По названию";
            // 
            // filterName
            // 
            this.filterName.Location = new System.Drawing.Point(16, 47);
            this.filterName.Multiline = true;
            this.filterName.Name = "filterName";
            this.filterName.Size = new System.Drawing.Size(404, 25);
            this.filterName.TabIndex = 4;
            // 
            // filterMin
            // 
            this.filterMin.Location = new System.Drawing.Point(16, 133);
            this.filterMin.Multiline = true;
            this.filterMin.Name = "filterMin";
            this.filterMin.Size = new System.Drawing.Size(109, 25);
            this.filterMin.TabIndex = 6;
            this.filterMin.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "По сумме";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // filterMax
            // 
            this.filterMax.Location = new System.Drawing.Point(131, 133);
            this.filterMax.Multiline = true;
            this.filterMax.Name = "filterMax";
            this.filterMax.Size = new System.Drawing.Size(109, 25);
            this.filterMax.TabIndex = 9;
            this.filterMax.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "По дате";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "До";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterDateStart
            // 
            this.filterDateStart.Location = new System.Drawing.Point(72, 231);
            this.filterDateStart.Name = "filterDateStart";
            this.filterDateStart.Size = new System.Drawing.Size(200, 20);
            this.filterDateStart.TabIndex = 17;
            // 
            // filterDateEnd
            // 
            this.filterDateEnd.Location = new System.Drawing.Point(72, 274);
            this.filterDateEnd.Name = "filterDateEnd";
            this.filterDateEnd.Size = new System.Drawing.Size(200, 20);
            this.filterDateEnd.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 206);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 579);
            this.Controls.Add(this.filterDateEnd);
            this.Controls.Add(this.filterDateStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterMax);
            this.Controls.Add(this.filterMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterName);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = " Поиск по записям";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterName;
        private System.Windows.Forms.TextBox filterMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker filterDateStart;
        private System.Windows.Forms.DateTimePicker filterDateEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}