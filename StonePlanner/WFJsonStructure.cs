using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner
{
    internal class WFJsonStructure
    {
        public class DataItem
        {
            /// <summary>
            /// 30日（星期六）
            /// </summary>
            public string day { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string date { get; set; }
            /// <summary>
            /// 星期六
            /// </summary>
            public string week { get; set; }
            /// <summary>
            /// 小雨转多云
            /// </summary>
            public string wea { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_img { get; set; }
            /// <summary>
            /// 小雨
            /// </summary>
            public string wea_day { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_day_img { get; set; }
            /// <summary>
            /// 多云
            /// </summary>
            public string wea_night { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_night_img { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem2 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string humidity { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string visibility { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pressure { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> win { get; set; }
            /// <summary>
            /// 3-4级
            /// </summary>
            public string win_speed { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string win_meter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string sunrise { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string sunset { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string air { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string air_level { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string air_tips { get; set; }
            /// <summary>
            /// 局部多云
            /// </summary>
            public string phrase { get; set; }
            /// <summary>
            /// 少云。 最高 28ºC。 东 风 15 到 25 每 km / h 。
            /// </summary>
            public string narrative { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string moonrise { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string moonset { get; set; }
            /// <summary>
            /// 娥眉月
            /// </summary>
            public string moonPhrase { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string rain { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string uvIndex { get; set; }
            /// <summary>
            /// 很强
            /// </summary>
            public string uvDescription { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> alarm { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string cityid { get; set; }
            /// <summary>
            /// 日照
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cityEn { get; set; }
            /// <summary>
            /// 中国
            /// </summary>
            public string country { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string countryEn { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string update_time { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<DataItem> data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int nums { get; set; }
        }
    }
    internal class NewsJsonStructure 
    {
        public class NewslistItem
        {
            /// <summary>
            /// 1儿童落水亲属营救 6人溺亡
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int hotnum { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string digest { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string msg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<NewslistItem> newslist { get; set; }
        }
    }
}
