using System;

namespace Serverapplication
    class FileIO
    {

        public static async Task WriteToFile(string text)
        {

            using StreamWriter sw = File.AppendText(@"c:\temp\MyTest.txt");
            await sw.WriteLineAsync(text);

        }

        public static void createLogFile()
        {
            System.IO.File.Create(@"c:\temp\MyTest.txt");
        }

        public static async Task<string> ReadFromFile()
        {
            using (StreamReader sr = File.OpenText(@"c:\temp\MyTest.txt"))
            {
                return await sr.ReadToEndAsync();
            }
        }

        public static DataTable getDataTable()
        {
            DataTable dt = new DataTable("Students");
            dt.Clear();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");
            DataRow row1 = dt.NewRow();
            row1["name"] = "Pascal Holthuijsen";
            row1["marks"] = "8";
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["name"] = "Pascal de Bruijn";
            row2["marks"] = "8";
            dt.Rows.Add(row2);


            return dt;
        }


    }
}
