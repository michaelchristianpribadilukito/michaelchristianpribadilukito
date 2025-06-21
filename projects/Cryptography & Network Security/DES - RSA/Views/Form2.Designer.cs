namespace DES.Views
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n_tb = new System.Windows.Forms.TextBox();
            this.q_tb = new System.Windows.Forms.TextBox();
            this.e_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phi_tb = new System.Windows.Forms.TextBox();
            this.d_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.publicKey_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.privateKey_tb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.message_tb = new System.Windows.Forms.TextBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.encrypted_tb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.decrypted_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ciphertext_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.p_tb = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.prosesOutput_tb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_tb);
            this.groupBox1.Controls.Add(this.p_tb);
            this.groupBox1.Controls.Add(this.q_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.p_lbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // p_lbl
            // 
            this.p_lbl.AutoSize = true;
            this.p_lbl.Location = new System.Drawing.Point(7, 22);
            this.p_lbl.Name = "p_lbl";
            this.p_lbl.Size = new System.Drawing.Size(15, 16);
            this.p_lbl.TabIndex = 0;
            this.p_lbl.Text = "p";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "e";
            // 
            // n_tb
            // 
            this.n_tb.Location = new System.Drawing.Point(61, 22);
            this.n_tb.Name = "n_tb";
            this.n_tb.ReadOnly = true;
            this.n_tb.Size = new System.Drawing.Size(89, 22);
            this.n_tb.TabIndex = 2;
            // 
            // q_tb
            // 
            this.q_tb.Location = new System.Drawing.Point(54, 46);
            this.q_tb.Name = "q_tb";
            this.q_tb.Size = new System.Drawing.Size(89, 22);
            this.q_tb.TabIndex = 2;
            // 
            // e_tb
            // 
            this.e_tb.Location = new System.Drawing.Point(54, 74);
            this.e_tb.Name = "e_tb";
            this.e_tb.Size = new System.Drawing.Size(89, 22);
            this.e_tb.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.d_tb);
            this.groupBox2.Controls.Add(this.phi_tb);
            this.groupBox2.Controls.Add(this.privateKey_tb);
            this.groupBox2.Controls.Add(this.publicKey_tb);
            this.groupBox2.Controls.Add(this.n_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(173, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key Generation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generateKeys_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "phi (n)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "d";
            // 
            // phi_tb
            // 
            this.phi_tb.Location = new System.Drawing.Point(61, 50);
            this.phi_tb.Name = "phi_tb";
            this.phi_tb.ReadOnly = true;
            this.phi_tb.Size = new System.Drawing.Size(89, 22);
            this.phi_tb.TabIndex = 2;
            // 
            // d_tb
            // 
            this.d_tb.Location = new System.Drawing.Point(61, 77);
            this.d_tb.Name = "d_tb";
            this.d_tb.ReadOnly = true;
            this.d_tb.Size = new System.Drawing.Size(89, 22);
            this.d_tb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Public Key";
            // 
            // publicKey_tb
            // 
            this.publicKey_tb.Location = new System.Drawing.Point(451, 19);
            this.publicKey_tb.Name = "publicKey_tb";
            this.publicKey_tb.ReadOnly = true;
            this.publicKey_tb.Size = new System.Drawing.Size(164, 22);
            this.publicKey_tb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Private Key";
            // 
            // privateKey_tb
            // 
            this.privateKey_tb.Location = new System.Drawing.Point(451, 68);
            this.privateKey_tb.Name = "privateKey_tb";
            this.privateKey_tb.ReadOnly = true;
            this.privateKey_tb.Size = new System.Drawing.Size(164, 22);
            this.privateKey_tb.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encrypt_btn);
            this.groupBox3.Controls.Add(this.encrypted_tb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.message_tb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(13, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Message (numeric)";
            // 
            // message_tb
            // 
            this.message_tb.Location = new System.Drawing.Point(160, 19);
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(194, 22);
            this.message_tb.TabIndex = 2;
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(114, 105);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(108, 27);
            this.encrypt_btn.TabIndex = 0;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ciphertext";
            // 
            // encrypted_tb
            // 
            this.encrypted_tb.Location = new System.Drawing.Point(160, 59);
            this.encrypted_tb.Name = "encrypted_tb";
            this.encrypted_tb.ReadOnly = true;
            this.encrypted_tb.Size = new System.Drawing.Size(194, 22);
            this.encrypted_tb.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.decrypt_btn);
            this.groupBox4.Controls.Add(this.decrypted_tb);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.ciphertext_tb);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(443, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decryption";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(114, 105);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(108, 27);
            this.decrypt_btn.TabIndex = 0;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // decrypted_tb
            // 
            this.decrypted_tb.Location = new System.Drawing.Point(160, 59);
            this.decrypted_tb.Name = "decrypted_tb";
            this.decrypted_tb.ReadOnly = true;
            this.decrypted_tb.Size = new System.Drawing.Size(194, 22);
            this.decrypted_tb.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Plaintext";
            // 
            // ciphertext_tb
            // 
            this.ciphertext_tb.Location = new System.Drawing.Point(160, 19);
            this.ciphertext_tb.Name = "ciphertext_tb";
            this.ciphertext_tb.Size = new System.Drawing.Size(194, 22);
            this.ciphertext_tb.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ciphertext (numeric)";
            // 
            // p_tb
            // 
            this.p_tb.Location = new System.Drawing.Point(54, 16);
            this.p_tb.Name = "p_tb";
            this.p_tb.Size = new System.Drawing.Size(89, 22);
            this.p_tb.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.prosesOutput_tb);
            this.groupBox5.Location = new System.Drawing.Point(13, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 323);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Process";
            // 
            // prosesOutput_tb
            // 
            this.prosesOutput_tb.Location = new System.Drawing.Point(10, 22);
            this.prosesOutput_tb.Multiline = true;
            this.prosesOutput_tb.Name = "prosesOutput_tb";
            this.prosesOutput_tb.ReadOnly = true;
            this.prosesOutput_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.prosesOutput_tb.Size = new System.Drawing.Size(774, 295);
            this.prosesOutput_tb.TabIndex = 0;
            this.prosesOutput_tb.WordWrap = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 619);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enkripsi - Dekripsi | RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p_lbl;
        private System.Windows.Forms.TextBox e_tb;
        private System.Windows.Forms.TextBox q_tb;
        private System.Windows.Forms.TextBox n_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phi_tb;
        private System.Windows.Forms.TextBox d_tb;
        private System.Windows.Forms.TextBox privateKey_tb;
        private System.Windows.Forms.TextBox publicKey_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.TextBox message_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox encrypted_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.TextBox decrypted_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ciphertext_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox p_tb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox prosesOutput_tb;
    }
}