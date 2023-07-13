
namespace test.SubForms
{
    partial class ValveConfig
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
            this.onButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.offButton = new System.Windows.Forms.Button();
            this.valveState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valveName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onButton
            // 
            this.onButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onButton.Location = new System.Drawing.Point(41, 104);
            this.onButton.Margin = new System.Windows.Forms.Padding(2);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(68, 36);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Bật";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trạng thái van:";
            // 
            // offButton
            // 
            this.offButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton.Location = new System.Drawing.Point(181, 104);
            this.offButton.Margin = new System.Windows.Forms.Padding(2);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(68, 36);
            this.offButton.TabIndex = 3;
            this.offButton.Text = "Tắt";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // valveState
            // 
            this.valveState.AutoSize = true;
            this.valveState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valveState.Location = new System.Drawing.Point(200, 63);
            this.valveState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valveState.Name = "valveState";
            this.valveState.Size = new System.Drawing.Size(66, 25);
            this.valveState.TabIndex = 5;
            this.valveState.Text = "STATE";
            this.valveState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên van:";
            // 
            // valveName
            // 
            this.valveName.AutoSize = true;
            this.valveName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valveName.ForeColor = System.Drawing.Color.Blue;
            this.valveName.Location = new System.Drawing.Point(200, 23);
            this.valveName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valveName.Name = "valveName";
            this.valveName.Size = new System.Drawing.Size(68, 25);
            this.valveName.TabIndex = 7;
            this.valveName.Text = "NAME";
            this.valveName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 165);
            this.Controls.Add(this.valveName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valveState);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ValveConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển Van";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Label valveState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valveName;
    }
}