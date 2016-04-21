using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class historyOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dataBind();
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

    protected void dataBind()
    {
        Session["customerId"] = 1;
        Session["houseId"] = 3;
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        string SqlStr = "select * from HOUSE_ORDER where customerId= 1";
        SqlDataAdapter myDa = new SqlDataAdapter(SqlStr, myConn);
        DataSet myDs = new DataSet();
        myDa.Fill(myDs);
        DataList1.DataSource = myDs;
        DataList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int _orderId = Convert.ToInt32(button.CommandArgument.ToString());
        int command = Convert.ToInt32(button.CommandName.ToString());
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_ORDER
                     where r.orderId == _orderId
                     select r;
        if(command==1)
        {
            foreach (HOUSE_ORDER h in result)
            {
                h.state = 2;
                h.stateNameCustomer = "已付款";
                h.stateHintCustomer = "完成";
                h.stateHintHost = "完成";
                h.stateNameHost = "已付款";
                h.isShowHost = 1;
            }
        }
        else if (command == 2)
        {
            foreach (HOUSE_ORDER h in result)
            {
                h.state = 3;
                h.stateHintCustomer = "";
                h.stateNameCustomer = "等待对方完成";
                h.isShowCustomer = 0;
            }
        }
        else if (command == 4)
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
                h.customerCheck = 1;
            }
        }
        lqdb.SubmitChanges();
        dataBind();
    }

    private string getHeadPicById(int customerId)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER_PROFILE
                     where r.userId == customerId
                     select r;
        USER_PROFILE user = result.FirstOrDefault();
        string pic = user.headImage;
        return pic;
    }

    protected void comsub_Click(object sender, EventArgs e)
    {
        string content = comment.Text.ToString();
        int customerId = (int)Session["customerId"];
        int houseId = (int)Session["houseId"];
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.COMMENT
                     where r.houseId == houseId
                     select r;
        COMMENT com = new COMMENT();
        com.houseId = houseId;
        com.commentContent = content;
        com.commentId = customerId;
        string pis = getHeadPicById(customerId);
        com.photo = pis;
        string date = DateTime.Now.ToString();
        com.commentDate = date;
        lqdb.COMMENT.InsertOnSubmit(com);
        lqdb.SubmitChanges();
    }
}