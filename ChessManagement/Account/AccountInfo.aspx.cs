using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement.Account
{
    public partial class AccountInfo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelDivision.Text = "First division"; // Set this to the data in the database for the divison string 
                                                   // (String becasue the division name can be set to anything.) 
            labelPoints.Text = 100.ToString();     // I didn't know that would work... but this needs to be set as well.
            int ranking = 1;                       // Set this from database
            int membersInDivision = 11;            // Set this from database too
            labelRanking.Text = String.Format("#{0} out of {1}", ranking.ToString(), membersInDivision.ToString());
            tableMatches.GridLines = GridLines.Both;
            tableMatches.DataBind();    // You have to define the data from the DB that will import the match data. I don't know how to do that.

        }
    }
}