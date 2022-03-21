
namespace Bankautomat
{
    partial class FormEinzahlen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEinzahlen));
            this.bttnEinzahlen = new System.Windows.Forms.Button();
            this.tbEinzahlen = new System.Windows.Forms.TextBox();
            this.lblEinzahlen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnEinzahlen
            // 
            this.bttnEinzahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEinzahlen.Location = new System.Drawing.Point(272, 207);
            this.bttnEinzahlen.Name = "bttnEinzahlen";
            this.bttnEinzahlen.Size = new System.Drawing.Size(100, 23);
            this.bttnEinzahlen.TabIndex = 1;
            this.bttnEinzahlen.Text = "Einzahlen";
            this.bttnEinzahlen.UseVisualStyleBackColor = true;
            this.bttnEinzahlen.Click += new System.EventHandler(this.bttnEinzahlen_Click);
            // 
            // tbEinzahlen
            // 
            this.tbEinzahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEinzahlen.Location = new System.Drawing.Point(272, 169);
            this.tbEinzahlen.Name = "tbEinzahlen";
            this.tbEinzahlen.Size = new System.Drawing.Size(100, 21);
            this.tbEinzahlen.TabIndex = 2;
            this.tbEinzahlen.TextChanged += new System.EventHandler(this.tbEinzahlen_TextChanged);
            // 
            // lblEinzahlen
            // 
            this.lblEinzahlen.AutoSize = true;
            this.lblEinzahlen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEinzahlen.Location = new System.Drawing.Point(167, 111);
            this.lblEinzahlen.Name = "lblEinzahlen";
            this.lblEinzahlen.Size = new System.Drawing.Size(320, 17);
            this.lblEinzahlen.TabIndex = 3;
            this.lblEinzahlen.Text = "Gebe den Betrag ein den Sie einzahlen möchten";
            this.lblEinzahlen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Einzahlen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betrag:";
            // 
            // FormEinzahlen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEinzahlen);
            this.Controls.Add(this.tbEinzahlen);
            this.Controls.Add(this.bttnEinzahlen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEinzahlen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontostand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEinzahlen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnEinzahlen;
        private System.Windows.Forms.TextBox tbEinzahlen;
        private System.Windows.Forms.Label lblEinzahlen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}