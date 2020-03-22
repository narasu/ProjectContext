using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BellButton : UIButton
{
    private Text num;

    private void Awake()
    {
        num = GetComponentInChildren<Text>();
    }
    private void Update()
    {
        if (Notifications.GetNewCount()>0)
        {
            num.text = Notifications.GetNewCount().ToString();
        }
        else
        {
            num.text = "";
        }
    }

    protected override void TaskOnClick()
    {
        Notifications.ResetCounter();
    }
}
