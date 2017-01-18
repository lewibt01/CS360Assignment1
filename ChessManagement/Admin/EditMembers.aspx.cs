using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ChessManagement.Admin
{
    public partial class EditMembers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = MYSQLDB.getUsers().Columns["username"]; //Populate the drop down box with users.
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String selectedUser = DropDownList1.SelectedValue;                  //Get the selected users username from the drop down list.
            DataTable selectedUserTable = MYSQLDB.getUserData(selectedUser);    //Get all values in the DB from the selected user.

            String selectedUserFirst = selectedUserTable.Columns["fname"].ToString();       //Gets the first name of the selected user.
            String selectedUserLast = selectedUserTable.Columns["lname"].ToString();        //Gets the last name of the selected user.
            String userPhoneNumber = selectedUserTable.Columns["phoneNumber"].ToString();   //Gets the phone number of the selected user.
            String userPassword = selectedUserTable.Columns["password"].ToString();         //Gets the password of the selected user.
            String userDivision = selectedUserTable.Columns["division"].ToString());       //Gets the value of the user's division.

            // If the value entered is different from the first name in the DB, change the value.
            if (!selectedUserFirst.Equals(TextBox1.Text))
            {
                MYSQLDB.changeFirstName(TextBox1.Text, selectedUser);
            }

            // If the value entered is different from the last name in the DB, change the value.
            if (!selectedUserLast.Equals(TextBox2.Text))
            {
                MYSQLDB.changeLastName(TextBox2.Text, selectedUser);
            }

            // If the value entered is different from the phone number in the DB, change the value.
            if (!userPhoneNumber.Equals(TextBox3.Text))
            {
                MYSQLDB.changePhoneNumber(TextBox3.Text, selectedUser);
            }

            // If the value entered is different from the password in the DB, change the value.
            if (!userPassword.Equals(TextBox4.Text))
            {
                MYSQLDB.changePassword(TextBox4.Text, selectedUser);
            }

            String selectedDivision = DropDownList2.SelectedValue;  //Get the division chosen.
            
            // If the value entered is different from the division in the DB, change the value.
            // This method could have problems, as drop down list is String, but DB value is an integer.
            if (!userDivision.Equals(selectedDivision))
            {
                MYSQLDB.changeDivision(Convert.ToInt32(selectedDivision), selectedUser);
            }
        }

        protected void removeMember(object sender, EventArgs e)
        {
            String selectedUser = DropDownList1.SelectedValue;      //Get the member chosen to delete.
            MYSQLDB.removeUser(selectedUser);                       //Removes the username chosen in the first dropdownlist from the database.  Cannot be undone.
        }
    }
}