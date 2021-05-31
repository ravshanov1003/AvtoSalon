namespace MyConnector
{
    partial class main
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
            System.Windows.Forms.Button Enter;
            System.Windows.Forms.Button kirish;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ismi = new System.Windows.Forms.TextBox();
            this.familyasi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Enter = new System.Windows.Forms.Button();
            kirish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter
            // 
            Enter.AutoSize = true;
            Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(214)))), ((int)(((byte)(72)))));
            Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Enter.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Enter.Location = new System.Drawing.Point(425, 532);
            Enter.Name = "Enter";
            Enter.Size = new System.Drawing.Size(278, 74);
            Enter.TabIndex = 6;
            Enter.Text = "Avtomobillar ";
            Enter.UseMnemonic = false;
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // kirish
            // 
            kirish.AutoSize = true;
            kirish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            kirish.Cursor = System.Windows.Forms.Cursors.Hand;
            kirish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            kirish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(214)))), ((int)(((byte)(72)))));
            kirish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            kirish.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kirish.Location = new System.Drawing.Point(440, 254);
            kirish.Name = "kirish";
            kirish.Size = new System.Drawing.Size(228, 69);
            kirish.TabIndex = 12;
            kirish.Text = "Kirish";
            kirish.UseMnemonic = false;
            kirish.UseVisualStyleBackColor = false;
            kirish.Click += new System.EventHandler(this.kirish_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 640);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(324, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avtomobillar ro`yhati";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shaxsiy kabinet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ismi
            // 
            this.ismi.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ismi.Location = new System.Drawing.Point(430, 97);
            this.ismi.Multiline = true;
            this.ismi.Name = "ismi";
            this.ismi.Size = new System.Drawing.Size(391, 70);
            this.ismi.TabIndex = 8;
            this.ismi.TextChanged += new System.EventHandler(this.ismi_TextChanged);
            this.ismi.Enter += new System.EventHandler(this.ismi_Enter);
            this.ismi.Leave += new System.EventHandler(this.ismi_Leave);
            // 
            // familyasi
            // 
            this.familyasi.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyasi.Location = new System.Drawing.Point(430, 173);
            this.familyasi.Multiline = true;
            this.familyasi.Name = "familyasi";
            this.familyasi.Size = new System.Drawing.Size(391, 65);
            this.familyasi.TabIndex = 9;
            this.familyasi.TextChanged += new System.EventHandler(this.familyasi_TextChanged);
            this.familyasi.Enter += new System.EventHandler(this.familyasi_Enter);
            this.familyasi.Leave += new System.EventHandler(this.familyasi_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyConnector.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(278, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 640);
            this.Controls.Add(kirish);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.familyasi);
            this.Controls.Add(this.ismi);
            this.Controls.Add(this.label2);
            this.Controls.Add(Enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ismi;
        private System.Windows.Forms.TextBox familyasi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}