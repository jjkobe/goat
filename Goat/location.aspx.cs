using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class location : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lat = Request.QueryString["lat"];
        string lng = Request.QueryString["lng"];
        string houseId = Request.QueryString["houseId"];
        int id = Convert.ToInt32(houseId);
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.HOUSE_INFO
                     where r.houseId == id
                     select r;
        foreach (HOUSE_INFO h in result)
        {
            h.lat = Convert.ToDecimal(lat);
            h.lng = Convert.ToDecimal(lng); ;
        }
        lqdb.SubmitChanges();
        Response.Write("yes");
        Response.End();
    }
}