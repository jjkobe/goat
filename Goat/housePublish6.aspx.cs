using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class housePublish6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            stepCheck();
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            int houseId = (int)Session["houseId"];
            GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
            var result = from r in lqdb.HOUSE_INFO
                         where r.houseId == houseId
                         select r;
            HOUSE_INFO house = result.FirstOrDefault();
            string price = "";
            if (house.price != null)
            {
                price = (string)house.houseName;
                this.price.Text = price;
            }
        }
    }

    private void stepCheck()
    {
        int step = (int)Session["step"];
        if (step == 1)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
        }
        else if (step == 2)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
        }
        else if (step == 3)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
        }
        else if (step == 4)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
        }
        else if (step == 5)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
        }
        else if (step == 6)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
        }
        else if (step == 7)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
            HyperLink7.NavigateUrl = "~/iamge.aspx";
        }
        else if (step == 8)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
            HyperLink7.NavigateUrl = "~/iamge.aspx";
            HyperLink8.NavigateUrl = "~/housePublish6.aspx";
        }
        else if (step == 9)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
            HyperLink7.NavigateUrl = "~/iamge.aspx";
            HyperLink8.NavigateUrl = "~/housePublish6.aspx";
            HyperLink9.NavigateUrl = "~/housePublish7.aspx";
        }
        else if (step == 10)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
            HyperLink7.NavigateUrl = "~/iamge.aspx";
            HyperLink8.NavigateUrl = "~/housePublish6.aspx";
            HyperLink9.NavigateUrl = "~/housePublish7.aspx";
            HyperLink10.NavigateUrl = "~/housePublish8.aspx";
        }
        else if (step == 11)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
            HyperLink3.NavigateUrl = "~/housePublish3.aspx";
            HyperLink4.NavigateUrl = "~/housePublish4.aspx";
            HyperLink5.NavigateUrl = "~/housePublish5.aspx";
            HyperLink6.NavigateUrl = "~/Service.aspx";
            HyperLink7.NavigateUrl = "~/iamge.aspx";
            HyperLink8.NavigateUrl = "~/housePublish6.aspx";
            HyperLink9.NavigateUrl = "~/housePublish7.aspx";
            HyperLink10.NavigateUrl = "~/housePublish8.aspx";
            HyperLink11.NavigateUrl = "~/housePublish9.aspx";
        }
    }
    private void nextStep()
    {
        int houseId = (int)Session["houseId"];
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.REF_USER_HOUSEINFO
                     where r.houseId == houseId
                     select r;
        foreach (REF_USER_HOUSEINFO ruf in result)
        {
            if (ruf.state == 0)
            {
                ruf.step = 9;
                Session["step"] = 9;
                break;
            }
        }
        lqdb.SubmitChanges();
    }
    protected void next6_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        string price = this.price.Text.ToString().Trim();
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.price = price;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/housePublish7.aspx");
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
}