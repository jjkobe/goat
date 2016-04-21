using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        /*foreach (Control ct in form1.Controls)
        {
            if (ct.GetType().ToString().Equals("System.Web.UI.HtmlControls.HtmlInputCheckBox"))
            {
                HtmlInputCheckBox cb = (HtmlInputCheckBox)ct;
                cb.Checked = true;
            }
        }*/
        //Control ct = form1.Controls[1];
        //Response.Write(ct.GetType().ToString());
        /*ArrayList arr = new ArrayList();
        arr.Add("a");
        arr.Add("b");
        arr.Add("c");
        DropDownList1.DataSource = arr;
        DropDownList1.DataBind();
        DropDownList1.ClearSelection();
        DropDownList1.Items.FindByValue("b").Selected = true;
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        HOUSE_INFO userProfile = new HOUSE_INFO();
        lqdb.HOUSE_INFO.InsertOnSubmit(userProfile);
        lqdb.SubmitChanges();
        int id = userProfile.houseId;
        Response.Write(id);



        if (!IsPostBack) { 
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == 3
                     select r;
        HOUSE_INFO house = result.FirstOrDefault();
        int id = (int)house.style;
        ArrayList arr = new ArrayList();
        arr.Add("a");
        arr.Add("b");
        arr.Add("c");
        DropDownList1.DataSource = arr;
        DropDownList1.DataBind();
        DropDownList1.ClearSelection();
        if(id==1)
        {
            DropDownList1.Items.FindByValue("a").Selected = true;
        }
        else if(id==2)
        {
            DropDownList1.Items.FindByValue("b").Selected = true;
        }
        else if(id==3)
        {
            DropDownList1.Items.FindByValue("c").Selected = true;
        }
        }*/
        this.CheckBox1.Checked = true;
        //ScriptManager.RegisterStartupScript(UpdatePanel1, this.Page.GetType(), "", "Ceshi('asas');", true);
        //ScriptManager.RegisterStartupScript(UpdatePanel1, this.Page.GetType(), "", "Ceshi('adas');", true);
        string date=this.data.Value.ToString().Trim();
        Response.Write(date);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string argValue = Request.Form["chk"];
        Response.Write(argValue);
        if (Request.Form["chk1"] != null) { Response.Write("选中"); } else { Response.Write("未选中"); }
        string path =@"D:/c#/Goat/houseImage/pic";
        if(!Directory.Exists(path))
            {
            Directory.CreateDirectory(path);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string style = this.DropDownList1.SelectedValue;
        int s = 0;
        if(style=="a")
        {
            s = 1;
        }
        else if(style=="b")
        {
            s = 2;
        }
        else if(style=="c")
        {
            s = 3;
        }
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == 3
                     select r;
        foreach(HOUSE_INFO h in result)
        {
            h.style = s;
        }
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/test1.aspx");
    }

    private void nextStep()
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.REF_USER_HOUSEINFO
                     where r.houseId == 3
                     select r;
        foreach (REF_USER_HOUSEINFO ruf in result)
        {
            if (ruf.state == 0)
            {
                ruf.step = 2;
                break;
            }
        }
        lqdb.SubmitChanges();
    }

    protected void wc_Click(object sender, EventArgs e)
    {
        int wc;
        if(Session["wc"]!=null)
        {
            wc = (int)Session["wc"];
        }
        else
        {
            wc = 0;
        }
        if(wc==0)
        {
            wc = 1;
            Session["wc"] = wc;
        }
        else if(wc==1)
        {
            wc = 0;
            Session["wc"] = 0;
        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {

        
    }

    protected void rt_Click(object sender, EventArgs e)
    {
        this.wc.CssClass = "asa";
        //ScriptManager.RegisterStartupScript(UpdatePanel1, this.Page.GetType(), "", "Ceshi('asas');", true);
    }
}