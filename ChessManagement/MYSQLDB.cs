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

        public static void AddUser(int userID,String fname, String lname, int accessLevel,String username,String password,int division,String phoneNumber)
        {
            DataTable result = statement("INSERT INTO USERS(id,fname,lname,accountType,username,password,division,phoneNumber) VALUES(" + userID + ",'" 
                + fname + "','" + lname + "','" + accessLevel + "','" + username + "','" + password + "'," + division + ",'" + phoneNumber + ")");
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