// Zaripov Riyaz 220th group, 30.05.22 Figures-4

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
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_chooseFigure = new System.Windows.Forms.Panel();
            this.lb_descriptionToColorAndThickness = new System.Windows.Forms.Label();
            this.lb_chooseFigure = new System.Windows.Forms.Label();
            this.lb_ThicknessOfPen = new System.Windows.Forms.Label();
            this.mtb_ThicknessOfPen = new System.Windows.Forms.MaskedTextBox();
            this.btn_chooseColorOfPen = new System.Windows.Forms.Button();
            this.panel_FigurePaper = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStripMainForm.SuspendLayout();
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
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(800, 24);
            this.menuStripMainForm.TabIndex = 6;
            this.menuStripMainForm.Text = "Menu strip";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFiguresToolStripMenuItem,
            this.loadFiguresToolStripMenuItem,
            this.clearFiguresToolStripMenuItem});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
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
            this.panel_chooseFigure.Controls.Add(this.lb_descriptionToColorAndThickness);
            this.panel_chooseFigure.Controls.Add(this.lb_chooseFigure);
            this.panel_chooseFigure.Controls.Add(this.lb_ThicknessOfPen);
            this.panel_chooseFigure.Controls.Add(this.mtb_ThicknessOfPen);
            this.panel_chooseFigure.Controls.Add(this.btn_chooseColorOfPen);
            this.panel_chooseFigure.Controls.Add(this.cb_chooseFigure);
            this.panel_chooseFigure.Controls.Add(this.btn_addFigure);
            this.panel_chooseFigure.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_chooseFigure.Location = new System.Drawing.Point(0, 24);
            this.panel_chooseFigure.Name = "panel_chooseFigure";
            this.panel_chooseFigure.Size = new System.Drawing.Size(266, 426);
            this.panel_chooseFigure.TabIndex = 7;
            // 
            // lb_descriptionToColorAndThickness
            // 
            this.lb_descriptionToColorAndThickness.ForeColor = System.Drawing.Color.Gray;
            this.lb_descriptionToColorAndThickness.Location = new System.Drawing.Point(3, 124);
            this.lb_descriptionToColorAndThickness.Name = "lb_descriptionToColorAndThickness";
            this.lb_descriptionToColorAndThickness.Size = new System.Drawing.Size(263, 33);
            this.lb_descriptionToColorAndThickness.TabIndex = 7;
            this.lb_descriptionToColorAndThickness.Text = "(Standart thickness is 1 and standart color is black)";
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
            // lb_ThicknessOfPen
            // 
            this.lb_ThicknessOfPen.AutoSize = true;
            this.lb_ThicknessOfPen.Location = new System.Drawing.Point(3, 100);
            this.lb_ThicknessOfPen.Name = "lb_ThicknessOfPen";
            this.lb_ThicknessOfPen.Size = new System.Drawing.Size(95, 15);
            this.lb_ThicknessOfPen.TabIndex = 5;
            this.lb_ThicknessOfPen.Text = "Thickness of pen";
            // 
            // mtb_ThicknessOfPen
            // 
            this.mtb_ThicknessOfPen.Location = new System.Drawing.Point(104, 97);
            this.mtb_ThicknessOfPen.Mask = "000";
            this.mtb_ThicknessOfPen.Name = "mtb_ThicknessOfPen";
            this.mtb_ThicknessOfPen.Size = new System.Drawing.Size(23, 23);
            this.mtb_ThicknessOfPen.TabIndex = 4;
            this.mtb_ThicknessOfPen.ValidatingType = typeof(int);
            this.mtb_ThicknessOfPen.Leave += new System.EventHandler(this.mtb_ThicknessOfPen_Leave);
            // 
            // btn_chooseColorOfPen
            // 
            this.btn_chooseColorOfPen.Location = new System.Drawing.Point(133, 97);
            this.btn_chooseColorOfPen.Name = "btn_chooseColorOfPen";
            this.btn_chooseColorOfPen.Size = new System.Drawing.Size(127, 24);
            this.btn_chooseColorOfPen.TabIndex = 3;
            this.btn_chooseColorOfPen.Text = "Choose color of pen";
            this.btn_chooseColorOfPen.UseVisualStyleBackColor = true;
            this.btn_chooseColorOfPen.Click += new System.EventHandler(this.btn_chooseColorOfPen_Click);
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
            // form_geometryFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_FigurePaper);
            this.Controls.Add(this.panel_chooseFigure);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "form_geometryFigures";
            this.Text = "Geometry figures";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem saveFiguresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFiguresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFiguresToolStripMenuItem;
        internal System.Windows.Forms.Panel panel_chooseFigure;
        internal System.Windows.Forms.Panel panel_FigurePaper;
        private System.Windows.Forms.Button btn_chooseColorOfPen;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lb_ThicknessOfPen;
        private System.Windows.Forms.MaskedTextBox mtb_ThicknessOfPen;
        private System.Windows.Forms.Label lb_chooseFigure;
        private System.Windows.Forms.Label lb_descriptionToColorAndThickness;
    }
}

