using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TarotData.Entity
{
   public  class RoleEntity
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 名稱
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 缺點
        /// </summary>
        public string Defect { get; set; }
        /// <summary>
        /// 優點
        /// </summary>
        public string Merit { get; set; }
        /// <summary>
        /// 圖案及動作內函
        /// </summary>
        public string PicAndAction { get; set; }
    }
}
