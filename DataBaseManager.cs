using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HealthNote
{
    public class DataBaseManager
    {
        private string filePath = Directory.GetCurrentDirectory() + @"\Health.db";

        private static DataBaseManager instance = new DataBaseManager();

        public static DataBaseManager Instance
        {
            get
            {
                if (instance == null) instance = new DataBaseManager();
                return instance;
            }
        }

        public void CreateDB()
        {
            if (File.Exists(filePath)) { }
            else
            {
                SQLiteConnection.CreateFile(filePath);

                string path = string.Format("Data Source = {0}", filePath);

                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Health_Info ( " +
                        "WorkType TEXT NOT NULL, " +
                        "Count INTEGER NOT NULL, " +
                        "WorkDateTime TEXT NOT NULL );";

                    string sql2 = "CREATE TABLE IF NOT EXISTS Work_Code (" +
                        "WorkType INTEGER NOT NULL, " +
                        "Description TEXT NOT NULL, " +
                        "PRIMARY KEY(WorkType) );";

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();

                    command = new SQLiteCommand(sql2, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<WorkOutInfo> SelectHealthInfo()
        {
            List<WorkOutInfo> returnList = new List<WorkOutInfo>();

            string path = String.Format("Data Source = {0}", filePath);
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string sql = "SELECT B.Description, A.Count, A.WorkDateTime " +
                    "FROM Health_Info A, Work_Code B " +
                    "WHERE A.WorkType = B.WorkType " +
                    "ORDER BY WorkDateTime;";

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(new WorkOutInfo
                        {
                            WorkType = reader["Description"].ToString(),
                            Count = (int)(long)reader["Count"],
                            WorkDateTime = reader["WorkDateTime"].ToString()
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return returnList;
        }
        public List<WorkOutInfo> SelectHealthInfo(string dateTime)
        {
            List<WorkOutInfo> returnList = new List<WorkOutInfo>();

            string path = String.Format("Data Source = {0}", filePath);
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string sql = 
                        "SELECT " +
                        "B.Description, ROUND(AVG(A.Count)) AS Avg_Count, SUM(A.COUNT) AS Total_Count, COUNT(B.DESCRIPTION) AS Total_Set " +
                        "FROM Health_Info A, Work_Code B " +
                        "WHERE A.WorkType = B.WorkType " +
                       $"AND A.WorkDateTime = '{dateTime}' " +
                        "GROUP BY B.DESCRIPTION " +
                        "ORDER BY B.Description;";

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(new WorkOutInfo
                        {
                            WorkType = reader["Description"].ToString(),
                            Count = (int)(double)reader["Avg_Count"],
                            TotalCount= (int)(long)reader["Total_Count"],
                            TotalSet = (int)(long)reader["Total_Set"]
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return returnList;
        }
        public List<string> SelectWorkTypes()
        {
            List<string> returnList = new List<string>();

            string path = String.Format("Data Source = {0}", filePath);
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string sql = "SELECT Description FROM Work_Code;";

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Add(reader["Description"].ToString()!);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return returnList;
        }
        public bool InsertWorkData(WorkOutInfo workData)
        {
            bool returnData = false;
            string path = String.Format("Data Source = {0}", filePath);

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();
                    string sql = "";
       
                    sql = "INSERT INTO Health_Info " +
                    " (WorkType, Count, WorkDateTime) " +
                    "VALUES ( " +
                    $"(SELECT WorkType FROM WORK_CODE WHERE WORK_CODE.DESCRIPTION = '{workData.WorkType}'), " +
                    $"{workData.Count}, " +
                    $"'{workData.WorkDateTime}'); ";

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    returnData = command.ExecuteNonQuery() > 0;
                }
                if (returnData) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteWorkData(WorkOutInfo workData)
        {
            bool returnData = false;
            string path = String.Format("Data Source = {0}", filePath);

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();

                    string sql = "DELETE FROM Health_Info " +
                    "WHERE " +
                    $"WorkType = (SELECT WorkType FROM WORK_CODE WHERE WORK_CODE.DESCRIPTION = '{workData.WorkType}') " +
                    $"AND Count = {workData.Count} " +
                    $"AND WorkDateTime = '{workData.WorkDateTime}';";
                    
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    returnData = command.ExecuteNonQuery() > 0;
                }
                if (returnData) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
