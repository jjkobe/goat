using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class doLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string phone = Request.Form["LoginInputPhone"].ToString();
        string pass = Request.Form["LoginInputPassword"].ToString();
        PublicUtil pt = new PublicUtil();
        string password = pt.GetMD5(pass);
        bool isSucc = checkLogin(phone, pass);
        if (isSucc)
        {
            Session["userId"] = phone;
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            Response.Write("<script>alert('用户名或密码不正确')</script>");
            Response.Redirect("~/Default.aspx");
        }
    }

    private bool checkLogin(string _phone, string _password)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER
                     where r.phone == _phone && r.password == _password
                     select r;
        if (result.FirstOrDefault() != null)
        {
            saveIdByPhone(_phone);
            return true;
        }
        else
        {
            return false;
        }
    }
    private void saveIdByPhone(string _phone)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER
                     where r.phone == _phone
                     select r;
        USER user = result.FirstOrDefault();
        int id = user.userId;
        Session["ID"] = user.userId;
        //addUserProfile(id);
    }
}