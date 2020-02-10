namespace tomcMatijaZadatak2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 54);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(124, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.Text = "Unesite ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(100, 87);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(124, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Text = "Upisi prezime";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(52, 124);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(142, 29);
            this.btnPrikaz.TabIndex = 4;
            this.btnPrikaz.Text = "Prikaz podataka";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 180);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPrikaz;
    }
}

