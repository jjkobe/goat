using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class housePublish2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            stepCheck();
            int houseId = (int)Session["houseId"];
            GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
            var result = from r in lqdb.HOUSE_INFO
                         where r.houseId == houseId
                         select r;
            HOUSE_INFO house = result.FirstOrDefault();
            string name = "";
            string des = "";
            if (house.houseName != null)
            {
                name = (string)house.houseName;
                initName(name);
            }
            if (house.houseDescription != null)
            {
                des = (string)house.houseDescription;
                initDes(des);
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
    private void initDes(string des)
    {
        this.houseDes.Text = des;
    }

    private void initName(string name)
    {
        this.houseName.Text = name;
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
                ruf.step = 3;
                Session["step"] = 3;
                break;
            }
        }
        lqdb.SubmitChanges();
    }

    private string getDes()
    {
        return this.houseDes.Text.ToString();
    }

    private string getName()
    {
        return this.houseName.Text.ToString();
    }

    protected void next2_Click1(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        string name = getName();
        string des = getDes();
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.houseName = name;
            h.houseDescription = des;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/housePublish3.aspx");
    }


}