using System;
using Xamarin.Forms;
using XamarinSqliteSample.iOS;
using System.IO;

[assembly:Dependency(typeof(SQLite_iOS))]
namespace XamarinSqliteSample.iOS
{
    public class SQLite_iOS
    {
        public SQLite.Net.SQLiteConnection GetConnection ()
        {
            var fileName = "Student.db3";
            var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine (documentsPath, "..", "Library");
            var path = Path.Combine (libraryPath, fileName);
 
            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS ();
            var connection = new SQLite.Net.SQLiteConnection (platform, path);
 
            return connection;
        }
    }
}