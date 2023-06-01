
namespace test
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
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(10D, 10, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl1.BlinkColor = System.Drawing.Color.Red;
            this.standardControl1.Category = "1PMP.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl1.Location = new System.Drawing.Point(200, 160);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(121, 121);
            this.standardControl1.SymbolHandle = ((long)(26978524));
            this.standardControl1.TabIndex = 0;
            this.standardControl1.Load += new System.EventHandler(this.standardControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.standardControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SymbolFactoryDotNet.StandardControl standardControl1;
    }
}

