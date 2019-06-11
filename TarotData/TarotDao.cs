using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TarotData.Entity;
using TarotData.Data;
namespace TarotData
{
    public class TarotDao
    {
        /// <summary>
        /// 抓角色資料
        /// </summary>
        /// <param name="dtBD">出生年月日</param>
        /// <param name="Year">流年年份</param>
        /// <returns></returns>
        public Role GetRoleData(DateTime dtBD, int Year)
        {
            RoleNo RN = GetDate(dtBD, Year);
            Role R = new Role();
            R.External = GetRole(RN.intExternal);
            R.Inherent = GetRole(RN.intInherent);
            R.RealNature = GetRole(RN.intRealNature);
            R.Other = GetRole(RN.intOther);
            R.YearLuck = GetYearLuck(RN.intYearLuck);
            return R;
        }

        /// <summary>
        /// 取各性格數字
        /// </summary>
        /// <param name="dtBD">出生日</param>
        /// <param name="Year">流年年份</param>
        /// <returns></returns>
        public RoleNo GetDate(DateTime dtBD, int Year)
        {

            string Date = dtBD.ToString("yyyyMMdd");
            string YearDate = (Year + dtBD.Month + dtBD.Day).ToString();//流年
            int RealNature = 0;//本性
            int Inherent = 0;//外在
            int External = 0;//內在
            int Other = dtBD.Day;//其他
            int YearLuck = 0;//流年
            string Mix = (dtBD.Year + dtBD.Month + dtBD.Day).ToString();
            int intMix = 0;
            for (int i = 2; i < dtBD.Year.ToString().Length; i++)
            {
                RealNature += Convert.ToInt16(dtBD.Year.ToString().Substring(i, 1));
            }
            for (int i = 0; i < Mix.Length; i++)
            {
                intMix += Convert.ToInt16(Mix.Substring(i, 1));
            }
            if (intMix >= 22)
            {
                Inherent = intMix - 22;
                External = (intMix / 10) + (intMix % 10);
            }
            else
            {
                Inherent = intMix;
                External = intMix;
            }
            if (Other >= 22)
            {
                Other = (Other / 10) + (Other % 10);
            }
            for (int i = 0; i < YearDate.Length; i++)//流年
            {
                YearLuck += Convert.ToInt16(YearDate.Substring(i, 1));
            }

            RoleNo RN = new RoleNo() { intRealNature = RealNature, intExternal = External, intInherent = Inherent, intOther = Other, intYearLuck = YearLuck };
            return RN;

        }
        /// <summary>
        /// 取角色介紹
        /// </summary>
        /// <param name="RoleNo">角色編號</param>
        /// <returns></returns>
        public RoleEntity GetRole(int RoleNo)
        {

            List<RoleEntity> AllRole = new TarotData.Data.TarotData().GetRoleAllData();
            List<RoleEntity> Ro = (from RoleEntity r in AllRole
                                   where r.No == RoleNo
                                   select r).ToList();
            return Ro[0];

        }
        /// <summary>
        /// 取流年運勢介紹
        /// </summary>
        /// <param name="RoleNo">角色編號</param>
        /// <returns></returns>
        public YearLuckEntity GetYearLuck(int RoleNo)
        {

            List<YearLuckEntity> AllYearLuck = new TarotData.Data.TarotData().GetRoleAllYearLuckData();
            List<YearLuckEntity> YL = (from YearLuckEntity r in AllYearLuck
                                       where r.No == RoleNo
                                       select r).ToList();
            return YL[0];

        }
    }
}