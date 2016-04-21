using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class doRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string phone = Request.Form["registerInputPhone"].ToString();
        string pass = Request.Form["registerInputPassword"].ToString();
        string pass1 = Request.Form["registerInputPassword1"].ToString();
        string validationNum = Request.Form["validationNum"].ToString();
        PublicUtil pt = new PublicUtil();
        if (!validationNum.Equals(Session["ValidationNum"]))
        {
            Response.Redirect("~/Default.aspx");
            Response.Write("<script>alert('验证码不正确')</script>");
            return;
        }
        else
        {
            if (!pass.Equals(pass1))
            {
                Response.Redirect("~/Default.aspx");
                Response.Write("<script>alert('两次密码不匹配')</script>");
                return;
            }
            else
            {
                string repassword = pt.GetMD5(pass);
                if (addUser(phone, repassword))
                {
                    saveIdByPhone(phone);
                    Session["userId"] = phone;
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                    Response.Write("<script>alert('该手机号已经注册')</script>");
                }
            }
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
        addUserProfile(id);
    }

    private void addUserProfile(int id)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        USER_PROFILE userProfile = new USER_PROFILE();
        userProfile.userId = id;
        lqdb.USER_PROFILE.InsertOnSubmit(userProfile);
        lqdb.SubmitChanges();
    }

    private bool findIdByPhone(string _phone)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER
                     where r.phone == _phone
                     select r;
        if (result.FirstOrDefault() != null)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    private bool addUser(string _phone, string _repassword)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        if (findIdByPhone(_phone) == false)
        {
            return false;
        }
        else
        {
            USER user = new USER();
            user.phone = _phone;
            user.password = _repassword;
            lqdb.USER.InsertOnSubmit(user);
            lqdb.SubmitChanges();
            return true;
        }


    }
}