namespace AutoClickMouse
{
    partial class AutoClickMouseLeftButton
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClickMouseLeftButton));
            this.BT_TestClick = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.LB_Numbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_TestClick
            // 
            this.BT_TestClick.Location = new System.Drawing.Point(38, 106);
            this.BT_TestClick.Name = "BT_TestClick";
            this.BT_TestClick.Size = new System.Drawing.Size(75, 23);
            this.BT_TestClick.TabIndex = 0;
            this.BT_TestClick.Text = "计数器→";
            this.BT_TestClick.UseVisualStyleBackColor = true;
            this.BT_TestClick.Click += new System.EventHandler(this.BT_TestClick_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(38, 44);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(75, 23);
            this.BT_Start.TabIndex = 1;
            this.BT_Start.Text = "开始(F9)";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(141, 44);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(75, 23);
            this.BT_Stop.TabIndex = 2;
            this.BT_Stop.Text = "结束(F10)";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // LB_Numbers
            // 
            this.LB_Numbers.Location = new System.Drawing.Point(141, 106);
            this.LB_Numbers.Name = "LB_Numbers";
            this.LB_Numbers.ReadOnly = true;
            this.LB_Numbers.Size = new System.Drawing.Size(100, 21);
            this.LB_Numbers.TabIndex = 3;
            // 
            // AutoClickMouseLeftButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.LB_Numbers);
            this.Controls.Add(this.BT_Stop);
            this.Controls.Add(this.BT_Start);
            this.Controls.Add(this.BT_TestClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClickMouseLeftButton";
            this.Text = "鼠标自动点击器 by sure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoClickMouseLeftButton_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_TestClick;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.TextBox LB_Numbers;
    }
}

