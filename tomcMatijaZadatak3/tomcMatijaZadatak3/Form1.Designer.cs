namespace tomcMatijaZadatak3
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
            this.txtPrviBr = new System.Windows.Forms.TextBox();
            this.txtDrugiBr = new System.Windows.Forms.TextBox();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvi broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugi broj:";
            // 
            // txtPrviBr
            // 
            this.txtPrviBr.Location = new System.Drawing.Point(141, 52);
            this.txtPrviBr.Name = "txtPrviBr";
            this.txtPrviBr.Size = new System.Drawing.Size(112, 20);
            this.txtPrviBr.TabIndex = 2;
            // 
            // txtDrugiBr
            // 
            this.txtDrugiBr.Location = new System.Drawing.Point(141, 88);
            this.txtDrugiBr.Name = "txtDrugiBr";
            this.txtDrugiBr.Size = new System.Drawing.Size(112, 20);
            this.txtDrugiBr.TabIndex = 3;
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(89, 131);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(104, 24);
            this.btnIzracun.TabIndex = 4;
            this.btnIzracun.Text = "Izraćunaj zbroj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 211);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.txtDrugiBr);
            this.Controls.Add(this.txtPrviBr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrviBr;
        private System.Windows.Forms.TextBox txtDrugiBr;
        private System.Windows.Forms.Button btnIzracun;
    }
}

