using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
    public class applicant
    {

        /// <summary>
        /// 检测是否该学号已报名
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool Search(int number)
        {
            return YF.DAL.applicant.Search(number);
        }

        /// <summary>
        /// 将前端信息穿入数据库访问层
        /// </summary>
        /// <param name="applicant"></param>
        /// <returns></returns>
        public static bool add(YF.Model.applicant applicant)
        {
            return YF.DAL.applicant.add(applicant);
        }
        /// <summary>
        /// 显示报名者信息
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string[] show(int number)
        {
            return YF.DAL.applicant.show(number);
        }
        /// <summary>
        /// 修改报名者信息
        /// </summary>
        /// <param name="applicant"></param>
        /// <returns></returns>
        public static bool amend(YF.Model.applicant applicant)
        {
            return YF.DAL.applicant.amend(applicant);
        }
    }
}
