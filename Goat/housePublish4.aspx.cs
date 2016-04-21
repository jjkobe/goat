using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class housePublish4 : System.Web.UI.Page
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
            if(h.must==1)
            {
                this.must.Checked = true;
            }
            if(h.TV==1)
            {
                this.TV.Checked = true;
            }
            if (h.airCondition == 1)
            {
                this.airCondition.Checked = true;
            }
            if (h.kiction == 1)
            {
                this.kiction.Checked = true;
            }
            if (h.network == 1)
            {
                this.net.Checked = true;
            }
            if (h.wifi == 1)
            {
                this.wifi.Checked = true;
            }
            if (h.time == 1)
            {
                this.time.Checked = true;
            }
            if (h.bath == 1)
            {
                this.bath.Checked = true;
            }
            if (h.wash == 1)
            {
                this.wash.Checked = true;
            }
            if (h.swimmingPool == 1)
            {
                this.swimmingPool.Checked = true;
            }
            if (h.breakfast == 1)
            {
                this.breakfast.Checked = true;
            }
            if (h.carPark == 1)
            {
                this.carPark.Checked = true;
            }
            if (h.workout == 1)
            {
                this.workout.Checked = true;
            }
            if (h.lift == 1)
            {
                this.lift.Checked = true;
            }
            if (h.guard == 1)
            {
                this.guard.Checked = true;
            }
            if (h.children == 1)
            {
                this.children.Checked = true;
            }
            if (h.smoke == 1)
            {
                this.smoke.Checked = true;
            }
            if (h.pet == 1)
            {
                this.pet.Checked = true;
            }
            if (h.disable == 1)
            {
                this.disable.Checked = true;
            }
            if (h.party == 1)
            {
                this.party.Checked = true;
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
                ruf.step = 5;
                Session["step"] = 5;
                break;
            }
        }
        lqdb.SubmitChanges();
    }

    protected void next4_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        int must = 0;
        int airCondition = 0;
        int tv = 0;
        int kiction = 0;
        int network = 0;
        int wifi = 0;
        int time = 0;
        int bath = 0;
        int wash = 0;
        int swimmingPool = 0;
        int breakfast = 0;
        int carPark = 0;
        int workout = 0;
        int lift = 0;
        int guard = 0;
        int children = 0;
        int smoke = 0;
        int pet = 0;
        int disable = 0;
        int party = 0;
        if(this.must.Checked==true)
        {
            must = 1;
        }
        if (this.TV.Checked == true)
        {
            tv = 1;
        }
        if (this.airCondition.Checked == true)
        {
            airCondition = 1;
        }
        if (this.kiction.Checked == true)
        {
            kiction = 1;
        }
        if (this.net.Checked == true)
        {
            network = 1;
        }
        if (this.wifi.Checked == true)
        {
            wifi = 1;
        }
        if (this.time.Checked == true)
        {
            time = 1;
        }
        if (this.bath.Checked == true)
        {
            bath = 1;
        }
        if (this.wash.Checked == true)
        {
            wash = 1;
        }
        if (this.swimmingPool.Checked == true)
        {
            swimmingPool = 1;
        }
        if (this.breakfast.Checked == true)
        {
            breakfast = 1;
        }
        if (this.carPark.Checked == true)
        {
            carPark = 1;
        }
        if (this.workout.Checked == true)
        {
            workout = 1;
        }
        if (this.lift.Checked == true)
        {
            lift = 1;
        }
        if (this.guard.Checked == true)
        {
            guard = 1;
        }
        if (this.children.Checked == true)
        {
            children = 1;
        }
        if (this.smoke.Checked == true)
        {
            smoke = 1;
        }
        if (this.pet.Checked == true)
        {
            pet = 1;
        }
        if (this.disable.Checked == true)
        {
            disable = 1;
        }
        if (this.party.Checked == true)
        {
            party = 1;
        }
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.must = must;
            h.TV = tv;
            h.kiction = kiction;
            h.network = network;
            h.airCondition = airCondition;
            h.wifi = wifi;
            h.time = time;
            h.bath = bath;
            h.wash = wash;
            h.swimmingPool = swimmingPool;
            h.breakfast = breakfast;
            h.carPark = carPark;
            h.workout = workout;
            h.lift = lift;
            h.guard = guard;
            h.children = children;
            h.smoke = smoke;
            h.disable = disable;
            h.pet = pet;
            h.party = party;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/housePublish5.aspx");
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