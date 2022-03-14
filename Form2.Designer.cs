namespace Assigment_Week_4
{
    partial class FormTampilanData
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
            this.LbLTampilanNama = new System.Windows.Forms.Label();
            this.LblTampilanAlamat = new System.Windows.Forms.Label();
            this.LblNoTelp = new System.Windows.Forms.Label();
            this.TxtBoxTampilanNama = new System.Windows.Forms.TextBox();
            this.TxtBoxTampilNoTelp = new System.Windows.Forms.TextBox();
            this.TxtBoxTampilAlamat = new System.Windows.Forms.TextBox();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnPrevData = new System.Windows.Forms.Button();
            this.BtnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbLTampilanNama
            // 
            this.LbLTampilanNama.AutoSize = true;
            this.LbLTampilanNama.Location = new System.Drawing.Point(26, 26);
            this.LbLTampilanNama.Name = "LbLTampilanNama";
            this.LbLTampilanNama.Size = new System.Drawing.Size(68, 25);
            this.LbLTampilanNama.TabIndex = 0;
            this.LbLTampilanNama.Text = "Nama :";
            // 
            // LblTampilanAlamat
            // 
            this.LblTampilanAlamat.AutoSize = true;
            this.LblTampilanAlamat.Location = new System.Drawing.Point(26, 85);
            this.LblTampilanAlamat.Name = "LblTampilanAlamat";
            this.LblTampilanAlamat.Size = new System.Drawing.Size(77, 25);
            this.LblTampilanAlamat.TabIndex = 1;
            this.LblTampilanAlamat.Text = "Alamat :";
            // 
            // LblNoTelp
            // 
            this.LblNoTelp.AutoSize = true;
            this.LblNoTelp.Location = new System.Drawing.Point(26, 142);
            this.LblNoTelp.Name = "LblNoTelp";
            this.LblNoTelp.Size = new System.Drawing.Size(85, 25);
            this.LblNoTelp.TabIndex = 2;
            this.LblNoTelp.Text = "No. Telp :";
            // 
            // TxtBoxTampilanNama
            // 
            this.TxtBoxTampilanNama.Enabled = false;
            this.TxtBoxTampilanNama.Location = new System.Drawing.Point(126, 26);
            this.TxtBoxTampilanNama.Name = "TxtBoxTampilanNama";
            this.TxtBoxTampilanNama.Size = new System.Drawing.Size(582, 31);
            this.TxtBoxTampilanNama.TabIndex = 3;
            // 
            // TxtBoxTampilNoTelp
            // 
            this.TxtBoxTampilNoTelp.Enabled = false;
            this.TxtBoxTampilNoTelp.Location = new System.Drawing.Point(126, 142);
            this.TxtBoxTampilNoTelp.Name = "TxtBoxTampilNoTelp";
            this.TxtBoxTampilNoTelp.Size = new System.Drawing.Size(582, 31);
            this.TxtBoxTampilNoTelp.TabIndex = 4;
            // 
            // TxtBoxTampilAlamat
            // 
            this.TxtBoxTampilAlamat.Enabled = false;
            this.TxtBoxTampilAlamat.Location = new System.Drawing.Point(126, 85);
            this.TxtBoxTampilAlamat.Name = "TxtBoxTampilAlamat";
            this.TxtBoxTampilAlamat.Size = new System.Drawing.Size(582, 31);
            this.TxtBoxTampilAlamat.TabIndex = 5;
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(26, 219);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(112, 34);
            this.BtnKembali.TabIndex = 6;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // BtnPrevData
            // 
            this.BtnPrevData.Location = new System.Drawing.Point(162, 219);
            this.BtnPrevData.Name = "BtnPrevData";
            this.BtnPrevData.Size = new System.Drawing.Size(112, 34);
            this.BtnPrevData.TabIndex = 7;
            this.BtnPrevData.Text = "Prev Data";
            this.BtnPrevData.UseVisualStyleBackColor = true;
            this.BtnPrevData.Click += new System.EventHandler(this.BtnPrevData_Click);
            // 
            // BtnNextData
            // 
            this.BtnNextData.Location = new System.Drawing.Point(298, 219);
            this.BtnNextData.Name = "BtnNextData";
            this.BtnNextData.Size = new System.Drawing.Size(112, 34);
            this.BtnNextData.TabIndex = 8;
            this.BtnNextData.Text = "Next Data";
            this.BtnNextData.UseVisualStyleBackColor = true;
            this.BtnNextData.Click += new System.EventHandler(this.BtnNextData_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 293);
            this.Controls.Add(this.BtnNextData);
            this.Controls.Add(this.BtnPrevData);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.TxtBoxTampilAlamat);
            this.Controls.Add(this.TxtBoxTampilNoTelp);
            this.Controls.Add(this.TxtBoxTampilanNama);
            this.Controls.Add(this.LblNoTelp);
            this.Controls.Add(this.LblTampilanAlamat);
            this.Controls.Add(this.LbLTampilanNama);
            this.Name = "FormTampilanData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLTampilanNama;
        private System.Windows.Forms.Label LblTampilanAlamat;
        private System.Windows.Forms.Label LblNoTelp;
        private System.Windows.Forms.TextBox TxtBoxTampilanNama;
        private System.Windows.Forms.TextBox TxtBoxTampilNoTelp;
        private System.Windows.Forms.TextBox TxtBoxTampilAlamat;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnPrevData;
        private System.Windows.Forms.Button BtnNextData;
    }
}