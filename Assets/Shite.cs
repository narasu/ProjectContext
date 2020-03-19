using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputStorage.WriteAnswer(0, "je bent kk pussy");
        InputStorage.WriteAnswer(0, "ga leven zoeken");

        InputStorage.WriteAnswer(1, "wfawegehn");
        InputStorage.WriteAnswer(1, "awefethytukui");

        List<string> list0 = InputStorage.GetAnswers(0);
        foreach (string s in list0)
        {
                Debug.Log(s);
        }

        List<string> list1 = InputStorage.GetAnswers(1);
        foreach (string s in list1)
        {
            Debug.Log(s);
        }

    }
}
