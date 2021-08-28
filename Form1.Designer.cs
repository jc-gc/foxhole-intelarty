
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
            this.imgBoxMap = new System.Windows.Forms.PictureBox();
            this.mapTileCmb = new System.Windows.Forms.ComboBox();
            this.dtsLbl = new System.Windows.Forms.Label();
            this.aziLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBoxMap
            // 
            this.imgBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBoxMap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgBoxMap.Location = new System.Drawing.Point(12, 12);
            this.imgBoxMap.Name = "imgBoxMap";
            this.imgBoxMap.Size = new System.Drawing.Size(1163, 928);
            this.imgBoxMap.TabIndex = 0;
            this.imgBoxMap.TabStop = false;
            this.imgBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.imgBoxMap_Paint);
            this.imgBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgBoxMap_MouseClick);
            // 
            // mapTileCmb
            // 
            this.mapTileCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapTileCmb.FormattingEnabled = true;
            this.mapTileCmb.Location = new System.Drawing.Point(670, 946);
            this.mapTileCmb.Name = "mapTileCmb";
            this.mapTileCmb.Size = new System.Drawing.Size(505, 23);
            this.mapTileCmb.TabIndex = 1;
            this.mapTileCmb.SelectedIndexChanged += new System.EventHandler(this.mapTileCmb_SelectedIndexChanged);
            // 
            // dtsLbl
            // 
            this.dtsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtsLbl.AutoSize = true;
            this.dtsLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtsLbl.Location = new System.Drawing.Point(12, 946);
            this.dtsLbl.Name = "dtsLbl";
            this.dtsLbl.Size = new System.Drawing.Size(152, 45);
            this.dtsLbl.TabIndex = 2;
            this.dtsLbl.Text = "Distance: ";
            // 
            // aziLbl
            // 
            this.aziLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aziLbl.AutoSize = true;
            this.aziLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aziLbl.Location = new System.Drawing.Point(12, 991);
            this.aziLbl.Name = "aziLbl";
            this.aziLbl.Size = new System.Drawing.Size(78, 45);
            this.aziLbl.TabIndex = 3;
            this.aziLbl.Text = "Azi: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 1043);
            this.Controls.Add(this.aziLbl);
            this.Controls.Add(this.dtsLbl);
            this.Controls.Add(this.mapTileCmb);
            this.Controls.Add(this.imgBoxMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBoxMap;
        private System.Windows.Forms.ComboBox mapTileCmb;
        private System.Windows.Forms.Label dtsLbl;
        private System.Windows.Forms.Label aziLbl;
    }
}

