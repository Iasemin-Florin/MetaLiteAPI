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

    public static Users[] readfile()
    {
        List<Users> list = new List<Users>();
        int i;
        foreach (string user in File.ReadAllLines(FilePath))
        {
            string[] array = user.Split(',');
            Users newuser = new Users(array[1], array[2], array[3]);
            newuser.userId = int.Parse(array[0]);
            list.Add(newuser);
        }
        return list.ToArray();
    }

    public static void writefile(Users signupuser)
    {
        List<string> newdb = File.ReadAllLines(FilePath).ToList();
        if(true)
        {

        }
        else
        {

        }
        string user = signupuser.userId.ToString() + "," + signupuser.Username + "," + signupuser.Email + "," + signupuser.Password;
        newdb.Add(user);

        File.WriteAllLines(FilePath, newdb);
    }

     
}
