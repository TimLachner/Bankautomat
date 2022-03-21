
namespace Bankautomat
{
    partial class FormAuszahlen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuszahlen));
            this.tbAuszahlen = new System.Windows.Forms.TextBox();
            this.bttnAuszahlen = new System.Windows.Forms.Button();
            this.lblEinzahlen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAuszahlen
            // 
            this.tbAuszahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuszahlen.Location = new System.Drawing.Point(261, 167);
            this.tbAuszahlen.Name = "tbAuszahlen";
            this.tbAuszahlen.Size = new System.Drawing.Size(100, 21);
            this.tbAuszahlen.TabIndex = 2;
            this.tbAuszahlen.TextChanged += new System.EventHandler(this.tbAuszahlen_TextChanged);
            // 
            // bttnAuszahlen
            // 
            this.bttnAuszahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAuszahlen.Location = new System.Drawing.Point(261, 211);
            this.bttnAuszahlen.Name = "bttnAuszahlen";
            this.bttnAuszahlen.Size = new System.Drawing.Size(100, 23);
            this.bttnAuszahlen.TabIndex = 4;
            this.bttnAuszahlen.Text = "Auszahlen";
            this.bttnAuszahlen.UseVisualStyleBackColor = true;
            this.bttnAuszahlen.Click += new System.EventHandler(this.bttnAuszahlen_Click);
            // 
            // lblEinzahlen
            // 
            this.lblEinzahlen.AutoSize = true;
            this.lblEinzahlen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEinzahlen.Location = new System.Drawing.Point(155, 120);
            this.lblEinzahlen.Name = "lblEinzahlen";
            this.lblEinzahlen.Size = new System.Drawing.Size(323, 17);
            this.lblEinzahlen.TabIndex = 5;
            this.lblEinzahlen.Text = "Gebe den Betrag ein den Sie auszahlen möchten";
            this.lblEinzahlen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Betrag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Auszahlen";
            // 
            // FormAuszahlen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEinzahlen);
            this.Controls.Add(this.bttnAuszahlen);
            this.Controls.Add(this.tbAuszahlen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuszahlen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuszahlen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuszahlen_FormClosing);
            this.Load += new System.EventHandler(this.FormAuszahlen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAuszahlen;
        private System.Windows.Forms.Button bttnAuszahlen;
        private System.Windows.Forms.Label lblEinzahlen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}