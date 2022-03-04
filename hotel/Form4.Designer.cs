namespace hotel
{
    partial class FormPesan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLamaMenginap = new System.Windows.Forms.TextBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.tbNomor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipeKamar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLamaMenginap);
            this.groupBox1.Controls.Add(this.btnPesan);
            this.groupBox1.Controls.Add(this.tbNomor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipeKamar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(135, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(290, 35);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(247, 22);
            this.tbUsername.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // tbLamaMenginap
            // 
            this.tbLamaMenginap.Location = new System.Drawing.Point(290, 155);
            this.tbLamaMenginap.Name = "tbLamaMenginap";
            this.tbLamaMenginap.Size = new System.Drawing.Size(247, 22);
            this.tbLamaMenginap.TabIndex = 9;
            this.tbLamaMenginap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLamaMenginap_KeyPress);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(172, 224);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(255, 23);
            this.btnPesan.TabIndex = 8;
            this.btnPesan.Text = "Pesan Kamar";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // tbNomor
            // 
            this.tbNomor.Location = new System.Drawing.Point(290, 70);
            this.tbNomor.Name = "tbNomor";
            this.tbNomor.Size = new System.Drawing.Size(247, 22);
            this.tbNomor.TabIndex = 4;
            this.tbNomor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lama Menginap";
            // 
            // cbTipeKamar
            // 
            this.cbTipeKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipeKamar.FormattingEnabled = true;
            this.cbTipeKamar.Location = new System.Drawing.Point(290, 116);
            this.cbTipeKamar.Name = "cbTipeKamar";
            this.cbTipeKamar.Size = new System.Drawing.Size(247, 24);
            this.cbTipeKamar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Telepon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel.Properties.Resources._311;
            this.pictureBox1.Location = new System.Drawing.Point(688, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPesan";
            this.Text = "Pesan Kamar Hotel";
            this.Load += new System.EventHandler(this.FormPesan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipeKamar;
        private System.Windows.Forms.TextBox tbLamaMenginap;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}