using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePlanner.StartUp.Models
{
    /// <summary>
    /// 封装版本数据
    /// </summary>
    public class VersionData
    {
        public string? VersionName;
        public Uri? DownloadUri;
        public VersionType VersionType;
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
