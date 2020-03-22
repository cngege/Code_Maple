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
using System.IO;

namespace 枫
{
    public partial class PlayerMenu : Form
    {
        public String ApiUrl = "https://anime-music.jijidown.com/api/v2/music";
        public String Mp3;

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
                Mp3 = (String)data["res"]["play_url"];
                Player(Mp3);

                //标题信息
                Title.Text = (String)data["res"]["anime_info"]["title"];


            }
        }








        private JObject GetUrl(String url = "https://anime-music.jijidown.com/api/v2/music")
        {
            Get data = new Get(url);
            data.data = "recommend=true";
            return JSON.Parse(data.Getdata());
        }

        private void Player(String _Mp3)
        {

        }





















        private void btn_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
