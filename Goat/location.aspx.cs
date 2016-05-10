using System;
using System.Configuration;
using System.Linq;

public partial class location : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string phone = Request.QueryString["phone"];
        string pass = Request.QueryString["password"];
        string lat = Request.QueryString["lat"];
        string lng = Request.QueryString["lng"];
        string houseId = Request.QueryString["houseId"];
        if (check(phone, pass)){
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
        else
        {
            Response.Write("no");
            Response.End();
        }
    }

    private bool check(string phone, string pass)
    {
        GoatDataContext lqdb = new GoatDataContext(ConfigurationManager.ConnectionStrings["GoatConnectionString"].ConnectionString.ToString());
        var result = from r in lqdb.USER
                     where r.phone == phone
                     select r;
        USER u = result.FirstOrDefault();
        if(u.password==pass)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}