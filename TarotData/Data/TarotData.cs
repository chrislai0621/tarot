using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TarotData.Entity;
namespace TarotData.Data
{
    public class TarotData
    {
        /// <summary>
        /// 取得各角色分析
        /// </summary>
        /// <returns></returns>
        public List<RoleEntity> GetRoleAllData()
        {

            List<RoleEntity> ListRole = new List<RoleEntity>();
            RoleEntity R0 = new RoleEntity()
            {
                No = 0,
                RoleName = "愚者",
                Defect = "容易相信別人，易受騙",
                Merit = "憨厚耿直，誠墾踏實",
                PicAndAction = "屁股朝外：不設防。貓：犯小人，易受抓弄。枯萎的花：防護力弱。包袱：喜歡外出或旅遊。手杖向後：不擅利用人事物。"
            };
            ListRole.Add(R0);
            RoleEntity R1 = new RoleEntity()
            {
                No = 1,
                RoleName = "魔術師",
                Defect = "情緒波動大，易善變",
                Merit = "喜歡變化，活潑外向",
                PicAndAction = "左手指揮棒：善變。桌上的道具：喜歡多彩多姿。旺盛的花：活力十足"
            };
            ListRole.Add(R1);
            RoleEntity R2 = new RoleEntity()
            {
                No = 2,
                RoleName = "女教宗(祭司)",
                Defect = "完全主義，脆弱，易優鬱及壓抑",
                Merit = "氣質脫俗，重精神生活",
                PicAndAction = "頭巾摭臉，自我保護，神秘。右手經書：善於研讀。椅下野獸：隱藏的智慧。"
            };
            ListRole.Add(R2);

            RoleEntity R3 = new RoleEntity()
            {
                No = 3,
                RoleName = "皇后",
                Defect = "征服慾強，易揮難",
                Merit = "有群眾魅力，有身分地位",
                PicAndAction = "左手權杖：掌權。翅膀：理想。白花：純潔。右手盾牌：權貴。"
            };
            ListRole.Add(R3);
            RoleEntity R4 = new RoleEntity()
            {
                No = 4,
                RoleName = "皇帝",
                Defect = "一意孤行，不易放下身段，自尊強",
                Merit = "行事果決，有領導才能",
                PicAndAction = "右手權杖：掌權。坐側面：自信，高傲 。左下角的花：元氣旺"
            };
            ListRole.Add(R4);
            RoleEntity R5 = new RoleEntity()
            {
                No = 5,
                RoleName = "男教宗",
                Defect = "愛說教，保守，厭倦世俗的競爭",
                Merit = "有謀略及口味，氣質不凡",
                PicAndAction = "左手權杖：掌權。右手手勢：下令，說教：腳下信徒：有領導能力。"
            };
            ListRole.Add(R5);
            RoleEntity R6 = new RoleEntity()
            {
                No = 6,
                RoleName = "情人",
                Defect = "心軟，易為愛著迷，感情用事",
                Merit = "溫柔體貼，善解人意",
                PicAndAction = "愛神的箭：渴望愛。左右二人：有人緣，不甘寂寞。"
            };
            ListRole.Add(R6);
            RoleEntity R7 = new RoleEntity()
            {
                No = 7,
                RoleName = "戰車",
                Defect = "率性而為，情緒強烈暴躁",
                Merit = "有衝勁，有魄力及膽識",
                PicAndAction = "右手指揮棒：有方向。戰車：冰冷強硬。黑白野獸：衝勁、血腥。"
            };
            ListRole.Add(R7);
            RoleEntity R8 = new RoleEntity()
            {
                No = 8,
                RoleName = "正義",
                Defect = "思想直接，不夠圓融且主觀",
                Merit = "個性豪邁，情義兼備",
                PicAndAction = "右手持劍：有魄力。天秤：公平，擇善固執"
            };
            ListRole.Add(R8);
            RoleEntity R9 = new RoleEntity()
            {
                No = 9,
                RoleName = "隱士",
                Defect = "不易被了解，思想過於複雜，個性壓抑",
                Merit = "有宗教緣，有智慧，深謀遠慮",
                PicAndAction = "右手提燈：夜間動物。全身披風：自我隱藏及保護。蛇：邪惡的智慧。左手手杖：擅於利用人事物"
            };
            ListRole.Add(R9);

            RoleEntity R10 = new RoleEntity()
            {
                No = 10,
                RoleName = "幸運之輪",
                Defect = "思考欠周延，物質主義者",
                Merit = "天之驕子，命帶富貴，有助力",
                PicAndAction = "右手持劍：有魄力。翅膀：理想開展。紫色及黃色野獸：守護神(貴人)。"
            };
            ListRole.Add(R10);
            RoleEntity R11 = new RoleEntity()
            {
                No = 11,
                RoleName = "堅強",
                Defect = "為別人而活，自虐，過於付出，個性壓抑",
                Merit = "凡事投入，任勞任怨",
                PicAndAction = "臉部表情：不容易快樂，默默接受。獅子口：困難"
            };
            ListRole.Add(R11);
            RoleEntity R12 = new RoleEntity()
            {
                No = 12,
                RoleName = "懸吊者",
                Defect = "個性兩極，叛逆思想較強",
                Merit = "與眾不同，舉一反三，有創意",
                PicAndAction = "頭朝下：叛逆。黃色及藍色的圓球：常遺漏物件。雙手後揹：隨興"
            };
            ListRole.Add(R12);
            RoleEntity R13 = new RoleEntity()
            {
                No = 13,
                RoleName = "死神",
                Defect = "命運波折多，思考問題過於深入",
                Merit = "洞悉問題，思想獨到",
                PicAndAction = "全身骨架：易看破，也帶漏。手握鐮刀：有殺傷力(指語言及眼神)"
            };
            ListRole.Add(R13);
            RoleEntity R14 = new RoleEntity()
            {
                No = 14,
                RoleName = "節制",
                Defect = "理想主義，安於現狀，放不開",
                Merit = "保守自制，重感情",
                PicAndAction = "翅膀：理想主義。瓶子的水：感情。枯萎的花：防護力弱"
            };
            ListRole.Add(R14);
            RoleEntity R15 = new RoleEntity()
            {
                No = 15,
                RoleName = "魔鬼",
                Defect = "慾望強烈，不滿足，棄道德",
                Merit = "人際關係通達，號召力強",
                PicAndAction = "藍色翅膀：野心擴張。右手權杖：掌權。兩隻被栓住的小野獸：喜歡駕馭或被駕馭"
            };
            ListRole.Add(R15);
            RoleEntity R16 = new RoleEntity()
            {
                No = 16,
                RoleName = "高塔",
                Defect = "易受外力傷害和干擾",
                Merit = "聰明伶俐，人緣極佳",
                PicAndAction = "塔：意志力。閃電：靈感、干擾。紅緣黃球：漏。男女：不分性別的遭遇"
            };
            ListRole.Add(R16);
            RoleEntity R17 = new RoleEntity()
            {
                No = 17,
                RoleName = "星星",
                Defect = "心思不穩定：心胸欠開闊",
                Merit = "領悟力高，靈感十足",
                PicAndAction = "星：靈感。裸女：坦誠。倒水：付出感情 。花蝴蝶：外緣佳"
            };
            ListRole.Add(R17);
            RoleEntity R18 = new RoleEntity()
            {
                No = 18,
                RoleName = "月亮",
                Defect = "為愛而活，愛幻想，易感情用事",
                Merit = "浪漫，溫柔，重感情",
                PicAndAction = "月亮：善變(陰晴圓缺)。黑白狗吠：恐懼。路：未知。比狗大的蝦蟹：重感情"
            };
            ListRole.Add(R18);
            RoleEntity R19 = new RoleEntity()
            {
                No = 19,
                RoleName = "太陽",
                Defect = "太為別人著想，熱情過度及強勢",
                Merit = "熱情博愛，有領道魅力",
                PicAndAction = "太陽：比人高，高不可攀。赤裸男女：熱情，領導能力。綠地：活力旺"
            };
            ListRole.Add(R19);
            RoleEntity R20 = new RoleEntity()
            {
                No = 20,
                RoleName = "審判(上帝)",
                Defect = "超完全主義，自我優越感強，人心難測",
                Merit = "心思細密，企圖心強",
                PicAndAction = "展翅的天使：神聖。喇叭：吹神音(說教)。三裸男女：領導，自戀"
            };
            ListRole.Add(R20);
            RoleEntity R21 = new RoleEntity()
            {
                No = 21,
                RoleName = "世界",
                Defect = "太隨心所慾，喜歡獨行天涯",
                Merit = "豁達，不拘束，心胸寬大",
                PicAndAction = "四角落的鳥獸：人緣五湖四海。女人：愛心。桂冠：被肯定(如願以償)"
            };
            ListRole.Add(R21);
            return ListRole;
        }


