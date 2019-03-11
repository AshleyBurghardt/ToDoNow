using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ToDoNowWeb.Entities
{
    public class DataAccess
    {
        public void AddListItem(ListItem listItem)
        {
            string insertStatement = "INSERT into [master].[ToDoNow].[ListItem] (ItemText) values (@itemText)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    SqlParameter parameter = new SqlParameter("itemText", listItem.ItemText);

                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string ConnectionString { get { return "Server=localhost\\sqlexpress; Database=master; Trusted_Connection=True;"; } }

        public List<ListItem> GetAllListItems()
        {
            string selectStatement = "SELECT * FROM [master].[ToDoNow].[ListItem]";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    List<ListItem> results = new List<ListItem>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //pick up here tomorrow
                    }

                    return results;

                }
            }
        }
    }
}