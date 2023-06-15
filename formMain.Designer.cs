namespace EvE_Mission_Helper
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.pctScreenshot = new System.Windows.Forms.PictureBox();
            this.pctInvert = new System.Windows.Forms.PictureBox();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.pctCrop = new System.Windows.Forms.PictureBox();
            this.pctGrayscale = new System.Windows.Forms.PictureBox();
            this.btnOCR = new System.Windows.Forms.Button();
            this.btnURIDirect = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScreenshot = new System.Windows.Forms.Label();
            this.lblCrop = new System.Windows.Forms.Label();
            this.lblInvert = new System.Windows.Forms.Label();
            this.lblGrayscale = new System.Windows.Forms.Label();
            this.lblOCR = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.btnMission = new System.Windows.Forms.Button();
            this.grbImage = new System.Windows.Forms.GroupBox();
            this.udcH = new System.Windows.Forms.NumericUpDown();
            this.udcW = new System.Windows.Forms.NumericUpDown();
            this.udcY = new System.Windows.Forms.NumericUpDown();
            this.udcX = new System.Windows.Forms.NumericUpDown();
            this.lblH = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCrop = new System.Windows.Forms.Button();
            this.grbText = new System.Windows.Forms.GroupBox();
            this.btnURISearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrayscale)).BeginInit();
            this.grbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udcH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcX)).BeginInit();
            this.grbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(6, 19);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(130, 38);
            this.btnScreenshot.TabIndex = 0;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // pctScreenshot
            // 
            this.pctScreenshot.Location = new System.Drawing.Point(12, 25);
            this.pctScreenshot.Name = "pctScreenshot";
            this.pctScreenshot.Size = new System.Drawing.Size(480, 270);
            this.pctScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctScreenshot.TabIndex = 1;
            this.pctScreenshot.TabStop = false;
            // 
            // pctInvert
            // 
            this.pctInvert.Location = new System.Drawing.Point(12, 317);
            this.pctInvert.Name = "pctInvert";
            this.pctInvert.Size = new System.Drawing.Size(480, 270);
            this.pctInvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctInvert.TabIndex = 1;
            this.pctInvert.TabStop = false;
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(984, 317);
            this.txtTrim.Multiline = true;
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(153, 270);
            this.txtTrim.TabIndex = 3;
            // 
            // txtRaw
            // 
            this.txtRaw.Location = new System.Drawing.Point(983, 25);
            this.txtRaw.Multiline = true;
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.Size = new System.Drawing.Size(153, 270);
            this.txtRaw.TabIndex = 3;
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(6, 144);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(130, 38);
            this.btnInvert.TabIndex = 6;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(6, 188);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(130, 38);
            this.btnGrayscale.TabIndex = 7;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // pctCrop
            // 
            this.pctCrop.Location = new System.Drawing.Point(498, 25);
            this.pctCrop.Name = "pctCrop";
            this.pctCrop.Size = new System.Drawing.Size(480, 270);
            this.pctCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCrop.TabIndex = 1;
            this.pctCrop.TabStop = false;
            // 
            // pctGrayscale
            // 
            this.pctGrayscale.Location = new System.Drawing.Point(498, 317);
            this.pctGrayscale.Name = "pctGrayscale";
            this.pctGrayscale.Size = new System.Drawing.Size(480, 270);
            this.pctGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctGrayscale.TabIndex = 1;
            this.pctGrayscale.TabStop = false;
            // 
            // btnOCR
            // 
            this.btnOCR.Location = new System.Drawing.Point(6, 19);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(130, 34);
            this.btnOCR.TabIndex = 9;
            this.btnOCR.Text = "OCR";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // btnURIDirect
            // 
            this.btnURIDirect.Location = new System.Drawing.Point(6, 179);
            this.btnURIDirect.Name = "btnURIDirect";
            this.btnURIDirect.Size = new System.Drawing.Size(130, 38);
            this.btnURIDirect.TabIndex = 14;
            this.btnURIDirect.Text = "URI Direct";
            this.btnURIDirect.UseVisualStyleBackColor = true;
            this.btnURIDirect.Click += new System.EventHandler(this.btnURIDirect_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.cmbLevel.Location = new System.Drawing.Point(6, 99);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(130, 21);
            this.cmbLevel.TabIndex = 11;
            this.cmbLevel.Text = "Mission Level";
            // 
            // cmbFaction
            // 
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Items.AddRange(new object[] {
            "Angel Cartel",
            "Blood Raiders",
            "DED",
            "Guristas Pirates",
            "Sansha\'s Nation",
            "Serpentis"});
            this.cmbFaction.Location = new System.Drawing.Point(6, 126);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(130, 21);
            this.cmbFaction.TabIndex = 12;
            this.cmbFaction.Text = "NPC Faction";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1143, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 57);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblScreenshot
            // 
            this.lblScreenshot.AutoSize = true;
            this.lblScreenshot.Location = new System.Drawing.Point(12, 9);
            this.lblScreenshot.Name = "lblScreenshot";
            this.lblScreenshot.Size = new System.Drawing.Size(61, 13);
            this.lblScreenshot.TabIndex = 5;
            this.lblScreenshot.Text = "Screenshot";
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Location = new System.Drawing.Point(495, 9);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(29, 13);
            this.lblCrop.TabIndex = 5;
            this.lblCrop.Text = "Crop";
            // 
            // lblInvert
            // 
            this.lblInvert.AutoSize = true;
            this.lblInvert.Location = new System.Drawing.Point(12, 301);
            this.lblInvert.Name = "lblInvert";
            this.lblInvert.Size = new System.Drawing.Size(34, 13);
            this.lblInvert.TabIndex = 5;
            this.lblInvert.Text = "Invert";
            // 
            // lblGrayscale
            // 
            this.lblGrayscale.AutoSize = true;
            this.lblGrayscale.Location = new System.Drawing.Point(495, 301);
            this.lblGrayscale.Name = "lblGrayscale";
            this.lblGrayscale.Size = new System.Drawing.Size(54, 13);
            this.lblGrayscale.TabIndex = 5;
            this.lblGrayscale.Text = "Grayscale";
            // 
            // lblOCR
            // 
            this.lblOCR.AutoSize = true;
            this.lblOCR.Location = new System.Drawing.Point(980, 9);
            this.lblOCR.Name = "lblOCR";
            this.lblOCR.Size = new System.Drawing.Size(53, 13);
            this.lblOCR.TabIndex = 5;
            this.lblOCR.Text = "Raw Text";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(981, 301);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(71, 13);
            this.lblTrim.TabIndex = 5;
            this.lblTrim.Text = "Trimmed Text";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(7, 153);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(129, 20);
            this.txtMission.TabIndex = 13;
            this.txtMission.Text = "Mission";
            // 
            // btnMission
            // 
            this.btnMission.Location = new System.Drawing.Point(6, 59);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(130, 34);
            this.btnMission.TabIndex = 10;
            this.btnMission.Text = "Read";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // grbImage
            // 
            this.grbImage.Controls.Add(this.udcH);
            this.grbImage.Controls.Add(this.udcW);
            this.grbImage.Controls.Add(this.udcY);
            this.grbImage.Controls.Add(this.udcX);
            this.grbImage.Controls.Add(this.lblH);
            this.grbImage.Controls.Add(this.lblY);
            this.grbImage.Controls.Add(this.lblW);
            this.grbImage.Controls.Add(this.lblX);
            this.grbImage.Controls.Add(this.btnScreenshot);
            this.grbImage.Controls.Add(this.btnGrayscale);
            this.grbImage.Controls.Add(this.btnCrop);
            this.grbImage.Controls.Add(this.btnInvert);
            this.grbImage.Location = new System.Drawing.Point(1142, 12);
            this.grbImage.Name = "grbImage";
            this.grbImage.Size = new System.Drawing.Size(143, 235);
            this.grbImage.TabIndex = 7;
            this.grbImage.TabStop = false;
            this.grbImage.Text = "Image";
            // 
            // udcH
            // 
            this.udcH.Location = new System.Drawing.Point(92, 86);
            this.udcH.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.udcH.Name = "udcH";
            this.udcH.Size = new System.Drawing.Size(44, 20);
            this.udcH.TabIndex = 5;
            this.udcH.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.udcH.ValueChanged += new System.EventHandler(this.udc_Change);
            // 
            // udcW
            // 
            this.udcW.Location = new System.Drawing.Point(92, 68);
            this.udcW.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.udcW.Name = "udcW";
            this.udcW.Size = new System.Drawing.Size(44, 20);
            this.udcW.TabIndex = 4;
            this.udcW.Value = new decimal(new int[] {
            232,
            0,
            0,
            0});
            this.udcW.ValueChanged += new System.EventHandler(this.udc_Change);
            // 
            // udcY
            // 
            this.udcY.Location = new System.Drawing.Point(24, 86);
            this.udcY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.udcY.Name = "udcY";
            this.udcY.Size = new System.Drawing.Size(44, 20);
            this.udcY.TabIndex = 3;
            this.udcY.Value = new decimal(new int[] {
            276,
            0,
            0,
            0});
            this.udcY.ValueChanged += new System.EventHandler(this.udc_Change);
            // 
            // udcX
            // 
            this.udcX.Location = new System.Drawing.Point(24, 66);
            this.udcX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.udcX.Name = "udcX";
            this.udcX.Size = new System.Drawing.Size(44, 20);
            this.udcX.TabIndex = 2;
            this.udcX.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.udcX.ValueChanged += new System.EventHandler(this.udc_Change);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(74, 89);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(15, 13);
            this.lblH.TabIndex = 5;
            this.lblH.Text = "H";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(6, 89);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(74, 71);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(18, 13);
            this.lblW.TabIndex = 5;
            this.lblW.Text = "W";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 71);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(6, 112);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(130, 26);
            this.btnCrop.TabIndex = 6;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.udc_Change);
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.btnOCR);
            this.grbText.Controls.Add(this.txtMission);
            this.grbText.Controls.Add(this.btnURISearch);
            this.grbText.Controls.Add(this.btnURIDirect);
            this.grbText.Controls.Add(this.btnMission);
            this.grbText.Controls.Add(this.cmbLevel);
            this.grbText.Controls.Add(this.cmbFaction);
            this.grbText.Location = new System.Drawing.Point(1142, 253);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(143, 271);
            this.grbText.TabIndex = 8;
            this.grbText.TabStop = false;
            this.grbText.Text = "Text";
            // 
            // btnURISearch
            // 
            this.btnURISearch.Location = new System.Drawing.Point(6, 223);
            this.btnURISearch.Name = "btnURISearch";
            this.btnURISearch.Size = new System.Drawing.Size(130, 38);
            this.btnURISearch.TabIndex = 14;
            this.btnURISearch.Text = "URI Search";
            this.btnURISearch.UseVisualStyleBackColor = true;
            this.btnURISearch.Click += new System.EventHandler(this.btnURISearch_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 600);
            this.Controls.Add(this.grbText);
            this.Controls.Add(this.grbImage);
            this.Controls.Add(this.lblGrayscale);
            this.Controls.Add(this.lblInvert);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblOCR);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.lblScreenshot);
            this.Controls.Add(this.txtRaw);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.pctInvert);
            this.Controls.Add(this.pctGrayscale);
            this.Controls.Add(this.pctCrop);
            this.Controls.Add(this.pctScreenshot);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "EvE Mission Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pctScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrayscale)).EndInit();
            this.grbImage.ResumeLayout(false);
            this.grbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udcH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udcX)).EndInit();
            this.grbText.ResumeLayout(false);
            this.grbText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		
		        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.PictureBox pctScreenshot;
        private System.Windows.Forms.PictureBox pctInvert;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.PictureBox pctCrop;
        private System.Windows.Forms.PictureBox pctGrayscale;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button btnURIDirect;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScreenshot;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.Label lblInvert;
        private System.Windows.Forms.Label lblGrayscale;
        private System.Windows.Forms.Label lblOCR;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.GroupBox grbImage;
        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown udcH;
        private System.Windows.Forms.NumericUpDown udcW;
        private System.Windows.Forms.NumericUpDown udcY;
        private System.Windows.Forms.NumericUpDown udcX;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnURISearch;

    }
}

