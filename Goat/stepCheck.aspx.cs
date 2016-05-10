using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class stepCheck : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = (int)Session["ID"];
        //int id = 1;
        if (!checkIsHave(id))
        {
            createNewHouseInfo();
            Response.Redirect("~/housePublish1.aspx");
        }
        else
        {
            int step = checkAllSubmit(id);
            Session["step"] = step;
            if (step == 0)
            {
                createNewHouseInfo();
                Response.Redirect("~/housePublish1.aspx");
            }
            else if (step == 1)
            {
                Response.Redirect("~/housePublish1.aspx");
            }
            else if (step == 2)
            {
                Response.Redirect("~/housePublish2.aspx");
            }
            else if (step == 3)
            {
                Response.Redirect("~/housePublish3.aspx");
            }
            else if (step == 4)
            {
                Response.Redirect("~/housePublish4.aspx");
            }
            else if (step == 5)
            {
                Response.Redirect("~/housePublish5.aspx");
            }
            else if (step == 6)
            {
                Response.Redirect("~/Service.aspx");
            }
            else if (step == 7)
            {
                Response.Redirect("~/iamge.aspx");
            }
            else if (step == 8)
            {
                Response.Redirect("~/housePublish6.aspx");
            }
            else if (step == 9)
            {
                Response.Redirect("~/housePublish7.aspx");
            }
            else if (step == 10)
            {
                Response.Redirect("~/housePublish8.aspx");
            }
            else if (step == 11)
            {
                Response.Redirect("~/housePublish9.aspx");
            }
        }
    }

    private void createNewHouseInfo()
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        HOUSE_INFO houseInfo = new HOUSE_INFO();
        lqdb.HOUSE_INFO.InsertOnSubmit(houseInfo);
        lqdb.SubmitChanges();
        int id = houseInfo.houseId;
        Session["houseId"] = id ;
        createNewRefInfo(id);
    }

    private void createNewRefInfo(int id)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        REF_USER_HOUSEINFO REF = new REF_USER_HOUSEINFO();
        int userId = (int)Session["ID"];
        //int userId = 1;
        REF.houseId = id;
        REF.userId = userId;
        REF.step = 1;
        Session["step"] = 1;
        REF.state = 0;
        lqdb.REF_USER_HOUSEINFO.InsertOnSubmit(REF);
        lqdb.SubmitChanges();
    }

    private int checkAllSubmit(int id)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.REF_USER_HOUSEINFO
                     where r.userId == id
                     select r;
        bool check = true;
        int step = 0;
        foreach(REF_USER_HOUSEINFO ruf in result)
        {
            if(ruf.state==0)
            {
                if(ruf.step!=null) step = (int)ruf.step;
                Session["houseId"] = ruf.houseId;
                check = false;
                break;
            }
        }
        if (check) return 0;
        else return step;
    }

    private bool checkIsHave(int id)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.REF_USER_HOUSEINFO
                     where r.userId==id
                     select r;
        if (result.FirstOrDefault() != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}