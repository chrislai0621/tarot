using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TarotData.Entity
{
    /// <summary>
    /// 流年運勢entity
    /// </summary>
    public class YearLuckEntity
    {
        /// <summary>
        /// 號碼
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 名稱
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 流年吉凶
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 關鍵語
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// 深度指引
        /// </summary>
        public string Point { get; set; }
    }
}
