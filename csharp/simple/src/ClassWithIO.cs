using System;
using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;

namespace simple
{
    public class ClassWithIO : IDisposable
    {
        readonly IDbConnection db;
        public ClassWithIO()
        {
            db = new SqliteConnection("Data Source=testdb.sqlite;");
        }

        public void DatabaseAccess()
        {
            db.Open();
            db.Close();
        }

        public void FileAccess()
        {
            if (!Directory.Exists(@"C:\Temp"))
                throw new InvalidOperationException("No Temp");
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
