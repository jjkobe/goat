using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["userId"] != null))//userId是登录时的电话号码
        {
            this.register.Visible = false;
            this.login.Visible = false;
            this.center.Visible = true;
            this.exit.Visible = true;
            this.tobehost.Visible = true;
        }

        else
        {
            this.register.Visible = true;
            this.login.Visible = true;
            this.center.Visible = false;
            this.exit.Visible = false;
            this.tobehost.Visible = false;
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
}