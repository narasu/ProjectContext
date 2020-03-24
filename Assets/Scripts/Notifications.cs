using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Notifications
{
    public static List<string> notifList = new List<string>();

    public static Dictionary<int, string> notifContent = new Dictionary<int, string>();
    public static Dictionary<int, string> notifTarget = new Dictionary<int, string>();

    private static int notifCount = 0;
    static Notifications()
    {
        Add("Welkom bij HelpQuest! Stel een vraag!", "Ask");
        //Add("You've got a new item!", "CharCreate");
        //Add("Someone has replied to your question!", "MyQuestions");
        //notifCount = 2;
    }

    public static void Add(string notif, string target)
    {
        notifList.Add(notif);
        notifContent.Add(notifContent.Count, notif);
        notifTarget.Add(notifTarget.Count, target);

        notifCount++;
    }

    public static int GetNewCount()
    {
        return notifCount;
    }

    public static void ResetCounter()
    {
        notifCount = 0;
    }

    public static int GetNum()
    {
        return notifCount = notifList.Count;
    }

    public static void Clear()
    {
        notifList.Clear();
        notifCount = 0;
    }
}
