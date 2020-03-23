namespace 枫
{
    partial class PlayerMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenu));
            this.Tip = new System.Windows.Forms.Timer(this.components);
            this.BackImage = new System.Windows.Forms.Panel();
            this.PlayerUI = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.playspeed = new System.Windows.Forms.ProgressBar();
            this.img_forware = new System.Windows.Forms.PictureBox();
            this.img_play = new System.Windows.Forms.PictureBox();
            this.Title_Menu = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.DownProgress = new System.Windows.Forms.Label();
            this.Desc_Label = new System.Windows.Forms.Label();
            this.BackImage.SuspendLayout();
            this.PlayerUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_forware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_play)).BeginInit();
            this.Title_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackImage
            // 
            this.BackImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.BackImage.Controls.Add(this.Desc_Label);
            this.BackImage.Controls.Add(this.Title_Menu);
            this.BackImage.Controls.Add(this.PlayerUI);
            this.BackImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackImage.Location = new System.Drawing.Point(0, 0);
            this.BackImage.Name = "BackImage";
            this.BackImage.Size = new System.Drawing.Size(687, 154);
            this.BackImage.TabIndex = 0;
            // 
            // PlayerUI
            // 
            this.PlayerUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerUI.Controls.Add(this.Title);
            this.PlayerUI.Controls.Add(this.playspeed);
            this.PlayerUI.Controls.Add(this.img_forware);
            this.PlayerUI.Controls.Add(this.img_play);
            this.PlayerUI.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerUI.Location = new System.Drawing.Point(0, 0);
            this.PlayerUI.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerUI.Name = "PlayerUI";
            this.PlayerUI.Size = new System.Drawing.Size(313, 154);
            this.PlayerUI.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(5, 110);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(303, 34);
            this.Title.TabIndex = 3;
            this.Title.Text = "貔貅I勿念";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playspeed
            // 
            this.playspeed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playspeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playspeed.ForeColor = System.Drawing.Color.White;
            this.playspeed.Location = new System.Drawing.Point(0, 147);
            this.playspeed.Margin = new System.Windows.Forms.Padding(0);
            this.playspeed.Name = "playspeed";
            this.playspeed.Size = new System.Drawing.Size(311, 5);
            this.playspeed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playspeed.TabIndex = 2;
            // 
            // img_forware
            // 
            this.img_forware.BackColor = System.Drawing.Color.Transparent;
            this.img_forware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_forware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_forware.Image = global::枫.Properties.Resources.fast_forward;
            this.img_forware.Location = new System.Drawing.Point(69, 62);
            this.img_forware.Name = "img_forware";
            this.img_forware.Size = new System.Drawing.Size(40, 40);
            this.img_forware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_forware.TabIndex = 1;
            this.img_forware.TabStop = false;
            this.img_forware.Click += new System.EventHandler(this.img_forware_Click);
            // 
            // img_play
            // 
            this.img_play.BackColor = System.Drawing.Color.Transparent;
            this.img_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_play.Image = ((System.Drawing.Image)(resources.GetObject("img_play.Image")));
            this.img_play.Location = new System.Drawing.Point(11, 52);
            this.img_play.Name = "img_play";
            this.img_play.Size = new System.Drawing.Size(50, 50);
            this.img_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_play.TabIndex = 0;
            this.img_play.TabStop = false;
            // 
            // Title_Menu
            // 
            this.Title_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.Title_Menu.Controls.Add(this.DownProgress);
            this.Title_Menu.Controls.Add(this.Info);
            this.Title_Menu.Controls.Add(this.Down);
            this.Title_Menu.Controls.Add(this.btn_exit);
            this.Title_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Menu.Location = new System.Drawing.Point(313, 0);
            this.Title_Menu.Name = "Title_Menu";
            this.Title_Menu.Size = new System.Drawing.Size(374, 30);
            this.Title_Menu.TabIndex = 2;
            this.Title_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_Menu_MouseDown);
            this.Title_Menu.MouseLeave += new System.EventHandler(this.Title_Menu_MouseLeave);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.BackgroundImage = global::枫.Properties.Resources.info;
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Info.FlatAppearance.BorderSize = 0;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Location = new System.Drawing.Point(312, 8);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(15, 15);
            this.Info.TabIndex = 2;
            this.Info.UseVisualStyleBackColor = true;
            // 
            // Down
            // 
            this.Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Down.BackgroundImage = global::枫.Properties.Resources.Download;
            this.Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Down.FlatAppearance.BorderSize = 0;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down.Location = new System.Drawing.Point(274, 8);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(15, 15);
            this.Down.TabIndex = 3;
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = global::枫.Properties.Resources.AppExit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(349, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(15, 15);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_exit_MouseClick);
            // 
            // DownProgress
            // 
            this.DownProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownProgress.BackColor = System.Drawing.Color.Transparent;
            this.DownProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.DownProgress.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownProgress.ForeColor = System.Drawing.Color.White;
            this.DownProgress.Location = new System.Drawing.Point(209, 0);
            this.DownProgress.Name = "DownProgress";
            this.DownProgress.Size = new System.Drawing.Size(59, 30);
            this.DownProgress.TabIndex = 5;
            this.DownProgress.Text = "OK";
            this.DownProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Desc_Label
            // 
            this.Desc_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desc_Label.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Desc_Label.ForeColor = System.Drawing.Color.White;
            this.Desc_Label.Location = new System.Drawing.Point(313, 30);
            this.Desc_Label.Name = "Desc_Label";
            this.Desc_Label.Size = new System.Drawing.Size(374, 124);
            this.Desc_Label.TabIndex = 3;
            this.Desc_Label.Text = "Desc";
            this.Desc_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(687, 154);
            this.Controls.Add(this.BackImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "桌面随机背景音乐播放器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PlayerMenu_Load);
            this.BackImage.ResumeLayout(false);
            this.PlayerUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_forware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_play)).EndInit();
            this.Title_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Tip;
        private System.Windows.Forms.Panel BackImage;
        private System.Windows.Forms.Panel PlayerUI;
        private System.Windows.Forms.PictureBox img_play;
        private System.Windows.Forms.PictureBox img_forware;
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.ProgressBar playspeed;
        private System.Windows.Forms.Panel Title_Menu;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Label DownProgress;
        private System.Windows.Forms.Label Desc_Label;
    }
}

