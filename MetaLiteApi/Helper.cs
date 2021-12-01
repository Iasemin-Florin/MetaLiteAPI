using MetaLiteApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Helper
{
    #region
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

    public static Users[] usersreadfile(string filepath)
    {
        List<Users> listofallusers = new List<Users>();
        foreach (string user in File.ReadAllLines(filepath))
        {
            string[] array = user.Split(',');
            Users newuser = new Users(array[1], array[2], array[3]);
            newuser.userId = int.Parse(array[0]);
            listofallusers.Add(newuser);
        }
        return listofallusers.ToArray();
    }

    

    public static void Userwritefile(Users signupuser, string filepath)
    {
        List<Users> listofallusers = usersreadfile(filepath).ToList();

        signupuser = givenewid(signupuser, listofallusers);

        if (Existing(signupuser, listofallusers))
        {
            throw new NotImplementedException();
        }
        else
        {
            listofallusers.Add(signupuser);
            File.WriteAllLines(filepath, arrayofallusersStr(listofallusers));
        }
        

    }

    private static Users givenewid(Users users, List<Users> listofallusers)
    {
        int id = 0;
        foreach (Users user in listofallusers)
        {
            if(user.userId > id)
            {
                id = user.userId;
            }
        }
        users.userId = id + 1;
        return users;
    }

    public static bool Existing(Users newuser,List<Users> listofallusers)
    {
        foreach (Users user in listofallusers)
        {
            if(newuser.userId == user.userId)
            {
                Users userFailed = user;
                return true;
            }
            
        }
        return false;
    }

    public static string[] arrayofallusersStr(List<Users> listofallusers)
    {
        List<string> listofalluserStr = new List<string>();

        foreach (Users user in listofallusers)
        {
            string userStr = user.userId.ToString() + "," + user.Username + "," + user.Email + "," + user.Password;
            listofalluserStr.Add(userStr);
        }
        return listofalluserStr.ToArray();
    }
    #endregion
    public static Posts[] postsreadfile(string filepath)
    {
        List<Posts> listofallposts = new List<Posts>();
        foreach (string post in File.ReadAllLines(filepath))
        {
            string[] array = post.Split(',');
            Posts newposts = new Posts(array[1], array[2], array[3]);
            newposts.postId = int.Parse(array[0]);
            listofallposts.Add(newposts);
        }
        return listofallposts.ToArray();
    }

    public static void postwritefile(Posts newpost, string filepath)
    {
        List<Posts> listofallposts = postsreadfile(filepath).ToList();
        newpost = postgivenewid(newpost, listofallposts);
        listofallposts.Add(newpost);
        File.WriteAllLines(filepath, arrayofallpostStr(listofallposts));
    }

    private static string[] arrayofallpostStr(List<Posts> listofallposts)
    {
        List<string> listofalluserStr = new List<string>();

        foreach (Posts post in listofallposts)
        {
            string postStr = post.postId.ToString() + "," + post.Title + "," + post.Describstion + "," + post.Image;
            listofalluserStr.Add(postStr);
        }
        return listofalluserStr.ToArray();
    }

    private static Posts postgivenewid(Posts newpost, List<Posts> listofallposts)
    {
        int id = 0;
        foreach (Posts post in listofallposts)
        {
            if(post.postId > id)
            {
                id = post.postId;
            }
        }
        newpost.postId = id;
        return newpost;
    }
}
