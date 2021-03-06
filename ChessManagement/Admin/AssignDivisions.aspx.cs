﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessManagement.Admin
{
    public partial class AssignDivisions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<String> userList = MYSQLDB.getUsers();       //Get the user list from the DB.
            DropDownList1.DataSource = MYSQLDB.getUsers().Columns["username"];  //Data source for DropDownList1.
            DropDownList1.DataBind();                           //Bind the data to the list.
            DropDownList2.DataTextFormatString = "Division {0:F0}";
        }

        /**
         * This method assigns the user selected in the first drop down list and assigns the division
         * selected in the second drop down list.
         **/
        protected void assignDivision(object sender, EventArgs e)
        {
            string selectedUser = DropDownList1.SelectedValue;      //Get the selected user.
            string selectedDivision = DropDownList2.SelectedValue;  //Get the selected division.
            if (!MYSQLDB.isConnected())
            {
                //error
            }
            else
            {
                MYSQLDB.statement("UPDATE USERS SET division='" + selectedDivision + "' WHERE username='" + selectedUser + "'");
            }
            

        }
    }
}