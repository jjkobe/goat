using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class likething : System.Web.UI.Page
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int _collectionId = Convert.ToInt32(button.CommandArgument.ToString());
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.COLLECCTION
                     where r.collectionId == _collectionId
                     select r;
        lqdb.COLLECCTION.DeleteAllOnSubmit(result);
        lqdb.SubmitChanges();
        dataBind();
    }
    protected void dataBind()
    {
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        string SqlStr = "select * from COLLECCTION where userId= 2";
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
        //跳转到详细信息的页面
    }
    [WebMethod(EnableSession =true)]
    public static string getLocation()
    {
        HttpContext.Current.Session["userId"] = 2;
        int userId = (int)HttpContext.Current.Session["userId"];
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.COLLECCTION
                     where r.userId == userId
                     select r;
        string json = "{\"location\":[";
        foreach (COLLECCTION c in result)
        {
            var resultHouse = from h in lqdb.HOUSE_INFO
                              where h.houseId == c.houseId
                              select h;
            HOUSE_INFO house = resultHouse.FirstOrDefault();
            json = json + "{\"lng\":\"" + house.lng + "\",\"lat\":\"" + house.lat + "\",\"name\":\""+house.houseName+"\",\"price\":\""+house.price+"\"},"; 
        }
        json = json.Substring(0, json.Length - 1);
        json = json + "]}";
        return json;
    }
}