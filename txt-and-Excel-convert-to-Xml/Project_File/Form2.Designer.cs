namespace Project_File
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.converte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_filename = new System.Windows.Forms.Button();
            this.Column_Delimiter = new System.Windows.Forms.TextBox();
            this.Row_Delimiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(886, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 454);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 37);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(-1, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 33);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(-1, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 447);
            this.panel4.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.converte);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_filename);
            this.groupBox1.Controls.Add(this.Column_Delimiter);
            this.groupBox1.Controls.Add(this.Row_Delimiter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 328);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Text";
            // 
            // converte
            // 
            this.converte.BackColor = System.Drawing.Color.DarkSlateGray;
            this.converte.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converte.ForeColor = System.Drawing.Color.White;
            this.converte.Location = new System.Drawing.Point(604, 277);
            this.converte.Name = "converte";
            this.converte.Size = new System.Drawing.Size(167, 45);
            this.converte.TabIndex = 16;
            this.converte.Text = "Back";
            this.converte.UseVisualStyleBackColor = false;
            this.converte.Click += new System.EventHandler(this.converte_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(419, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Constraints";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(628, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 123);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_filename
            // 
            this.btn_filename.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_filename.Image = ((System.Drawing.Image)(resources.GetObject("btn_filename.Image")));
            this.btn_filename.Location = new System.Drawing.Point(383, 204);
            this.btn_filename.Name = "btn_filename";
            this.btn_filename.Size = new System.Drawing.Size(67, 59);
            this.btn_filename.TabIndex = 8;
            this.btn_filename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filename.UseVisualStyleBackColor = false;
            this.btn_filename.Click += new System.EventHandler(this.btn_filename_Click);
            // 
            // Column_Delimiter
            // 
            this.Column_Delimiter.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_Delimiter.Location = new System.Drawing.Point(383, 138);
            this.Column_Delimiter.Multiline = true;
            this.Column_Delimiter.Name = "Column_Delimiter";
            this.Column_Delimiter.Size = new System.Drawing.Size(67, 45);
            this.Column_Delimiter.TabIndex = 10;
            // 
            // Row_Delimiter
            // 
            this.Row_Delimiter.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Row_Delimiter.Location = new System.Drawing.Point(383, 78);
            this.Row_Delimiter.Multiline = true;
            this.Row_Delimiter.Name = "Row_Delimiter";
            this.Row_Delimiter.Size = new System.Drawing.Size(67, 43);
            this.Row_Delimiter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 213);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Upload The File\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Column Delimiter ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = " Row Delimiter";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_filename;
        private System.Windows.Forms.TextBox Column_Delimiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Row_Delimiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button converte;
    }
}