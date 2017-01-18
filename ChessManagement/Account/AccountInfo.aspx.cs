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

            if (!MYSQLDB.isConnected())
            {
                return;
            }
            DataTable UserData = MYSQLDB.getUserData(User.Identity.Name);
            int userId = (int)UserData.Rows[0]["id"];
            int division = (int)UserData.Rows[0]["division"];
            labelName.Text = UserData.Rows[0]["fname"].ToString();

            labelEmail.Text = UserData.Rows[0]["username"].ToString();
            labelDivision.Text = UserData.Rows[0]["division"].ToString();

            labelPoints.Text = 100.ToString();     // Default value  
            int ranking = 1;                       // Set this from database somehow!

            int membersInDivision = (int)MYSQLDB.statement("SELECT *, COUNT(*) FROM USERS WHERE division=" + division.ToString()).Rows[0][0];
            labelRanking.Text = String.Format("#{0} out of {1}", ranking.ToString(), membersInDivision.ToString());

            gridMatches.GridLines = GridLines.Both;
            DataTable userHistory = MYSQLDB.getUserMatchHistory(userId); //Get User match history
            gridMatches.DataSource = userHistory;

            int winScore = (int)userHistory.Compute("Sum(winCondition)", "idWinner=" + userId);
            int drawScore = (int)userHistory.Compute("Sum(winCondition)", "winCondition > 1 AND winCondition < 4 AND idWinner=" + userId) / 2;
            labelPoints.Text = (winScore + drawScore).ToString();

        }

    }
}