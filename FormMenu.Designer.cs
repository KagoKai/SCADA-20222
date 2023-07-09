
namespace test
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.logoutButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl6 = new SymbolFactoryDotNet.StandardControl();
            this.menuTitle = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.standardControl2 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl3 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl5 = new SymbolFactoryDotNet.StandardControl();
            this.buttonMalt = new System.Windows.Forms.Button();
            this.buttonGao = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.standardControl4 = new SymbolFactoryDotNet.StandardControl();
            this.buttonLang = new System.Windows.Forms.Button();
            this.buttonHoa = new System.Windows.Forms.Button();
            this.buttonCIP = new System.Windows.Forms.Button();
            this.timerComm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1150, 590);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(105, 38);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Đăng xuất";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(1150, 634);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(105, 38);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Thoát";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.BackColor = System.Drawing.Color.Transparent;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl1.BlinkColor = System.Drawing.Color.Red;
            this.standardControl1.Category = "1TANK.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl1.Location = new System.Drawing.Point(243, 198);
            this.standardControl1.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(152, 142);
            this.standardControl1.SymbolHandle = ((long)(1308633972));
            this.standardControl1.TabIndex = 2;
            // 
            // standardControl6
            // 
            this.standardControl6.AnalogIntValue1 = ((short)(0));
            this.standardControl6.AnalogValue1 = 0D;
            this.standardControl6.BackColor = System.Drawing.Color.Transparent;
            this.standardControl6.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl6.BlinkColor = System.Drawing.Color.Red;
            this.standardControl6.Category = "1TANK.cat2";
            this.standardControl6.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl6.DebugData"));
            this.standardControl6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl6.Location = new System.Drawing.Point(30, 353);
            this.standardControl6.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl6.Name = "standardControl6";
            this.standardControl6.Size = new System.Drawing.Size(90, 110);
            this.standardControl6.SymbolHandle = ((long)(224908965));
            this.standardControl6.TabIndex = 10;
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.Font = new System.Drawing.Font("Segoe UI", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.Location = new System.Drawing.Point(234, 24);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(842, 118);
            this.menuTitle.TabIndex = 11;
            this.menuTitle.Text = "HỆ THỐNG CIP \r\nTRONG NHÀ MÁY BIA KHÔNG CÓ THẬT\r\n";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.dateLabel.Location = new System.Drawing.Point(10, 7);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(152, 25);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Ngày tháng năm";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Blue;
            this.timeLabel.Location = new System.Drawing.Point(10, 33);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 25);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Giờ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // standardControl2
            // 
            this.standardControl2.AnalogIntValue1 = ((short)(0));
            this.standardControl2.AnalogValue1 = 0D;
            this.standardControl2.BackColor = System.Drawing.Color.Transparent;
            this.standardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl2.BlinkColor = System.Drawing.Color.Red;
            this.standardControl2.Category = "1TANK.cat2";
            this.standardControl2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl2.DebugData"));
            this.standardControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl2.Location = new System.Drawing.Point(565, 198);
            this.standardControl2.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl2.Name = "standardControl2";
            this.standardControl2.Size = new System.Drawing.Size(152, 142);
            this.standardControl2.SymbolHandle = ((long)(1308633972));
            this.standardControl2.TabIndex = 14;
            // 
            // standardControl3
            // 
            this.standardControl3.AnalogIntValue1 = ((short)(0));
            this.standardControl3.AnalogValue1 = 0D;
            this.standardControl3.BackColor = System.Drawing.Color.Transparent;
            this.standardControl3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl3.BlinkColor = System.Drawing.Color.Red;
            this.standardControl3.Category = "1TANK.cat2";
            this.standardControl3.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl3.DebugData"));
            this.standardControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl3.Location = new System.Drawing.Point(886, 198);
            this.standardControl3.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl3.Name = "standardControl3";
            this.standardControl3.Size = new System.Drawing.Size(152, 142);
            this.standardControl3.SymbolHandle = ((long)(2145454206));
            this.standardControl3.TabIndex = 15;
            // 
            // standardControl5
            // 
            this.standardControl5.AnalogIntValue1 = ((short)(0));
            this.standardControl5.AnalogValue1 = 0D;
            this.standardControl5.BackColor = System.Drawing.Color.Transparent;
            this.standardControl5.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl5.BlinkColor = System.Drawing.Color.Red;
            this.standardControl5.Category = "1TANK.cat2";
            this.standardControl5.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl5.DebugData"));
            this.standardControl5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl5.Location = new System.Drawing.Point(735, 414);
            this.standardControl5.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl5.Name = "standardControl5";
            this.standardControl5.Size = new System.Drawing.Size(152, 142);
            this.standardControl5.SymbolHandle = ((long)(2145454206));
            this.standardControl5.TabIndex = 17;
            // 
            // buttonMalt
            // 
            this.buttonMalt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMalt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMalt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMalt.Location = new System.Drawing.Point(582, 353);
            this.buttonMalt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMalt.Name = "buttonMalt";
            this.buttonMalt.Size = new System.Drawing.Size(121, 34);
            this.buttonMalt.TabIndex = 18;
            this.buttonMalt.Text = "Tank malt";
            this.buttonMalt.UseVisualStyleBackColor = false;
            // 
            // buttonGao
            // 
            this.buttonGao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGao.Location = new System.Drawing.Point(257, 353);
            this.buttonGao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGao.Name = "buttonGao";
            this.buttonGao.Size = new System.Drawing.Size(120, 34);
            this.buttonGao.TabIndex = 19;
            this.buttonGao.Text = "Tank gạo";
            this.buttonGao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGao.UseVisualStyleBackColor = false;
            this.buttonGao.Click += new System.EventHandler(this.buttonGao_Click);
            // 
            // buttonLoc
            // 
            this.buttonLoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoc.Location = new System.Drawing.Point(902, 353);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(121, 34);
            this.buttonLoc.TabIndex = 20;
            this.buttonLoc.Text = "Tank lọc";
            this.buttonLoc.UseVisualStyleBackColor = false;
            // 
            // standardControl4
            // 
            this.standardControl4.AnalogIntValue1 = ((short)(0));
            this.standardControl4.AnalogValue1 = 0D;
            this.standardControl4.BackColor = System.Drawing.Color.Transparent;
            this.standardControl4.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl4.BlinkColor = System.Drawing.Color.Red;
            this.standardControl4.Category = "1TANK.cat2";
            this.standardControl4.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl4.DebugData"));
            this.standardControl4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl4.Location = new System.Drawing.Point(403, 414);
            this.standardControl4.Margin = new System.Windows.Forms.Padding(2);
            this.standardControl4.Name = "standardControl4";
            this.standardControl4.Size = new System.Drawing.Size(152, 142);
            this.standardControl4.SymbolHandle = ((long)(1308633972));
            this.standardControl4.TabIndex = 21;
            // 
            // buttonLang
            // 
            this.buttonLang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLang.Location = new System.Drawing.Point(751, 568);
            this.buttonLang.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLang.Name = "buttonLang";
            this.buttonLang.Size = new System.Drawing.Size(121, 34);
            this.buttonLang.TabIndex = 23;
            this.buttonLang.Text = "Tank lắng xoáy";
            this.buttonLang.UseVisualStyleBackColor = false;
            // 
            // buttonHoa
            // 
            this.buttonHoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHoa.Location = new System.Drawing.Point(420, 569);
            this.buttonHoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHoa.Name = "buttonHoa";
            this.buttonHoa.Size = new System.Drawing.Size(122, 34);
            this.buttonHoa.TabIndex = 25;
            this.buttonHoa.Text = "Tank hoa";
            this.buttonHoa.UseVisualStyleBackColor = false;
            // 
            // buttonCIP
            // 
            this.buttonCIP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCIP.Location = new System.Drawing.Point(22, 475);
            this.buttonCIP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCIP.Name = "buttonCIP";
            this.buttonCIP.Size = new System.Drawing.Size(105, 38);
            this.buttonCIP.TabIndex = 26;
            this.buttonCIP.Text = "Hệ CIP";
            this.buttonCIP.UseVisualStyleBackColor = false;
            this.buttonCIP.Click += new System.EventHandler(this.buttonCIP_Click);
            // 
            // timerComm
            // 
            this.timerComm.Interval = 1000;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1266, 682);
            this.Controls.Add(this.buttonCIP);
            this.Controls.Add(this.buttonHoa);
            this.Controls.Add(this.buttonLang);
            this.Controls.Add(this.standardControl4);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonGao);
            this.Controls.Add(this.buttonMalt);
            this.Controls.Add(this.standardControl5);
            this.Controls.Add(this.standardControl3);
            this.Controls.Add(this.standardControl2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.standardControl6);
            this.Controls.Add(this.standardControl1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button quitButton;
        private SymbolFactoryDotNet.StandardControl standardControl1;
        private SymbolFactoryDotNet.StandardControl standardControl6;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private SymbolFactoryDotNet.StandardControl standardControl2;
        private SymbolFactoryDotNet.StandardControl standardControl3;
        private SymbolFactoryDotNet.StandardControl standardControl5;
        private System.Windows.Forms.Button buttonMalt;
        private System.Windows.Forms.Button buttonGao;
        private System.Windows.Forms.Button buttonLoc;
        private SymbolFactoryDotNet.StandardControl standardControl4;
        private System.Windows.Forms.Button buttonLang;
        private System.Windows.Forms.Button buttonHoa;
        private System.Windows.Forms.Button buttonCIP;
        private System.Windows.Forms.Timer timerComm;
    }
}