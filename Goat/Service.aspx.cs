using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Service : System.Web.UI.Page
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
            if (h.engage == 1)
            {
                this.engage.Checked = true;
            }
            if (h.brorrowCar == 1)
            {
                this.brorrowCar.Checked = true;
            }
            if (h.foodGuide == 1)
            {
                this.foodGuide.Checked = true;
            }
            if (h.shopGuide == 1)
            {
                this.shopGuide.Checked = true;
            }
            if (h.spotGuide == 1)
            {
                this.spotGuide.Checked = true;
            }
            if (h.foodMake == 1)
            {
                this.foodMake.Checked = true;
            }
            if (h.ticket == 1)
            {
                this.ticket.Checked = true;
            }
            if (h.translate == 1)
            {
                this.translate.Checked = true;
            }
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
                ruf.step = 7;
                Session["step"] = 7;
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
    protected void nextService_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        int engage = 0;
        int brorrowCar = 0;
        int foodGuide = 0;
        int shopGuide = 0;
        int spotGuide = 0;
        int ticket = 0;
        int foodMake = 0;
        int translate = 0;
        if (this.engage.Checked == true)
        {
            engage = 1;
        }
        if (this.brorrowCar.Checked == true)
        {
            brorrowCar = 1;
        }
        if (this.foodGuide.Checked == true)
        {
            foodGuide = 1;
        }
        if (this.shopGuide.Checked == true)
        {
            shopGuide = 1;
        }
        if (this.spotGuide.Checked == true)
        {
            spotGuide = 1;
        }
        if (this.ticket.Checked == true)
        {
            ticket = 1;
        }
        if (this.foodMake.Checked == true)
        {
            foodMake = 1;
        }
        if (this.translate.Checked == true)
        {
            translate = 1;
            GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
            var result = from r in lqdb.HOUSE_INFO
                         where r.houseId == houseId
                         select r;
            foreach (HOUSE_INFO h in result)
            {
                h.engage = engage;
                h.brorrowCar = brorrowCar;
                h.foodGuide = foodGuide;
                h.spotGuide = spotGuide;
                h.shopGuide = shopGuide;
                h.ticket = ticket;
                h.translate = translate;
                h.foodMake = foodMake;
            }
            lqdb.SubmitChanges();
            nextStep();
            Response.Redirect("~/iamge.aspx");
        }
    }
}