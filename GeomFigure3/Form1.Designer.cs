namespace GeomFigure3
{
    partial class GraphicEditor
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.panelDataInput = new System.Windows.Forms.Panel();
            this.panelFilledFigure = new System.Windows.Forms.Panel();
            this.trbStrokeWidth = new System.Windows.Forms.TrackBar();
            this.lbStrokeWidth = new System.Windows.Forms.Label();
            this.panelStrokColor = new System.Windows.Forms.Panel();
            this.lbStrokColor = new System.Windows.Forms.Label();
            this.lbSelectColor = new System.Windows.Forms.Label();
            this.panelFigureColor = new System.Windows.Forms.Panel();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.tbCircleX = new System.Windows.Forms.TextBox();
            this.lbRadius = new System.Windows.Forms.Label();
            this.tbCircleY = new System.Windows.Forms.TextBox();
            this.lbCircleY = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.lbCircleX = new System.Windows.Forms.Label();
            this.panelRectangle = new System.Windows.Forms.Panel();
            this.tbRectangleX = new System.Windows.Forms.TextBox();
            this.tbRectangleY = new System.Windows.Forms.TextBox();
            this.lbRectangleY = new System.Windows.Forms.Label();
            this.lbRectangleX = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbHight = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.panelTriangle = new System.Windows.Forms.Panel();
            this.tbTriangleY2 = new System.Windows.Forms.TextBox();
            this.lbTriangleX2 = new System.Windows.Forms.Label();
            this.tbTriangleX2 = new System.Windows.Forms.TextBox();
            this.lbTriangleY2 = new System.Windows.Forms.Label();
            this.tbTriangleX = new System.Windows.Forms.TextBox();
            this.tbTriangleY3 = new System.Windows.Forms.TextBox();
            this.tbTriangleY = new System.Windows.Forms.TextBox();
            this.tbTriangleX3 = new System.Windows.Forms.TextBox();
            this.lbTriangleY3 = new System.Windows.Forms.Label();
            this.lbTriangleY = new System.Windows.Forms.Label();
            this.lbTriangleX3 = new System.Windows.Forms.Label();
            this.lbTriangleX = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.tbLineX = new System.Windows.Forms.TextBox();
            this.tbLineY = new System.Windows.Forms.TextBox();
            this.tbLineY2 = new System.Windows.Forms.TextBox();
            this.lbLineY = new System.Windows.Forms.Label();
            this.lbLineX = new System.Windows.Forms.Label();
            this.lbLineX2 = new System.Windows.Forms.Label();
            this.tbLineX2 = new System.Windows.Forms.TextBox();
            this.lbLineY2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.labelSelectFigure = new System.Windows.Forms.Label();
            this.cbFigures = new System.Windows.Forms.ComboBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cdlgFilled = new System.Windows.Forms.ColorDialog();
            this.msMenu.SuspendLayout();
            this.panelDataInput.SuspendLayout();
            this.panelFilledFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrokeWidth)).BeginInit();
            this.panelCircle.SuspendLayout();
            this.panelRectangle.SuspendLayout();
            this.panelTriangle.SuspendLayout();
            this.panelLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1260, 28);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "Menu";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSave,
            this.itemLoad});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(46, 24);
            this.itemFile.Text = "File";
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(224, 26);
            this.itemSave.Text = "Save";
            this.itemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // itemLoad
            // 
            this.itemLoad.Name = "itemLoad";
            this.itemLoad.Size = new System.Drawing.Size(224, 26);
            this.itemLoad.Text = "Load";
            this.itemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // dlgLoad
            // 
            this.dlgLoad.FileName = "openFileDialog1";
            // 
            // panelDataInput
            // 
            this.panelDataInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDataInput.Controls.Add(this.panelFilledFigure);
            this.panelDataInput.Controls.Add(this.panelCircle);
            this.panelDataInput.Controls.Add(this.panelRectangle);
            this.panelDataInput.Controls.Add(this.panelTriangle);
            this.panelDataInput.Controls.Add(this.panelLine);
            this.panelDataInput.Controls.Add(this.btnClear);
            this.panelDataInput.Controls.Add(this.btnDraw);
            this.panelDataInput.Controls.Add(this.labelSelectFigure);
            this.panelDataInput.Controls.Add(this.cbFigures);
            this.panelDataInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataInput.Location = new System.Drawing.Point(0, 28);
            this.panelDataInput.Name = "panelDataInput";
            this.panelDataInput.Size = new System.Drawing.Size(332, 377);
            this.panelDataInput.TabIndex = 5;
            // 
            // panelFilledFigure
            // 
            this.panelFilledFigure.Controls.Add(this.trbStrokeWidth);
            this.panelFilledFigure.Controls.Add(this.lbStrokeWidth);
            this.panelFilledFigure.Controls.Add(this.panelStrokColor);
            this.panelFilledFigure.Controls.Add(this.lbStrokColor);
            this.panelFilledFigure.Controls.Add(this.lbSelectColor);
            this.panelFilledFigure.Controls.Add(this.panelFigureColor);
            this.panelFilledFigure.Location = new System.Drawing.Point(0, 285);
            this.panelFilledFigure.Name = "panelFilledFigure";
            this.panelFilledFigure.Size = new System.Drawing.Size(332, 179);
            this.panelFilledFigure.TabIndex = 30;
            this.panelFilledFigure.Visible = false;
            // 
            // trbStrokeWidth
            // 
            this.trbStrokeWidth.Location = new System.Drawing.Point(184, 111);
            this.trbStrokeWidth.Name = "trbStrokeWidth";
            this.trbStrokeWidth.Size = new System.Drawing.Size(134, 56);
            this.trbStrokeWidth.TabIndex = 6;
            this.trbStrokeWidth.Scroll += new System.EventHandler(this.trbStrokeWidth_Scroll);
            // 
            // lbStrokeWidth
            // 
            this.lbStrokeWidth.AutoSize = true;
            this.lbStrokeWidth.Location = new System.Drawing.Point(184, 79);
            this.lbStrokeWidth.Name = "lbStrokeWidth";
            this.lbStrokeWidth.Size = new System.Drawing.Size(134, 20);
            this.lbStrokeWidth.TabIndex = 5;
            this.lbStrokeWidth.Text = "Select stroke width";
            // 
            // panelStrokColor
            // 
            this.panelStrokColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStrokColor.Location = new System.Drawing.Point(201, 37);
            this.panelStrokColor.Name = "panelStrokColor";
            this.panelStrokColor.Size = new System.Drawing.Size(29, 29);
            this.panelStrokColor.TabIndex = 4;
            this.panelStrokColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelStrokColor_MouseClick);
            // 
            // lbStrokColor
            // 
            this.lbStrokColor.AutoSize = true;
            this.lbStrokColor.Location = new System.Drawing.Point(184, 13);
            this.lbStrokColor.Name = "lbStrokColor";
            this.lbStrokColor.Size = new System.Drawing.Size(131, 20);
            this.lbStrokColor.TabIndex = 3;
            this.lbStrokColor.Text = "Select stroke color";
            // 
            // lbSelectColor
            // 
            this.lbSelectColor.AutoSize = true;
            this.lbSelectColor.Location = new System.Drawing.Point(34, 13);
            this.lbSelectColor.Name = "lbSelectColor";
            this.lbSelectColor.Size = new System.Drawing.Size(130, 20);
            this.lbSelectColor.TabIndex = 2;
            this.lbSelectColor.Text = "Select figure color";
            // 
            // panelFigureColor
            // 
            this.panelFigureColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFigureColor.Location = new System.Drawing.Point(42, 37);
            this.panelFigureColor.Name = "panelFigureColor";
            this.panelFigureColor.Size = new System.Drawing.Size(29, 29);
            this.panelFigureColor.TabIndex = 0;
            this.panelFigureColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelFigureColor_MouseClick);
            // 
            // panelCircle
            // 
            this.panelCircle.Controls.Add(this.tbCircleX);
            this.panelCircle.Controls.Add(this.lbRadius);
            this.panelCircle.Controls.Add(this.tbCircleY);
            this.panelCircle.Controls.Add(this.lbCircleY);
            this.panelCircle.Controls.Add(this.tbRadius);
            this.panelCircle.Controls.Add(this.lbCircleX);
            this.panelCircle.Location = new System.Drawing.Point(0, 127);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(332, 157);
            this.panelCircle.TabIndex = 27;
            this.panelCircle.Visible = false;
            // 
            // tbCircleX
            // 
            this.tbCircleX.Location = new System.Drawing.Point(35, 14);
            this.tbCircleX.Name = "tbCircleX";
            this.tbCircleX.Size = new System.Drawing.Size(125, 27);
            this.tbCircleX.TabIndex = 7;
            this.tbCircleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Location = new System.Drawing.Point(9, 102);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(21, 20);
            this.lbRadius.TabIndex = 12;
            this.lbRadius.Text = "R:";
            // 
            // tbCircleY
            // 
            this.tbCircleY.Location = new System.Drawing.Point(36, 56);
            this.tbCircleY.Name = "tbCircleY";
            this.tbCircleY.Size = new System.Drawing.Size(125, 27);
            this.tbCircleY.TabIndex = 8;
            this.tbCircleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbCircleY
            // 
            this.lbCircleY.AutoSize = true;
            this.lbCircleY.Location = new System.Drawing.Point(9, 56);
            this.lbCircleY.Name = "lbCircleY";
            this.lbCircleY.Size = new System.Drawing.Size(20, 20);
            this.lbCircleY.TabIndex = 11;
            this.lbCircleY.Text = "Y:";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(36, 99);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(125, 27);
            this.tbRadius.TabIndex = 9;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbCircleX
            // 
            this.lbCircleX.AutoSize = true;
            this.lbCircleX.Location = new System.Drawing.Point(8, 17);
            this.lbCircleX.Name = "lbCircleX";
            this.lbCircleX.Size = new System.Drawing.Size(21, 20);
            this.lbCircleX.TabIndex = 10;
            this.lbCircleX.Text = "X:";
            // 
            // panelRectangle
            // 
            this.panelRectangle.Controls.Add(this.tbRectangleX);
            this.panelRectangle.Controls.Add(this.tbRectangleY);
            this.panelRectangle.Controls.Add(this.lbRectangleY);
            this.panelRectangle.Controls.Add(this.lbRectangleX);
            this.panelRectangle.Controls.Add(this.tbWidth);
            this.panelRectangle.Controls.Add(this.lbHeight);
            this.panelRectangle.Controls.Add(this.tbHight);
            this.panelRectangle.Controls.Add(this.lbWidth);
            this.panelRectangle.Location = new System.Drawing.Point(0, 117);
            this.panelRectangle.Name = "panelRectangle";
            this.panelRectangle.Size = new System.Drawing.Size(332, 167);
            this.panelRectangle.TabIndex = 29;
            this.panelRectangle.Visible = false;
            // 
            // tbRectangleX
            // 
            this.tbRectangleX.Location = new System.Drawing.Point(34, 12);
            this.tbRectangleX.Name = "tbRectangleX";
            this.tbRectangleX.Size = new System.Drawing.Size(125, 27);
            this.tbRectangleX.TabIndex = 26;
            this.tbRectangleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbRectangleY
            // 
            this.tbRectangleY.Location = new System.Drawing.Point(35, 54);
            this.tbRectangleY.Name = "tbRectangleY";
            this.tbRectangleY.Size = new System.Drawing.Size(125, 27);
            this.tbRectangleY.TabIndex = 27;
            this.tbRectangleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbRectangleY
            // 
            this.lbRectangleY.AutoSize = true;
            this.lbRectangleY.Location = new System.Drawing.Point(9, 54);
            this.lbRectangleY.Name = "lbRectangleY";
            this.lbRectangleY.Size = new System.Drawing.Size(20, 20);
            this.lbRectangleY.TabIndex = 29;
            this.lbRectangleY.Text = "Y:";
            // 
            // lbRectangleX
            // 
            this.lbRectangleX.AutoSize = true;
            this.lbRectangleX.Location = new System.Drawing.Point(9, 16);
            this.lbRectangleX.Name = "lbRectangleX";
            this.lbRectangleX.Size = new System.Drawing.Size(21, 20);
            this.lbRectangleX.TabIndex = 28;
            this.lbRectangleX.Text = "X:";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(193, 116);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(125, 27);
            this.tbWidth.TabIndex = 25;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(68, 93);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(57, 20);
            this.lbHeight.TabIndex = 22;
            this.lbHeight.Text = "Height:";
            // 
            // tbHight
            // 
            this.tbHight.Location = new System.Drawing.Point(34, 116);
            this.tbHight.Name = "tbHight";
            this.tbHight.Size = new System.Drawing.Size(125, 27);
            this.tbHight.TabIndex = 23;
            this.tbHight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(232, 93);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(52, 20);
            this.lbWidth.TabIndex = 24;
            this.lbWidth.Text = "Width:";
            // 
            // panelTriangle
            // 
            this.panelTriangle.Controls.Add(this.tbTriangleY2);
            this.panelTriangle.Controls.Add(this.lbTriangleX2);
            this.panelTriangle.Controls.Add(this.tbTriangleX2);
            this.panelTriangle.Controls.Add(this.lbTriangleY2);
            this.panelTriangle.Controls.Add(this.tbTriangleX);
            this.panelTriangle.Controls.Add(this.tbTriangleY3);
            this.panelTriangle.Controls.Add(this.tbTriangleY);
            this.panelTriangle.Controls.Add(this.tbTriangleX3);
            this.panelTriangle.Controls.Add(this.lbTriangleY3);
            this.panelTriangle.Controls.Add(this.lbTriangleY);
            this.panelTriangle.Controls.Add(this.lbTriangleX3);
            this.panelTriangle.Controls.Add(this.lbTriangleX);
            this.panelTriangle.Location = new System.Drawing.Point(0, 117);
            this.panelTriangle.Name = "panelTriangle";
            this.panelTriangle.Size = new System.Drawing.Size(332, 182);
            this.panelTriangle.TabIndex = 28;
            this.panelTriangle.Visible = false;
            // 
            // tbTriangleY2
            // 
            this.tbTriangleY2.Location = new System.Drawing.Point(201, 55);
            this.tbTriangleY2.Name = "tbTriangleY2";
            this.tbTriangleY2.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleY2.TabIndex = 22;
            this.tbTriangleY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbTriangleX2
            // 
            this.lbTriangleX2.AutoSize = true;
            this.lbTriangleX2.Location = new System.Drawing.Point(166, 16);
            this.lbTriangleX2.Name = "lbTriangleX2";
            this.lbTriangleX2.Size = new System.Drawing.Size(29, 20);
            this.lbTriangleX2.TabIndex = 20;
            this.lbTriangleX2.Text = "X2:";
            // 
            // tbTriangleX2
            // 
            this.tbTriangleX2.Location = new System.Drawing.Point(201, 13);
            this.tbTriangleX2.Name = "tbTriangleX2";
            this.tbTriangleX2.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleX2.TabIndex = 21;
            this.tbTriangleX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbTriangleY2
            // 
            this.lbTriangleY2.AutoSize = true;
            this.lbTriangleY2.Location = new System.Drawing.Point(167, 58);
            this.lbTriangleY2.Name = "lbTriangleY2";
            this.lbTriangleY2.Size = new System.Drawing.Size(28, 20);
            this.lbTriangleY2.TabIndex = 23;
            this.lbTriangleY2.Text = "Y2:";
            // 
            // tbTriangleX
            // 
            this.tbTriangleX.Location = new System.Drawing.Point(35, 13);
            this.tbTriangleX.Name = "tbTriangleX";
            this.tbTriangleX.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleX.TabIndex = 16;
            this.tbTriangleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbTriangleY3
            // 
            this.tbTriangleY3.Location = new System.Drawing.Point(201, 140);
            this.tbTriangleY3.Name = "tbTriangleY3";
            this.tbTriangleY3.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleY3.TabIndex = 21;
            this.tbTriangleY3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbTriangleY
            // 
            this.tbTriangleY.Location = new System.Drawing.Point(36, 55);
            this.tbTriangleY.Name = "tbTriangleY";
            this.tbTriangleY.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleY.TabIndex = 17;
            this.tbTriangleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbTriangleX3
            // 
            this.tbTriangleX3.Location = new System.Drawing.Point(201, 97);
            this.tbTriangleX3.Name = "tbTriangleX3";
            this.tbTriangleX3.Size = new System.Drawing.Size(125, 27);
            this.tbTriangleX3.TabIndex = 20;
            this.tbTriangleX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbTriangleY3
            // 
            this.lbTriangleY3.AutoSize = true;
            this.lbTriangleY3.Location = new System.Drawing.Point(168, 143);
            this.lbTriangleY3.Name = "lbTriangleY3";
            this.lbTriangleY3.Size = new System.Drawing.Size(28, 20);
            this.lbTriangleY3.TabIndex = 19;
            this.lbTriangleY3.Text = "Y3:";
            // 
            // lbTriangleY
            // 
            this.lbTriangleY.AutoSize = true;
            this.lbTriangleY.Location = new System.Drawing.Point(9, 55);
            this.lbTriangleY.Name = "lbTriangleY";
            this.lbTriangleY.Size = new System.Drawing.Size(20, 20);
            this.lbTriangleY.TabIndex = 19;
            this.lbTriangleY.Text = "Y:";
            // 
            // lbTriangleX3
            // 
            this.lbTriangleX3.AutoSize = true;
            this.lbTriangleX3.Location = new System.Drawing.Point(167, 100);
            this.lbTriangleX3.Name = "lbTriangleX3";
            this.lbTriangleX3.Size = new System.Drawing.Size(29, 20);
            this.lbTriangleX3.TabIndex = 18;
            this.lbTriangleX3.Text = "X3:";
            // 
            // lbTriangleX
            // 
            this.lbTriangleX.AutoSize = true;
            this.lbTriangleX.Location = new System.Drawing.Point(8, 16);
            this.lbTriangleX.Name = "lbTriangleX";
            this.lbTriangleX.Size = new System.Drawing.Size(21, 20);
            this.lbTriangleX.TabIndex = 18;
            this.lbTriangleX.Text = "X:";
            // 
            // panelLine
            // 
            this.panelLine.Controls.Add(this.tbLineX);
            this.panelLine.Controls.Add(this.tbLineY);
            this.panelLine.Controls.Add(this.tbLineY2);
            this.panelLine.Controls.Add(this.lbLineY);
            this.panelLine.Controls.Add(this.lbLineX);
            this.panelLine.Controls.Add(this.lbLineX2);
            this.panelLine.Controls.Add(this.tbLineX2);
            this.panelLine.Controls.Add(this.lbLineY2);
            this.panelLine.Location = new System.Drawing.Point(0, 127);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(332, 157);
            this.panelLine.TabIndex = 28;
            this.panelLine.Visible = false;
            // 
            // tbLineX
            // 
            this.tbLineX.Location = new System.Drawing.Point(34, 9);
            this.tbLineX.Name = "tbLineX";
            this.tbLineX.Size = new System.Drawing.Size(125, 27);
            this.tbLineX.TabIndex = 12;
            this.tbLineX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbLineY
            // 
            this.tbLineY.Location = new System.Drawing.Point(35, 51);
            this.tbLineY.Name = "tbLineY";
            this.tbLineY.Size = new System.Drawing.Size(125, 27);
            this.tbLineY.TabIndex = 13;
            this.tbLineY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tbLineY2
            // 
            this.tbLineY2.Location = new System.Drawing.Point(201, 51);
            this.tbLineY2.Name = "tbLineY2";
            this.tbLineY2.Size = new System.Drawing.Size(125, 27);
            this.tbLineY2.TabIndex = 15;
            this.tbLineY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbLineY
            // 
            this.lbLineY.AutoSize = true;
            this.lbLineY.Location = new System.Drawing.Point(9, 51);
            this.lbLineY.Name = "lbLineY";
            this.lbLineY.Size = new System.Drawing.Size(20, 20);
            this.lbLineY.TabIndex = 15;
            this.lbLineY.Text = "Y:";
            // 
            // lbLineX
            // 
            this.lbLineX.AutoSize = true;
            this.lbLineX.Location = new System.Drawing.Point(9, 13);
            this.lbLineX.Name = "lbLineX";
            this.lbLineX.Size = new System.Drawing.Size(21, 20);
            this.lbLineX.TabIndex = 14;
            this.lbLineX.Text = "X:";
            // 
            // lbLineX2
            // 
            this.lbLineX2.AutoSize = true;
            this.lbLineX2.Location = new System.Drawing.Point(169, 12);
            this.lbLineX2.Name = "lbLineX2";
            this.lbLineX2.Size = new System.Drawing.Size(29, 20);
            this.lbLineX2.TabIndex = 13;
            this.lbLineX2.Text = "X2:";
            // 
            // tbLineX2
            // 
            this.tbLineX2.Location = new System.Drawing.Point(201, 9);
            this.tbLineX2.Name = "tbLineX2";
            this.tbLineX2.Size = new System.Drawing.Size(125, 27);
            this.tbLineX2.TabIndex = 14;
            this.tbLineX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lbLineY2
            // 
            this.lbLineY2.AutoSize = true;
            this.lbLineY2.Location = new System.Drawing.Point(170, 54);
            this.lbLineY2.Name = "lbLineY2";
            this.lbLineY2.Size = new System.Drawing.Size(28, 20);
            this.lbLineY2.TabIndex = 16;
            this.lbLineY2.Text = "Y2:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(224, 49);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(94, 29);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // labelSelectFigure
            // 
            this.labelSelectFigure.AutoSize = true;
            this.labelSelectFigure.Location = new System.Drawing.Point(42, 27);
            this.labelSelectFigure.Name = "labelSelectFigure";
            this.labelSelectFigure.Size = new System.Drawing.Size(92, 20);
            this.labelSelectFigure.TabIndex = 3;
            this.labelSelectFigure.Text = "Select figure";
            // 
            // cbFigures
            // 
            this.cbFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFigures.FormattingEnabled = true;
            this.cbFigures.Items.AddRange(new object[] {
            "Circle",
            "Line",
            "Rectangle",
            "Triangle"});
            this.cbFigures.Location = new System.Drawing.Point(12, 50);
            this.cbFigures.Name = "cbFigures";
            this.cbFigures.Size = new System.Drawing.Size(151, 28);
            this.cbFigures.TabIndex = 2;
            this.cbFigures.SelectedIndexChanged += new System.EventHandler(this.cbFigures_SelectedIndexChanged);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Location = new System.Drawing.Point(332, 28);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(928, 377);
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // GraphicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 405);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.panelDataInput);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "GraphicEditor";
            this.Text = "GraphicEditor";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panelDataInput.ResumeLayout(false);
            this.panelDataInput.PerformLayout();
            this.panelFilledFigure.ResumeLayout(false);
            this.panelFilledFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrokeWidth)).EndInit();
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.panelRectangle.ResumeLayout(false);
            this.panelRectangle.PerformLayout();
            this.panelTriangle.ResumeLayout(false);
            this.panelTriangle.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip msMenu;
        private ToolStripMenuItem itemFile;
        private ToolStripMenuItem itemSave;
        private ToolStripMenuItem itemLoad;
        private OpenFileDialog dlgLoad;
        private SaveFileDialog dlgSave;
        public Panel panelDataInput;
        private Label labelSelectFigure;
        private ComboBox cbFigures;
        private Button btnDraw;
        public PictureBox pbPicture;
        private TextBox tbRadius;
        private TextBox tbCircleY;
        private TextBox tbCircleX;
        private Label lbRadius;
        private Label lbCircleY;
        private Label lbCircleX;
        private Label lbLineX2;
        private TextBox tbLineY2;
        private TextBox tbLineX2;
        private TextBox tbTriangleY3;
        private TextBox tbTriangleX3;
        private Label lbTriangleY3;
        private Label lbTriangleX3;
        private Label lbLineY2;
        private TextBox tbWidth;
        private Label lbWidth;
        private TextBox tbHight;
        private Label lbHeight;
        private Button btnClear;
        private Panel panelCircle;
        private Panel panelLine;
        private TextBox tbLineX;
        private TextBox tbLineY;
        private Label lbLineY;
        private Label lbLineX;
        private Panel panelTriangle;
        private TextBox tbTriangleY2;
        private Label lbTriangleX2;
        private TextBox tbTriangleX2;
        private Label lbTriangleY2;
        private TextBox tbTriangleX;
        private TextBox tbTriangleY;
        private Label lbTriangleY;
        private Label lbTriangleX;
        private Panel panelRectangle;
        private TextBox tbRectangleX;
        private TextBox tbRectangleY;
        private Label lbRectangleY;
        private Label lbRectangleX;
        private Panel panelFilledFigure;
        private Panel panelFigureColor;
        public ColorDialog cdlgFilled;
        private Label lbSelectColor;
        private Panel panelStrokColor;
        private Label lbStrokColor;
        private TrackBar trbStrokeWidth;
        private Label lbStrokeWidth;
    }
}