using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamWebsite
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strsql = "select number,yourname,sex,mobile,majorclass,address,math,chinese,english,physics,two,total,type from tb_applicant";
            DataTable dataTable = YF.MysqlHelper.YFMysqlHelper.ExecuteDataTable(strsql);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}