
namespace Bankautomat
{
    partial class FormÜberweisung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜberweisung));
            this.lblÜberschrift = new System.Windows.Forms.Label();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.lblBetrag = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.tbBetrag = new System.Windows.Forms.TextBox();
            this.bttnÜberweisen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblÜberschrift
            // 
            this.lblÜberschrift.AutoSize = true;
            this.lblÜberschrift.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÜberschrift.Location = new System.Drawing.Point(153, 102);
            this.lblÜberschrift.Name = "lblÜberschrift";
            this.lblÜberschrift.Size = new System.Drawing.Size(272, 17);
            this.lblÜberschrift.TabIndex = 0;
            this.lblÜberschrift.Text = "Hier können sie eine Überweisung tätigen";
            // 
            // tbPerson
            // 
            this.tbPerson.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPerson.Location = new System.Drawing.Point(237, 243);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(122, 21);
            this.tbPerson.TabIndex = 2;
            this.tbPerson.TextChanged += new System.EventHandler(this.tbPerson_TextChanged);
            // 
            // lblBetrag
            // 
            this.lblBetrag.AutoSize = true;
            this.lblBetrag.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetrag.Location = new System.Drawing.Point(234, 163);
            this.lblBetrag.Name = "lblBetrag";
            this.lblBetrag.Size = new System.Drawing.Size(46, 16);
            this.lblBetrag.TabIndex = 3;
            this.lblBetrag.Text = "Betrag:";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(234, 224);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(46, 16);
            this.lblPerson.TabIndex = 4;
            this.lblPerson.Text = "Person:";
            // 
            // tbBetrag
            // 
            this.tbBetrag.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBetrag.Location = new System.Drawing.Point(237, 183);
            this.tbBetrag.Name = "tbBetrag";
            this.tbBetrag.Size = new System.Drawing.Size(122, 21);
            this.tbBetrag.TabIndex = 5;
            this.tbBetrag.TextChanged += new System.EventHandler(this.tbBetrag_TextChanged);
            // 
            // bttnÜberweisen
            // 
            this.bttnÜberweisen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnÜberweisen.Location = new System.Drawing.Point(197, 284);
            this.bttnÜberweisen.Name = "bttnÜberweisen";
            this.bttnÜberweisen.Size = new System.Drawing.Size(162, 31);
            this.bttnÜberweisen.TabIndex = 6;
            this.bttnÜberweisen.Text = "Überweisen";
            this.bttnÜberweisen.UseVisualStyleBackColor = true;
            this.bttnÜberweisen.Click += new System.EventHandler(this.bttnÜberweisen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Überweisung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // FormÜberweisung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnÜberweisen);
            this.Controls.Add(this.tbBetrag);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblBetrag);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.lblÜberschrift);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormÜberweisung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Überweisung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormÜberweisung_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblÜberschrift;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.Label lblBetrag;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox tbBetrag;
        private System.Windows.Forms.Button bttnÜberweisen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}