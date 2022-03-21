
namespace Bankautomat
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.bttnEinzahlen = new System.Windows.Forms.Button();
            this.bttnAuszahlen = new System.Windows.Forms.Button();
            this.bttnÜberweisung = new System.Windows.Forms.Button();
            this.bttnKontoa = new System.Windows.Forms.Button();
            this.bttnKontostand = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnEinzahlen
            // 
            this.bttnEinzahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEinzahlen.Location = new System.Drawing.Point(11, 95);
            this.bttnEinzahlen.Name = "bttnEinzahlen";
            this.bttnEinzahlen.Size = new System.Drawing.Size(109, 23);
            this.bttnEinzahlen.TabIndex = 1;
            this.bttnEinzahlen.Text = "Einzahlen";
            this.bttnEinzahlen.UseVisualStyleBackColor = true;
            this.bttnEinzahlen.Click += new System.EventHandler(this.bttnEinzahlen_Click);
            // 
            // bttnAuszahlen
            // 
            this.bttnAuszahlen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAuszahlen.Location = new System.Drawing.Point(11, 150);
            this.bttnAuszahlen.Name = "bttnAuszahlen";
            this.bttnAuszahlen.Size = new System.Drawing.Size(109, 23);
            this.bttnAuszahlen.TabIndex = 2;
            this.bttnAuszahlen.Text = "Auszahlen";
            this.bttnAuszahlen.UseVisualStyleBackColor = true;
            this.bttnAuszahlen.Click += new System.EventHandler(this.bttnAuszahlen_Click);
            // 
            // bttnÜberweisung
            // 
            this.bttnÜberweisung.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnÜberweisung.Location = new System.Drawing.Point(11, 194);
            this.bttnÜberweisung.Name = "bttnÜberweisung";
            this.bttnÜberweisung.Size = new System.Drawing.Size(109, 23);
            this.bttnÜberweisung.TabIndex = 3;
            this.bttnÜberweisung.Text = "Überweisung";
            this.bttnÜberweisung.UseVisualStyleBackColor = true;
            this.bttnÜberweisung.Click += new System.EventHandler(this.bttnÜberweisung_Click);
            // 
            // bttnKontoa
            // 
            this.bttnKontoa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnKontoa.Location = new System.Drawing.Point(11, 239);
            this.bttnKontoa.Name = "bttnKontoa";
            this.bttnKontoa.Size = new System.Drawing.Size(109, 26);
            this.bttnKontoa.TabIndex = 4;
            this.bttnKontoa.Text = "Konto Auszüge";
            this.bttnKontoa.UseVisualStyleBackColor = true;
            this.bttnKontoa.Click += new System.EventHandler(this.bttnKontoa_Click);
            // 
            // bttnKontostand
            // 
            this.bttnKontostand.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnKontostand.Location = new System.Drawing.Point(12, 285);
            this.bttnKontostand.Name = "bttnKontostand";
            this.bttnKontostand.Size = new System.Drawing.Size(108, 23);
            this.bttnKontostand.TabIndex = 5;
            this.bttnKontostand.Text = "Kontostand Abfragen";
            this.bttnKontostand.UseVisualStyleBackColor = true;
            this.bttnKontostand.Click += new System.EventHandler(this.bttnKontostand_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(8, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 22);
            this.lblWelcome.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Exit";
            // 
            // panelDashboard
            // 
            this.panelDashboard.Location = new System.Drawing.Point(125, 59);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(675, 392);
            this.panelDashboard.TabIndex = 11;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.bttnKontostand);
            this.Controls.Add(this.bttnKontoa);
            this.Controls.Add(this.bttnÜberweisung);
            this.Controls.Add(this.bttnAuszahlen);
            this.Controls.Add(this.bttnEinzahlen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnEinzahlen;
        private System.Windows.Forms.Button bttnAuszahlen;
        private System.Windows.Forms.Button bttnÜberweisung;
        private System.Windows.Forms.Button bttnKontoa;
        private System.Windows.Forms.Button bttnKontostand;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDashboard;
    }
}