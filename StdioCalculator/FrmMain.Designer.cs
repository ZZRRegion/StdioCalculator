namespace StdioCalculator
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDeci = new System.Windows.Forms.Label();
            this.txtDeci = new System.Windows.Forms.TextBox();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnDeci = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(147, 37);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(215, 21);
            this.txtHex.TabIndex = 0;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(69, 41);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(65, 12);
            this.lblHex.TabIndex = 1;
            this.lblHex.Text = "十六进制：";
            // 
            // lblDeci
            // 
            this.lblDeci.AutoSize = true;
            this.lblDeci.Location = new System.Drawing.Point(69, 90);
            this.lblDeci.Name = "lblDeci";
            this.lblDeci.Size = new System.Drawing.Size(53, 12);
            this.lblDeci.TabIndex = 3;
            this.lblDeci.Text = "十进制：";
            // 
            // txtDeci
            // 
            this.txtDeci.Location = new System.Drawing.Point(147, 86);
            this.txtDeci.Name = "txtDeci";
            this.txtDeci.Size = new System.Drawing.Size(215, 21);
            this.txtDeci.TabIndex = 2;
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(371, 36);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(75, 23);
            this.btnHex.TabIndex = 4;
            this.btnHex.Text = "计算";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnDeci
            // 
            this.btnDeci.Location = new System.Drawing.Point(371, 85);
            this.btnDeci.Name = "btnDeci";
            this.btnDeci.Size = new System.Drawing.Size(75, 23);
            this.btnDeci.TabIndex = 5;
            this.btnDeci.Text = "计算";
            this.btnDeci.UseVisualStyleBackColor = true;
            this.btnDeci.Click += new System.EventHandler(this.btnDeci_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(69, 117);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "黏贴";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 152);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnDeci);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.lblDeci);
            this.Controls.Add(this.txtDeci);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.txtHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进制转换";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDeci;
        private System.Windows.Forms.TextBox txtDeci;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnDeci;
        private System.Windows.Forms.Button btnPaste;
    }
}

