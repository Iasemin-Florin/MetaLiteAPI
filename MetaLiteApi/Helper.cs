using MetaLiteApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Helper
{
    public static string FilePath = "D:/FileDB/DB.txt";

    public static bool IsTooLong(string value)
    {
        if (value.Length >= 255)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static List<string> readfile()
    {
        List<string> file = File.ReadAllLines(FilePath).ToList();
        return file;
    }

    public static void writefile(List<Users> list)
    {
        File.WriteAllLines(FilePath, (IEnumerable<string>)list);
    }
}
