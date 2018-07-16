namespace skyline二次开发平台
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.底图切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.百度地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载shp数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加标记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钻孔模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地质体模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加建筑物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义漫游ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钻孔显示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.地下场景显示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.地上地下一体化显示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.底层显示控制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示控制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.属性控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.场景显示控制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.调整透明度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.光线属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阴影属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材质属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.场景相关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axTE3DWindow1 = new AxTerraExplorerX.AxTE3DWindow();
            this.axTEInformationWindow1 = new AxTerraExplorerX.AxTEInformationWindow();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DWindow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTEInformationWindow1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.添加标签ToolStripMenuItem,
            this.底图切换ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.添加标记ToolStripMenuItem,
            this.添加模型ToolStripMenuItem,
            this.自定义漫游ToolStripMenuItem,
            this.显示控制ToolStripMenuItem,
            this.场景相关ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(946, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // 添加标签ToolStripMenuItem
            // 
            this.添加标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字标签ToolStripMenuItem});
            this.添加标签ToolStripMenuItem.Name = "添加标签ToolStripMenuItem";
            this.添加标签ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加标签ToolStripMenuItem.Text = "添加标签";
            // 
            // 文字标签ToolStripMenuItem
            // 
            this.文字标签ToolStripMenuItem.Name = "文字标签ToolStripMenuItem";
            this.文字标签ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文字标签ToolStripMenuItem.Text = "文字标签";
            this.文字标签ToolStripMenuItem.Click += new System.EventHandler(this.文字标签ToolStripMenuItem_Click);
            // 
            // 底图切换ToolStripMenuItem
            // 
            this.底图切换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.天地图ToolStripMenuItem,
            this.百度地图ToolStripMenuItem});
            this.底图切换ToolStripMenuItem.Name = "底图切换ToolStripMenuItem";
            this.底图切换ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.底图切换ToolStripMenuItem.Text = "底图切换";
            // 
            // 天地图ToolStripMenuItem
            // 
            this.天地图ToolStripMenuItem.Name = "天地图ToolStripMenuItem";
            this.天地图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.天地图ToolStripMenuItem.Text = "天地图";
            // 
            // 百度地图ToolStripMenuItem
            // 
            this.百度地图ToolStripMenuItem.Name = "百度地图ToolStripMenuItem";
            this.百度地图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.百度地图ToolStripMenuItem.Text = "百度地图";
            this.百度地图ToolStripMenuItem.Click += new System.EventHandler(this.百度地图ToolStripMenuItem_Click);
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载shp数据ToolStripMenuItem});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据ToolStripMenuItem.Text = "数据";
            // 
            // 加载shp数据ToolStripMenuItem
            // 
            this.加载shp数据ToolStripMenuItem.Name = "加载shp数据ToolStripMenuItem";
            this.加载shp数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加载shp数据ToolStripMenuItem.Text = "加载矢量数据";
            this.加载shp数据ToolStripMenuItem.Click += new System.EventHandler(this.加载shp数据ToolStripMenuItem_Click);
            // 
            // 添加标记ToolStripMenuItem
            // 
            this.添加标记ToolStripMenuItem.Name = "添加标记ToolStripMenuItem";
            this.添加标记ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.添加标记ToolStripMenuItem.Text = "地表影像贴图";
            // 
            // 添加模型ToolStripMenuItem
            // 
            this.添加模型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.钻孔模型ToolStripMenuItem,
            this.地质体模型ToolStripMenuItem,
            this.添加建筑物ToolStripMenuItem});
            this.添加模型ToolStripMenuItem.Name = "添加模型ToolStripMenuItem";
            this.添加模型ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加模型ToolStripMenuItem.Text = "添加模型";
            // 
            // 钻孔模型ToolStripMenuItem
            // 
            this.钻孔模型ToolStripMenuItem.Name = "钻孔模型ToolStripMenuItem";
            this.钻孔模型ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.钻孔模型ToolStripMenuItem.Text = "添加钻孔模型";
            this.钻孔模型ToolStripMenuItem.Click += new System.EventHandler(this.钻孔模型ToolStripMenuItem_Click);
            // 
            // 地质体模型ToolStripMenuItem
            // 
            this.地质体模型ToolStripMenuItem.Name = "地质体模型ToolStripMenuItem";
            this.地质体模型ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.地质体模型ToolStripMenuItem.Text = "添加地质体模型";
            this.地质体模型ToolStripMenuItem.Click += new System.EventHandler(this.地质体模型ToolStripMenuItem_Click);
            // 
            // 添加建筑物ToolStripMenuItem
            // 
            this.添加建筑物ToolStripMenuItem.Name = "添加建筑物ToolStripMenuItem";
            this.添加建筑物ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加建筑物ToolStripMenuItem.Text = "添加建筑物";
            this.添加建筑物ToolStripMenuItem.Click += new System.EventHandler(this.添加建筑物ToolStripMenuItem_Click);
            // 
            // 自定义漫游ToolStripMenuItem
            // 
            this.自定义漫游ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.钻孔显示ToolStripMenuItem1,
            this.地下场景显示ToolStripMenuItem1,
            this.地上地下一体化显示ToolStripMenuItem1});
            this.自定义漫游ToolStripMenuItem.Name = "自定义漫游ToolStripMenuItem";
            this.自定义漫游ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.自定义漫游ToolStripMenuItem.Text = "影像显示";
            // 
            // 钻孔显示ToolStripMenuItem1
            // 
            this.钻孔显示ToolStripMenuItem1.Name = "钻孔显示ToolStripMenuItem1";
            this.钻孔显示ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.钻孔显示ToolStripMenuItem1.Text = "钻孔显示";
            // 
            // 地下场景显示ToolStripMenuItem1
            // 
            this.地下场景显示ToolStripMenuItem1.Name = "地下场景显示ToolStripMenuItem1";
            this.地下场景显示ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.地下场景显示ToolStripMenuItem1.Text = "地下场景显示";
            // 
            // 地上地下一体化显示ToolStripMenuItem1
            // 
            this.地上地下一体化显示ToolStripMenuItem1.Name = "地上地下一体化显示ToolStripMenuItem1";
            this.地上地下一体化显示ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.地上地下一体化显示ToolStripMenuItem1.Text = "地上地下一体化显示";
            // 
            // 显示控制ToolStripMenuItem
            // 
            this.显示控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.底层显示控制ToolStripMenuItem1,
            this.场景显示控制ToolStripMenuItem1});
            this.显示控制ToolStripMenuItem.Name = "显示控制ToolStripMenuItem";
            this.显示控制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.显示控制ToolStripMenuItem.Text = "显示控制";
            // 
            // 底层显示控制ToolStripMenuItem1
            // 
            this.底层显示控制ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示控制ToolStripMenuItem1,
            this.属性控制ToolStripMenuItem});
            this.底层显示控制ToolStripMenuItem1.Name = "底层显示控制ToolStripMenuItem1";
            this.底层显示控制ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.底层显示控制ToolStripMenuItem1.Text = "地层显示控制";
            // 
            // 显示控制ToolStripMenuItem1
            // 
            this.显示控制ToolStripMenuItem1.Name = "显示控制ToolStripMenuItem1";
            this.显示控制ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.显示控制ToolStripMenuItem1.Text = "显示控制";
            // 
            // 属性控制ToolStripMenuItem
            // 
            this.属性控制ToolStripMenuItem.Name = "属性控制ToolStripMenuItem";
            this.属性控制ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.属性控制ToolStripMenuItem.Text = "属性控制";
            // 
            // 场景显示控制ToolStripMenuItem1
            // 
            this.场景显示控制ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.调整透明度ToolStripMenuItem,
            this.光线属性ToolStripMenuItem,
            this.阴影属性ToolStripMenuItem,
            this.材质属性ToolStripMenuItem});
            this.场景显示控制ToolStripMenuItem1.Name = "场景显示控制ToolStripMenuItem1";
            this.场景显示控制ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.场景显示控制ToolStripMenuItem1.Text = "场景显示控制";
            // 
            // 调整透明度ToolStripMenuItem
            // 
            this.调整透明度ToolStripMenuItem.Name = "调整透明度ToolStripMenuItem";
            this.调整透明度ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.调整透明度ToolStripMenuItem.Text = "调整透明度";
            // 
            // 光线属性ToolStripMenuItem
            // 
            this.光线属性ToolStripMenuItem.Name = "光线属性ToolStripMenuItem";
            this.光线属性ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.光线属性ToolStripMenuItem.Text = "调整光线属性";
            // 
            // 阴影属性ToolStripMenuItem
            // 
            this.阴影属性ToolStripMenuItem.Name = "阴影属性ToolStripMenuItem";
            this.阴影属性ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.阴影属性ToolStripMenuItem.Text = "调整阴影属性";
            // 
            // 材质属性ToolStripMenuItem
            // 
            this.材质属性ToolStripMenuItem.Name = "材质属性ToolStripMenuItem";
            this.材质属性ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.材质属性ToolStripMenuItem.Text = "调整材质属性";
            // 
            // 场景相关ToolStripMenuItem
            // 
            this.场景相关ToolStripMenuItem.Name = "场景相关ToolStripMenuItem";
            this.场景相关ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.场景相关ToolStripMenuItem.Text = "场景漫游";
            // 
            // axTE3DWindow1
            // 
            this.axTE3DWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axTE3DWindow1.Enabled = true;
            this.axTE3DWindow1.Location = new System.Drawing.Point(225, 27);
            this.axTE3DWindow1.Name = "axTE3DWindow1";
            this.axTE3DWindow1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTE3DWindow1.OcxState")));
            this.axTE3DWindow1.Size = new System.Drawing.Size(721, 553);
            this.axTE3DWindow1.TabIndex = 1;
            // 
            // axTEInformationWindow1
            // 
            this.axTEInformationWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axTEInformationWindow1.Enabled = true;
            this.axTEInformationWindow1.Location = new System.Drawing.Point(0, 27);
            this.axTEInformationWindow1.Name = "axTEInformationWindow1";
            this.axTEInformationWindow1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTEInformationWindow1.OcxState")));
            this.axTEInformationWindow1.Size = new System.Drawing.Size(219, 553);
            this.axTEInformationWindow1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "经纬度显示：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(12, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 41);
            this.label2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axTEInformationWindow1);
            this.Controls.Add(this.axTE3DWindow1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyLine二次开发平台";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DWindow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTEInformationWindow1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxTerraExplorerX.AxTE3DWindow axTE3DWindow1;
        private AxTerraExplorerX.AxTEInformationWindow axTEInformationWindow1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 底图切换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加标记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义漫游ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 天地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 百度地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 钻孔模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地质体模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 钻孔显示ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 地下场景显示ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 地上地下一体化显示ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 底层显示控制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 场景显示控制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 场景相关ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示控制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 属性控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调整透明度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 光线属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阴影属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材质属性ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 文字标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加建筑物ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem 加载shp数据ToolStripMenuItem;
    }
}

