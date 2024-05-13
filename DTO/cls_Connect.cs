using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_Connect
    {
        string dataSource, database, userName, passWord;
        public string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        public string Database
        {
            get { return database; }
            set { database = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public string SqlconnectionSQLSeverAuthentication()
        {
            string connString =
                @"Data Source=" + DataSource +
                ";Initial Catalog=" + Database +
                ";User ID=" + UserName +
                ";Password=" + PassWord;

            return connString;
        }
        public string SqlConnectionWindowsAuthentication()
        {
            string connString = @"Data Source=" + DataSource + ";Initial Catalog="
                        + Database + ";Integrated Security=True";
            
            return connString;
        }
        public cls_Connect(string datasource, string database, string username, string password)
        {
            DataSource = datasource;
            Database = database;
            UserName = username;
            PassWord = password;
        }
        public cls_Connect(string datasource, string database)
        {
            DataSource = datasource;
            Database = database;
        }
        public cls_Connect()
        {

        }
    }
}
