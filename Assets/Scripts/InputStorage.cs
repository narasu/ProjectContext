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

    private static Dictionary<string, List<string>> myQuestions = new Dictionary<string, List<string>>(); //key = question, value = list of answers

    private static Dictionary<string, List<string>> allQuestions = new Dictionary<string, List<string>>(); //key = question, value = list of answers

    

    static InputStorage()
    {
        
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
        myQuestions.Add(question, new List<string>());
    }

    //get list of questions by all users

    /* 
     * The Get method below takes an int value "type" to specify whether to check for items the user posted, or "other users" 
     * Give it parameter 0 to check myQuestions variable, and 1 for allQuestions
     */

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
}
