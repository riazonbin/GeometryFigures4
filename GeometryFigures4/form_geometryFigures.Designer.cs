// Zaripov Riyaz 220th group, 24.05.22 Figures-3

namespace GeometryFigures4
{
    partial class form_geometryFigures
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
            this.cb_chooseFigure = new System.Windows.Forms.ComboBox();
            this.btn_addFigure = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripMain = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_chooseFigure = new System.Windows.Forms.Panel();
            this.lb_ThicknessOfPen = new System.Windows.Forms.Label();
            this.mtb_chooseThicknessOfPen = new System.Windows.Forms.MaskedTextBox();
            this.btn_chooseColor = new System.Windows.Forms.Button();
            this.panel_FigurePaper = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lb_chooseFigure = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_chooseFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_chooseFigure
            // 
            this.cb_chooseFigure.FormattingEnabled = true;
            this.cb_chooseFigure.Items.AddRange(new object[] {
            "Segment",
            "Triangle",
            "Rectangle",
            "Circle"});
            this.cb_chooseFigure.Location = new System.Drawing.Point(3, 33);
            this.cb_chooseFigure.Name = "cb_chooseFigure";
            this.cb_chooseFigure.Size = new System.Drawing.Size(133, 23);
            this.cb_chooseFigure.TabIndex = 1;
            // 
            // btn_addFigure
            // 
            this.btn_addFigure.Location = new System.Drawing.Point(142, 33);
            this.btn_addFigure.Name = "btn_addFigure";
            this.btn_addFigure.Size = new System.Drawing.Size(75, 23);
            this.btn_addFigure.TabIndex = 2;
            this.btn_addFigure.Text = "Add";
            this.btn_addFigure.UseVisualStyleBackColor = true;
            this.btn_addFigure.Click += new System.EventHandler(this.btn_addFigure_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFiguresToolStripMenuItem,
            this.loadFiguresToolStripMenuItem,
            this.clearFiguresToolStripMenuItem});
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(37, 20);
            this.menuStripMain.Text = "File";
            // 
            // saveFiguresToolStripMenuItem
            // 
            this.saveFiguresToolStripMenuItem.Name = "saveFiguresToolStripMenuItem";
            this.saveFiguresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveFiguresToolStripMenuItem.Text = "Save figures";
            this.saveFiguresToolStripMenuItem.Click += new System.EventHandler(this.saveFiguresToolStripMenuItem_Click);
            // 
            // loadFiguresToolStripMenuItem
            // 
            this.loadFiguresToolStripMenuItem.Name = "loadFiguresToolStripMenuItem";
            this.loadFiguresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadFiguresToolStripMenuItem.Text = "Load figures";
            this.loadFiguresToolStripMenuItem.Click += new System.EventHandler(this.loadFiguresToolStripMenuItem_Click);
            // 
            // clearFiguresToolStripMenuItem
            // 
            this.clearFiguresToolStripMenuItem.Name = "clearFiguresToolStripMenuItem";
            this.clearFiguresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clearFiguresToolStripMenuItem.Text = "Clear figures";
            this.clearFiguresToolStripMenuItem.Click += new System.EventHandler(this.clearFiguresToolStripMenuItem_Click);
            // 
            // panel_chooseFigure
            // 
            this.panel_chooseFigure.Controls.Add(this.lb_chooseFigure);
            this.panel_chooseFigure.Controls.Add(this.lb_ThicknessOfPen);
            this.panel_chooseFigure.Controls.Add(this.mtb_chooseThicknessOfPen);
            this.panel_chooseFigure.Controls.Add(this.btn_chooseColor);
            this.panel_chooseFigure.Controls.Add(this.cb_chooseFigure);
            this.panel_chooseFigure.Controls.Add(this.btn_addFigure);
            this.panel_chooseFigure.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_chooseFigure.Location = new System.Drawing.Point(0, 24);
            this.panel_chooseFigure.Name = "panel_chooseFigure";
            this.panel_chooseFigure.Size = new System.Drawing.Size(266, 426);
            this.panel_chooseFigure.TabIndex = 7;
            // 
            // lb_ThicknessOfPen
            // 
            this.lb_ThicknessOfPen.AutoSize = true;
            this.lb_ThicknessOfPen.Location = new System.Drawing.Point(3, 100);
            this.lb_ThicknessOfPen.Name = "lb_ThicknessOfPen";
            this.lb_ThicknessOfPen.Size = new System.Drawing.Size(95, 15);
            this.lb_ThicknessOfPen.TabIndex = 5;
            this.lb_ThicknessOfPen.Text = "Thickness of pen";
            // 
            // mtb_chooseThicknessOfPen
            // 
            this.mtb_chooseThicknessOfPen.Location = new System.Drawing.Point(104, 97);
            this.mtb_chooseThicknessOfPen.Mask = "000";
            this.mtb_chooseThicknessOfPen.Name = "mtb_chooseThicknessOfPen";
            this.mtb_chooseThicknessOfPen.Size = new System.Drawing.Size(23, 23);
            this.mtb_chooseThicknessOfPen.TabIndex = 4;
            this.mtb_chooseThicknessOfPen.ValidatingType = typeof(int);
            this.mtb_chooseThicknessOfPen.Leave += new System.EventHandler(this.mtb_chooseThicknessOfPen_Leave);
            // 
            // btn_chooseColor
            // 
            this.btn_chooseColor.Location = new System.Drawing.Point(133, 97);
            this.btn_chooseColor.Name = "btn_chooseColor";
            this.btn_chooseColor.Size = new System.Drawing.Size(127, 24);
            this.btn_chooseColor.TabIndex = 3;
            this.btn_chooseColor.Text = "Choose color of pen";
            this.btn_chooseColor.UseVisualStyleBackColor = true;
            this.btn_chooseColor.Click += new System.EventHandler(this.btn_chooseColor_Click);
            // 
            // panel_FigurePaper
            // 
            this.panel_FigurePaper.BackColor = System.Drawing.SystemColors.Window;
            this.panel_FigurePaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FigurePaper.Location = new System.Drawing.Point(266, 24);
            this.panel_FigurePaper.Name = "panel_FigurePaper";
            this.panel_FigurePaper.Size = new System.Drawing.Size(534, 426);
            this.panel_FigurePaper.TabIndex = 8;
            this.panel_FigurePaper.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_FigurePaper_Paint);
            // 
            // lb_chooseFigure
            // 
            this.lb_chooseFigure.AutoSize = true;
            this.lb_chooseFigure.Location = new System.Drawing.Point(3, 15);
            this.lb_chooseFigure.Name = "lb_chooseFigure";
            this.lb_chooseFigure.Size = new System.Drawing.Size(81, 15);
            this.lb_chooseFigure.TabIndex = 6;
            this.lb_chooseFigure.Text = "Choose figure";
            // 
            // form_geometryFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_FigurePaper);
            this.Controls.Add(this.panel_chooseFigure);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_geometryFigures";
            this.Text = "Geometry figures";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_chooseFigure.ResumeLayout(false);
            this.panel_chooseFigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_chooseFigure;
        private System.Windows.Forms.Button btn_addFigure;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem saveFiguresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFiguresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFiguresToolStripMenuItem;
        internal System.Windows.Forms.Panel panel_chooseFigure;
        internal System.Windows.Forms.Panel panel_FigurePaper;
        private System.Windows.Forms.Button btn_chooseColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lb_ThicknessOfPen;
        private System.Windows.Forms.MaskedTextBox mtb_chooseThicknessOfPen;
        private System.Windows.Forms.Label lb_chooseFigure;
    }
}

