using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
    public class User
    {
        /// <summary>
        /// 查询是否有重复用户名
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool search(string username)
        {
            return YF.DAL.User.search(username);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add(YF.Model.User user)
        {
            return YF.DAL.User.add(user);
        }

        /// <summary>
        /// 登录用户名密码是否一致
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool login(string username, string password)
        {
            return YF.DAL.User.login(username, password);
        }
        /// <summary>
        /// 验证登录者是否为管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static bool verify(YF.Model.User admin)
        {
            return YF.DAL.User.verify(admin);
        }
        /// <summary>
        /// 验证是否有资格报名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Sizer(YF.Model.User user)
        {
            return YF.DAL.User.Sizer(user);
        }
        /// <summary>
        /// 明转暗，暗文输送用户名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string mtod(string ming)
        {
            return YF.DAL.User.mtod(ming);
        }


        /// <summary>
        /// 暗转明
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string dtom(string dark)
        {
            return YF.DAL.User.dtom(dark);
        }
    }
}
