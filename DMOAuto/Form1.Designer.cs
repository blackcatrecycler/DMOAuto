namespace DMOAuto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnSearchPro = new System.Windows.Forms.Button();
            this.LblProId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSearchPro
            // 
            this.BtnSearchPro.Location = new System.Drawing.Point(21, 23);
            this.BtnSearchPro.Name = "BtnSearchPro";
            this.BtnSearchPro.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchPro.TabIndex = 0;
            this.BtnSearchPro.Text = "寻找进程";
            this.BtnSearchPro.UseVisualStyleBackColor = true;
            // 
            // LblProId
            // 
            this.LblProId.AutoSize = true;
            this.LblProId.Location = new System.Drawing.Point(102, 28);
            this.LblProId.Name = "LblProId";
            this.LblProId.Size = new System.Drawing.Size(53, 12);
            this.LblProId.TabIndex = 1;
            this.LblProId.Text = "暂无进程";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 425);
            this.Controls.Add(this.LblProId);
            this.Controls.Add(this.BtnSearchPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DMOAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchPro;
        private System.Windows.Forms.Label LblProId;
    }
}

