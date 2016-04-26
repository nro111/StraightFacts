using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Web.Configuration;

namespace Vote.Repository
{
    public class StoredProcedures
    {
        //modify this section to send credentials to the db
        #region Credentials
        [SqlProcedure]
        public static void insert_Into_Authentication_Table(string username, string password, string securityQuestion, string securityAnswer)
        {
            //added command.ExecuteNonQuery(); and conn.Close(); to try and register credentials
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);
            using (dbConnection)
            {
                using (SqlCommand insertCredentialsIntoDB = new SqlCommand("usp_Insert_Into_Authentication", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    insertCredentialsIntoDB.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                    insertCredentialsIntoDB.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                    insertCredentialsIntoDB.Parameters.Add("@securityQuestion", SqlDbType.NVarChar).Value = securityQuestion;
                    insertCredentialsIntoDB.Parameters.Add("@securityAnswer", SqlDbType.NVarChar).Value = securityAnswer;
                    insertCredentialsIntoDB.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
        }
        #endregion

        #region National

        #region National Level Officials
        [SqlProcedure()]
        public static List<object> select_All_From_Executive_Branch()
        {
            List<object> loadNationalOfficials = new List<object>();
            List<object> electedOfficial;
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getNationalOfficials = new SqlCommand("usp_Select_All_From_Executive_Branch", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();                    
                    SqlDataReader sdr = getNationalOfficials.ExecuteReader(); 
                    while(sdr.Read())
                    {
                        electedOfficial = new List<object>();
                        electedOfficial.Add(sdr["NE_ID"]);
                        electedOfficial.Add(sdr["NE_FirstName"].ToString());
                        electedOfficial.Add(sdr["NE_LastName"].ToString());                        
                        electedOfficial.Add(sdr["NE_Picture"]);
                        electedOfficial.Add(sdr["NE_Position"]);
                        electedOfficial.Add(sdr["NE_Party"]);
                        electedOfficial.Add(sdr["NE_Bio"]);
                        electedOfficial.Add(sdr["NE_Years_Of_Service"]);
                        electedOfficial.Add(sdr["NE_Terms"]);
                        electedOfficial.Add(sdr["NE_Branch"]);
                        loadNationalOfficials.Add(electedOfficial); 
                    }
                    dbConnection.Close();
                }                
            }
            return loadNationalOfficials;
        }

        [SqlProcedure()]
        public static List<object> select_All_From_National_House_Of_Representatives()
        {
            List<object> loadNationalHouseOfReps = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getNationalOfficials = new SqlCommand("usp_Select_All_From_National_House_Of_Representatives", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getNationalOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["NHOR_ID"]);
                        electedOfficial.Add(sdr["NHOR_FirstName"].ToString());
                        electedOfficial.Add(sdr["NHOR_LastName"].ToString());
                        electedOfficial.Add(sdr["NHOR_Picture"]);
                        electedOfficial.Add(sdr["NHOR_Party"]);
                        electedOfficial.Add(sdr["NHOR_Bio"]);
                        electedOfficial.Add(sdr["NHOR_Years_Of_Service"]);
                        electedOfficial.Add(sdr["NHOR_Terms"]);
                        loadNationalHouseOfReps.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadNationalHouseOfReps;
        }

        [SqlProcedure()]
        public static List<object> select_All_From_National_Senate()
        {
            List<object> loadNationalSenateOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getNationalOfficials = new SqlCommand("usp_Select_All_From_National_Senate", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getNationalOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["NS_ID"]);
                        electedOfficial.Add(sdr["NS_FirstName"].ToString());
                        electedOfficial.Add(sdr["NS_LastName"].ToString());
                        electedOfficial.Add(sdr["NS_Picture"]);
                        electedOfficial.Add(sdr["NS_Party"]);
                        electedOfficial.Add(sdr["NS_Bio"]);
                        electedOfficial.Add(sdr["NS_Years_Of_Service"]);
                        electedOfficial.Add(sdr["NS_Terms"]);
                        electedOfficial.Add(sdr["NS_Branch"]);
                        loadNationalSenateOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadNationalSenateOfficials;
        }

        [SqlProcedure()]
        public static List<object> select_All_From_National_Judicial()
        {
            List<object> loadNationalJudicialOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getNationalOfficials = new SqlCommand("usp_Select_All_From_National_Judicial", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getNationalOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["NJ_ID"]);
                        electedOfficial.Add(sdr["NJ_FirstName"].ToString());
                        electedOfficial.Add(sdr["NJ_LastName"].ToString());
                        electedOfficial.Add(sdr["NJ_Picture"]);
                        electedOfficial.Add(sdr["NJ_Bio"]);
                        electedOfficial.Add(sdr["NJ_Years_Of_Service"]);
                        electedOfficial.Add(sdr["NJ_Terms"]);
                        electedOfficial.Add(sdr["NJ_Branch"]);
                        loadNationalJudicialOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadNationalJudicialOfficials;
        }

        #endregion

        #region National Level Views

        #endregion

        #endregion

        #region State

        #region State Level Officials
        [SqlProcedure()]
        public static List<object> select_All_From_State_Executive()
        {
            List<object> loadStateExecutivesOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getStateOfficials = new SqlCommand("usp_Select_All_From_State_Executive", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getStateOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["SE_ID"]);
                        electedOfficial.Add(sdr["SE_FirstName"].ToString());
                        electedOfficial.Add(sdr["SE_LastName"].ToString());
                        electedOfficial.Add(sdr["SE_Picture"]);
                        electedOfficial.Add(sdr["SE_Position"]);
                        electedOfficial.Add(sdr["SE_Party"]);
                        electedOfficial.Add(sdr["SE_Bio"]);
                        electedOfficial.Add(sdr["SE_Years_Of_Service"]);
                        electedOfficial.Add(sdr["SE_Terms"]);
                        electedOfficial.Add(sdr["SE_Branch"]);
                        loadStateExecutivesOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadStateExecutivesOfficials;
        }

        [SqlProcedure()]
        public static List<object> select_All_From_State_House_Of_Representatives()
        {
            List<object> loadStateHouseOfRepresentativeOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getStateOfficials = new SqlCommand("usp_Select_All_From_State_House_Of_Representatives", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getStateOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["SHOR_ID"]);
                        electedOfficial.Add(sdr["SHOR_FName"].ToString());
                        electedOfficial.Add(sdr["SHOR_LName"].ToString());
                        electedOfficial.Add(sdr["SHOR_Picture"]);
                        electedOfficial.Add(sdr["SHOR_Party"]);
                        electedOfficial.Add(sdr["SHOR_Bio"]);
                        electedOfficial.Add(sdr["SHOR_Years_Of_Service"]);
                        electedOfficial.Add(sdr["SHOR_Terms"]);
                        electedOfficial.Add(sdr["SHOR_Branch"]);
                        loadStateHouseOfRepresentativeOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadStateHouseOfRepresentativeOfficials;
        }

        [SqlProcedure()]
        public static List<object> select_All_From_State_Senate()
        {
            List<object> loadStateOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getStateOfficials = new SqlCommand("usp_Select_All_From_State_Senate", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getStateOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["SSEN_ID"]);
                        electedOfficial.Add(sdr["SSEN_FName"].ToString());
                        electedOfficial.Add(sdr["SSEN_LName"].ToString());
                        electedOfficial.Add(sdr["SSEN_Picture"]);
                        electedOfficial.Add(sdr["SSEN_Party"]);
                        electedOfficial.Add(sdr["SSEN_Bio"]);
                        electedOfficial.Add(sdr["SSEN_Years_Of_Service"]);
                        electedOfficial.Add(sdr["SSEN_Terms"]);
                        electedOfficial.Add(sdr["SSEN_Branch"]);
                        loadStateOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadStateOfficials;
        }        

        [SqlProcedure()]
        public static List<object> select_All_From_State_Judicial()
        {
            List<object> loadStateOfficials = new List<object>();
            List<object> electedOfficial = new List<object>();
            SqlConnection dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Straight_Facts_DB_ConnectionString"].ConnectionString);

            using (dbConnection)
            {
                using (SqlCommand getStateOfficials = new SqlCommand("usp_Select_All_From_State_Judicial", dbConnection)
                { CommandType = CommandType.StoredProcedure })
                {
                    dbConnection.Open();
                    SqlDataReader sdr = getStateOfficials.ExecuteReader();
                    while (sdr.Read())
                    {
                        electedOfficial.Add(sdr["SJ_ID"]);
                        electedOfficial.Add(sdr["SJ_FirstName"].ToString());
                        electedOfficial.Add(sdr["SJ_LastName"].ToString());
                        electedOfficial.Add(sdr["SJ_Picture"]);
                        electedOfficial.Add(sdr["SJ_Bio"]);
                        electedOfficial.Add(sdr["SJ_Years_Of_Service"]);
                        electedOfficial.Add(sdr["SJ_Terms"]);
                        electedOfficial.Add(sdr["SJ_Branch"]);
                        loadStateOfficials.Add(electedOfficial);
                    }
                    dbConnection.Close();
                }
            }
            return loadStateOfficials;
        }

        #endregion

        #region State Level Views

        #endregion

        #endregion

        #region Local

        #region Local Level Officials
        
        //Mayors

        //
        #endregion

        #region Local Level Views

        #endregion

        #endregion
    }
}
