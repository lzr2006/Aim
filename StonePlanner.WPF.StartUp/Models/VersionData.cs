using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner.WPF.StartUp.Models
{
    /// <summary>
    /// 封装版本数据
    /// </summary>
    public class VersionData
    {
        public string? VersionName { get; set; }
        public Uri? DownloadUri { get; set; }
        public VersionType VersionType { get; set; }
    }
    /// <summary>
    /// 版本的类型枚举
    /// </summary>
    public enum VersionType
    {
        Origin,
        Alpha,
        Beta,
        Epsilon
    }
}
