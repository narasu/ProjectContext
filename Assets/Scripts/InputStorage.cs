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

    public static string username;

    public static int selectedType;
    public static int selectedQuestion;

    public static int questionsPosted;
    public static int answersPosted;

    public static bool firstTimeStartup;

    static InputStorage()
    {
        aqID.Add(0, "Ik heb stress wat moet ik doen :(");
        aqID.Add(1, "Het gaat echt niet goed met mij ik raak in paniek aaaaaaaa mag school gecanceld worden?");

        foreach (string value in aqID.Values)
        {
            allQuestions.Add(value, new List<string>());
        }

        firstTimeStartup = true;
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

    public static void WriteAnswer(string answer)
    {
        if (selectedType==0)
        {
            myQuestions[mqID[selectedQuestion]].Add(answer);
        }

        if (selectedType == 1)
        {
            allQuestions[aqID[selectedQuestion]].Add(answer);
        }
        /*
        if (allQuestions.ContainsKey(question))
        {
            allQuestions[question].Add(answer);

        }
        else
        {
            Debug.Log("Question \"" + question + "\" does not exist!");
        }
        */
    }

    /* 
     * The Get methods below take an int value "type" to specify whether to check for items the user posted, or "other users" 
     * Give it parameter 0 to check myQuestions variable, and 1 for allQuestions
     */

    //get list of questions by all users
    public static List<string> GetQuestionsList(int type)
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

    public static string GetQuestion()
    {
        string q="";
        if (selectedType==0)
        {
            mqID.TryGetValue(selectedQuestion, out q);
        }

        if (selectedType == 1)
        {
            aqID.TryGetValue(selectedQuestion, out q);
        }
        return q;
    }

    public static List<string> GetAnswers()
    {
        List<string> values = new List<string>();

        if (selectedType == 0)
        {
            if (mqID.ContainsKey(selectedQuestion))
            {
                values = myQuestions[mqID[selectedQuestion]];

            }
            else
            {
                Debug.Log("Question \"" + selectedQuestion + "\" does not exist!");
            }
        }
        if (selectedType == 1)
        {
            if (aqID.ContainsKey(selectedQuestion))
            {
                values = allQuestions[aqID[selectedQuestion]];
            }
            else
            {
                Debug.Log("Question \"" + selectedQuestion + "\" does not exist!");
            }
        }

        return values;
    }
}
