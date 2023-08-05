
namespace test.SubForms
{
    partial class PumpConfig
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
            this.pumpName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pumpState = new System.Windows.Forms.Label();
            this.offButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pumpName
            // 
            this.pumpName.AutoSize = true;
            this.pumpName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpName.ForeColor = System.Drawing.Color.Blue;
            this.pumpName.Location = new System.Drawing.Point(145, 27);
            this.pumpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pumpName.Name = "pumpName";
            this.pumpName.Size = new System.Drawing.Size(68, 25);
            this.pumpName.TabIndex = 13;
            this.pumpName.Text = "NAME";
            this.pumpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên bơm:";
            // 
            // pumpState
            // 
            this.pumpState.AutoSize = true;
            this.pumpState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpState.Location = new System.Drawing.Point(214, 66);
            this.pumpState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pumpState.Name = "pumpState";
            this.pumpState.Size = new System.Drawing.Size(66, 25);
            this.pumpState.TabIndex = 11;
            this.pumpState.Text = "STATE";
            this.pumpState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offButton
            // 
            this.offButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton.Location = new System.Drawing.Point(197, 106);
            this.offButton.Margin = new System.Windows.Forms.Padding(2);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(68, 36);
            this.offButton.TabIndex = 10;
            this.offButton.Text = "Tắt";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trạng thái bơm:";
            // 
            // onButton
            // 
            this.onButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onButton.Location = new System.Drawing.Point(61, 106);
            this.onButton.Margin = new System.Windows.Forms.Padding(2);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(68, 36);
            this.onButton.TabIndex = 8;
            this.onButton.Text = "Bật";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // PumpConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(318, 165);
            this.Controls.Add(this.pumpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pumpState);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onButton);
            this.Name = "PumpConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PumpConfig";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.PumpConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pumpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pumpState;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onButton;
    }
}