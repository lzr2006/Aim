using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class WeatherForecast : UserControl
    {
        public WeatherForecast()
        {
            InitializeComponent();
        }

        internal WFJsonStructure.DataItem weather;
        private async void WeatherForecast_Load(object sender, EventArgs e)
        {
            //害 没想到吧 我连参数都懒得写
            //请求天气API
            HttpClient client = new HttpClient();
            //发送Get请求
            var resultjson = await client.GetStringAsync("https://v0.yiketianqi.com/api?unescape=1&version=v91&appid=43656176&appsecret=I42og6Lm&ext=&cityid=&city=");
            //接下来暴力解析
            JavaScriptSerializer js = new JavaScriptSerializer();//实例化一个能够序列化数据的类
            WFJsonStructure.Root list =null;
            try
            {
                list = js.Deserialize<WFJsonStructure.Root>(resultjson); //将json数据转化为对象类型并赋值给list
            }
            catch 
            {
                //Not Support WeatherForecast (x)
                //Developer Should be Fucked  (√)
                Main.AddSign(9);
                return;
            }
            label_Capital.Text = $"{list.city}市·天气预报";
            weather = list.data[0]; //提取今日天气
            DateTime dateTime = new DateTime(Convert.ToInt32(weather.date.Split('-')[0]),
                                             Convert.ToInt32(weather.date.Split('-')[1]), 
                                             Convert.ToInt32(weather.date.Split('-')[2])
                                            );
            label_Date.Text = $"{dateTime.ToString("yyyy年 MM月 dd日 ddd").Replace(" ","")}";
            #region 过一阵子要用的代码
            //判断：白天or晚上 9种天气：xue、lei、shachen、wu、bingbao、yun、yu、yin、qing
            string weatherPict;
            //if (Convert.ToInt32(DateTime.Now.ToString("HH")) <= 19 && Convert.ToInt32(DateTime.Now.ToString("HH")) >= 7)
            //{
            //    weatherPict = weather.wea_day_img;
            //    path = weatherPict switch
            //    {
            //        "xue" => "m_snow",
            //        "lei" => "m_thunder",
            //        "shachen" => "m_sanddust",
            //        "wu" => "m_frog",
            //        "bingbao" => "m_hail",
            //        "yun" => "m_cloudy",
            //        "yu" => "m_rainy",
            //        "yin" => "m_overcast",
            //        "qing" => "m_sunny",
            //        _ => throw new Exceptions.WeatherNotExistException()
            //    };
            //}
            //else
            //{
            //    weatherPict = weather.wea_night_img;
            //    path = weatherPict switch
            //    {
            //        "xue" => "n_snow",
            //        "lei" => "n_thunder",
            //        "shachen" => "n_sanddust",
            //        "wu" => "n_frog",
            //        "bingbao" => "n_hail",
            //        "yun" => "n_cloudy",
            //        "yu" => "n_rainy",
            //        "yin" => "n_overcast",
            //        "qing" => "n_sunny",
            //        _ => throw new Exceptions.WeatherNotExistException()
            //    };
            //}
            //string temp = path;
            //path = $@"{Application.StartupPath}\icon\wea\{temp}.png";
            //pictureBox_Wea.BackgroundImage = Image.FromFile(path);
            #endregion
            if (Convert.ToInt32(DateTime.Now.ToString("HH")) <= 19 && Convert.ToInt32(DateTime.Now.ToString("HH")) >= 7)
            {
                weatherPict = weather.wea_day_img;
                label_WeStatus.Text = weatherPict switch
                {
                    "xue" => "雪",
                    "lei" => "雷",
                    "shachen" => "沙",
                    "wu" => "雾",
                    "bingbao" => "雹",
                    "yun" => "云",
                    "yu" => "雨",
                    "yin" => "阴",
                    "qing" => "晴",
                    _ => throw new Exceptions.WeatherNotExistException()
                };
            }
            else
            {
                weatherPict = weather.wea_night_img;
                label_WeStatus.Text = weatherPict switch
                {
                    "xue" => "雪",
                    "lei" => "雷",
                    "shachen" => "沙",
                    "wu" => "雾",
                    "bingbao" => "雹",
                    "yun" => "云",
                    "yu" => "雨",
                    "yin" => "阴",
                    "qing" => "晴",
                    _ => throw new Exceptions.WeatherNotExistException()
                };
            }
            //具体天气
            label_WeaDetails.Text = weather.wea.Length switch 
            {
                1 => $"  {weather.wea}",
                2 => $" {weather.wea}",
                3 => $"{weather.wea}",
                4 => $"{weather.wea}",
                5 => $"{weather.wea}",
                _ => throw new Exceptions.WeatherNotExistException()
            };
            //温度显示
            label_Tem.Text = (weather.tem1.Length / weather.tem2.Length) switch 
            {
                <1 => $" {weather.tem1}℃/{weather.tem2}℃",
                1 => $"{weather.tem1}℃/{weather.tem2}℃",
                >1 => $"{weather.tem1}℃/ {weather.tem2}℃"
            };if (weather.tem1.Length == 1 && weather.tem2.Length == 1)  label_Tem.Text = $"{weather.tem1}℃ / {weather.tem2}℃";
            label_Humidity.Text = $"湿度：{weather.humidity}";
            label_Visibility.Text = $"能见度：{weather.visibility.Replace("km","KM").Replace("0", "∞")}";
            label_Pressure.Text = $@"气压：{weather.pressure.Length switch
            {
                3 => $" {weather.pressure}",
                4 => $"{weather.pressure}",
                _ => throw new Exceptions.PressureShouldNotExistException()
            } + "Kpa"}";
            label_Winspeed.Text = $"风级：{weather.win_speed}";
            label_Air.Text = $"空气质量：{weather.air}";
            label_AirLevel.Text = $"级别：{weather.air_level}";
        }

        private void WeatherForecast_Paint(object sender, PaintEventArgs e)
        {
            TaskDetails.Type(this, 15, 0.2);
        }

        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer($@"{Application.StartupPath}\icon\Click.wav");
            sp.Play();
            DestroyHandle();
        }

        internal void GetWInfo(out WFJsonStructure.DataItem weather) { weather = this.weather; }
    }
}
