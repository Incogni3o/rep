namespace WindowsFormsApp7
{
    partial class OkazanieUslug
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
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.komment = new System.Windows.Forms.TextBox();
            this.givotnoe = new System.Windows.Forms.ComboBox();
            this.uslugi = new System.Windows.Forms.ComboBox();
            this.sotr = new System.Windows.Forms.ComboBox();
            this.dataline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 281);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(776, 215);
            this.dataGrid1.TabIndex = 0;
           
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(480, 33);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(206, 46);
            this.but1.TabIndex = 1;
            this.but1.Text = "Сохранить";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(480, 97);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(206, 46);
            this.but2.TabIndex = 2;
            this.but2.Text = "Печать договорв";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(480, 166);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(206, 46);
            this.but3.TabIndex = 3;
            this.but3.Text = "Квитанция на оплату";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Животное:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Услуга:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сотрудник:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Комментарий:";
            // 
            // komment
            // 
            this.komment.Location = new System.Drawing.Point(126, 200);
            this.komment.Multiline = true;
            this.komment.Name = "komment";
            this.komment.Size = new System.Drawing.Size(288, 60);
            this.komment.TabIndex = 11;
            // 
            // givotnoe
            // 
            this.givotnoe.FormattingEnabled = true;
            this.givotnoe.Location = new System.Drawing.Point(126, 75);
            this.givotnoe.Name = "givotnoe";
            this.givotnoe.Size = new System.Drawing.Size(288, 21);
            this.givotnoe.TabIndex = 13;
            // 
            // uslugi
            // 
            this.uslugi.FormattingEnabled = true;
            this.uslugi.Location = new System.Drawing.Point(126, 120);
            this.uslugi.Name = "uslugi";
            this.uslugi.Size = new System.Drawing.Size(288, 21);
            this.uslugi.TabIndex = 14;
            // 
            // sotr
            // 
            this.sotr.FormattingEnabled = true;
            this.sotr.Location = new System.Drawing.Point(126, 163);
            this.sotr.Name = "sotr";
            this.sotr.Size = new System.Drawing.Size(288, 21);
            this.sotr.TabIndex = 15;
            // 
            // dataline
            // 
            this.dataline.Location = new System.Drawing.Point(126, 32);
            this.dataline.Name = "dataline";
            this.dataline.Size = new System.Drawing.Size(288, 20);
            this.dataline.TabIndex = 16;
            // 
            // OkazanieUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.dataline);
            this.Controls.Add(this.sotr);
            this.Controls.Add(this.uslugi);
            this.Controls.Add(this.givotnoe);
            this.Controls.Add(this.komment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "OkazanieUslug";
            this.Text = "Оказание услуг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox komment;
        private System.Windows.Forms.ComboBox givotnoe;
        private System.Windows.Forms.ComboBox uslugi;
        private System.Windows.Forms.ComboBox sotr;
        private System.Windows.Forms.DateTimePicker dataline;
    }
}