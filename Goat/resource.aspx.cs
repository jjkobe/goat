using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class resource : System.Web.UI.Page
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
        Response.Redirect("~/profile.aspx");
    }
    protected void dataBind()
    {
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        string SqlStr = "select * from HOUSE_INFO where hostId= 2";
        SqlDataAdapter myDa = new SqlDataAdapter(SqlStr, myConn);
        DataSet myDs = new DataSet();
        myDa.Fill(myDs);
        DataList1.DataSource = myDs;
        DataList1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int _houseId = Convert.ToInt32(button.CommandArgument.ToString());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int hostId = Convert.ToInt32(button.CommandArgument.ToString());
        Session["ID"] = hostId;
        Response.Redirect("~/stepCheck.aspx");
    }



    protected void add_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/stepCheck.aspx");
    }
}