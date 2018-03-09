using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            date1Label.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            date2Label.Text = Calendar2.SelectedDate.ToShortDateString();
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime date1 = Calendar1.SelectedDate;
            DateTime date2 = Calendar2.SelectedDate;

            TimeSpan result = date1.Subtract(date2);

            if (result.Days < 0) result = -result;
            if (result.Days > 1)
                resultLabel.Text = result.Days.ToString() + " days";
            else resultLabel.Text = result.Days.ToString() + " day";
        }
    }
}