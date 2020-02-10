namespace tomcMatijaZadatak4
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnZbroj = new System.Windows.Forms.Button();
            this.btnRazlika = new System.Windows.Forms.Button();
            this.btnUmnozak = new System.Windows.Forms.Button();
            this.btnKvocijent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B=";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(97, 43);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(121, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(97, 80);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(121, 20);
            this.txtB.TabIndex = 3;
            // 
            // btnZbroj
            // 
            this.btnZbroj.Location = new System.Drawing.Point(274, 41);
            this.btnZbroj.Name = "btnZbroj";
            this.btnZbroj.Size = new System.Drawing.Size(75, 23);
            this.btnZbroj.TabIndex = 4;
            this.btnZbroj.Text = "Zbroj";
            this.btnZbroj.UseVisualStyleBackColor = true;
            this.btnZbroj.Click += new System.EventHandler(this.btnZbroj_Click);
            // 
            // btnRazlika
            // 
            this.btnRazlika.Location = new System.Drawing.Point(274, 78);
            this.btnRazlika.Name = "btnRazlika";
            this.btnRazlika.Size = new System.Drawing.Size(75, 23);
            this.btnRazlika.TabIndex = 5;
            this.btnRazlika.Text = "Razlika";
            this.btnRazlika.UseVisualStyleBackColor = true;
            this.btnRazlika.Click += new System.EventHandler(this.btnRazlika_Click);
            // 
            // btnUmnozak
            // 
            this.btnUmnozak.Location = new System.Drawing.Point(378, 41);
            this.btnUmnozak.Name = "btnUmnozak";
            this.btnUmnozak.Size = new System.Drawing.Size(75, 23);
            this.btnUmnozak.TabIndex = 6;
            this.btnUmnozak.Text = "Umnožak";
            this.btnUmnozak.UseVisualStyleBackColor = true;
            this.btnUmnozak.Click += new System.EventHandler(this.btnUmnozak_Click);
            // 
            // btnKvocijent
            // 
            this.btnKvocijent.Location = new System.Drawing.Point(378, 78);
            this.btnKvocijent.Name = "btnKvocijent";
            this.btnKvocijent.Size = new System.Drawing.Size(75, 23);
            this.btnKvocijent.TabIndex = 7;
            this.btnKvocijent.Text = "Kvocijent";
            this.btnKvocijent.UseVisualStyleBackColor = true;
            this.btnKvocijent.Click += new System.EventHandler(this.btnKvocijent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 141);
            this.Controls.Add(this.btnKvocijent);
            this.Controls.Add(this.btnUmnozak);
            this.Controls.Add(this.btnRazlika);
            this.Controls.Add(this.btnZbroj);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
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
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnZbroj;
        private System.Windows.Forms.Button btnRazlika;
        private System.Windows.Forms.Button btnUmnozak;
        private System.Windows.Forms.Button btnKvocijent;
    }
}

