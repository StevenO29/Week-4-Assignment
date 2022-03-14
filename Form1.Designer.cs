namespace Assigment_Week_4
{
    partial class FormPenambahanData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbLNama = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblNoTelp = new System.Windows.Forms.Label();
            this.TxtBoxInputNama = new System.Windows.Forms.TextBox();
            this.TxtBoxInputNoTelp = new System.Windows.Forms.TextBox();
            this.TxtBoxInputAlamat = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbLNama
            // 
            this.LbLNama.AutoSize = true;
            this.LbLNama.Location = new System.Drawing.Point(29, 29);
            this.LbLNama.Name = "LbLNama";
            this.LbLNama.Size = new System.Drawing.Size(68, 25);
            this.LbLNama.TabIndex = 0;
            this.LbLNama.Text = "Nama :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(29, 85);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(77, 25);
            this.LblAlamat.TabIndex = 1;
            this.LblAlamat.Text = "Alamat :";
            // 
            // LblNoTelp
            // 
            this.LblNoTelp.AutoSize = true;
            this.LblNoTelp.Location = new System.Drawing.Point(29, 145);
            this.LblNoTelp.Name = "LblNoTelp";
            this.LblNoTelp.Size = new System.Drawing.Size(90, 25);
            this.LblNoTelp.TabIndex = 2;
            this.LblNoTelp.Text = "No. Telp : ";
            // 
            // TxtBoxInputNama
            // 
            this.TxtBoxInputNama.Location = new System.Drawing.Point(139, 29);
            this.TxtBoxInputNama.Name = "TxtBoxInputNama";
            this.TxtBoxInputNama.Size = new System.Drawing.Size(577, 31);
            this.TxtBoxInputNama.TabIndex = 3;
            // 
            // TxtBoxInputNoTelp
            // 
            this.TxtBoxInputNoTelp.Location = new System.Drawing.Point(139, 145);
            this.TxtBoxInputNoTelp.Name = "TxtBoxInputNoTelp";
            this.TxtBoxInputNoTelp.Size = new System.Drawing.Size(577, 31);
            this.TxtBoxInputNoTelp.TabIndex = 4;
            this.TxtBoxInputNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxInputNoTelp_KeyPress);
            // 
            // TxtBoxInputAlamat
            // 
            this.TxtBoxInputAlamat.Location = new System.Drawing.Point(139, 85);
            this.TxtBoxInputAlamat.Name = "TxtBoxInputAlamat";
            this.TxtBoxInputAlamat.Size = new System.Drawing.Size(577, 31);
            this.TxtBoxInputAlamat.TabIndex = 5;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(29, 220);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(112, 34);
            this.BtnSimpan.TabIndex = 6;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnLihatData
            // 
            this.BtnLihatData.Location = new System.Drawing.Point(172, 220);
            this.BtnLihatData.Name = "BtnLihatData";
            this.BtnLihatData.Size = new System.Drawing.Size(112, 34);
            this.BtnLihatData.TabIndex = 7;
            this.BtnLihatData.Text = "Lihat Data";
            this.BtnLihatData.UseVisualStyleBackColor = true;
            this.BtnLihatData.Click += new System.EventHandler(this.BtnLihatData_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 296);
            this.Controls.Add(this.BtnLihatData);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtBoxInputAlamat);
            this.Controls.Add(this.TxtBoxInputNoTelp);
            this.Controls.Add(this.TxtBoxInputNama);
            this.Controls.Add(this.LblNoTelp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LbLNama);
            this.Name = "FormPenambahanData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLNama;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.Label LblNoTelp;
        private System.Windows.Forms.TextBox TxtBoxInputNama;
        private System.Windows.Forms.TextBox TxtBoxInputNoTelp;
        private System.Windows.Forms.TextBox TxtBoxInputAlamat;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnLihatData;
    }
}
