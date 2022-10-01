using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamWebsite
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Dl_submit_Click(object sender, EventArgs e)
        {
            YF.Model.User user = new YF.Model.User();
            user.Username = Request.Form["dl_username"].ToString();
            user.Password = Request.Form["dl_password"].ToString();

            if (YF.BLL.User.login(user.Username, user.Password) == true)
            {
                string s_url,dark;
                dark = YF.BLL.User.mtod(user.Username);
                s_url = "home.aspx?qlmdkjkjkjfhfsmneiecnmdsqjeinfncs=" + dark;
                Response.Redirect(s_url);

                YF.JsHelper.AlertAndRedirect("登录成功", "home.aspx");
            }
            else
            {
                YF.JsHelper.Alert("账号或密码错误！");
            }
        }

        protected void Zc_submit_Click(object sender, EventArgs e)
        {
            YF.Model.User user = new YF.Model.User();
            user.Username = Request.Form["zc_number"];
            user.Email = Request.Form["zc_email"];
            user.Password = Request.Form["zc_password"];
            user.State = 1;
            user.Adddate = DateTime.Now;
            string zc_password = Request.Form["zc_password1"];
            if(zc_password != ""|| user.Password != "")
            {
                if (zc_password == user.Password)
                {
                    if (YF.BLL.User.search(user.Username) == true)
                    {
                        if (YF.BLL.User.add(user) == true)
                        {
                            string s_url, dark;
                            dark = YF.BLL.User.mtod(user.Username);
                            s_url = "home.aspx?qlmdkjkjkjfhfsmneiecnmdsqjeinfncs=" + dark;
                            Response.Redirect(s_url);

                            YF.JsHelper.AlertAndRedirect("注册成功,已为您自动登录", "home.aspx");
                        }
                        else
                        {
                            YF.JsHelper.Alert("注册失败，请咨询招新群管理员!");
                        }
                    }
                    else
                    {
                        YF.JsHelper.Alert("该学号已被注册!");
                    }
                }
                else
                {
                    YF.JsHelper.Alert("两次输入的密码不一致！");
                }
            }
            else
            {
                YF.JsHelper.Alert("请输入密码！");
            }
        }
    }
}