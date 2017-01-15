using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement
{
    public partial class Schedule : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //put permissions for editing matches here
            //these include: unlocking the textbox and unhiding the save button
        }
        

        protected void Calendar1_SelectDay(object sender, EventArgs e)
        {
            txtSchedule.Visible = true;
            lblMatches.Visible = true;
            lblMatches.Text += Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            lblMatches.Text += ":";
            //show matches in text box
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //write match changed to db
        }
    }
}