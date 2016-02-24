using System.Collections.Generic;
using Vote.Repository;


namespace Vote.Data_Adapter
{
    public class DataAdapter : IDiscoveryService
    {
        public void add_New_User_To_DB(string username, string password, string securityQuestion, string securityAnswer)
        {            
            StoredProcedures.insert_Into_Authentication_Table(username, password, securityQuestion, securityAnswer);
        }

        public List<object> retrieve_National_Executive_Officials()
        {
            List<object> nationalExecutiveBranchList = new List<object>();
            //add stored procedure element ranges to list 
            nationalExecutiveBranchList.AddRange(StoredProcedures.select_All_From_Executive_Branch());
            
            return nationalExecutiveBranchList;               
        }

        public List<object> retrieve_National_Senate_Officials()
        {
            List<object> nationalSenateList = new List<object>();
            //add stored procedure element ranges to list 
            nationalSenateList.AddRange(StoredProcedures.select_All_From_National_Senate());

            return nationalSenateList;
        }

        public List<object> retrieve_National_House_Officials()
        {
            List<object> nationalHouseOfRepsList = new List<object>();
            //add stored procedure element ranges to list 
            nationalHouseOfRepsList.AddRange(StoredProcedures.select_All_From_National_House_Of_Representatives());

            return nationalHouseOfRepsList;
        }

        public List<object> retrieve_National_Judicial_Officials()
        {
            List<object> nationalJudicialBranchList = new List<object>();
            nationalJudicialBranchList.AddRange(StoredProcedures.select_All_From_National_Judicial());
            return nationalJudicialBranchList;
        }

        public List<object> retrieve_State_Executive_Officials()
        {
            List<object> stateExecutiveBranchList = new List<object>();
            stateExecutiveBranchList.AddRange(StoredProcedures.select_All_From_State_Executive());
            return stateExecutiveBranchList;
        }

        public List<object> retrieve_State_Senate_Officials()
        {
            List<object> stateSenateList = new List<object>();
            stateSenateList.AddRange(StoredProcedures.select_All_From_State_Senate());
            return stateSenateList;
        }

        public List<object> retrieve_State_House_Officials()
        {
            List<object> stateHouseOfRepsList = new List<object>();
            stateHouseOfRepsList.AddRange(StoredProcedures.select_All_From_State_House_Of_Representatives());
            return stateHouseOfRepsList;
        }

        public List<object> retrieve_State_Judicial_Officials()
        {
            List<object> stateJudicialBranchList = new List<object>();
            stateJudicialBranchList.AddRange(StoredProcedures.select_All_From_State_Judicial());
            return stateJudicialBranchList;
        }

    }
}
