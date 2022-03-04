namespace hotel
{
    partial class FormDetailPesanan
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbLama = new System.Windows.Forms.TextBox();
            this.tbTipe = new System.Windows.Forms.TextBox();
            this.tbNomor = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.tbLama);
            this.groupBox1.Controls.Add(this.tbTipe);
            this.groupBox1.Controls.Add(this.tbNomor);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(33, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Pesanan";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(173, 55);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(178, 22);
            this.tbId.TabIndex = 5;
            // 
            // tbLama
            // 
            this.tbLama.Location = new System.Drawing.Point(173, 258);
            this.tbLama.Name = "tbLama";
            this.tbLama.ReadOnly = true;
            this.tbLama.Size = new System.Drawing.Size(178, 22);
            this.tbLama.TabIndex = 8;
            // 
            // tbTipe
            // 
            this.tbTipe.Location = new System.Drawing.Point(173, 207);
            this.tbTipe.Name = "tbTipe";
            this.tbTipe.ReadOnly = true;
            this.tbTipe.Size = new System.Drawing.Size(178, 22);
            this.tbTipe.TabIndex = 7;
            // 
            // tbNomor
            // 
            this.tbNomor.Location = new System.Drawing.Point(173, 157);
            this.tbNomor.Name = "tbNomor";
            this.tbNomor.ReadOnly = true;
            this.tbNomor.Size = new System.Drawing.Size(178, 22);
            this.tbNomor.TabIndex = 6;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(173, 103);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(178, 22);
            this.tbUsername.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipe Kamar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lama Menginap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor Telpon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pesanan :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel.Properties.Resources._311;
            this.pictureBox1.Location = new System.Drawing.Point(294, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDetailPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDetailPesanan";
            this.Text = "Detail Pesanan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbLama;
        public System.Windows.Forms.TextBox tbTipe;
        public System.Windows.Forms.TextBox tbNomor;
        public System.Windows.Forms.TextBox tbUsername;
        public System.Windows.Forms.TextBox tbId;
    }
}