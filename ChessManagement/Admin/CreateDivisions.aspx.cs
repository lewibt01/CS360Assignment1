using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement.Admin
{
    public partial class CreateDivisions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> userList = MYSQLDB.getUsers();     //Get the entire list of users.
            CheckBoxList1.DataSource = userList;            //Populate the checkbox with all users.
            CheckBoxList1.DataBind();                       //Binds the data.   
        }


        protected void assignDivision(object sender, EventArgs e)
        {
            String selectedUser = CheckBoxList1.SelectedValue;

        }
    }
}