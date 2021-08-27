
namespace foxhole_intelarty
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mapTileCmb = new System.Windows.Forms.ComboBox();
            this.dtsLbl = new System.Windows.Forms.Label();
            this.aziLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 508);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mapTileCmb
            // 
            this.mapTileCmb.FormattingEnabled = true;
            this.mapTileCmb.Location = new System.Drawing.Point(623, 526);
            this.mapTileCmb.Name = "mapTileCmb";
            this.mapTileCmb.Size = new System.Drawing.Size(213, 23);
            this.mapTileCmb.TabIndex = 1;
            // 
            // dtsLbl
            // 
            this.dtsLbl.AutoSize = true;
            this.dtsLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtsLbl.Location = new System.Drawing.Point(12, 526);
            this.dtsLbl.Name = "dtsLbl";
            this.dtsLbl.Size = new System.Drawing.Size(152, 45);
            this.dtsLbl.TabIndex = 2;
            this.dtsLbl.Text = "Distance: ";
            this.dtsLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // aziLbl
            // 
            this.aziLbl.AutoSize = true;
            this.aziLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aziLbl.Location = new System.Drawing.Point(12, 571);
            this.aziLbl.Name = "aziLbl";
            this.aziLbl.Size = new System.Drawing.Size(78, 45);
            this.aziLbl.TabIndex = 3;
            this.aziLbl.Text = "Azi: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 627);
            this.Controls.Add(this.aziLbl);
            this.Controls.Add(this.dtsLbl);
            this.Controls.Add(this.mapTileCmb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox mapTileCmb;
        private System.Windows.Forms.Label dtsLbl;
        private System.Windows.Forms.Label aziLbl;
    }
}

