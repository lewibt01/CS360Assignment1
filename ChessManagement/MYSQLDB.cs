using System;
using System.Collections.Generic;
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
                Console.WriteLine("Connection Error");
            }
            return false;
        }

        //returns a List<> of every user in the database. 
        public static List<String> getUsers()
        {
            List<String> tmpList = new List<String>();

            return tmpList;
        }

        //returns all the data in the DB under a single user entry.
        public static List<String> getUserData()
        {
            List<String> tmpList = new List<String>();

            return tmpList;
        }

        /// <summary>
        /// Get a user's match history, with each line containing the comma delmimited values of 1 match.
        /// Data is displayed from that user's point of view, this determines whether or not the user won
        /// or lost a particular match. 
        /// </summary>
        /// <param name="username"> the username of the user who's match history is desired </param> 
        /// <returns> The designated user's match history as a list of strings </returns> 
        public static List<String> getUserMatchHistory(String username)
        {
            List<String> tmpList = new List<String>();

            return tmpList;
        }

        //return a list of all the tournaments in the DB
        public static List<String> getTournaments()
        {
            List<String> tmpList = new List<String>();

            return tmpList;
        }

        private static void updateDB()
        {

        }

        private static List<String> statement(String commandString, String username, String password, bool query = false)
        {
            List<String> tmpList = new List<String>();

            MySqlCommand cmd = new MySqlCommand(commandString, conn);
            MySqlDataReader reader;
            if (!query)
            {
                try
                {
                    //open the connection to the DB
                    cmd.Connection.Open();

                    //execute the SQL command, saving the relevant data
                    reader = cmd.ExecuteReader();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    //open sesame
                    cmd.Connection.Open();

                    //attach the reader to the command output
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return tmpList;
        }

    }
}