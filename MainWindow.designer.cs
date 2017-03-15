namespace PWinForm
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAboutView = new System.Windows.Forms.Button();
            this.btnHelpView = new System.Windows.Forms.Button();
            this.btnLogView = new System.Windows.Forms.Button();
            this.btnControlView = new System.Windows.Forms.Button();
            this.btnHomeView = new System.Windows.Forms.Button();
            this.btnConfigView = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExitMenu,
            this.aaToolStripMenuItem,
            this.btnRestart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnExitMenu.Size = new System.Drawing.Size(89, 21);
            this.btnExitMenu.Text = "退出(Ctrl+X)";
            this.btnExitMenu.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // btnRestart
            // 
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.btnRestart.Size = new System.Drawing.Size(89, 21);
            this.btnRestart.Text = "重启(Ctrl+R)";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 128);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAboutView
            // 
            this.btnAboutView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAboutView.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutView.Image")));
            this.btnAboutView.Location = new System.Drawing.Point(830, 35);
            this.btnAboutView.Name = "btnAboutView";
            this.btnAboutView.Size = new System.Drawing.Size(108, 108);
            this.btnAboutView.TabIndex = 30;
            this.btnAboutView.Text = "关于我们";
            this.btnAboutView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAboutView.UseVisualStyleBackColor = true;
            this.btnAboutView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnHelpView
            // 
            this.btnHelpView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelpView.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpView.Image")));
            this.btnHelpView.Location = new System.Drawing.Point(680, 35);
            this.btnHelpView.Name = "btnHelpView";
            this.btnHelpView.Size = new System.Drawing.Size(108, 108);
            this.btnHelpView.TabIndex = 30;
            this.btnHelpView.Text = "帮助说明";
            this.btnHelpView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelpView.UseVisualStyleBackColor = true;
            this.btnHelpView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLogView
            // 
            this.btnLogView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogView.Image = ((System.Drawing.Image)(resources.GetObject("btnLogView.Image")));
            this.btnLogView.Location = new System.Drawing.Point(530, 35);
            this.btnLogView.Name = "btnLogView";
            this.btnLogView.Size = new System.Drawing.Size(108, 108);
            this.btnLogView.TabIndex = 30;
            this.btnLogView.Text = "运行记录";
            this.btnLogView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogView.UseVisualStyleBackColor = true;
            this.btnLogView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnControlView
            // 
            this.btnControlView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnControlView.Image = ((System.Drawing.Image)(resources.GetObject("btnControlView.Image")));
            this.btnControlView.Location = new System.Drawing.Point(230, 35);
            this.btnControlView.Name = "btnControlView";
            this.btnControlView.Size = new System.Drawing.Size(108, 108);
            this.btnControlView.TabIndex = 30;
            this.btnControlView.Text = "控制面板";
            this.btnControlView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlView.UseVisualStyleBackColor = true;
            this.btnControlView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnHomeView
            // 
            this.btnHomeView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHomeView.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeView.Image")));
            this.btnHomeView.Location = new System.Drawing.Point(80, 35);
            this.btnHomeView.Name = "btnHomeView";
            this.btnHomeView.Size = new System.Drawing.Size(108, 108);
            this.btnHomeView.TabIndex = 30;
            this.btnHomeView.Text = "程序首页";
            this.btnHomeView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomeView.UseVisualStyleBackColor = true;
            this.btnHomeView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnConfigView
            // 
            this.btnConfigView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfigView.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigView.Image")));
            this.btnConfigView.Location = new System.Drawing.Point(380, 35);
            this.btnConfigView.Name = "btnConfigView";
            this.btnConfigView.Size = new System.Drawing.Size(108, 108);
            this.btnConfigView.TabIndex = 30;
            this.btnConfigView.Text = "参数配置";
            this.btnConfigView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfigView.UseVisualStyleBackColor = true;
            this.btnConfigView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAboutView);
            this.Controls.Add(this.btnHelpView);
            this.Controls.Add(this.btnLogView);
            this.Controls.Add(this.btnControlView);
            this.Controls.Add(this.btnHomeView);
            this.Controls.Add(this.btnConfigView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StandardMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExitMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnConfigView;
        private System.Windows.Forms.Button btnLogView;
        private System.Windows.Forms.Button btnHelpView;
        private System.Windows.Forms.Button btnAboutView;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRestart;
        protected System.Windows.Forms.Button btnControlView;
        protected System.Windows.Forms.Button btnHomeView;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
