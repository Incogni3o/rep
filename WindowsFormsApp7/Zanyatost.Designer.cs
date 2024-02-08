namespace WindowsFormsApp7
{
    partial class Zanyat
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.formEX = new System.Windows.Forms.Button();
            this.sotrr = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(334, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // formEX
            // 
            this.formEX.Location = new System.Drawing.Point(172, 254);
            this.formEX.Name = "formEX";
            this.formEX.Size = new System.Drawing.Size(260, 23);
            this.formEX.TabIndex = 2;
            this.formEX.Text = "Сформировать в Excel";
            this.formEX.UseVisualStyleBackColor = true;
            this.formEX.Click += new System.EventHandler(this.formEX_Click);
            // 
            // sotrr
            // 
            this.sotrr.AutoSize = true;
            this.sotrr.Location = new System.Drawing.Point(113, 173);
            this.sotrr.Name = "sotrr";
            this.sotrr.Size = new System.Drawing.Size(63, 13);
            this.sotrr.TabIndex = 3;
            this.sotrr.Text = "Сотрудник:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Zanyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sotrr);
            this.Controls.Add(this.formEX);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Zanyat";
            this.Text = "Отчет Занятость специалиста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button formEX;
        private System.Windows.Forms.Label sotrr;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}