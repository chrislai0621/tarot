using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TarotData.Entity;
namespace TarotData.Entity
{
   public  class Role
    {
       /// <summary>
       /// 本性
       /// </summary>
       public  RoleEntity RealNature{get;set;}

       /// <summary>
       /// 內在
       /// </summary>
       public RoleEntity Inherent { get; set; }

       /// <summary>
       /// 外在
       /// </summary>
       public RoleEntity External { get; set; }

       /// <summary>
       /// 其他
       /// </summary>
       public RoleEntity Other { get; set; }

       /// <summary>
       /// 流年運勢
       /// </summary>
       public YearLuckEntity YearLuck { get; set; }

    }

}
