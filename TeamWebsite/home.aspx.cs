using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamWebsite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            YF.Model.User user = new YF.Model.User();
            string dark;
            dark = Request.QueryString["qlmdkjkjkjfhfsmneiecnmdsqjeinfncs"];
            user.Username = YF.BLL.User.dtom(dark);
            YF.Model.applicant applicant = new YF.Model.applicant();
            applicant.Number = int.Parse(user.Username.ToString());
            info_number.Text = applicant.Number.ToString();
            if (YF.BLL.User.verify(user) == true)
            {
                //管理员按钮显示
                admin_button.Style.Add("display", "block");
            }
            else
            {
                if (YF.BLL.User.Sizer(user) == true)
                {
                    if (YF.BLL.applicant.Search(applicant.Number) == true)
                    {
                        //有资格但未报名者，显示信息填写控件和提交信息按钮
                        info.Style.Add("display", "block");
                        bm_submit.Style.Add("display", "block");
                    }
                    else
                    {
                        tongzhi.Style.Add("display", "block");
                        look_button.Style.Add("display", "block");
                    }
                }
                else
                {
                    //报名控件全部隐藏，显示“您不是电气工程学院2021级学生，无法报名！”
                    tishi.Style.Add("display", "block");
                }
            }
        }
        /// <summary>
        /// 提交报名者信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Bm_submit_Click(object sender, EventArgs e)
        {   
          try
            {
                YF.Model.applicant applicant = new YF.Model.applicant();
                applicant.Number = int.Parse(info_number.Text.ToString());
                applicant.Yourname = info_name.Text.ToString();
                applicant.Sex = info_sex.Text.ToString();
                applicant.Mobile = info_mobile.Text.ToString();
                applicant.Majorclass = info_majorclass.Text.ToString();
                applicant.Address = info_address.Text.ToString();
                applicant.Math = int.Parse(info_math.Text.ToString());
                applicant.English = int.Parse(info_english.Text.ToString());
                applicant.Chinese = int.Parse(info_chinese.Text.ToString());
                applicant.Physics = int.Parse(info_physics.Text.ToString());
                if (info_two.Text == "")
                {
                    applicant.Two = 0;
                }
                else { applicant.Two = int.Parse(info_two.Text.ToString()); }
                applicant.Total = applicant.Math + applicant.Physics + applicant.English + applicant.Chinese+applicant.Two;
                applicant.Type = 0;
                string dark;
                dark = YF.BLL.User.dtom(Request.QueryString["qlmdkjkjkjfhfsmneiecnmdsqjeinfncs"]);
                if (applicant.Number == int.Parse(dark))
                {
                    if (YF.BLL.applicant.add(applicant) == true)
                    {
                        //显示用户信息，信息控件冻结，修改信息按钮显示
                        string s_url = "Home.aspx?qlmdkjkjkjfhfsmneiecnmdsqjeinfncs=" + YF.BLL.User.mtod(dark); ;
                        Response.Redirect(s_url);
                        YF.JsHelper.AlertAndRedirect("报名成功，请等待笔试通知", "home.aspx");
                    }
                    else
                    {
                        YF.JsHelper.Alert("报名失败，请联系招新群管理员");
                    }
                }
                else
                {
                    YF.JsHelper.Alert("请用自己注册用的学号进行报名！");
                }
            }
            catch
            {
                YF.JsHelper.Alert("请正确填写信息！");
            }
        }
        /// <summary>
        /// 点击查看报名者信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Look_button_Click(object sender, EventArgs e)
        {
            string dark;
            dark = Request.QueryString["qlmdkjkjkjfhfsmneiecnmdsqjeinfncs"];

            YF.Model.applicant applicant = new YF.Model.applicant();
            applicant.Number = int.Parse(YF.BLL.User.dtom(dark));
            info_number.Text = applicant.Number.ToString();

            //已报名者，显示信息控件（只读）和修改信息键
            info_number.Text = YF.BLL.applicant.show(applicant.Number)[0];
            info_number.Enabled = false;
            info_name.Text = YF.BLL.applicant.show(applicant.Number)[1];
            info_name.Enabled = false;
            info_sex.Text = YF.BLL.applicant.show(applicant.Number)[2];
            info_sex.Enabled = false;
            info_mobile.Text = YF.BLL.applicant.show(applicant.Number)[3];
            info_mobile.Enabled = false;
            info_majorclass.Text = YF.BLL.applicant.show(applicant.Number)[4];
            info_majorclass.Enabled = false;
            info_address.Text = YF.BLL.applicant.show(applicant.Number)[5];
            info_address.Enabled = false;
            info_math.Text = YF.BLL.applicant.show(applicant.Number)[6];
            info_math.Enabled = false;
            info_chinese.Text = YF.BLL.applicant.show(applicant.Number)[7];
            info_chinese.Enabled = false;
            info_english.Text = YF.BLL.applicant.show(applicant.Number)[8];
            info_english.Enabled = false;
            info_physics.Text = YF.BLL.applicant.show(applicant.Number)[9];
            info_physics.Enabled = false;
            info_two.Text = YF.BLL.applicant.show(applicant.Number)[10];
            info_two.Enabled = false;
            tongzhi.Style.Add("display", "none");
            look_button.Style.Add("display", "none");
            info.Style.Add("display", "block");
            amend_button.Style.Add("display", "block");
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Amend_button_Click(object sender, EventArgs e)
        {
            info_number.Enabled = true;
            info_number.ReadOnly = true;
            info_name.Enabled = true;
            info_sex.Enabled = true;
            info_mobile.Enabled = true;
            info_majorclass.Enabled = true;
            info_address.Enabled = true;
            info_math.Enabled = true;
            info_physics.Enabled = true;
            info_english.Enabled = true;
            info_chinese.Enabled = true; 
            info_two.Enabled = true;
            tongzhi.Style.Add("display", "none");
            look_button.Style.Add("display", "none");
            amend_button.Style.Add("display", "none");

            affirm_button.Style.Add("display", "block");
        }

        /// <summary>
        /// 确认修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Affirm_button_Click(object sender, EventArgs e)
        {
            YF.Model.applicant applicant = new YF.Model.applicant();
            applicant.Number = int.Parse(info_number.Text.ToString());
            applicant.Yourname = info_name.Text.ToString();
            applicant.Sex = info_sex.Text.ToString();
            applicant.Mobile = info_mobile.Text.ToString();
            applicant.Majorclass = info_majorclass.Text.ToString();
            applicant.Address = info_address.Text.ToString();
            applicant.Math = int.Parse(info_math.Text.ToString());
            applicant.Physics = int.Parse(info_physics.Text.ToString());
            applicant.English = int.Parse(info_english.Text.ToString());
            applicant.Chinese = int.Parse(info_chinese.Text.ToString());
  
            if (info_two.Text.ToString() == "")
            {
                applicant.Two = 0;
            }
            else { applicant.Two = int.Parse(info_two.Text.ToString()); }
            applicant.Total = applicant.Math + applicant.Physics + applicant.English + applicant.Chinese + applicant.Two;
            applicant.Type = 0;

            if (YF.BLL.applicant.amend(applicant))
            {
                YF.JsHelper.Alert("修改成功!请刷新界面");
                affirm_button.Style.Add("display", "none");
                info.Style.Add("display", "none");
            }
        }

        /// <summary>
        /// 管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Admin_button_Click(object sender, EventArgs e)
        {
            YF.JsHelper.Redirect("admin.aspx");
        }
    }
}