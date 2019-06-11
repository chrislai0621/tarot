using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TarotData;
using TarotData.Entity;
namespace TAROT
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                for(int i = 0 ;i <=20;i++)
                {
                  string Year=DateTime.Now.AddYears(i).Year.ToString();
                  ddlYear.Items.Add(new ListItem(Year, Year));

                }
            
            }
            
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            DateTime dtDate = new DateTime();
            if (DateTime.TryParse(txtDate.Text, out dtDate))
            {
                Role R = new TarotDao().GetRoleData(dtDate, Convert.ToInt32(ddlYear.SelectedItem.Value));
                //本性
                lblRno.Text = R.RealNature.No.ToString();
                lblRName.Text = R.RealNature.RoleName;
                lblRMerit.Text = R.RealNature.Merit;
                lblRDefect.Text = R.RealNature.Defect;
                lblRPicAndAction.Text = R.RealNature.PicAndAction;
                //內在
                lblINo.Text = R.Inherent.No.ToString();
                lblIName.Text = R.Inherent.RoleName;
                lblImerit.Text = R.Inherent.Merit;
                lblIDefect.Text = R.Inherent.Defect;
                lblIPicAndAction.Text = R.Inherent.PicAndAction;

                //外在
                lblENo.Text = R.External.No.ToString();
                lblEName.Text = R.External.RoleName;
                lblEMerit.Text = R.External.Merit;
                lblEDefect.Text = R.External.Defect;
                lblEPicAndAction.Text = R.External.PicAndAction;

                //其它
                lblONo.Text = R.Other.No.ToString();
                lblOName.Text = R.Other.RoleName;
                lblOMerit.Text = R.Other.Merit;
                lblODefect.Text = R.Other.Defect;
                lblOPicAndAction.Text = R.Other.PicAndAction;

                //流年運勢
                lblYYear.Text = ddlYear.SelectedItem.Value;
                lblYNo.Text = R.YearLuck.No.ToString();
                lblYName.Text = R.YearLuck.RoleName;
                lblYStatus.Text = R.YearLuck.Status;
                lblYkeyWord.Text = R.YearLuck.KeyWord;
                lblYPoint.Text = R.YearLuck.Point;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('出生年月日格式有誤，請重新輸入')", true);
                txtDate.Text = "";
            }

        }

       
    }
}
