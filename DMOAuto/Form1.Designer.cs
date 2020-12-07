namespace DMOAuto
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnSearchPro = new System.Windows.Forms.Button();
            this.lblProId = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.pibMonster = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPro
            // 
            this.btnSearchPro.Location = new System.Drawing.Point(21, 23);
            this.btnSearchPro.Name = "btnSearchPro";
            this.btnSearchPro.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPro.TabIndex = 0;
            this.btnSearchPro.Text = "Link Start";
            this.btnSearchPro.UseVisualStyleBackColor = true;
            this.btnSearchPro.Click += new System.EventHandler(this.ProSearch);
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Location = new System.Drawing.Point(102, 28);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(53, 12);
            this.lblProId.TabIndex = 1;
            this.lblProId.Text = "暂无进程";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Go";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.AllStart);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "W";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mody);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Mody);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Mody);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "S";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mody);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(115, 66);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 37);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.AllStop);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(104, 246);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.Mody);
            // 
            // txtBox
            // 
            this.txtBox.AcceptsReturn = true;
            this.txtBox.Location = new System.Drawing.Point(480, 157);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(312, 215);
            this.txtBox.TabIndex = 9;
            // 
            // pibMonster
            // 
            this.pibMonster.Location = new System.Drawing.Point(278, 23);
            this.pibMonster.Name = "pibMonster";
            this.pibMonster.Size = new System.Drawing.Size(40, 40);
            this.pibMonster.TabIndex = 10;
            this.pibMonster.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 63);
            this.button5.TabIndex = 11;
            this.button5.Text = "Select Monster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SelectMonster);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(437, 28);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 21);
            this.txtCor.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 425);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pibMonster);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblProId);
            this.Controls.Add(this.btnSearchPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "DMOAuto";
            ((System.ComponentModel.ISupportInitialize)(this.pibMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPro;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.PictureBox pibMonster;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtCor;
    }
}

