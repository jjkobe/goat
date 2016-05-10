using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addComment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["houseId"] = 3;
            int houseId = (int)Session["houseId"];
            int customerId = (int)Session["customerId"];
            GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
            var result = from r in lqdb.HOUSE_INFO
                         where r.houseId == houseId
                         select r;
            HOUSE_INFO house = result.FirstOrDefault();
            houseName.Text = house.houseName;
            price.Text = house.price;
            province.Text = house.province;
            city.Text = house.city;
            startDate.Text = house.startDate;
            endDate.Text = house.endDate;
            string url = house.photo;
            string[] s = url.Split(new char[] { ';' });
            Image1.ImageUrl = s[0];
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            datenow.Text = date;
            var result1 = from r in lqdb.USER_PROFILE
                          where r.userId == customerId
                          select r;
            USER_PROFILE user = result1.FirstOrDefault();
            name.Text = user.userName;
            Image2.ImageUrl = user.headImage;
        }
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        //跳转到详细信息页面
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        int customerId = (int)Session["customerId"];
        string content = comment.Text.ToString();
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
        Response.Write("<script>alert('评论已经成功提交')</script>");
        Response.Redirect("~/historyOrder.aspx");
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
}