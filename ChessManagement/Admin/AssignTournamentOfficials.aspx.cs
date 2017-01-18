using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement.Admin
{
    public partial class AssignTournamentOfficials : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> userList = MYSQLDB.getUsers();     //Get the user list from the DB.
            CheckBoxList1.DataSource = userList;            //Data source for the check box list of all members.
            CheckBoxList1.DataBind();                       //Bind the data to the list.
        }

        /*
         *  This method takes the user that was selected from the check box list and makes them a tournament official.
         **/
        protected void makeOfficial(object sender, EventArgs e)
        {

        }
    }
}