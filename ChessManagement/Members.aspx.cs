using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable UsersInDivision = MYSQLDB.getDivisions(int.Parse(DropDownList1.SelectedItem.Value));
            gridUsers.DataSource = UsersInDivision;
            
        }
    }
}