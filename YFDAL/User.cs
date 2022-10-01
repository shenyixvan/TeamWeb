using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.DAL
{
    public class User
    {
        /// <summary>
        /// 验证是否有重复的用户名
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        
        public static bool search(string username)
        {
            bool result = false;

            string strsql = "select * from tb_user where username='" + username + "'";

            try
            {
                DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);
                if (dataTable.Rows.Count == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 添加用户注册信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add(YF.Model.User user)
        {
            bool result = false;

            string strsql = "insert into tb_user (username,password,email,state,adddate) values ('" + user.Username + "','" + user.Password + "','" + user.Email + "'," + user.State + ",'" + user.Adddate + "')";

            int i = YF.MysqlHelper.YFMysqlHelper.ExecuteNonQuery(strsql);

            if (i > 0)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// 验证登录用户名密码是否匹配
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public static bool login(string username, string password)
        {
            bool result = false;

            string strsql = "select * from tb_user where username='" + username + "'and password ='" + password + "'";

            try
            {
                DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);

                if (dataTable.Rows.Count != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
        /// <summary>
        /// 验证登录的用户是否为管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static bool verify(YF.Model.User admin)
        {
            bool result = false;

            string strsql = "select * from tb_user where username='" + admin.Username + "'and state =0";

            DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);
            if (dataTable.Rows.Count == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// 验证用户是否有资格报名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Sizer(YF.Model.User user)
        {
           //* bool result;

           // bool condition1 = user.Username.Substring(0, 6) == "210301" || user.Username.Substring(0, 6) == "210302" || user.Username.Substring(0, 6) == "210303";
          //  bool condition2 = user.Username.Substring(0, 6) == "210301" && int.Parse(user.Username.Substring(6, 3)) < 100;
          //  bool condition3 = user.Username.Substring(0, 6) == "210302" && int.Parse(user.Username.Substring(6, 3)) < 140;
          //  bool condition4 = user.Username.Substring(0, 6) == "210303" && int.Parse(user.Username.Substring(6, 3)) < 200;

         //   if (condition1)
            {
            //    if (condition2||condition3||condition4)
                {
              //      result = true;
                }
               // else
                {
             //       result = false;
                }
            }
          //  else
            {
           //     result = false;
            }
            ///
            return true;
        }

        /// <summary>
        /// 明转暗，通过一定对应关系，转换登录的用户名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string mtod(string ming)
        {
            string result;

            string str0, str1, str2, str3, str4, str5, str6, str7, str8;
            str0 = ming.Substring(0, 1);
            str1 = ming.Substring(1, 1);
            str2 = ming.Substring(2, 1);
            str3 = ming.Substring(3, 1);
            str4 = ming.Substring(4, 1);
            str5 = ming.Substring(5, 1);
            str6 = ming.Substring(6, 1);
            str7 = ming.Substring(7, 1);
            str8 = ming.Substring(8, 1);

            if(str0 == "0"){str0 = ".";}
            else if(str0 == "1") { str0 = "k"; }
            else if(str0 == "2") { str0 = "x"; }
            else if(str0 == "3") { str0 = "$"; }
            else if(str0 == "4") { str0 = "q"; }
            else if(str0 == "5") { str0 = "s"; }
            else if(str0 == "6") { str0 = "r"; }
            else if(str0 == "7") { str0 = "l"; }
            else if(str0 == "8") { str0 = "3"; }
            else{ str0 = "1"; }

            if (str1 == "0") { str1 = "."; }
            else if (str1 == "1") { str1 = "k"; }
            else if (str1 == "2") { str1 = "x"; }
            else if (str1 == "3") { str1 = "$"; }
            else if (str1 == "4") { str1 = "q"; }
            else if (str1 == "5") { str1 = "s"; }
            else if (str1 == "6") { str1 = "r"; }
            else if (str1 == "7") { str1 = "l"; }
            else if (str1 == "8") { str1 = "3"; }
            else { str1 = "1"; }

            if (str2 == "0") { str2 = "."; }
            else if (str2 == "1") { str2 = "k"; }
            else if (str2 == "2") { str2 = "x"; }
            else if (str2 == "3") { str2 = "$"; }
            else if (str2 == "4") { str2 = "q"; }
            else if (str2 == "5") { str2 = "s"; }
            else if (str2 == "6") { str2 = "r"; }
            else if (str2 == "7") { str2 = "l"; }
            else if (str2 == "8") { str2 = "3"; }
            else { str2 = "1"; }

            if (str3 == "0") { str3 = "."; }
            else if (str3 == "1") { str3 = "k"; }
            else if (str3 == "2") { str3 = "x"; }
            else if (str3 == "3") { str3 = "$"; }
            else if (str3 == "4") { str3 = "q"; }
            else if (str3 == "5") { str3 = "s"; }
            else if (str3 == "6") { str3 = "r"; }
            else if (str3 == "7") { str3 = "l"; }
            else if (str3 == "8") { str3 = "3"; }
            else { str3 = "1"; }

            if (str4 == "0") { str4 = "."; }
            else if (str4 == "1") { str4 = "k"; }
            else if (str4 == "2") { str4 = "x"; }
            else if (str4 == "3") { str4 = "$"; }
            else if (str4 == "4") { str4 = "q"; }
            else if (str4 == "5") { str4 = "s"; }
            else if (str4 == "6") { str4 = "r"; }
            else if (str4 == "7") { str4 = "l"; }
            else if (str4 == "8") { str4 = "3"; }
            else { str4 = "1"; }

            if (str5 == "0") { str5 = "."; }
            else if (str5 == "1") { str5 = "k"; }
            else if (str5 == "2") { str5 = "x"; }
            else if (str5 == "3") { str5 = "$"; }
            else if (str5 == "4") { str5 = "q"; }
            else if (str5 == "5") { str5 = "s"; }
            else if (str5 == "6") { str5 = "r"; }
            else if (str5 == "7") { str5 = "l"; }
            else if (str5 == "8") { str5 = "3"; }
            else { str5 = "1"; }

            if (str6 == "0") { str6 = "."; }
            else if (str6 == "1") { str6 = "k"; }
            else if (str6 == "2") { str6 = "x"; }
            else if (str6 == "3") { str6 = "$"; }
            else if (str6 == "4") { str6 = "q"; }
            else if (str6 == "5") { str6 = "s"; }
            else if (str6 == "6") { str6 = "r"; }
            else if (str6 == "7") { str6 = "l"; }
            else if (str6 == "8") { str6 = "3"; }
            else { str6 = "1"; }

            if (str7 == "0") { str7 = "."; }
            else if (str7 == "1") { str7 = "k"; }
            else if (str7 == "2") { str7 = "x"; }
            else if (str7 == "3") { str7 = "$"; }
            else if (str7 == "4") { str7 = "q"; }
            else if (str7 == "5") { str7 = "s"; }
            else if (str7 == "6") { str7 = "r"; }
            else if (str7 == "7") { str7 = "l"; }
            else if (str7 == "8") { str7 = "3"; }
            else { str7 = "1"; }

            if (str8 == "0") { str8 = "."; }
            else if (str8 == "1") { str8 = "k"; }
            else if (str8 == "2") { str8 = "x"; }
            else if (str8 == "3") { str8 = "$"; }
            else if (str8 == "4") { str8 = "q"; }
            else if (str8 == "5") { str8 = "s"; }
            else if (str8 == "6") { str8 = "r"; }
            else if (str8 == "7") { str8 = "l"; }
            else if (str8 == "8") { str8 = "3"; }
            else { str8 = "1"; }


            result = str0 + str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8;

            return result;
        }

        /// <summary>
        /// 暗转明，
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string dtom(string dark)
        {
            string result;

            string str0, str1, str2, str3, str4, str5, str6, str7, str8;
            str0 = dark.Substring(0, 1);
            str1 = dark.Substring(1, 1);
            str2 = dark.Substring(2, 1);
            str3 = dark.Substring(3, 1);
            str4 = dark.Substring(4, 1);
            str5 = dark.Substring(5, 1);
            str6 = dark.Substring(6, 1);
            str7 = dark.Substring(7, 1);
            str8 = dark.Substring(8, 1);

            if (str0 == ".") { str0 = "0"; }
            else if (str0 == "k") { str0 = "1"; }
            else if (str0 == "x") { str0 = "2"; }
            else if (str0 == "$") { str0 = "3"; }
            else if (str0 == "q") { str0 = "4"; }
            else if (str0 == "s") { str0 = "5"; }
            else if (str0 == "r") { str0 = "6"; }
            else if (str0 == "l") { str0 = "7"; }
            else if (str0 == "3") { str0 = "8"; }
            else { str0 = "9"; }

            if (str1 == ".") { str1 = "0"; }
            else if (str1 == "k") { str1 = "1"; }
            else if (str1 == "x") { str1 = "2"; }
            else if (str1 == "$") { str1 = "3"; }
            else if (str1 == "q") { str1 = "4"; }
            else if (str1 == "s") { str1 = "5"; }
            else if (str1 == "r") { str1 = "6"; }
            else if (str1 == "l") { str1 = "7"; }
            else if (str1 == "3") { str1 = "8"; }
            else { str1 = "9"; }

            if (str2 == ".") { str2 = "0"; }
            else if (str2 == "k") { str2 = "1"; }
            else if (str2 == "x") { str2 = "2"; }
            else if (str2 == "$") { str2 = "3"; }
            else if (str2 == "q") { str2 = "4"; }
            else if (str2 == "s") { str2 = "5"; }
            else if (str2 == "r") { str2 = "6"; }
            else if (str2 == "l") { str2 = "7"; }
            else if (str2 == "3") { str2 = "8"; }
            else { str2 = "9"; }

            if (str3 == ".") { str3 = "0"; }
            else if (str3 == "k") { str3 = "1"; }
            else if (str3 == "x") { str3 = "2"; }
            else if (str3 == "$") { str3 = "3"; }
            else if (str3 == "q") { str3 = "4"; }
            else if (str3 == "s") { str3 = "5"; }
            else if (str3 == "r") { str3 = "6"; }
            else if (str3 == "l") { str3 = "7"; }
            else if (str3 == "3") { str3 = "8"; }
            else { str3 = "9"; }

            if (str4 == ".") { str4 = "0"; }
            else if (str4 == "k") { str4 = "1"; }
            else if (str4 == "x") { str4 = "2"; }
            else if (str4 == "$") { str4 = "3"; }
            else if (str4 == "q") { str4 = "4"; }
            else if (str4 == "s") { str4 = "5"; }
            else if (str4 == "r") { str4 = "6"; }
            else if (str4 == "l") { str4 = "7"; }
            else if (str4 == "3") { str4 = "8"; }
            else { str4 = "9"; }

            if (str5 == ".") { str5 = "0"; }
            else if (str5 == "k") { str5 = "1"; }
            else if (str5 == "x") { str5 = "2"; }
            else if (str5 == "$") { str5 = "3"; }
            else if (str5 == "q") { str5 = "4"; }
            else if (str5 == "s") { str5 = "5"; }
            else if (str5 == "r") { str5 = "6"; }
            else if (str5 == "l") { str5 = "7"; }
            else if (str5 == "3") { str5 = "8"; }
            else { str5 = "9"; }

            if (str6 == ".") { str6 = "0"; }
            else if (str6 == "k") { str6 = "1"; }
            else if (str6 == "x") { str6 = "2"; }
            else if (str6 == "$") { str6 = "3"; }
            else if (str6 == "q") { str6 = "4"; }
            else if (str6 == "s") { str6 = "5"; }
            else if (str6 == "r") { str6 = "6"; }
            else if (str6 == "l") { str6 = "7"; }
            else if (str6 == "3") { str6 = "8"; }
            else { str6 = "9"; }

            if (str7 == ".") { str7 = "0"; }
            else if (str7 == "k") { str7 = "1"; }
            else if (str7 == "x") { str7 = "2"; }
            else if (str7 == "$") { str7 = "3"; }
            else if (str7 == "q") { str7 = "4"; }
            else if (str7 == "s") { str7 = "5"; }
            else if (str7 == "r") { str7 = "6"; }
            else if (str7 == "l") { str7 = "7"; }
            else if (str7 == "3") { str7 = "8"; }
            else { str7 = "9"; }

            if (str8 == ".") { str8 = "0"; }
            else if (str8 == "k") { str8 = "1"; }
            else if (str8 == "x") { str8 = "2"; }
            else if (str8 == "$") { str8 = "3"; }
            else if (str8 == "q") { str8 = "4"; }
            else if (str8 == "s") { str8 = "5"; }
            else if (str8 == "r") { str8 = "6"; }
            else if (str8 == "l") { str8 = "7"; }
            else if (str8 == "3") { str8 = "8"; }
            else { str8 = "9"; }

            result = str0 + str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8;

            return result;
        }
    }
}
