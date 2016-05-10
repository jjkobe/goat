using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["userId"] = 1;
        int userId = (int)Session["userId"];
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER_PROFILE
                     where r.userId == userId
                     select r;
        USER_PROFILE user = result.FirstOrDefault();
        Image1.ImageUrl = user.headImage;
        Label1.Text = user.userName;
        Label2.Text = user.userName;
        Label3.Text = user.phone;
        Label4.Text = user.description;
        if(user.gender==1)
        {
            Label5.Text = "男";
        }
        else if(user.gender==0)
        {
            Label5.Text = "女";
        }
        Label6.Text = user.email;
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
        bool fileIsValid = false;
        if (this.FileUpload1.HasFile)
        {
            string fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();
            string[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
            for (int i = 0; i < restrictExtension.Length; i++)
            {
                if (fileExtension == restrictExtension[i])
                {
                    fileIsValid = true;
                }
            }
            if (fileIsValid == true)
            {
                string houseId = Convert.ToString((int)Session["userId"]);
                string date = DateTime.Now.ToFileTimeUtc().ToString();
                string ppp = Server.MapPath("~/headImage/") + houseId + date + FileUpload1.FileName;
                this.FileUpload1.SaveAs(Server.MapPath("~/headImage/") + houseId + date + FileUpload1.FileName);
                string path = "~/headImage/" + houseId + date + FileUpload1.FileName;
                Image1.ImageUrl = path;
                SaveImage(path);
            }
        }
    }

    private void SaveImage(String path)
    {
        int userId = (int)Session["userId"];
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER_PROFILE
                     where r.userId == userId
                     select r;
        foreach(USER_PROFILE user in result)
        {
            user.headImage = path;
        }
        lqdb.SubmitChanges();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        FileUpload1.Visible = true;
        Button1.Visible = true;
        Button2.Visible = false;
        Button3.Visible = true;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        FileUpload1.Visible = false;
        Button3.Visible = false;
        Button2.Visible = true;
        Button1.Visible = false;
    }
}