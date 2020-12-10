namespace SimpleCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.divideBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fourBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.oneBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.zeroBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dotBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.twoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fiveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.eightBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nineBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sixBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.threeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.calcBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minusBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plusBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sevenBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // divideBtn
            // 
            resources.ApplyResources(this.divideBtn, "divideBtn");
            this.divideBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.divideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.divideBtn.BorderRadius = 0;
            this.divideBtn.ButtonText = "/";
            this.divideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divideBtn.DisabledColor = System.Drawing.Color.Gray;
            this.divideBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.divideBtn.Iconimage = null;
            this.divideBtn.Iconimage_right = null;
            this.divideBtn.Iconimage_right_Selected = null;
            this.divideBtn.Iconimage_Selected = null;
            this.divideBtn.IconMarginLeft = 0;
            this.divideBtn.IconMarginRight = 0;
            this.divideBtn.IconRightVisible = true;
            this.divideBtn.IconRightZoom = 0D;
            this.divideBtn.IconVisible = true;
            this.divideBtn.IconZoom = 90D;
            this.divideBtn.IsTab = false;
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.divideBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.divideBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.divideBtn.selected = false;
            this.divideBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divideBtn.Textcolor = System.Drawing.Color.White;
            this.divideBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            resources.ApplyResources(this.bunifuMaterialTextbox1, "bunifuMaterialTextbox1");
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.bunifuMaterialTextbox1.LineThickness = 5;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fourBtn
            // 
            resources.ApplyResources(this.fourBtn, "fourBtn");
            this.fourBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.fourBtn.BorderRadius = 0;
            this.fourBtn.ButtonText = "4";
            this.fourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourBtn.DisabledColor = System.Drawing.Color.Gray;
            this.fourBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.fourBtn.Iconimage = null;
            this.fourBtn.Iconimage_right = null;
            this.fourBtn.Iconimage_right_Selected = null;
            this.fourBtn.Iconimage_Selected = null;
            this.fourBtn.IconMarginLeft = 0;
            this.fourBtn.IconMarginRight = 0;
            this.fourBtn.IconRightVisible = true;
            this.fourBtn.IconRightZoom = 0D;
            this.fourBtn.IconVisible = true;
            this.fourBtn.IconZoom = 90D;
            this.fourBtn.IsTab = false;
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.fourBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.fourBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.fourBtn.selected = false;
            this.fourBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fourBtn.Textcolor = System.Drawing.Color.White;
            this.fourBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // oneBtn
            // 
            resources.ApplyResources(this.oneBtn, "oneBtn");
            this.oneBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.oneBtn.BorderRadius = 0;
            this.oneBtn.ButtonText = "1";
            this.oneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneBtn.DisabledColor = System.Drawing.Color.Gray;
            this.oneBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.oneBtn.Iconimage = null;
            this.oneBtn.Iconimage_right = null;
            this.oneBtn.Iconimage_right_Selected = null;
            this.oneBtn.Iconimage_Selected = null;
            this.oneBtn.IconMarginLeft = 0;
            this.oneBtn.IconMarginRight = 0;
            this.oneBtn.IconRightVisible = true;
            this.oneBtn.IconRightZoom = 0D;
            this.oneBtn.IconVisible = true;
            this.oneBtn.IconZoom = 90D;
            this.oneBtn.IsTab = false;
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.oneBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.oneBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.oneBtn.selected = false;
            this.oneBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oneBtn.Textcolor = System.Drawing.Color.White;
            this.oneBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // zeroBtn
            // 
            resources.ApplyResources(this.zeroBtn, "zeroBtn");
            this.zeroBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.zeroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.zeroBtn.BorderRadius = 0;
            this.zeroBtn.ButtonText = "0";
            this.zeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroBtn.DisabledColor = System.Drawing.Color.Gray;
            this.zeroBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.zeroBtn.Iconimage = null;
            this.zeroBtn.Iconimage_right = null;
            this.zeroBtn.Iconimage_right_Selected = null;
            this.zeroBtn.Iconimage_Selected = null;
            this.zeroBtn.IconMarginLeft = 0;
            this.zeroBtn.IconMarginRight = 0;
            this.zeroBtn.IconRightVisible = true;
            this.zeroBtn.IconRightZoom = 0D;
            this.zeroBtn.IconVisible = true;
            this.zeroBtn.IconZoom = 90D;
            this.zeroBtn.IsTab = false;
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.zeroBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.zeroBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.zeroBtn.selected = false;
            this.zeroBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zeroBtn.Textcolor = System.Drawing.Color.White;
            this.zeroBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // dotBtn
            // 
            resources.ApplyResources(this.dotBtn, "dotBtn");
            this.dotBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.dotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.dotBtn.BorderRadius = 0;
            this.dotBtn.ButtonText = ".";
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dotBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dotBtn.Iconimage = null;
            this.dotBtn.Iconimage_right = null;
            this.dotBtn.Iconimage_right_Selected = null;
            this.dotBtn.Iconimage_Selected = null;
            this.dotBtn.IconMarginLeft = 0;
            this.dotBtn.IconMarginRight = 0;
            this.dotBtn.IconRightVisible = true;
            this.dotBtn.IconRightZoom = 0D;
            this.dotBtn.IconVisible = true;
            this.dotBtn.IconZoom = 90D;
            this.dotBtn.IsTab = false;
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.dotBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.dotBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.dotBtn.selected = false;
            this.dotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dotBtn.Textcolor = System.Drawing.Color.White;
            this.dotBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // twoBtn
            // 
            resources.ApplyResources(this.twoBtn, "twoBtn");
            this.twoBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.twoBtn.BorderRadius = 0;
            this.twoBtn.ButtonText = "2";
            this.twoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoBtn.DisabledColor = System.Drawing.Color.Gray;
            this.twoBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.twoBtn.Iconimage = null;
            this.twoBtn.Iconimage_right = null;
            this.twoBtn.Iconimage_right_Selected = null;
            this.twoBtn.Iconimage_Selected = null;
            this.twoBtn.IconMarginLeft = 0;
            this.twoBtn.IconMarginRight = 0;
            this.twoBtn.IconRightVisible = true;
            this.twoBtn.IconRightZoom = 0D;
            this.twoBtn.IconVisible = true;
            this.twoBtn.IconZoom = 90D;
            this.twoBtn.IsTab = false;
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.twoBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.twoBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.twoBtn.selected = false;
            this.twoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twoBtn.Textcolor = System.Drawing.Color.White;
            this.twoBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // fiveBtn
            // 
            resources.ApplyResources(this.fiveBtn, "fiveBtn");
            this.fiveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.fiveBtn.BorderRadius = 0;
            this.fiveBtn.ButtonText = "5";
            this.fiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.fiveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.fiveBtn.Iconimage = null;
            this.fiveBtn.Iconimage_right = null;
            this.fiveBtn.Iconimage_right_Selected = null;
            this.fiveBtn.Iconimage_Selected = null;
            this.fiveBtn.IconMarginLeft = 0;
            this.fiveBtn.IconMarginRight = 0;
            this.fiveBtn.IconRightVisible = true;
            this.fiveBtn.IconRightZoom = 0D;
            this.fiveBtn.IconVisible = true;
            this.fiveBtn.IconZoom = 90D;
            this.fiveBtn.IsTab = false;
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.fiveBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.fiveBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.fiveBtn.selected = false;
            this.fiveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fiveBtn.Textcolor = System.Drawing.Color.White;
            this.fiveBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // eightBtn
            // 
            resources.ApplyResources(this.eightBtn, "eightBtn");
            this.eightBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.eightBtn.BorderRadius = 0;
            this.eightBtn.ButtonText = "8";
            this.eightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eightBtn.DisabledColor = System.Drawing.Color.Gray;
            this.eightBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.eightBtn.Iconimage = null;
            this.eightBtn.Iconimage_right = null;
            this.eightBtn.Iconimage_right_Selected = null;
            this.eightBtn.Iconimage_Selected = null;
            this.eightBtn.IconMarginLeft = 0;
            this.eightBtn.IconMarginRight = 0;
            this.eightBtn.IconRightVisible = true;
            this.eightBtn.IconRightZoom = 0D;
            this.eightBtn.IconVisible = true;
            this.eightBtn.IconZoom = 90D;
            this.eightBtn.IsTab = false;
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.eightBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.eightBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.eightBtn.selected = false;
            this.eightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eightBtn.Textcolor = System.Drawing.Color.White;
            this.eightBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            resources.ApplyResources(this.nineBtn, "nineBtn");
            this.nineBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.nineBtn.BorderRadius = 0;
            this.nineBtn.ButtonText = "9";
            this.nineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nineBtn.DisabledColor = System.Drawing.Color.Gray;
            this.nineBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nineBtn.Iconimage = null;
            this.nineBtn.Iconimage_right = null;
            this.nineBtn.Iconimage_right_Selected = null;
            this.nineBtn.Iconimage_Selected = null;
            this.nineBtn.IconMarginLeft = 0;
            this.nineBtn.IconMarginRight = 0;
            this.nineBtn.IconRightVisible = true;
            this.nineBtn.IconRightZoom = 0D;
            this.nineBtn.IconVisible = true;
            this.nineBtn.IconZoom = 90D;
            this.nineBtn.IsTab = false;
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.nineBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.nineBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.nineBtn.selected = false;
            this.nineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nineBtn.Textcolor = System.Drawing.Color.White;
            this.nineBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // sixBtn
            // 
            resources.ApplyResources(this.sixBtn, "sixBtn");
            this.sixBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.sixBtn.BorderRadius = 0;
            this.sixBtn.ButtonText = "6";
            this.sixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sixBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sixBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sixBtn.Iconimage = null;
            this.sixBtn.Iconimage_right = null;
            this.sixBtn.Iconimage_right_Selected = null;
            this.sixBtn.Iconimage_Selected = null;
            this.sixBtn.IconMarginLeft = 0;
            this.sixBtn.IconMarginRight = 0;
            this.sixBtn.IconRightVisible = true;
            this.sixBtn.IconRightZoom = 0D;
            this.sixBtn.IconVisible = true;
            this.sixBtn.IconZoom = 90D;
            this.sixBtn.IsTab = false;
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.sixBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.sixBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.sixBtn.selected = false;
            this.sixBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sixBtn.Textcolor = System.Drawing.Color.White;
            this.sixBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // threeBtn
            // 
            resources.ApplyResources(this.threeBtn, "threeBtn");
            this.threeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.threeBtn.BorderRadius = 0;
            this.threeBtn.ButtonText = "3";
            this.threeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.threeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.threeBtn.Iconimage = null;
            this.threeBtn.Iconimage_right = null;
            this.threeBtn.Iconimage_right_Selected = null;
            this.threeBtn.Iconimage_Selected = null;
            this.threeBtn.IconMarginLeft = 0;
            this.threeBtn.IconMarginRight = 0;
            this.threeBtn.IconRightVisible = true;
            this.threeBtn.IconRightZoom = 0D;
            this.threeBtn.IconVisible = true;
            this.threeBtn.IconZoom = 90D;
            this.threeBtn.IsTab = false;
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.threeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.threeBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.threeBtn.selected = false;
            this.threeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threeBtn.Textcolor = System.Drawing.Color.White;
            this.threeBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // clearBtn
            // 
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.clearBtn.BorderRadius = 0;
            this.clearBtn.ButtonText = "C";
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DisabledColor = System.Drawing.Color.Gray;
            this.clearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.clearBtn.Iconimage = null;
            this.clearBtn.Iconimage_right = null;
            this.clearBtn.Iconimage_right_Selected = null;
            this.clearBtn.Iconimage_Selected = null;
            this.clearBtn.IconMarginLeft = 0;
            this.clearBtn.IconMarginRight = 0;
            this.clearBtn.IconRightVisible = true;
            this.clearBtn.IconRightZoom = 0D;
            this.clearBtn.IconVisible = true;
            this.clearBtn.IconZoom = 90D;
            this.clearBtn.IsTab = false;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.clearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.clearBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.selected = false;
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearBtn.Textcolor = System.Drawing.Color.White;
            this.clearBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calcBtn
            // 
            resources.ApplyResources(this.calcBtn, "calcBtn");
            this.calcBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.calcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.calcBtn.BorderRadius = 0;
            this.calcBtn.ButtonText = "Calculate";
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcBtn.DisabledColor = System.Drawing.Color.Gray;
            this.calcBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.calcBtn.Iconimage = null;
            this.calcBtn.Iconimage_right = null;
            this.calcBtn.Iconimage_right_Selected = null;
            this.calcBtn.Iconimage_Selected = null;
            this.calcBtn.IconMarginLeft = 0;
            this.calcBtn.IconMarginRight = 0;
            this.calcBtn.IconRightVisible = true;
            this.calcBtn.IconRightZoom = 0D;
            this.calcBtn.IconVisible = true;
            this.calcBtn.IconZoom = 90D;
            this.calcBtn.IsTab = false;
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.calcBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.calcBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.calcBtn.selected = false;
            this.calcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.calcBtn.Textcolor = System.Drawing.Color.White;
            this.calcBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // minusBtn
            // 
            resources.ApplyResources(this.minusBtn, "minusBtn");
            this.minusBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.minusBtn.BorderRadius = 0;
            this.minusBtn.ButtonText = "-";
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.DisabledColor = System.Drawing.Color.Gray;
            this.minusBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.minusBtn.Iconimage = null;
            this.minusBtn.Iconimage_right = null;
            this.minusBtn.Iconimage_right_Selected = null;
            this.minusBtn.Iconimage_Selected = null;
            this.minusBtn.IconMarginLeft = 0;
            this.minusBtn.IconMarginRight = 0;
            this.minusBtn.IconRightVisible = true;
            this.minusBtn.IconRightZoom = 0D;
            this.minusBtn.IconVisible = true;
            this.minusBtn.IconZoom = 90D;
            this.minusBtn.IsTab = false;
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.minusBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.minusBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.minusBtn.selected = false;
            this.minusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusBtn.Textcolor = System.Drawing.Color.White;
            this.minusBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            resources.ApplyResources(this.plusBtn, "plusBtn");
            this.plusBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.plusBtn.BorderRadius = 0;
            this.plusBtn.ButtonText = "+";
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.DisabledColor = System.Drawing.Color.Gray;
            this.plusBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.plusBtn.Iconimage = null;
            this.plusBtn.Iconimage_right = null;
            this.plusBtn.Iconimage_right_Selected = null;
            this.plusBtn.Iconimage_Selected = null;
            this.plusBtn.IconMarginLeft = 0;
            this.plusBtn.IconMarginRight = 0;
            this.plusBtn.IconRightVisible = true;
            this.plusBtn.IconRightZoom = 0D;
            this.plusBtn.IconVisible = true;
            this.plusBtn.IconZoom = 90D;
            this.plusBtn.IsTab = false;
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.plusBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.plusBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.plusBtn.selected = false;
            this.plusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusBtn.Textcolor = System.Drawing.Color.White;
            this.plusBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // timesBtn
            // 
            resources.ApplyResources(this.timesBtn, "timesBtn");
            this.timesBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.timesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.timesBtn.BorderRadius = 0;
            this.timesBtn.ButtonText = "*";
            this.timesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.timesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.timesBtn.Iconimage = null;
            this.timesBtn.Iconimage_right = null;
            this.timesBtn.Iconimage_right_Selected = null;
            this.timesBtn.Iconimage_Selected = null;
            this.timesBtn.IconMarginLeft = 0;
            this.timesBtn.IconMarginRight = 0;
            this.timesBtn.IconRightVisible = true;
            this.timesBtn.IconRightZoom = 0D;
            this.timesBtn.IconVisible = true;
            this.timesBtn.IconZoom = 90D;
            this.timesBtn.IsTab = false;
            this.timesBtn.Name = "timesBtn";
            this.timesBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.timesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.timesBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.timesBtn.selected = false;
            this.timesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timesBtn.Textcolor = System.Drawing.Color.White;
            this.timesBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesBtn.Click += new System.EventHandler(this.timesBtn_Click);
            // 
            // sevenBtn
            // 
            resources.ApplyResources(this.sevenBtn, "sevenBtn");
            this.sevenBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.sevenBtn.BorderRadius = 0;
            this.sevenBtn.ButtonText = "7";
            this.sevenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sevenBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sevenBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sevenBtn.Iconimage = null;
            this.sevenBtn.Iconimage_right = null;
            this.sevenBtn.Iconimage_right_Selected = null;
            this.sevenBtn.Iconimage_Selected = null;
            this.sevenBtn.IconMarginLeft = 0;
            this.sevenBtn.IconMarginRight = 0;
            this.sevenBtn.IconRightVisible = true;
            this.sevenBtn.IconRightZoom = 0D;
            this.sevenBtn.IconVisible = true;
            this.sevenBtn.IconZoom = 90D;
            this.sevenBtn.IsTab = false;
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.sevenBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.sevenBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.sevenBtn.selected = false;
            this.sevenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sevenBtn.Textcolor = System.Drawing.Color.White;
            this.sevenBtn.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleCalculator.Properties.Resources.bg;
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.timesBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.divideBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuFlatButton divideBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton fourBtn;
        private Bunifu.Framework.UI.BunifuFlatButton oneBtn;
        private Bunifu.Framework.UI.BunifuFlatButton zeroBtn;
        private Bunifu.Framework.UI.BunifuFlatButton dotBtn;
        private Bunifu.Framework.UI.BunifuFlatButton twoBtn;
        private Bunifu.Framework.UI.BunifuFlatButton fiveBtn;
        private Bunifu.Framework.UI.BunifuFlatButton eightBtn;
        private Bunifu.Framework.UI.BunifuFlatButton nineBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sixBtn;
        private Bunifu.Framework.UI.BunifuFlatButton threeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton clearBtn;
        private Bunifu.Framework.UI.BunifuFlatButton calcBtn;
        private Bunifu.Framework.UI.BunifuFlatButton minusBtn;
        private Bunifu.Framework.UI.BunifuFlatButton plusBtn;
        private Bunifu.Framework.UI.BunifuFlatButton timesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sevenBtn;
    }
}

