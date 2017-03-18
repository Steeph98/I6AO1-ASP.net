using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oefening3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLeeftijd_Click(object sender, EventArgs e)
        {
            // DateTime Time = DateTime.Now;
            // TimeSpan objSpan = new TimeSpan(36, 0, 0);
            // DateTime x = Time.Add(objSpan);
            //lblLeeftijd.Text = Time.ToString();

            String slcDate;
            slcDate = kalVerjaardag.SelectedDate.ToString("d");
            int slcYear = Convert.ToInt32(kalVerjaardag.SelectedDate.Year);
            int crtYear = 2017;
            int newYear = crtYear - slcYear;

            lblLeeftijd.Text = Convert.ToString(newYear);
            lblDatum.Text = slcDate;
        }


    }
}