namespace DES.Views
{
    partial class Form1
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
            this.proses_lbl = new System.Windows.Forms.Label();
            this.plaintextOutput_tb = new System.Windows.Forms.TextBox();
            this.kunciDesInput_tb2 = new System.Windows.Forms.TextBox();
            this.cyphertextInput_tb = new System.Windows.Forms.TextBox();
            this.dekripsi_lbl = new System.Windows.Forms.Label();
            this.plaintextOutput_lbl = new System.Windows.Forms.Label();
            this.kunciDesInput_lbl2 = new System.Windows.Forms.Label();
            this.cyphertextInput_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prosesOutput_tb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.start_btn2 = new System.Windows.Forms.Button();
            this.kunciDesInput_tb = new System.Windows.Forms.TextBox();
            this.cyphertextOutput_lbl = new System.Windows.Forms.Label();
            this.kunciDesInput_lbl = new System.Windows.Forms.Label();
            this.plaintextInput_tb = new System.Windows.Forms.TextBox();
            this.enkripsi_lbl = new System.Windows.Forms.Label();
            this.plaintextInput_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.enkripsiOutput_tb = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proses_lbl
            // 
            this.proses_lbl.AutoSize = true;
            this.proses_lbl.Location = new System.Drawing.Point(17, 14);
            this.proses_lbl.Name = "proses_lbl";
            this.proses_lbl.Size = new System.Drawing.Size(53, 16);
            this.proses_lbl.TabIndex = 0;
            this.proses_lbl.Text = "Proses:";
            this.proses_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plaintextOutput_tb
            // 
            this.plaintextOutput_tb.Location = new System.Drawing.Point(159, 118);
            this.plaintextOutput_tb.Name = "plaintextOutput_tb";
            this.plaintextOutput_tb.ReadOnly = true;
            this.plaintextOutput_tb.Size = new System.Drawing.Size(231, 22);
            this.plaintextOutput_tb.TabIndex = 1;
            // 
            // kunciDesInput_tb2
            // 
            this.kunciDesInput_tb2.Location = new System.Drawing.Point(159, 80);
            this.kunciDesInput_tb2.Name = "kunciDesInput_tb2";
            this.kunciDesInput_tb2.Size = new System.Drawing.Size(231, 22);
            this.kunciDesInput_tb2.TabIndex = 1;
            // 
            // cyphertextInput_tb
            // 
            this.cyphertextInput_tb.Location = new System.Drawing.Point(159, 44);
            this.cyphertextInput_tb.Name = "cyphertextInput_tb";
            this.cyphertextInput_tb.Size = new System.Drawing.Size(231, 22);
            this.cyphertextInput_tb.TabIndex = 1;
            // 
            // dekripsi_lbl
            // 
            this.dekripsi_lbl.AutoSize = true;
            this.dekripsi_lbl.Location = new System.Drawing.Point(156, 14);
            this.dekripsi_lbl.Name = "dekripsi_lbl";
            this.dekripsi_lbl.Size = new System.Drawing.Size(57, 16);
            this.dekripsi_lbl.TabIndex = 0;
            this.dekripsi_lbl.Text = "Dekripsi";
            this.dekripsi_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plaintextOutput_lbl
            // 
            this.plaintextOutput_lbl.AutoSize = true;
            this.plaintextOutput_lbl.Location = new System.Drawing.Point(16, 124);
            this.plaintextOutput_lbl.Name = "plaintextOutput_lbl";
            this.plaintextOutput_lbl.Size = new System.Drawing.Size(57, 16);
            this.plaintextOutput_lbl.TabIndex = 0;
            this.plaintextOutput_lbl.Text = "Plaintext";
            this.plaintextOutput_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kunciDesInput_lbl2
            // 
            this.kunciDesInput_lbl2.AutoSize = true;
            this.kunciDesInput_lbl2.Location = new System.Drawing.Point(16, 84);
            this.kunciDesInput_lbl2.Name = "kunciDesInput_lbl2";
            this.kunciDesInput_lbl2.Size = new System.Drawing.Size(70, 16);
            this.kunciDesInput_lbl2.TabIndex = 0;
            this.kunciDesInput_lbl2.Text = "Kunci DES";
            this.kunciDesInput_lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cyphertextInput_lbl
            // 
            this.cyphertextInput_lbl.AutoSize = true;
            this.cyphertextInput_lbl.Location = new System.Drawing.Point(16, 47);
            this.cyphertextInput_lbl.Name = "cyphertextInput_lbl";
            this.cyphertextInput_lbl.Size = new System.Drawing.Size(70, 16);
            this.cyphertextInput_lbl.TabIndex = 0;
            this.cyphertextInput_lbl.Text = "Cyphertext";
            this.cyphertextInput_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prosesOutput_tb);
            this.panel3.Controls.Add(this.proses_lbl);
            this.panel3.Location = new System.Drawing.Point(12, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(856, 322);
            this.panel3.TabIndex = 4;
            // 
            // prosesOutput_tb
            // 
            this.prosesOutput_tb.Location = new System.Drawing.Point(20, 34);
            this.prosesOutput_tb.Multiline = true;
            this.prosesOutput_tb.Name = "prosesOutput_tb";
            this.prosesOutput_tb.ReadOnly = true;
            this.prosesOutput_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.prosesOutput_tb.Size = new System.Drawing.Size(823, 273);
            this.prosesOutput_tb.TabIndex = 1;
            this.prosesOutput_tb.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.start_btn2);
            this.panel2.Controls.Add(this.plaintextOutput_tb);
            this.panel2.Controls.Add(this.kunciDesInput_tb2);
            this.panel2.Controls.Add(this.cyphertextInput_tb);
            this.panel2.Controls.Add(this.dekripsi_lbl);
            this.panel2.Controls.Add(this.plaintextOutput_lbl);
            this.panel2.Controls.Add(this.kunciDesInput_lbl2);
            this.panel2.Controls.Add(this.cyphertextInput_lbl);
            this.panel2.Location = new System.Drawing.Point(466, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 249);
            this.panel2.TabIndex = 2;
            // 
            // start_btn2
            // 
            this.start_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start_btn2.Location = new System.Drawing.Point(140, 199);
            this.start_btn2.Name = "start_btn2";
            this.start_btn2.Size = new System.Drawing.Size(152, 47);
            this.start_btn2.TabIndex = 5;
            this.start_btn2.Text = "START";
            this.start_btn2.UseVisualStyleBackColor = false;
            this.start_btn2.Click += new System.EventHandler(this.start_btn2_Click);
            // 
            // kunciDesInput_tb
            // 
            this.kunciDesInput_tb.Location = new System.Drawing.Point(159, 80);
            this.kunciDesInput_tb.Name = "kunciDesInput_tb";
            this.kunciDesInput_tb.Size = new System.Drawing.Size(231, 22);
            this.kunciDesInput_tb.TabIndex = 1;
            // 
            // cyphertextOutput_lbl
            // 
            this.cyphertextOutput_lbl.AutoSize = true;
            this.cyphertextOutput_lbl.Location = new System.Drawing.Point(16, 124);
            this.cyphertextOutput_lbl.Name = "cyphertextOutput_lbl";
            this.cyphertextOutput_lbl.Size = new System.Drawing.Size(70, 16);
            this.cyphertextOutput_lbl.TabIndex = 0;
            this.cyphertextOutput_lbl.Text = "Cyphertext";
            this.cyphertextOutput_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kunciDesInput_lbl
            // 
            this.kunciDesInput_lbl.AutoSize = true;
            this.kunciDesInput_lbl.Location = new System.Drawing.Point(16, 84);
            this.kunciDesInput_lbl.Name = "kunciDesInput_lbl";
            this.kunciDesInput_lbl.Size = new System.Drawing.Size(70, 16);
            this.kunciDesInput_lbl.TabIndex = 0;
            this.kunciDesInput_lbl.Text = "Kunci DES";
            this.kunciDesInput_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plaintextInput_tb
            // 
            this.plaintextInput_tb.Location = new System.Drawing.Point(159, 44);
            this.plaintextInput_tb.Name = "plaintextInput_tb";
            this.plaintextInput_tb.Size = new System.Drawing.Size(231, 22);
            this.plaintextInput_tb.TabIndex = 1;
            // 
            // enkripsi_lbl
            // 
            this.enkripsi_lbl.AutoSize = true;
            this.enkripsi_lbl.Location = new System.Drawing.Point(156, 14);
            this.enkripsi_lbl.Name = "enkripsi_lbl";
            this.enkripsi_lbl.Size = new System.Drawing.Size(55, 16);
            this.enkripsi_lbl.TabIndex = 0;
            this.enkripsi_lbl.Text = "Enkripsi";
            this.enkripsi_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plaintextInput_lbl
            // 
            this.plaintextInput_lbl.AutoSize = true;
            this.plaintextInput_lbl.Location = new System.Drawing.Point(16, 47);
            this.plaintextInput_lbl.Name = "plaintextInput_lbl";
            this.plaintextInput_lbl.Size = new System.Drawing.Size(57, 16);
            this.plaintextInput_lbl.TabIndex = 0;
            this.plaintextInput_lbl.Text = "Plaintext";
            this.plaintextInput_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Controls.Add(this.enkripsiOutput_tb);
            this.panel1.Controls.Add(this.kunciDesInput_tb);
            this.panel1.Controls.Add(this.plaintextInput_tb);
            this.panel1.Controls.Add(this.enkripsi_lbl);
            this.panel1.Controls.Add(this.cyphertextOutput_lbl);
            this.panel1.Controls.Add(this.kunciDesInput_lbl);
            this.panel1.Controls.Add(this.plaintextInput_lbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 252);
            this.panel1.TabIndex = 3;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start_btn.Location = new System.Drawing.Point(121, 202);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(152, 47);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // enkripsiOutput_tb
            // 
            this.enkripsiOutput_tb.Location = new System.Drawing.Point(159, 118);
            this.enkripsiOutput_tb.Name = "enkripsiOutput_tb";
            this.enkripsiOutput_tb.ReadOnly = true;
            this.enkripsiOutput_tb.Size = new System.Drawing.Size(231, 22);
            this.enkripsiOutput_tb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enkripsi-Dekripsi | DES";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label proses_lbl;
        private System.Windows.Forms.TextBox plaintextOutput_tb;
        private System.Windows.Forms.TextBox kunciDesInput_tb2;
        private System.Windows.Forms.TextBox cyphertextInput_tb;
        private System.Windows.Forms.Label dekripsi_lbl;
        private System.Windows.Forms.Label plaintextOutput_lbl;
        private System.Windows.Forms.Label kunciDesInput_lbl2;
        private System.Windows.Forms.Label cyphertextInput_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox prosesOutput_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox kunciDesInput_tb;
        private System.Windows.Forms.Label cyphertextOutput_lbl;
        private System.Windows.Forms.Label kunciDesInput_lbl;
        private System.Windows.Forms.TextBox plaintextInput_tb;
        private System.Windows.Forms.Label enkripsi_lbl;
        private System.Windows.Forms.Label plaintextInput_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox enkripsiOutput_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button start_btn2;
    }
}

