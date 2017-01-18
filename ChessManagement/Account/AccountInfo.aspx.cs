using System;
using System.Collections.Generic;
using System.Data;
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
            labelName.Text = User.Identity.Name;
            string UserData = MYSQLDB.getUserData().ToString();
            labelDivision.Text = "First division"; // Set this to the data in the database for the divison string 
                                                   // (String because the division name can be set to anything.) 
            labelDivision.Text = UserData.Split(',')[3];
            labelPoints.Text = 100.ToString();     // I didn't know that would work... but this needs to be set as well.
            int ranking = 1;                       // Set this from database
            int membersInDivision = 11;            // Set this from database too
            labelRanking.Text = String.Format("#{0} out of {1}", ranking.ToString(), membersInDivision.ToString());

            tableMatches.GridLines = GridLines.Both;
            DataTable dt = new DataTable();
            List<string> userHistory = MYSQLDB.getUserMatchHistory(User.Identity.Name); //Get User match history
            foreach (string item in userHistory)
            {
                dt.LoadDataRow(item.Split(','), true);  // Take each row, and put it into DataTable
            }
            tableMatches.DataSource = dt;

        }

        protected void tableMatches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}