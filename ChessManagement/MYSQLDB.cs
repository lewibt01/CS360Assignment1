using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ChessManagement
{
    public class MYSQLDB
    {
        //hard coded ip address for the external SQL server
        private static String conString = "server=172.76.245.119;Port=3306;database=CHESS;uid=webAccess;pwd=qwerty;";
        private static MySqlConnection conn = new MySqlConnection(conString);

        //test if the database is connected
        public static bool isConnected()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connection Established");
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        //returns a List<> of every user in the database. 
        public static DataTable getUsers()
        {
            DataTable result = statement("SELECT * FROM USERS ORDER BY id ASC");
            return result;
        }

        //Updates the first name of a certain username.
        public static void changeFirstName(String fname, String username)
        {
            DataTable result = statement("UPDATE USERS SET fname=" + fname + "WHERE username=" + username);
        }

        //Updates the last name of a certain username
        public static void changeLastName(String lname, String username)
        {
            DataTable result = statement("UPDATE USERS SET lname=" + lname + "WHERE username=" + username);
        }

        //Updates the phone number of a certain username
        public static void changePhoneNumber(String phoneNumber, String username)
        {
            DataTable result = statement("UPDATE USERS SET phoneNumber=" + phoneNumber + "WHERE username=" + username);
        }

        //Updates the division of a certain username
        public static void changeDivision(int division, String username)
        {
            DataTable result = statement("UPDATE USERS SET division=" + division + "WHERE username=" + username);
        }

        //Updates the password of a certain username
        public static void changePassword(String password, String username)
        {
            DataTable result = statement("UPDATE USERS SET password=" + password + "WHERE username=" + username);
        }

        //Adds a user to the DB.
        public static void AddUser(int userID,String fname, String lname, int accessLevel,String username,String password,int division,String phoneNumber)
        {
            DataTable result = statement("INSERT INTO USERS(id,fname,lname,accountType,username,password,division,phoneNumber) VALUES(" + userID + ",'" 
                + fname + "','" + lname + "','" + accessLevel + "','" + username + "','" + password + "'," + division + ",'" + phoneNumber + ")");
        }

        // Removes a user from the DB.
        public static void removeUser(String username)
        {
            DataTable result = statement("DELETE FROM USERS WHERE username=" + username);
        }

        //returns all the data in the DB under a single user entry.
        public static DataTable getUserData(String username)
        {
            DataTable result = statement("SELECT * FROM USER WHERE username="+username);
            return result;
        }


        //grab all the users in a given division
        public static DataTable getDivisions(int division)
        {
            DataTable result = statement("SELECT idUSER,fname,lname,username FROM USERS WHERE division="+division);
            return result;
        }
 
        //grab all the matches from the MATCH table
        public static DataTable getMatches()
        {
            DataTable result = statement("SELECT * FROM MATCH ORDER BY id ASC");
            return result;
        }

        //grab all the data from the command history table
        public static DataTable getHistory()
        {
            DataTable result = statement("SELECT * FROM HISTORY ORDER BY date ASC");
            return result;
        }

        //grab the specified user's match history from their point of view. 
        public static DataTable getUserMatchHistory(int userID)
        {
           //milage may vary with this method
            DataTable result = statement("SELECT idTournament,idUSER1,idUSER2,winCondition,date FROM MATCH WHERE idUSER1="+userID+
                " OR idUSER2="+userID+" ORDER BY date ASC");
            return result;
        }

        //return a list of all the tournaments in the DB
        public static DataTable getTournaments(String username,String password)
        {
            DataTable result = statement("SELECT * FROM TOURNAMENT");
            return result;
        }

        //execute some given SQL command with the given credentials
        public static DataTable statement(String commandString, bool query = true)
        {
            DataTable result = new DataTable();
            MySqlCommand cmd = new MySqlCommand(commandString, conn);
            MySqlDataReader reader;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            if (!query)
            {
                try
                {
                    //open the connection to the DB
                    conn.Open();

                    //execute the SQL command, saving the relevant data
                    reader = cmd.ExecuteReader();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    //open sesame
                    conn.Open();

                    //fill a datatable with the resultant data
                    adapter.Fill(result);

                    /*
                    foreach (DataRow row in result.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.WriteLine(item);
                        }
                    }*/

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conn.Close();
                }
            }

            return result;
        }

    }
}