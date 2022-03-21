
namespace Bankautomat
{
    partial class FormKontostand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontostand));
            this.lblKontostandtext = new System.Windows.Forms.Label();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKontostandtext
            // 
            this.lblKontostandtext.AutoSize = true;
            this.lblKontostandtext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontostandtext.Location = new System.Drawing.Point(203, 87);
            this.lblKontostandtext.Name = "lblKontostandtext";
            this.lblKontostandtext.Size = new System.Drawing.Size(232, 17);
            this.lblKontostandtext.TabIndex = 0;
            this.lblKontostandtext.Text = "Dein Aktueller Kontostand beträgt:";
            this.lblKontostandtext.Click += new System.EventHandler(this.lblKontostandtext_Click);
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontostand.Location = new System.Drawing.Point(318, 157);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(0, 20);
            this.lblKontostand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kontostand";
            // 
            // FormKontostand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.lblKontostandtext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKontostand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontostand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKontostand_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKontostandtext;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.Label label1;
    }
}