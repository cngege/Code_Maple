using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Data;
using Tools.Net;
using Tools.Formoperate;
using System.IO;

namespace 枫
{
    public partial class PlayerMenu : Form
    {
        public String ApiUrl = "https://anime-music.jijidown.com/api/v2/music";
        public String Mp3Url;
        public String Mp3Title;
        public String Desc;


        public PlayerMenu()
        {
            InitializeComponent();
        }

        private void PlayerMenu_Load(object sender, EventArgs e)
        {
            Location = new Point(0,500);
            if (!Directory.Exists(@"cache\"))
                Directory.CreateDirectory(@"cache\");
            if(!Directory.Exists(@"down\"))
                Directory.CreateDirectory(@"down\");

            





            CheckForIllegalCrossThreadCalls = false;
            ResetPlayer(false);
        }

        /// <summary>
        /// 重新设置播放器参数
        /// </summary>
        /// <param name="play">是否在设置播放器后自动播放歌曲</param>
        private void ResetPlayer(bool play = true)
        {
            JObject data = GetUrl(ApiUrl);
            if ((String)data["msg"] == "ok")
            {
                //设置背景图片
                String ImgUrl = (String)data["res"]["anime_info"]["logo"];
                string url = string.Format(ImgUrl);
                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                System.Net.WebResponse webres = webreq.GetResponse();
                using (Stream stream = webres.GetResponseStream())
                {
                    PlayerUI.BackgroundImage = Image.FromStream(stream);
                }

                //取回歌曲链接 并播放
                Mp3Url = (String)data["res"]["play_url"];
                Player(Mp3Url);

                //标题信息
                Mp3Title = (String)data["res"]["anime_info"]["title"];
                Title.Text = Mp3Title;

                //介绍信息
                Desc = (String)data["res"]["anime_info"]["desc"];
                Desc_Label.Text = Desc;
            }
        }



        private JObject GetUrl(String url = "https://anime-music.jijidown.com/api/v2/music")
        {
            try
            {
                Get data = new Get(url);
                data.data = "recommend=true";
                return JSON.Parse(data.Getdata());
            }
            catch
            {
                if( MessageBox.Show("","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetPlayer();
                }
                return JSON.Parse("{}");
            }

        }

        private void Player(String _Mp3)
        {

        }










        //退出程序
        private void btn_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        //下载当前歌曲
        private void Down_Click(object sender, EventArgs e)
        {
            if (Mp3Url != String.Empty)
            {
                Download audio = new Download(Mp3Url);
                audio.SavePath = @"down\";
                audio.SaveFile = Mp3Title.Replace(" ", "_").Replace("/", "_") + Path.GetExtension(audio.GetHttpFileName(Mp3Url));
                //audio.SaveFile = audio.GetHttpFileName(Mp3Url);
                //audio.Downprogress = (long a,long b,bool c) => { if (c) { DownProgress.Text = "OK"; } else { DownProgress.Text = Math.Floor(a*1.0 / b * 100).ToString(); }};
                audio.Downprogress = Downpro;
                audio.bt = 1024 * 200;
                audio.Start();
            }
        }

        public void Downpro(long a, long b, bool c)
        {
            if (c)
            {
                DownProgress.Text = "OK - "+ (Math.Floor(b * 1.0 / (1024*1024)*10)/10).ToString() + "Mb";
            }
            else
            {
                DownProgress.Text = (Math.Floor(a * 1.0 / b * 100)).ToString() + " - " + (Math.Floor(b * 1.0 / (1024*1024) * 10) / 10).ToString() + "Mb";
            }
        }

        //移动窗口
        private void Title_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            Forms.MoveFrom(this.Handle);
        }

        //窗口自动靠边
        private void Title_Menu_MouseLeave(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.GetBounds(this).Width;
            if (Location.X + Width / 2 < ScreenWidth / 2)
            {
                Location = new Point(0, Location.Y);
            }
            else
            {
                Location = new Point(ScreenWidth - Width, Location.Y);
            }
        }

        private void img_forware_Click(object sender, EventArgs e)
        {
            ResetPlayer(true);
        }
    }
}
