namespace MSPaint2024
{
    partial class fOkno
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tsSouradniceMysi = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpVyberBarvy = new System.Windows.Forms.GroupBox();
            this.pnColorRed = new System.Windows.Forms.Panel();
            this.pnColorBrown = new System.Windows.Forms.Panel();
            this.pnColorOrange = new System.Windows.Forms.Panel();
            this.pnColorWhite = new System.Windows.Forms.Panel();
            this.pnColorYellow = new System.Windows.Forms.Panel();
            this.pnColorMagenta = new System.Windows.Forms.Panel();
            this.pnColorBlue = new System.Windows.Forms.Panel();
            this.pnColorCyan = new System.Windows.Forms.Panel();
            this.pnColorGreen = new System.Windows.Forms.Panel();
            this.pnBackColor = new System.Windows.Forms.Panel();
            this.pnColorDarkGrey = new System.Windows.Forms.Panel();
            this.pnForeColor = new System.Windows.Forms.Panel();
            this.pnColorLightGrey = new System.Windows.Forms.Panel();
            this.pnColorBlack = new System.Windows.Forms.Panel();
            this.gpWidth = new System.Windows.Forms.GroupBox();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.gpNastroje = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.radioBtLine = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUlozit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOtevrit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.ssBottom.SuspendLayout();
            this.gpVyberBarvy.SuspendLayout();
            this.gpWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.gpNastroje.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(12, 39);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(952, 511);
            this.pbPlatno.TabIndex = 0;
            this.pbPlatno.TabStop = false;
            this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
            this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
            this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
            // 
            // ssBottom
            // 
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSouradniceMysi});
            this.ssBottom.Location = new System.Drawing.Point(0, 559);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(1237, 22);
            this.ssBottom.TabIndex = 2;
            this.ssBottom.Text = "tsSouradniceMysi";
            // 
            // tsSouradniceMysi
            // 
            this.tsSouradniceMysi.Name = "tsSouradniceMysi";
            this.tsSouradniceMysi.Size = new System.Drawing.Size(40, 17);
            this.tsSouradniceMysi.Text = "x:0 y:0";
            // 
            // gpVyberBarvy
            // 
            this.gpVyberBarvy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpVyberBarvy.Controls.Add(this.pnColorRed);
            this.gpVyberBarvy.Controls.Add(this.pnColorBrown);
            this.gpVyberBarvy.Controls.Add(this.pnColorOrange);
            this.gpVyberBarvy.Controls.Add(this.pnColorWhite);
            this.gpVyberBarvy.Controls.Add(this.pnColorYellow);
            this.gpVyberBarvy.Controls.Add(this.pnColorMagenta);
            this.gpVyberBarvy.Controls.Add(this.pnColorBlue);
            this.gpVyberBarvy.Controls.Add(this.pnColorCyan);
            this.gpVyberBarvy.Controls.Add(this.pnColorGreen);
            this.gpVyberBarvy.Controls.Add(this.pnBackColor);
            this.gpVyberBarvy.Controls.Add(this.pnColorDarkGrey);
            this.gpVyberBarvy.Controls.Add(this.pnForeColor);
            this.gpVyberBarvy.Controls.Add(this.pnColorLightGrey);
            this.gpVyberBarvy.Controls.Add(this.pnColorBlack);
            this.gpVyberBarvy.Location = new System.Drawing.Point(970, 39);
            this.gpVyberBarvy.Name = "gpVyberBarvy";
            this.gpVyberBarvy.Size = new System.Drawing.Size(255, 120);
            this.gpVyberBarvy.TabIndex = 3;
            this.gpVyberBarvy.TabStop = false;
            this.gpVyberBarvy.Text = "Výběr barvy";
            // 
            // pnColorRed
            // 
            this.pnColorRed.BackColor = System.Drawing.Color.Red;
            this.pnColorRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorRed.Location = new System.Drawing.Point(220, 80);
            this.pnColorRed.Name = "pnColorRed";
            this.pnColorRed.Size = new System.Drawing.Size(22, 20);
            this.pnColorRed.TabIndex = 13;
            this.pnColorRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBrown
            // 
            this.pnColorBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnColorBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBrown.Location = new System.Drawing.Point(192, 80);
            this.pnColorBrown.Name = "pnColorBrown";
            this.pnColorBrown.Size = new System.Drawing.Size(22, 20);
            this.pnColorBrown.TabIndex = 13;
            this.pnColorBrown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorOrange
            // 
            this.pnColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorOrange.Location = new System.Drawing.Point(164, 80);
            this.pnColorOrange.Name = "pnColorOrange";
            this.pnColorOrange.Size = new System.Drawing.Size(22, 20);
            this.pnColorOrange.TabIndex = 13;
            this.pnColorOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorWhite
            // 
            this.pnColorWhite.BackColor = System.Drawing.Color.White;
            this.pnColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorWhite.Location = new System.Drawing.Point(220, 28);
            this.pnColorWhite.Name = "pnColorWhite";
            this.pnColorWhite.Size = new System.Drawing.Size(22, 20);
            this.pnColorWhite.TabIndex = 6;
            this.pnColorWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorYellow
            // 
            this.pnColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorYellow.Location = new System.Drawing.Point(136, 80);
            this.pnColorYellow.Name = "pnColorYellow";
            this.pnColorYellow.Size = new System.Drawing.Size(22, 20);
            this.pnColorYellow.TabIndex = 12;
            this.pnColorYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorMagenta
            // 
            this.pnColorMagenta.BackColor = System.Drawing.Color.Fuchsia;
            this.pnColorMagenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorMagenta.Location = new System.Drawing.Point(220, 54);
            this.pnColorMagenta.Name = "pnColorMagenta";
            this.pnColorMagenta.Size = new System.Drawing.Size(22, 20);
            this.pnColorMagenta.TabIndex = 12;
            this.pnColorMagenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBlue
            // 
            this.pnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.pnColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlue.Location = new System.Drawing.Point(192, 54);
            this.pnColorBlue.Name = "pnColorBlue";
            this.pnColorBlue.Size = new System.Drawing.Size(22, 20);
            this.pnColorBlue.TabIndex = 12;
            this.pnColorBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorCyan
            // 
            this.pnColorCyan.BackColor = System.Drawing.Color.Cyan;
            this.pnColorCyan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorCyan.Location = new System.Drawing.Point(164, 54);
            this.pnColorCyan.Name = "pnColorCyan";
            this.pnColorCyan.Size = new System.Drawing.Size(22, 20);
            this.pnColorCyan.TabIndex = 11;
            this.pnColorCyan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorGreen
            // 
            this.pnColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorGreen.Location = new System.Drawing.Point(136, 54);
            this.pnColorGreen.Name = "pnColorGreen";
            this.pnColorGreen.Size = new System.Drawing.Size(22, 20);
            this.pnColorGreen.TabIndex = 10;
            this.pnColorGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnBackColor
            // 
            this.pnBackColor.BackColor = System.Drawing.Color.Black;
            this.pnBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBackColor.Location = new System.Drawing.Point(70, 28);
            this.pnBackColor.Name = "pnBackColor";
            this.pnBackColor.Size = new System.Drawing.Size(47, 46);
            this.pnBackColor.TabIndex = 5;
            // 
            // pnColorDarkGrey
            // 
            this.pnColorDarkGrey.BackColor = System.Drawing.Color.Gray;
            this.pnColorDarkGrey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorDarkGrey.Location = new System.Drawing.Point(164, 28);
            this.pnColorDarkGrey.Name = "pnColorDarkGrey";
            this.pnColorDarkGrey.Size = new System.Drawing.Size(22, 20);
            this.pnColorDarkGrey.TabIndex = 9;
            this.pnColorDarkGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnForeColor
            // 
            this.pnForeColor.BackColor = System.Drawing.Color.Black;
            this.pnForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnForeColor.Location = new System.Drawing.Point(15, 28);
            this.pnForeColor.Name = "pnForeColor";
            this.pnForeColor.Size = new System.Drawing.Size(49, 46);
            this.pnForeColor.TabIndex = 4;
            // 
            // pnColorLightGrey
            // 
            this.pnColorLightGrey.BackColor = System.Drawing.Color.LightGray;
            this.pnColorLightGrey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorLightGrey.Location = new System.Drawing.Point(192, 28);
            this.pnColorLightGrey.Name = "pnColorLightGrey";
            this.pnColorLightGrey.Size = new System.Drawing.Size(22, 20);
            this.pnColorLightGrey.TabIndex = 8;
            this.pnColorLightGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // pnColorBlack
            // 
            this.pnColorBlack.BackColor = System.Drawing.Color.Black;
            this.pnColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnColorBlack.Location = new System.Drawing.Point(136, 28);
            this.pnColorBlack.Name = "pnColorBlack";
            this.pnColorBlack.Size = new System.Drawing.Size(22, 20);
            this.pnColorBlack.TabIndex = 7;
            this.pnColorBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseDown);
            // 
            // gpWidth
            // 
            this.gpWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpWidth.Controls.Add(this.tbWidth);
            this.gpWidth.Location = new System.Drawing.Point(970, 253);
            this.gpWidth.Name = "gpWidth";
            this.gpWidth.Size = new System.Drawing.Size(230, 51);
            this.gpWidth.TabIndex = 5;
            this.gpWidth.TabStop = false;
            this.gpWidth.Text = "Šířka";
            // 
            // tbWidth
            // 
            this.tbWidth.LargeChange = 1;
            this.tbWidth.Location = new System.Drawing.Point(7, 20);
            this.tbWidth.Maximum = 20;
            this.tbWidth.Minimum = 2;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(223, 45);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.Value = 2;
            // 
            // gpNastroje
            // 
            this.gpNastroje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpNastroje.Controls.Add(this.btClear);
            this.gpNastroje.Controls.Add(this.rbEllipse);
            this.gpNastroje.Controls.Add(this.rbPen);
            this.gpNastroje.Controls.Add(this.rbRectangle);
            this.gpNastroje.Controls.Add(this.radioBtLine);
            this.gpNastroje.Location = new System.Drawing.Point(970, 165);
            this.gpNastroje.Name = "gpNastroje";
            this.gpNastroje.Size = new System.Drawing.Size(255, 82);
            this.gpNastroje.TabIndex = 6;
            this.gpNastroje.TabStop = false;
            this.gpNastroje.Text = "Nástroje";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(174, 19);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(56, 40);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(92, 42);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 3;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(15, 42);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(44, 17);
            this.rbPen.TabIndex = 2;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(92, 19);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanged);
            // 
            // radioBtLine
            // 
            this.radioBtLine.AutoSize = true;
            this.radioBtLine.Checked = true;
            this.radioBtLine.Location = new System.Drawing.Point(15, 19);
            this.radioBtLine.Name = "radioBtLine";
            this.radioBtLine.Size = new System.Drawing.Size(45, 17);
            this.radioBtLine.TabIndex = 0;
            this.radioBtLine.TabStop = true;
            this.radioBtLine.Text = "Line";
            this.radioBtLine.UseVisualStyleBackColor = true;
            this.radioBtLine.CheckedChanged += new System.EventHandler(this.rbTool_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSoubor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSoubor
            // 
            this.tsmiSoubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUlozit,
            this.tsmiOtevrit,
            this.tsmiKonec});
            this.tsmiSoubor.Name = "tsmiSoubor";
            this.tsmiSoubor.Size = new System.Drawing.Size(57, 20);
            this.tsmiSoubor.Text = "Soubor";
            // 
            // tsmiUlozit
            // 
            this.tsmiUlozit.Name = "tsmiUlozit";
            this.tsmiUlozit.Size = new System.Drawing.Size(110, 22);
            this.tsmiUlozit.Text = "Uložit";
            this.tsmiUlozit.Click += new System.EventHandler(this.tsmiUlozit_Click);
            // 
            // tsmiOtevrit
            // 
            this.tsmiOtevrit.Name = "tsmiOtevrit";
            this.tsmiOtevrit.Size = new System.Drawing.Size(110, 22);
            this.tsmiOtevrit.Text = "Otevřít";
            this.tsmiOtevrit.Click += new System.EventHandler(this.tsmiOtevrit_Click);
            // 
            // tsmiKonec
            // 
            this.tsmiKonec.Name = "tsmiKonec";
            this.tsmiKonec.Size = new System.Drawing.Size(110, 22);
            this.tsmiKonec.Text = "Konec";
            this.tsmiKonec.Click += new System.EventHandler(this.tsmiKonec_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1237, 581);
            this.Controls.Add(this.gpNastroje);
            this.Controls.Add(this.gpWidth);
            this.Controls.Add(this.gpVyberBarvy);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbPlatno);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fOkno";
            this.Text = "MS Paint 2024";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.gpVyberBarvy.ResumeLayout(false);
            this.gpWidth.ResumeLayout(false);
            this.gpWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.gpNastroje.ResumeLayout(false);
            this.gpNastroje.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsSouradniceMysi;
        private System.Windows.Forms.GroupBox gpVyberBarvy;
        private System.Windows.Forms.Panel pnColorWhite;
        private System.Windows.Forms.Panel pnBackColor;
        private System.Windows.Forms.Panel pnForeColor;
        private System.Windows.Forms.Panel pnColorCyan;
        private System.Windows.Forms.Panel pnColorGreen;
        private System.Windows.Forms.Panel pnColorDarkGrey;
        private System.Windows.Forms.Panel pnColorLightGrey;
        private System.Windows.Forms.Panel pnColorBlack;
        private System.Windows.Forms.Panel pnColorRed;
        private System.Windows.Forms.Panel pnColorBrown;
        private System.Windows.Forms.Panel pnColorOrange;
        private System.Windows.Forms.Panel pnColorYellow;
        private System.Windows.Forms.Panel pnColorMagenta;
        private System.Windows.Forms.Panel pnColorBlue;
        private System.Windows.Forms.GroupBox gpWidth;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.GroupBox gpNastroje;
        private System.Windows.Forms.RadioButton radioBtLine;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSoubor;
        private System.Windows.Forms.ToolStripMenuItem tsmiUlozit;
        private System.Windows.Forms.ToolStripMenuItem tsmiOtevrit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKonec;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btClear;
    }
}

