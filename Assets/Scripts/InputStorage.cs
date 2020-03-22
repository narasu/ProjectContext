using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputStorage
{
    
    private static List<int> charList = new List<int>()
    {
        0,
        0,
        0,
        0
    };

    private static Dictionary<int, string> mqID = new Dictionary<int, string>();
    private static Dictionary<string, List<string>> myQuestions = new Dictionary<string, List<string>>(); //key = question, value = list of answers

    private static Dictionary<int, string> aqID = new Dictionary<int, string>();
    private static Dictionary<string, List<string>> allQuestions = new Dictionary<string, List<string>>(); //key = question, value = list of answers

    static InputStorage()
    {
        aqID.Add(0, "Ik heb stress wat moet ik doen :(");
        aqID.Add(1, "Het gaat niet goed met mij, wattefak al deze shit en shit en shit kanker godverdomme aaaaaaaaaaaaaaaaaa vertel mij wat zou jij doen");

        foreach (string value in aqID.Values)
        {
            allQuestions.Add(value, new List<string>());
        }

        /*allQuestions.Add("Ik heb stress wat moet ik doen :(", new List<string>());
        allQuestions.Add("Het gaat niet goed met mij, wattefak al deze shit en shit en shit kanker godverdomme aaaaaaaaaaaaaaaaaa vertel mij wat zou jij doen", new List<string>());
        */
    }

    //set item into character equipment slot
    public static void InsertIntoCharList(int index, int value)
    {
        charList[index] = value;
    }

    //get all items equipped on character
    public static int ReadFromCharList(int index)
    {
        return charList[index];
    }

    //write a question
    public static void WriteQuestion(string question)
    {
        mqID.Add(mqID.Count, question);
        myQuestions.Add(question, new List<string>());
    }

    public static void WriteAnswer(string question, string answer)
    {
        if (allQuestions.ContainsKey(question))
        {
            allQuestions[question].Add(answer);

        }
        else
        {
            Debug.Log("Question \"" + question + "\" does not exist!");
        }
    }

    /* 
     * The Get methods below take an int value "type" to specify whether to check for items the user posted, or "other users" 
     * Give it parameter 0 to check myQuestions variable, and 1 for allQuestions
     */

    //get list of questions by all users
    public static List<string> GetQuestions(int type)
    {
        List<string> values = new List<string>();
        if (type==0)
        {
            foreach (string key in myQuestions.Keys)
            {
                values.Add(key);
            }
        }
        if (type == 1)
        {
            foreach (string key in allQuestions.Keys)
            {
                values.Add(key);
            }
        }

        return values;
    }

    public static List<string> GetAnswers(int type, string question)
    {
        List<string> values = new List<string>();

        if (type == 0)
        {
            if (allQuestions.ContainsKey(question))
            {
                values = myQuestions[question];

            }
            else
            {
                Debug.Log("Question \"" + question + "\" does not exist!");
            }
        }
        if (type == 1)
        {
            if (allQuestions.ContainsKey(question))
            {
                values = allQuestions[question];

            }
            else
            {
                Debug.Log("Question \"" + question + "\" does not exist!");
            }
        }

        return values;
    }
}
