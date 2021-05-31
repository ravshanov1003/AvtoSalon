namespace MyConnector
{
    partial class Avtomobillar
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
            System.Windows.Forms.Button search;
            System.Windows.Forms.Button newcarSearch;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.avtoName = new System.Windows.Forms.TextBox();
            this.avtoColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newCars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tahoe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            search = new System.Windows.Forms.Button();
            newcarSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            search.AutoSize = true;
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            search.Cursor = System.Windows.Forms.Cursors.Hand;
            search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            search.FlatAppearance.BorderSize = 0;
            search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(214)))), ((int)(((byte)(72)))));
            search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            search.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            search.Location = new System.Drawing.Point(86, 364);
            search.Name = "search";
            search.Size = new System.Drawing.Size(346, 64);
            search.TabIndex = 11;
            search.Text = "Avtomobilni  ko`rsatish";
            search.UseMnemonic = false;
            search.UseVisualStyleBackColor = false;
            search.Click += new System.EventHandler(this.search_Click);
            // 
            // newcarSearch
            // 
            newcarSearch.AutoSize = true;
            newcarSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            newcarSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            newcarSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            newcarSearch.FlatAppearance.BorderSize = 0;
            newcarSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(214)))), ((int)(((byte)(72)))));
            newcarSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            newcarSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newcarSearch.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            newcarSearch.Location = new System.Drawing.Point(518, 576);
            newcarSearch.Name = "newcarSearch";
            newcarSearch.Size = new System.Drawing.Size(156, 69);
            newcarSearch.TabIndex = 14;
            newcarSearch.Text = "Qidirish";
            newcarSearch.UseMnemonic = false;
            newcarSearch.UseVisualStyleBackColor = false;
            newcarSearch.Click += new System.EventHandler(this.newcarSearch_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1167, 681);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Avtomobillar ro`yhati";
            // 
            // avtoName
            // 
            this.avtoName.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtoName.Location = new System.Drawing.Point(208, 146);
            this.avtoName.Multiline = true;
            this.avtoName.Name = "avtoName";
            this.avtoName.Size = new System.Drawing.Size(283, 59);
            this.avtoName.TabIndex = 7;
            // 
            // avtoColor
            // 
            this.avtoColor.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtoColor.Location = new System.Drawing.Point(208, 243);
            this.avtoColor.Multiline = true;
            this.avtoColor.Name = "avtoColor";
            this.avtoColor.Size = new System.Drawing.Size(283, 60);
            this.avtoColor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label2.Location = new System.Drawing.Point(8, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Avto nomi";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label3.Location = new System.Drawing.Point(4, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 52);
            this.label3.TabIndex = 10;
            this.label3.Text = "Avto rangi";
            // 
            // newCars
            // 
            this.newCars.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCars.Location = new System.Drawing.Point(17, 576);
            this.newCars.Multiline = true;
            this.newCars.Name = "newCars";
            this.newCars.Size = new System.Drawing.Size(495, 69);
            this.newCars.TabIndex = 12;
            this.newCars.Enter += new System.EventHandler(this.newCars_Enter);
            this.newCars.Leave += new System.EventHandler(this.newCars_Leave);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label5.Location = new System.Drawing.Point(120, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 52);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yangi avtomobillar";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.label4.Location = new System.Drawing.Point(762, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Trenddagi avto haqida bilish";
            // 
            // tahoe
            // 
            this.tahoe.AutoSize = true;
            this.tahoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.tahoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tahoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahoe.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tahoe.Location = new System.Drawing.Point(1015, 573);
            this.tahoe.Name = "tahoe";
            this.tahoe.Size = new System.Drawing.Size(140, 69);
            this.tahoe.TabIndex = 17;
            this.tahoe.Text = "Tahoe";
            this.tahoe.UseMnemonic = false;
            this.tahoe.UseVisualStyleBackColor = false;
            this.tahoe.Click += new System.EventHandler(this.tahoe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(7)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MyConnector.Properties.Resources.tahoe;
            this.pictureBox1.Location = new System.Drawing.Point(518, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Avtomobillar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 681);
            this.Controls.Add(this.tahoe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(newcarSearch);
            this.Controls.Add(this.newCars);
            this.Controls.Add(search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avtoColor);
            this.Controls.Add(this.avtoName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Avtomobillar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avtomobillar";
            this.Load += new System.EventHandler(this.Avtomobillar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox avtoName;
        private System.Windows.Forms.TextBox avtoColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tahoe;
    }
}