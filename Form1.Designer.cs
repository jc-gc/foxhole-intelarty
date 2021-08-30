
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
            this.mapTileCmb = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtsLbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.aziLbl = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxMap)).BeginInit();
            this.metroSetPanel1.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBoxMap
            // 
            this.imgBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBoxMap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgBoxMap.Location = new System.Drawing.Point(15, 78);
            this.imgBoxMap.Name = "imgBoxMap";
            this.imgBoxMap.Size = new System.Drawing.Size(1068, 922);
            this.imgBoxMap.TabIndex = 0;
            this.imgBoxMap.TabStop = false;
            this.imgBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgBoxMap_MouseClick);
            // 
            // mapTileCmb
            // 
            this.mapTileCmb.AllowDrop = true;
            this.mapTileCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapTileCmb.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mapTileCmb.BackColor = System.Drawing.Color.Transparent;
            this.mapTileCmb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mapTileCmb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.mapTileCmb.CausesValidation = false;
            this.mapTileCmb.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mapTileCmb.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mapTileCmb.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mapTileCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mapTileCmb.DropDownHeight = 600;
            this.mapTileCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapTileCmb.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapTileCmb.FormattingEnabled = true;
            this.mapTileCmb.IntegralHeight = false;
            this.mapTileCmb.IsDerivedStyle = true;
            this.mapTileCmb.ItemHeight = 40;
            this.mapTileCmb.Location = new System.Drawing.Point(598, 15);
            this.mapTileCmb.MaxDropDownItems = 16;
            this.mapTileCmb.Name = "mapTileCmb";
            this.mapTileCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mapTileCmb.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mapTileCmb.SelectedItemForeColor = System.Drawing.Color.White;
            this.mapTileCmb.Size = new System.Drawing.Size(485, 46);
            this.mapTileCmb.Style = MetroSet_UI.Enums.Style.Dark;
            this.mapTileCmb.StyleManager = null;
            this.mapTileCmb.TabIndex = 4;
            this.mapTileCmb.ThemeAuthor = "Narwin";
            this.mapTileCmb.ThemeName = "MetroDark";
            this.mapTileCmb.SelectedIndexChanged += new System.EventHandler(this.mapTileCmb_SelectedIndexChanged_1);
            // 
            // dtsLbl
            // 
            this.dtsLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtsLbl.IsDerivedStyle = true;
            this.dtsLbl.Location = new System.Drawing.Point(0, 0);
            this.dtsLbl.Name = "dtsLbl";
            this.dtsLbl.Size = new System.Drawing.Size(265, 46);
            this.dtsLbl.Style = MetroSet_UI.Enums.Style.Dark;
            this.dtsLbl.StyleManager = null;
            this.dtsLbl.TabIndex = 5;
            this.dtsLbl.Text = "Distance: ";
            this.dtsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtsLbl.ThemeAuthor = "Narwin";
            this.dtsLbl.ThemeName = "MetroDark";
            // 
            // aziLbl
            // 
            this.aziLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aziLbl.IsDerivedStyle = true;
            this.aziLbl.Location = new System.Drawing.Point(0, 0);
            this.aziLbl.Name = "aziLbl";
            this.aziLbl.Size = new System.Drawing.Size(265, 46);
            this.aziLbl.Style = MetroSet_UI.Enums.Style.Dark;
            this.aziLbl.StyleManager = null;
            this.aziLbl.TabIndex = 6;
            this.aziLbl.Text = "Azimuth: ";
            this.aziLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aziLbl.ThemeAuthor = "Narwin";
            this.aziLbl.ThemeName = "MetroDark";
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.IsDerivedStyle = true;
            this.metroSetDivider1.Location = new System.Drawing.Point(15, 67);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider1.Size = new System.Drawing.Size(1089, 4);
            this.metroSetDivider1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 7;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroDark";
            this.metroSetDivider1.Thickness = 1;
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.dtsLbl);
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(15, 15);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(325, 46);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 8;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.aziLbl);
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(346, 15);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(246, 46);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 8;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroDark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1098, 1015);
            this.Controls.Add(this.metroSetPanel2);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.metroSetDivider1);
            this.Controls.Add(this.mapTileCmb);
            this.Controls.Add(this.imgBoxMap);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "FORM1";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxMap)).EndInit();
            this.metroSetPanel1.ResumeLayout(false);
            this.metroSetPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBoxMap;
        private MetroSet_UI.Controls.MetroSetComboBox mapTileCmb;
        private MetroSet_UI.Controls.MetroSetLabel dtsLbl;
        private MetroSet_UI.Controls.MetroSetLabel aziLbl;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
    }
}

