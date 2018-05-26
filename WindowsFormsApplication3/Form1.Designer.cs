namespace WindowsFormsApplication3
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑白ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.马赛克ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.薄码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一般ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.究极马赛克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.变暗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.柔化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenBox
            // 
            this.OpenBox.Location = new System.Drawing.Point(9, 489);
            this.OpenBox.Name = "OpenBox";
            this.OpenBox.Size = new System.Drawing.Size(96, 36);
            this.OpenBox.TabIndex = 1;
            this.OpenBox.Text = "打开图片";
            this.OpenBox.UseVisualStyleBackColor = true;
            this.OpenBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(475, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 372);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "暗化";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "初始：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "结果：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 537);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "马赛克";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 580);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 35);
            this.button6.TabIndex = 15;
            this.button6.Text = "浮雕";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(100, 540);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 33);
            this.button7.TabIndex = 16;
            this.button7.Text = "黑白";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(723, 468);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(723, 495);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(723, 522);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown3.TabIndex = 19;
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(475, 466);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(128, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.黑白ToolStripMenuItem1,
            this.马赛克ToolStripMenuItem1,
            this.浮雕ToolStripMenuItem1,
            this.变暗ToolStripMenuItem,
            this.柔化ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(919, 25);
            this.menuStrip2.TabIndex = 25;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开图片ToolStripMenuItem,
            this.保存图片ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "图片操作";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 打开图片ToolStripMenuItem
            // 
            this.打开图片ToolStripMenuItem.Name = "打开图片ToolStripMenuItem";
            this.打开图片ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开图片ToolStripMenuItem.Text = "打开图片";
            this.打开图片ToolStripMenuItem.Click += new System.EventHandler(this.打开图片ToolStripMenuItem_Click);
            // 
            // 保存图片ToolStripMenuItem
            // 
            this.保存图片ToolStripMenuItem.Name = "保存图片ToolStripMenuItem";
            this.保存图片ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存图片ToolStripMenuItem.Text = "保存图片";
            this.保存图片ToolStripMenuItem.Click += new System.EventHandler(this.保存图片ToolStripMenuItem_Click);
            // 
            // 黑白ToolStripMenuItem1
            // 
            this.黑白ToolStripMenuItem1.Name = "黑白ToolStripMenuItem1";
            this.黑白ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.黑白ToolStripMenuItem1.Text = "黑白";
            this.黑白ToolStripMenuItem1.Click += new System.EventHandler(this.黑白ToolStripMenuItem1_Click);
            // 
            // 马赛克ToolStripMenuItem1
            // 
            this.马赛克ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.薄码ToolStripMenuItem,
            this.一般ToolStripMenuItem,
            this.究极马赛克ToolStripMenuItem});
            this.马赛克ToolStripMenuItem1.Name = "马赛克ToolStripMenuItem1";
            this.马赛克ToolStripMenuItem1.Size = new System.Drawing.Size(56, 21);
            this.马赛克ToolStripMenuItem1.Text = "马赛克";
            // 
            // 薄码ToolStripMenuItem
            // 
            this.薄码ToolStripMenuItem.Name = "薄码ToolStripMenuItem";
            this.薄码ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.薄码ToolStripMenuItem.Text = "薄码";
            this.薄码ToolStripMenuItem.Click += new System.EventHandler(this.薄码ToolStripMenuItem_Click);
            // 
            // 一般ToolStripMenuItem
            // 
            this.一般ToolStripMenuItem.Name = "一般ToolStripMenuItem";
            this.一般ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.一般ToolStripMenuItem.Text = "一般";
            this.一般ToolStripMenuItem.Click += new System.EventHandler(this.一般ToolStripMenuItem_Click);
            // 
            // 究极马赛克ToolStripMenuItem
            // 
            this.究极马赛克ToolStripMenuItem.Name = "究极马赛克ToolStripMenuItem";
            this.究极马赛克ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.究极马赛克ToolStripMenuItem.Text = "究极马赛克";
            this.究极马赛克ToolStripMenuItem.Click += new System.EventHandler(this.究极马赛克ToolStripMenuItem_Click);
            // 
            // 浮雕ToolStripMenuItem1
            // 
            this.浮雕ToolStripMenuItem1.Name = "浮雕ToolStripMenuItem1";
            this.浮雕ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.浮雕ToolStripMenuItem1.Text = "浮雕";
            this.浮雕ToolStripMenuItem1.Click += new System.EventHandler(this.浮雕ToolStripMenuItem1_Click);
            // 
            // 变暗ToolStripMenuItem
            // 
            this.变暗ToolStripMenuItem.Name = "变暗ToolStripMenuItem";
            this.变暗ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.变暗ToolStripMenuItem.Text = "变暗";
            this.变暗ToolStripMenuItem.Click += new System.EventHandler(this.变暗ToolStripMenuItem_Click);
            // 
            // 柔化ToolStripMenuItem
            // 
            this.柔化ToolStripMenuItem.Name = "柔化ToolStripMenuItem";
            this.柔化ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.柔化ToolStripMenuItem.Text = "柔化";
            this.柔化ToolStripMenuItem.Click += new System.EventHandler(this.柔化ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 627);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑白ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 马赛克ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 浮雕ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 变暗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薄码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 究极马赛克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 柔化ToolStripMenuItem;
    }
}

