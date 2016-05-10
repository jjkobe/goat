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

public partial class iamge : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
       
        //Session.Clear();
        //addImage();
        if (!IsPostBack)
        {
            stepCheck();
            Session["houseId"] = 3;
            int houseId = (int)Session["houseId"];
            GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
            var result = from r in lqdb.HOUSE_INFO
                         where r.houseId == houseId
                         select r;
            HOUSE_INFO house = result.FirstOrDefault();
            Session["fileList"] = null;
            if (house.photo != null)
            {
                string[] photo = house.photo.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                ArrayList al = new ArrayList();
                for (int i = 0; i < photo.Length; i++)
                {
                    al.Add(photo[i]);
                }
                Session["fileList"] = al;
            }
        }
        addImage();
    }
    protected void exit_ServerClick(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Cookies.Clear();
        Request.Cookies.Clear();
        Response.Redirect("~/Default.aspx");
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
                string houseId = Convert.ToString((int)Session["houseId"]);
                string date= DateTime.Now.ToFileTimeUtc().ToString();
                ArrayList al = new ArrayList();
                string ppp=Server.MapPath("~/houseImage/pic") + houseId + date+ FileUpload1.FileName ;
                this.FileUpload1.SaveAs(Server.MapPath("~/houseImage/pic/") + houseId + date + FileUpload1.FileName);
                string path = "~/houseImage/pic/" + houseId + date + FileUpload1.FileName;
                if (Session["fileList"] != null)
                {
                    al = (ArrayList)Session["fileList"];
                    al.Add(path);
                    Session["fileList"] = al;
                }
                else
                {
                    al.Add(path);
                    Session.Add("fileList", al);
                }
                addImage();
            }
        }
    }


    private void addImage()
    {
        ArrayList al = new ArrayList();
        if (Session["fileList"] != null)
        {
            al = (ArrayList)Session["fileList"];
        }
        this.Table1.Rows.Clear();
        HtmlTableRow tr = new HtmlTableRow();
        int num = 0;
        for (int i = 0; i < al.Count; i++)
        {
            if (num == 0)
            {
                tr = new HtmlTableRow();
            }
            HtmlTableCell tc = new HtmlTableCell();
            ImageButton im = new ImageButton();
            im.ImageUrl = (string)al[i];
            im.ID = (string)al[i];
            im.Attributes.Add("runat", "server");
            im.Click += new ImageClickEventHandler(this.delete_Click);
            tc.Controls.Add(im);
            num++;
            tr.Cells.Add(tc);
            if (num == 3)
            {
                this.Table1.Rows.Add(tr);
                num = 0;
            }
        }
        this.Table1.Rows.Add(tr);
    }


    private void delete_Click(object sender, EventArgs e)
    {
        ImageButton btnImg = (ImageButton)sender;
        string buttonId = btnImg.ID;
        ArrayList al = new ArrayList();
        if (Session["fileList"] != null)
        {
            al = (ArrayList)Session["fileList"];
        }
        al.Remove(buttonId);
        Session.Add("fileList", al);
        //File.Delete(Server.MapPath("images/")+FileUpload1.FileName);
        addImage();
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
                ruf.step = 8;
                Session["step"] = 8;
                break;
            }
        }
        lqdb.SubmitChanges();
    }
    protected void save_Click(object sender, EventArgs e)
    {
        int houseId = (int)Session["houseId"];
        ArrayList al = new ArrayList();
        string photo="";
        string headPhoto="";
        if (Session["fileList"] != null)
        {
            al = (ArrayList)Session["fileList"];
            foreach(string photoPath in al)
            {
                photo += photoPath + ";";
            }
            headPhoto =(string)al[0];
        }

        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == houseId
                     select r;
        HOUSE_INFO house = result.FirstOrDefault();
        house.photo = photo;
        house.headPhoto = headPhoto;
        lqdb.SubmitChanges();
        nextStep();
        Response.Redirect("~/housePublish6.aspx");
    }
}