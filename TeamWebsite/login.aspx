<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TeamWebsite.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>登录</title>
    <link rel="stylesheet" href="Css/login.css"/>
    <script src="Js/home.js"></script>
    <link rel="shortcut icon" href="image/团队信息/1.ico"/>

</head>

<body>
    <section>
	<form runat="server" onkeydown="if(event.keyCode==13){return false;}">

        <div class="container">
            <div class="user signinBx">
                <div class="imgBx"><img src="Image/团队信息/logo.png"/></div>
                <div class="formBx">
                    <div class="form">
                        <h2>众智创新团队</h2>
                        <input type="number" name="dl_username" placeholder="学号"/>
                        <input type="password" name="dl_password" placeholder="密码"/>
                        <input type="button" class="btnbtn" name="submit" runat="server" value="登录" onserverclick="Dl_submit_Click"/>
                        <p class="signup">没有账号？<a href="#" onclick="topggleForm();">注册</a></p>
                    </div>
                </div>
            </div>
            <div class="user signupBx">
                <div class="formBx">
                    <div class="form">
                        <h2>注册</h2>
                        <input type="text" id="zc_number" title="" name="zc_number" placeholder="学号" pattern="[0-9]{9,9}" oninvalid="setCustomValidity('请输入9位数的真实学号！');" oninput="setCustomValidity('');"/>
                        <input type="email" id="zc_email" name="zc_email" placeholder="邮箱地址"  required="required" oninvalid="setCustomValidity('请填写您的邮箱')" oninput="setCustomValidity('')"/>
                        <input type="password" title="" id="zc_password" name="zc_password" placeholder="密码" pattern="^(?=).{4,10}$" oninvalid="setCustomValidity('长度在4-10之间!');" oninput="setCustomValidity('');"/>
                        <input type="password" id="zc_password1" name="zc_password1" placeholder="再次输入密码"/>
                        <input type="submit" class="btnbtn" id="zc_submit" name="zc_submit" runat="server" value="注册" onserverclick="Zc_submit_Click" usesubmitbehavior="False"/>
                        <p class="signup">已有账号？<a href="#" onclick="topggleForm();">登录</a></p>
                    </div>
                </div>
                <div class="imgBx"><img src="Image/团队信息/logo.png"/></div>
            </div>  
        </div>
       <div>
		 <div>
		 		<a target="_blank" href="http://www.beian.gov.cn/portal/registerSystemInfo?recordcode=21070202000153" style="display:inline;text-decoration:none;height:20px;line-height:20px;"><img src="Image/团队信息/备案图标 .png" style="float:left;"/><h4 style="float:left;height:20px;line-height:20px;margin: 0px 0px 0px 5px;">辽公网安备 21070202000153号</h4></a>

              <a href="http://beian.miit.gov.cn/" target="_blank"  style="display:inline-block;text-decoration:none;height:20px;line-height:20px;""><h4> &nbsp &nbsp 皖ICP备2021010200号-1</h4></a>
        </div>
            	</div>
    </form>
    </section>
    <script type="text/javascript">
        function topggleForm(){
            var container = document.querySelector('.container');
            container.classList.toggle('active');
        }
    </script>
</body>
</html>
