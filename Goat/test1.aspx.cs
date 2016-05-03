using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("~/test.aspx");
        WebService service = new WebService();
        string ans = service.Pay("jjkobe", 12);
        Label1.Text = ans;
    }
}