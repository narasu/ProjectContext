using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifTimer : MonoBehaviour
{
    public static bool asked = false;
    private bool askedDone = false;
    private float askedTimer = 0f;

    public static bool answered = false;
    private bool answeredDone = false;
    private float answeredTimer = 0f;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (asked && !askedDone)
        {
            askedTimer += Time.deltaTime;

            
        }

        if (askedTimer >= 10f && !askedDone)
        {
            InputStorage.selectedQuestion = 0;
            InputStorage.selectedType = 0;
            InputStorage.WriteAnswer("Houd een vaste bedtijd aan!");

            Notifications.Add("Iemand heeft antwoord gegeven op jouw vraag!", "Question");

            
            askedDone = true;
        }

        if (answered && !answeredDone)
        {
            answeredTimer += Time.deltaTime;
        }

        if (answeredTimer >= 10f && !answeredDone)
        {
            //InputStorage.selectedQuestion = 0;
            //InputStorage.selectedType = 0;
            Notifications.Add("Iemand was blij met jouw antwoord! Bekijk nu je beloning!", "CharCreate");
            answeredDone = true;
        }

    }
}
