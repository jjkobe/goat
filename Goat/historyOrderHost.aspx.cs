using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class historyOrderHost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dataBindHost();
    }
    protected void exit_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Cookies.Clear();
        Request.Cookies.Clear();
        Response.Redirect("~/Default.aspx");
    }
    protected void center_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("~/profileContent.aspx");
    }

    protected void dataBindHost()
    {
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        string SqlStr = "select * from HOUSE_ORDER where hostId= 3";
        SqlDataAdapter myDa = new SqlDataAdapter(SqlStr, myConn);
        DataSet myDs = new DataSet();
        myDa.Fill(myDs);
        DataList1.DataSource = myDs;
        DataList1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int _orderId = Convert.ToInt32(button.CommandArgument.ToString());
        int command = Convert.ToInt32(button.CommandName.ToString());
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_ORDER
                     where r.orderId == _orderId
                     select r;
        if (command == 2)
        {
            foreach (HOUSE_ORDER h in result)
            {
                h.state = 3;
                h.stateHintHost = "";
                h.stateNameHost = "等待对方完成";
                h.isShowHost = 0;
            }
        }
        else if (command == 3)
        {
            foreach (HOUSE_ORDER h in result)
            {
                h.state = 5;
                h.stateHintCustomer = "";
                h.stateNameCustomer = "已完成";
                h.isShowCustomer = 0;
                h.stateHintHost = "";
                h.stateNameHost = "已完成";
                h.isShowHost = 0;
            }
        }
        lqdb.SubmitChanges();
        dataBindHost();
    }
}