        /// <summary>
        /// 取得流年所有資料
        /// </summary>
        /// <returns></returns>
        public List<YearLuckEntity> GetRoleAllYearLuckData()
        {

            List<YearLuckEntity> ListRole = new List<YearLuckEntity>();

            YearLuckEntity R2 = new YearLuckEntity()
            {
                No = 2,
                RoleName = "女教宗(祭司)",
                Status = "普",
                KeyWord = "凡事低調應對即可",
                Point = "勿管閒事及投資"
            };
            ListRole.Add(R2);

            YearLuckEntity R3 = new YearLuckEntity()
            {
                No = 3,
                RoleName = "皇后",
                Status = "吉",
                KeyWord = "開財運，有貴人和名望",
                Point = "多表現自我，廣植人脈"
            };
            ListRole.Add(R3);
            YearLuckEntity R4 = new YearLuckEntity()
            {
                No = 4,
                RoleName = "皇帝",
                Status = "大吉",
                KeyWord = "升官進財俱全之數",
                Point = "全方位外交，可做重大決定"
            };
            ListRole.Add(R4);
            YearLuckEntity R5 = new YearLuckEntity()
            {
                No = 5,
                RoleName = "男教宗",
                Status = "普",
                KeyWord = "起凡入聖之數，與凡人不合",
                Point = "宜進修，自我深造，修身一年"
            };
            ListRole.Add(R5);
            YearLuckEntity R6 = new YearLuckEntity()
            {
                No = 6,
                RoleName = "情人",
                Status = "吉",
                KeyWord = "人緣及異性緣開展之數",
                Point = "審慎處理異性關係、黃金三年"
            };
            ListRole.Add(R6);
            YearLuckEntity R7 = new YearLuckEntity()
            {
                No = 7,
                RoleName = "戰車",
                Status = "吉/凶",
                KeyWord = "積極魄力，凡事可成",
                Point = "個人人身安全宜防犯(血光)，黃金三年"
            };
            ListRole.Add(R7);
            YearLuckEntity R8 = new YearLuckEntity()
            {
                No = 8,
                RoleName = "正義",
                Status = "吉",
                KeyWord = "積極魄力，凡事可成",
                Point = "不宜偷懶休閒或渡假，黃金三年"
            };
            ListRole.Add(R8);
            YearLuckEntity R9 = new YearLuckEntity()
            {
                No = 9,
                RoleName = "隱士",
                Status = "兇",
                KeyWord = "有形或無形風險增高(陰煞)卡陰",
                Point = "宜少外出，深層進修"
            };
            ListRole.Add(R9);

            YearLuckEntity R10 = new YearLuckEntity()
            {
                No = 10,
                RoleName = "幸運之輪",
                Status = "大吉",
                KeyWord = "萬事皆宜，財喜獲得",
                Point = "適時回饋社會。"
            };
            ListRole.Add(R10);
            YearLuckEntity R11 = new YearLuckEntity()
            {
                No = 11,
                RoleName = "堅強",
                Status = "凶",
                KeyWord = "工作與付出較往年艱辛",
                Point = "激勵自我，接受磨練"
            };
            ListRole.Add(R11);
            YearLuckEntity R12 = new YearLuckEntity()
            {
                No = 12,
                RoleName = "懸吊者",
                Status = "吉/凶",
                KeyWord = "與本性號碼性質相反來做反析解讀，人生之中轉淚點",
                Point = ""
            };
            ListRole.Add(R12);
            YearLuckEntity R13 = new YearLuckEntity()
            {
                No = 13,
                RoleName = "死神",
                Status = "凶",
                KeyWord = "領悟力強，易看破人生",
                Point = "可往宗教哲學方面深入進修，開智慧"
            };
            ListRole.Add(R13);
            YearLuckEntity R14 = new YearLuckEntity()
            {
                No = 14,
                RoleName = "節制",
                Status = "普",
                KeyWord = "保持現狀即可",
                Point = "宜養精蓄銳"
            };
            ListRole.Add(R14);
            YearLuckEntity R15 = new YearLuckEntity()
            {
                No = 15,
                RoleName = "魔鬼",
                Status = "凶",
                KeyWord = "全力拓展生活層次，脫胎換骨",
                Point = "可嚐試改造自我，勇於冒險"
            };
            ListRole.Add(R15);
            YearLuckEntity R16 = new YearLuckEntity()
            {
                No = 16,
                RoleName = "高塔",
                Status = "大兇",
                KeyWord = "外力傷害頻率增加",
                Point = "嚴禁外出遊山玩水"
            };
            ListRole.Add(R16);
            YearLuckEntity R17 = new YearLuckEntity()
            {
                No = 17,
                RoleName = "星星",
                Status = "普",
                KeyWord = "正常生活",
                Point = "隨遇而安"
            };
            ListRole.Add(R17);
            YearLuckEntity R18 = new YearLuckEntity()
            {
                No = 18,
                RoleName = "月亮",
                Status = "普",
                KeyWord = "正常生活",
                Point = "隨遇而安"
            };
            ListRole.Add(R18);
            YearLuckEntity R19 = new YearLuckEntity()
            {
                No = 19,
                RoleName = "太陽",
                Status = "吉",
                KeyWord = "多從事公益，好運不斷",
                Point = "想做什麼，就做什麼"
            };
            ListRole.Add(R19);
            YearLuckEntity R20 = new YearLuckEntity()
            {
                No = 20,
                RoleName = "審判(上帝)",
                Status = "吉",
                KeyWord = "處理任何事情，速審速決",
                Point = "可做任何重大決定"
            };
            ListRole.Add(R20);
            YearLuckEntity R21 = new YearLuckEntity()
            {
                No = 21,
                RoleName = "世界",
                Status = "吉",
                KeyWord = "外出旅遊，心境更廣",
                Point = "多參加各種聯誼活動"
            };
            ListRole.Add(R21);
            return ListRole;
        }
    }
}
