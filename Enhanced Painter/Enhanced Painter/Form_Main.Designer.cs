namespace Enhanced_Painter
{
    partial class Form_Main
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
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.comboBox_Shape = new System.Windows.Forms.ComboBox();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.radioButton_Custom = new System.Windows.Forms.RadioButton();
            this.radioButton_Red = new System.Windows.Forms.RadioButton();
            this.radioButton_Black = new System.Windows.Forms.RadioButton();
            this.groupBox_PenSize = new System.Windows.Forms.GroupBox();
            this.radioButton_LargePen = new System.Windows.Forms.RadioButton();
            this.radioButton_mediumPen = new System.Windows.Forms.RadioButton();
            this.radioButton_smallPen = new System.Windows.Forms.RadioButton();
            this.panel_DrawPad = new System.Windows.Forms.Panel();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Controls.SuspendLayout();
            this.groupBox_Color.SuspendLayout();
            this.groupBox_PenSize.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Controls.Controls.Add(this.comboBox_Shape);
            this.panel_Controls.Controls.Add(this.groupBox_Color);
            this.panel_Controls.Controls.Add(this.groupBox_PenSize);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Controls.Location = new System.Drawing.Point(0, 28);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(200, 544);
            this.panel_Controls.TabIndex = 0;
            // 
            // comboBox_Shape
            // 
            this.comboBox_Shape.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox_Shape.FormattingEnabled = true;
            this.comboBox_Shape.Items.AddRange(new object[] {
            "Draw Line",
            "Draw Ellipse",
            "Draw Rectangle",
            "Draw Polygon",
            "Fill Polygon"});
            this.comboBox_Shape.Location = new System.Drawing.Point(12, 18);
            this.comboBox_Shape.Name = "comboBox_Shape";
            this.comboBox_Shape.Size = new System.Drawing.Size(182, 24);
            this.comboBox_Shape.TabIndex = 3;
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.radioButton_Custom);
            this.groupBox_Color.Controls.Add(this.radioButton_Red);
            this.groupBox_Color.Controls.Add(this.radioButton_Black);
            this.groupBox_Color.Location = new System.Drawing.Point(12, 179);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(182, 106);
            this.groupBox_Color.TabIndex = 2;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Color";
            // 
            // radioButton_Custom
            // 
            this.radioButton_Custom.AutoSize = true;
            this.radioButton_Custom.Location = new System.Drawing.Point(17, 75);
            this.radioButton_Custom.Name = "radioButton_Custom";
            this.radioButton_Custom.Size = new System.Drawing.Size(95, 26);
            this.radioButton_Custom.TabIndex = 2;
            this.radioButton_Custom.TabStop = true;
            this.radioButton_Custom.Text = "Custom";
            this.radioButton_Custom.UseVisualStyleBackColor = true;
            this.radioButton_Custom.CheckedChanged += new System.EventHandler(this.groupBox_Color_CheckedChanged);
            // 
            // radioButton_Red
            // 
            this.radioButton_Red.AutoSize = true;
            this.radioButton_Red.Location = new System.Drawing.Point(17, 48);
            this.radioButton_Red.Name = "radioButton_Red";
            this.radioButton_Red.Size = new System.Drawing.Size(69, 26);
            this.radioButton_Red.TabIndex = 1;
            this.radioButton_Red.TabStop = true;
            this.radioButton_Red.Text = "Red";
            this.radioButton_Red.UseVisualStyleBackColor = true;
            this.radioButton_Red.CheckedChanged += new System.EventHandler(this.groupBox_Color_CheckedChanged);
            // 
            // radioButton_Black
            // 
            this.radioButton_Black.AutoSize = true;
            this.radioButton_Black.Checked = true;
            this.radioButton_Black.Location = new System.Drawing.Point(17, 21);
            this.radioButton_Black.Name = "radioButton_Black";
            this.radioButton_Black.Size = new System.Drawing.Size(79, 26);
            this.radioButton_Black.TabIndex = 0;
            this.radioButton_Black.TabStop = true;
            this.radioButton_Black.Text = "Black";
            this.radioButton_Black.UseVisualStyleBackColor = true;
            this.radioButton_Black.CheckedChanged += new System.EventHandler(this.groupBox_Color_CheckedChanged);
            // 
            // groupBox_PenSize
            // 
            this.groupBox_PenSize.Controls.Add(this.radioButton_LargePen);
            this.groupBox_PenSize.Controls.Add(this.radioButton_mediumPen);
            this.groupBox_PenSize.Controls.Add(this.radioButton_smallPen);
            this.groupBox_PenSize.Location = new System.Drawing.Point(12, 63);
            this.groupBox_PenSize.Name = "groupBox_PenSize";
            this.groupBox_PenSize.Size = new System.Drawing.Size(182, 100);
            this.groupBox_PenSize.TabIndex = 1;
            this.groupBox_PenSize.TabStop = false;
            this.groupBox_PenSize.Text = "Pen Size";
            // 
            // radioButton_LargePen
            // 
            this.radioButton_LargePen.AutoSize = true;
            this.radioButton_LargePen.Location = new System.Drawing.Point(17, 73);
            this.radioButton_LargePen.Name = "radioButton_LargePen";
            this.radioButton_LargePen.Size = new System.Drawing.Size(95, 21);
            this.radioButton_LargePen.TabIndex = 2;
            this.radioButton_LargePen.Text = "Large Pen";
            this.radioButton_LargePen.UseVisualStyleBackColor = true;
            this.radioButton_LargePen.CheckedChanged += new System.EventHandler(this.groupBox_PenSize_CheckedChanged);
            // 
            // radioButton_mediumPen
            // 
            this.radioButton_mediumPen.AutoSize = true;
            this.radioButton_mediumPen.Location = new System.Drawing.Point(17, 48);
            this.radioButton_mediumPen.Name = "radioButton_mediumPen";
            this.radioButton_mediumPen.Size = new System.Drawing.Size(107, 21);
            this.radioButton_mediumPen.TabIndex = 1;
            this.radioButton_mediumPen.Text = "Medium Pen";
            this.radioButton_mediumPen.UseVisualStyleBackColor = true;
            this.radioButton_mediumPen.CheckedChanged += new System.EventHandler(this.groupBox_PenSize_CheckedChanged);
            // 
            // radioButton_smallPen
            // 
            this.radioButton_smallPen.AutoSize = true;
            this.radioButton_smallPen.Checked = true;
            this.radioButton_smallPen.Location = new System.Drawing.Point(17, 21);
            this.radioButton_smallPen.Name = "radioButton_smallPen";
            this.radioButton_smallPen.Size = new System.Drawing.Size(92, 21);
            this.radioButton_smallPen.TabIndex = 0;
            this.radioButton_smallPen.TabStop = true;
            this.radioButton_smallPen.Text = "Small Pen";
            this.radioButton_smallPen.UseVisualStyleBackColor = true;
            this.radioButton_smallPen.CheckedChanged += new System.EventHandler(this.groupBox_PenSize_CheckedChanged);
            // 
            // panel_DrawPad
            // 
            this.panel_DrawPad.BackColor = System.Drawing.Color.LightGray;
            this.panel_DrawPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DrawPad.Location = new System.Drawing.Point(200, 28);
            this.panel_DrawPad.MinimumSize = new System.Drawing.Size(648, 480);
            this.panel_DrawPad.Name = "panel_DrawPad";
            this.panel_DrawPad.Size = new System.Drawing.Size(654, 544);
            this.panel_DrawPad.TabIndex = 1;
            this.panel_DrawPad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DrawPad_Paint);
            this.panel_DrawPad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_DrawPad_MouseDown);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(854, 28);
            this.menuStrip_Main.TabIndex = 2;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearPadToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearPadToolStripMenuItem
            // 
            this.clearPadToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.clearPadToolStripMenuItem.Name = "clearPadToolStripMenuItem";
            this.clearPadToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.clearPadToolStripMenuItem.Text = "Clear Pad";
            this.clearPadToolStripMenuItem.Click += new System.EventHandler(this.clearPadToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 572);
            this.Controls.Add(this.panel_DrawPad);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(872, 619);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enhanced Painter";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel_Controls.ResumeLayout(false);
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            this.groupBox_PenSize.ResumeLayout(false);
            this.groupBox_PenSize.PerformLayout();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Panel panel_DrawPad;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPadToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_Shape;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.GroupBox groupBox_PenSize;
        private System.Windows.Forms.RadioButton radioButton_Custom;
        private System.Windows.Forms.RadioButton radioButton_Red;
        private System.Windows.Forms.RadioButton radioButton_Black;
        private System.Windows.Forms.RadioButton radioButton_LargePen;
        private System.Windows.Forms.RadioButton radioButton_mediumPen;
        private System.Windows.Forms.RadioButton radioButton_smallPen;
    }
}

