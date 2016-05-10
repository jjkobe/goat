using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profileContent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void save_Click(object sender, EventArgs e)
    {
        string name = Request.Form["name"].ToString();
        string gender = Request.Form["gender"].ToString();
        //string female = Request.Form["female"].ToString();
        string phone = Request.Form["phone"].ToString();
        string place = Request.Form["place"].ToString();
        string description = Request.Form["description"].ToString();
        string school = Request.Form["school"].ToString();
        string work = Request.Form["work"].ToString();
        string email = Request.Form["email"].ToString();
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        //USER_PROFILE userProfile = new USER_PROFILE();
        int id = (int)Session["ID"];
        //int id = 10;
        var result = from r in lqdb.USER_PROFILE
                     where r.userId == id
                     select r;
        foreach(USER_PROFILE userProfile in result)
        {
            userProfile.gender = Convert.ToInt32(gender);
            userProfile.userName = name;
            userProfile.email = email;
            userProfile.phone = phone;
            userProfile.description = description;
        }
        lqdb.SubmitChanges();
        Response.Redirect("~/Default.aspx");
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
}