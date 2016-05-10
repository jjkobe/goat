using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class housePublish5 : System.Web.UI.Page
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
            HOUSE_INFO h = result.FirstOrDefault();
            if (h.smokeAlert == 1)
            {
                this.smokeAlert.Checked = true;
            }
            if (h.coAlert == 1)
            {
                this.coAlert.Checked = true;
            }
            if (h.aid == 1)
            {
                this.aid.Checked = true;
            }
            if (h.aidCard == 1)
            {
                this.aidCard.Checked = true;
            }
            if (h.fire == 1)
            {
                this.fire.Checked = true;
            }
            string fireLocation = "";
            string fireAlertLocation = "";
            string coEnd = "";
            string exitLocation = "";
            string aidCall = "";
            string fireCall = "";
            string policeCall = "";
            if (h.fireLocation != null)
            {
                fireLocation = (string)h.houseName;
                this.fireLocation.Text = fireLocation;
            }
            if (h.fireAlertLocation != null)
            {
                fireAlertLocation = (string)h.fireAlertLocation;
                this.fireAlertLocation.Text = fireAlertLocation;
            }
            if (h.coEnd != null)
            {
                coEnd = (string)h.coEnd;
                this.coEnd.Text = coEnd;
            }
            if (h.exitLocation != null)
            {
                exitLocation = (string)h.exitLocation;
                this.exitLocation.Text = exitLocation;
            }
            if (h.aidCall != null)
            {
                aidCall = (string)h.aidCall;
                this.aidCall.Text = aidCall;
            }
            if (h.fireCall != null)
            {
                fireCall = (string)h.fireCall;
                this.fireCall.Text = fireCall;
            }
            if (h.policeCall != null)
            {
                policeCall = (string)h.policeCall;
                this.policeCall.Text = policeCall;
            }
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
                ruf.step = 6;
                Session["step"] = 6;
                break;
            }
        }
        lqdb.SubmitChanges();
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
    protected void next5_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        int smokeAlert = 0;
        int coAlert = 0;
        int aid = 0;
        int aidCard = 0;
        int fire = 0;
        if (this.smokeAlert.Checked == true)
        {
            smokeAlert = 1;
        }
        if (this.coAlert.Checked == true)
        {
            coAlert = 1;
        }
        if (this.aid.Checked == true)
        {
            aid = 1;
        }
        if (this.aidCard.Checked == true)
        {
            aidCard = 1;
        }
        if (this.fire.Checked == true)
        {
            fire = 1;
        }
        string fireLocation = this.fireLocation.Text.ToString();
        string fireAlertLocation = this.fireAlertLocation.Text.ToString();
        string coEnd = this.coEnd.Text.ToString();
        string exitLocation = this.exitLocation.Text.ToString();
        string aidCall = this.aidCall.Text.ToString();
        string fireCall = this.fireCall.Text.ToString();
        string policeCall = this.policeCall.Text.ToString();
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.smokeAlert = smokeAlert;
            h.coAlert = coAlert;
            h.aid = aid;
            h.aidCard = aidCard;
            h.fire = fire;
            h.fireLocation = fireLocation;
            h.fireAlertLocation = fireAlertLocation;
            h.coEnd = coEnd;
            h.exitLocation = exitLocation;
            h.aidCall = aidCall;
            h.fireCall = fireCall;
            h.policeCall = policeCall;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/Service.aspx");
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