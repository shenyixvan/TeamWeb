using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.DAL
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
            bool result;

            string strsql = "select * from tb_applicant where number=" + number.ToString();

            DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);
            if (dataTable.Rows.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// 将用户报名信息填入数据表格，true or false
        /// </summary>
        /// <param name="applicant"></param>
        /// <returns></returns>
        public static bool add(YF.Model.applicant applicant)
        {

            bool result = false;
            string strsql = "insert into tb_applicant (number,yourname,sex,mobile,majorclass,address,math,chinese,english,physics,two,total,type) values (" + applicant.Number + ",'" +
                applicant.Yourname + "','" + applicant.Sex + "','" + applicant.Mobile + "','" + applicant.Majorclass + "','" + applicant.Address + "'," + applicant.Math + ","+applicant.Chinese+"," + applicant.English + "," + 
                applicant.Physics + "," + applicant.Two + "," + applicant.Total + "," + applicant.Type + ")";

            int i = YF.MysqlHelper.YFMysqlHelper.ExecuteNonQuery(strsql);

            if (i > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        /// <summary
        /// 显示已报名者信息
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string[] show(int number)
        {
            string[] showinfo = new string[12];

            string strsql = "select * from tb_applicant where number=" + number.ToString();

            DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);

            for(int i = 0; i <= 11; i++)
            {
                showinfo[i] = dataTable.Rows[0][i + 1].ToString();
            }
            showinfo[11] = dataTable.Rows[0][12].ToString();

            return showinfo;
        }

        public static bool amend(YF.Model.applicant applicant)
        {
            bool result;

            string sql = "update tb_applicant set yourname='" + applicant.Yourname + "',sex='" + applicant.Sex + "',mobile='" + applicant.Mobile +
                "',majorclass='" + applicant.Majorclass + "',address='" + applicant.Address + "',math = " + applicant.Math + ",chinese=" + applicant.Chinese +
                ",english=" + applicant.English + " ,physics=" + applicant.Physics+ ",two=" + applicant.Two + ",total=" + applicant.Total + 
                " where number=" + applicant.Number;

            int i = YF.MysqlHelper.YFMysqlHelper.ExecuteNonQuery(sql);

            if (i > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
