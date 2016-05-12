using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class housePublish1 : System.Web.UI.Page
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
            int styleId = 0;
            int typeId = 0;
            int limitId = 0;
            int bedroomId = 0;
            int bedId = 0;
            int restroomId = 0;
            this.style.ClearSelection();
            if (house.style!=null)
            {
                styleId = (int)house.style;
                initStyle(styleId);
            }
            if (house.type != null)
            {
                typeId = (int)house.type;
                initType(typeId);
            }
            if (house.limit != null)
            {
                limitId = (int)house.limit;
                initLimit(limitId);
            }
            if (house.bedroom != null)
            {
                bedroomId = (int)house.bedroom;
                initBedroom(bedroomId);
            }
            if (house.bed != null)
            {
                bedId = (int)house.bed;
                initBed(bedId);
            }
            if (house.restroom != null)
            {
                restroomId = (int)house.restroom;
                initRestroom(restroomId);
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
        Response.Redirect("~/profile.aspx");
    }
    private void initRestroom(int restroomId)
    {
        if (restroomId == 1)
        {
            this.restroom.Items.FindByValue("1").Selected = true;
        }
        else if (restroomId == 2)
        {
            this.restroom.Items.FindByValue("2").Selected = true;
        }
        else if (restroomId == 3)
        {
            this.restroom.Items.FindByValue("3+").Selected = true;
        }
    }

    private void stepCheck()
    {
        int step = (int)Session["step"];
        if(step==1)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
        }
        else if(step==2)
        {
            HyperLink1.NavigateUrl = "~/housePublish1.aspx";
            HyperLink2.NavigateUrl = "~/housePublish2.aspx";
        }
        else if(step==3)
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

    private void initBed(int bedId)
    {
        if (bedId == 1)
        {
            this.bed.Items.FindByValue("1").Selected = true;
        }
        else if (bedId == 2)
        {
            this.bed.Items.FindByValue("2").Selected = true;
        }
        else if (bedId == 3)
        {
            this.bed.Items.FindByValue("3").Selected = true;
        }
        else if (bedId == 4)
        {
            this.bed.Items.FindByValue("4").Selected = true;
        }
        else if (bedId == 5)
        {
            this.bed.Items.FindByValue("5+").Selected = true;
        }
    }

    private void initBedroom(int bedroomId)
    {
        if (bedroomId == 1)
        {
            this.bedroom.Items.FindByValue("1").Selected = true;
        }
        else if (bedroomId == 2)
        {
            this.bedroom.Items.FindByValue("2").Selected = true;
        }
        else if (bedroomId == 3)
        {
            this.bedroom.Items.FindByValue("3").Selected = true;
        }
        else if (bedroomId == 4)
        {
            this.bedroom.Items.FindByValue("4").Selected = true;
        }
        else if (bedroomId == 5)
        {
            this.bedroom.Items.FindByValue("5+").Selected = true;
        }
    }

    private void initLimit(int limitId)
    {
        if (limitId == 1)
        {
            this.limit.Items.FindByValue("1").Selected = true;
        }
        else if (limitId == 2)
        {
            this.limit.Items.FindByValue("2").Selected = true;
        }
        else if (limitId == 3)
        {
            this.limit.Items.FindByValue("3").Selected = true;
        }
        else if (limitId == 4)
        {
            this.limit.Items.FindByValue("4").Selected = true;
        }
        else if (limitId == 5)
        {
            this.limit.Items.FindByValue("5").Selected = true;
        }
        else if (limitId == 6)
        {
            this.limit.Items.FindByValue("6").Selected = true;
        }
        else if (limitId == 7)
        {
            this.limit.Items.FindByValue("7").Selected = true;
        }
        else if (limitId == 8)
        {
            this.limit.Items.FindByValue("8+").Selected = true;
        }
    }

    private void initType(int typeId)
    {
        if (typeId == 1)
        {
            this.type.Items.FindByValue("整套房子/公寓").Selected = true;
        }
        else if (typeId == 2)
        {
            this.type.Items.FindByValue("独立房间").Selected = true;
        }
        else if (typeId == 3)
        {
            this.type.Items.FindByValue("合住房间").Selected = true;
        }
    }

    private void initStyle(int styleId)
    {
        if (styleId == 1)
        {
            this.style.Items.FindByValue("公寓").Selected = true;
        }
        else if (styleId == 2)
        {
            this.style.Items.FindByValue("独立屋").Selected = true;
        }
        else if (styleId == 3)
        {
            this.style.Items.FindByValue("住宿加早餐").Selected = true;
        }
        else if (styleId == 4)
        {
            this.style.Items.FindByValue("LOFT").Selected = true;
        }
        else if (styleId == 5)
        {
            this.style.Items.FindByValue("别墅").Selected = true;
        }
        else if (styleId == 6)
        {
            this.style.Items.FindByValue("宿舍").Selected = true;
        }
        else if (styleId == 7)
        {
            this.style.Items.FindByValue("房车").Selected = true;
        }
        else if (styleId == 8)
        {
            this.style.Items.FindByValue("蒙古包").Selected = true;
        }
        else if (styleId == 9)
        {
            this.style.Items.FindByValue("岛屿").Selected = true;
        }
        else if (styleId == 10)
        {
            this.style.Items.FindByValue("帐篷").Selected = true;
        }
        else if (styleId == 11)
        {
            this.style.Items.FindByValue("平房").Selected = true;
        }
        else if (styleId == 12)
        {
            this.style.Items.FindByValue("小木屋").Selected = true;
        }
        else if (styleId == 13)
        {
            this.style.Items.FindByValue("其他").Selected = true;
        }
    }

    protected void next_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        int style = getStyle();
        int type = getType();
        int limit = getLimit();
        int bedroom = getBedroom();
        int bed = getBed();
        int restroom = getRestroom();
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.style = style;
            h.type = type;
            h.limit = limit;
            h.bedroom = bedroom;
            h.bed = bed;
            h.restroom = restroom;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/housePublish2.aspx");
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
                ruf.step = 2;
                Session["step"] = 2;
                break;
            }
        }
        lqdb.SubmitChanges();
    }

    private int getRestroom()
    {
        string restroom = this.restroom.SelectedValue;
        int s = 0;
        if (restroom == "1")
        {
            s = 1;
        }
        else if (restroom == "2")
        {
            s = 2;
        }
        else if (restroom == "3+")
        {
            s = 3;
        }
        return s;
    }

    private int getBed()
    {
        string bed = this.bed.SelectedValue;
        int s = 0;
        if (bed == "1")
        {
            s = 1;
        }
        else if (bed == "2")
        {
            s = 2;
        }
        else if (bed == "3")
        {
            s = 3;
        }
        else if (bed == "4")
        {
            s = 4;
        }
        else if (bed == "5+")
        {
            s = 5;
        }
        return s;
    }

    private int getBedroom()
    {
        string bedroom = this.bedroom.SelectedValue;
        int s = 0;
        if (bedroom == "1")
        {
            s = 1;
        }
        else if (bedroom == "2")
        {
            s = 2;
        }
        else if (bedroom == "3")
        {
            s = 3;
        }
        else if (bedroom == "4")
        {
            s = 4;
        }
        else if (bedroom == "5+")
        {
            s = 5;
        }
        return s;
    }

    private int getLimit()
    {
        string limit = this.limit.SelectedValue;
        int s = 0;
        if (limit == "1")
        {
            s = 1;
        }
        else if (limit == "2")
        {
            s = 2;
        }
        else if (limit == "3")
        {
            s = 3;
        }
        else if (limit == "4")
        {
            s = 4;
        }
        else if (limit == "5")
        {
            s = 5;
        }
        else if (limit == "6")
        {
            s = 6;
        }
        else if (limit == "7")
        {
            s = 7;
        }
        else if (limit == "8+")
        {
            s = 8;
        }
        return s;
        }

    private int getType()
    {
        string type = this.type.SelectedValue;
        int s = 0;
        if (type == "整套房子/公寓")
        {
            s = 1;
        }
        else if (type == "独立房间")
        {
            s = 2;
        }
        else if (type == "合住房间")
        {
            s = 3;
        }
        return s;
    }

    private int getStyle()
    {
        string style = this.style.SelectedValue;
        int s = 0;
        if (style == "公寓")
        {
            s = 1;
        }
        else if (style == "独立屋")
        {
            s = 2;
        }
        else if (style == "住宿加早餐")
        {
            s = 3;
        }
        else if (style == "LOFT")
        {
            s = 4;
        }
        else if (style == "别墅")
        {
            s = 5;
        }
        else if (style == "宿舍")
        {
            s = 6;
        }
        else if (style == "房车")
        {
            s = 7;
        }
        else if (style == "蒙古包")
        {
            s = 8;
        }
        else if (style == "岛屿")
        {
            s = 9;
        }
        else if (style == "帐篷")
        {
            s = 10;
        }
        else if (style == "平房")
        {
            s = 11;
        }
        else if (style == "小木屋")
        {
            s = 12;
        }
        else if (style == "其他")
        {
            s = 13;
        }
        return s;
    }
}